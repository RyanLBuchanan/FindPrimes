namespace FindPrimes
{
    public partial class FindPrimesForm : Form
    {
        // Used to enable cancelation of the sync task
        private bool Canceled { get; set; }
        private bool[] primes; // Array used to determine primes

        public FindPrimesForm()
        {
            InitializeComponent();
            progressBar.Minimum = 2;
            percentageLabel.Text = $"{0:PO}";
        }

        // Handles getPrimesButton's click event
        private async void getPrimesButton_Click(object sender, EventArgs e)
        {
            // Get user input
            var maximum = int.Parse(maxValueTextBox.Text);

            // Create array for determining primes 
            primes = Enumerable.Repeat(true, maximum).ToArray();

            // Reset Canceled and GUI
            Canceled = false;
            getPrimesButton.Enabled = false;
            cancelButton.Enabled = true;
            primesTextBox.Text = string.Empty;
            statusLabel.Text = string.Empty;
            percentageLabel.Text = $"{0:PO}";
            progressBar.Value = progressBar.Minimum;
            progressBar.Maximum = maximum;

            // Show primes up to maximum
            int count = await FindPrimes(maximum);
            statusLabel.Text = $"Found {count} prime(s)";
        }

        // Displays prime numbers in primesTextBox
        private async Task<int> FindPrimes(int maximum)
        {
            var primeCount = 0;

            // Find primes less than maximum
            for (var i = 2; i < maximum && !Canceled; ++i)
            {
                // If i is prime, display it
                if (await Task.Run(() => IsPrime(i)))
                {
                    ++primeCount;
                    primesTextBox.AppendText($"{i}{Environment.NewLine}");
                }

                var percentage = (double)progressBar.Value / (progressBar.Maximum - progressBar.Minimum + 1);
                percentageLabel.Text = $"{percentage:PO}";
                progressBar.Value = i + 1;
            }

            if (Canceled)
            {
                primesTextBox.AppendText($"Canceled{Environment.NewLine}");
            }

            getPrimesButton.Enabled = true;
            cancelButton.Enabled = false;
            return primeCount;
        }

        // The Sieve of Eratosthenes
        public bool IsPrime(int value)
        {
            if (primes[value])
            {
                for (var i = value + value; i < primes.Length; i += value)
                {
                    primes[i] = false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Canceled = true;
            getPrimesButton.Enabled = true;
            cancelButton.Enabled = false;
        }
    }
}