namespace Team_Grade_System
{
    partial class PrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SaveReportButton = new System.Windows.Forms.Button();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(75, 104);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(182, 20);
            this.ErrorLabel.TabIndex = 28;
            this.ErrorLabel.Text = "Must Enter a Student ID";
            // 
            // SaveReportButton
            // 
            this.SaveReportButton.BackColor = System.Drawing.Color.GhostWhite;
            this.SaveReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveReportButton.Location = new System.Drawing.Point(66, 199);
            this.SaveReportButton.Name = "SaveReportButton";
            this.SaveReportButton.Size = new System.Drawing.Size(215, 34);
            this.SaveReportButton.TabIndex = 27;
            this.SaveReportButton.Text = "Save Report";
            this.SaveReportButton.UseVisualStyleBackColor = false;
            this.SaveReportButton.Click += new System.EventHandler(this.SaveReportButton_Click);
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDTextBox.Location = new System.Drawing.Point(66, 140);
            this.StudentIDTextBox.Multiline = true;
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(215, 34);
            this.StudentIDTextBox.TabIndex = 26;
            this.StudentIDTextBox.TextChanged += new System.EventHandler(this.StudentIDTextBox_TextChanged);
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(61, 68);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(220, 25);
            this.StudentIDLabel.TabIndex = 25;
            this.StudentIDLabel.Text = "Enter a Student ID";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(345, 352);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SaveReportButton);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.StudentIDLabel);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button SaveReportButton;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.Label StudentIDLabel;
    }
}