namespace FindPrimes
{
    partial class FindPrimesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getPrimesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxValueTextBox = new System.Windows.Forms.TextBox();
            this.primesTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getPrimesButton
            // 
            this.getPrimesButton.Location = new System.Drawing.Point(338, 16);
            this.getPrimesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.getPrimesButton.Name = "getPrimesButton";
            this.getPrimesButton.Size = new System.Drawing.Size(105, 31);
            this.getPrimesButton.TabIndex = 0;
            this.getPrimesButton.Text = "Get Primes";
            this.getPrimesButton.UseVisualStyleBackColor = true;
            this.getPrimesButton.Click += new System.EventHandler(this.getPrimesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Finding primes less than";
            // 
            // maxValueTextBox
            // 
            this.maxValueTextBox.Location = new System.Drawing.Point(203, 16);
            this.maxValueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxValueTextBox.Name = "maxValueTextBox";
            this.maxValueTextBox.Size = new System.Drawing.Size(127, 29);
            this.maxValueTextBox.TabIndex = 2;
            // 
            // primesTextBox
            // 
            this.primesTextBox.Location = new System.Drawing.Point(16, 61);
            this.primesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.primesTextBox.Multiline = true;
            this.primesTextBox.Name = "primesTextBox";
            this.primesTextBox.Size = new System.Drawing.Size(427, 299);
            this.primesTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(338, 374);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 31);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(298, 379);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(32, 21);
            this.percentageLabel.TabIndex = 5;
            this.percentageLabel.Text = "...%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 378);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(257, 23);
            this.progressBar.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(20, 419);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 21);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status";
            // 
            // FindPrimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 457);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.primesTextBox);
            this.Controls.Add(this.maxValueTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getPrimesButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FindPrimesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finding Primes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getPrimesButton;
        private Label label1;
        private TextBox maxValueTextBox;
        private TextBox primesTextBox;
        private Button cancelButton;
        private Label percentageLabel;
        private ProgressBar progressBar;
        private Label statusLabel;
    }
}