namespace Team_Grade_System
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorLabelForLogIn = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIDLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormTitleLabel.Location = new System.Drawing.Point(79, 29);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(191, 32);
            this.FormTitleLabel.TabIndex = 21;
            this.FormTitleLabel.Text = "RINO Systems";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Team_Grade_System.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(96, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 123);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ErrorLabelForLogIn);
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchIDLabel);
            this.panel1.Controls.Add(this.SignInButton);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(36, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 501);
            this.panel1.TabIndex = 29;
            // 
            // ErrorLabelForLogIn
            // 
            this.ErrorLabelForLogIn.AutoSize = true;
            this.ErrorLabelForLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabelForLogIn.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelForLogIn.Location = new System.Drawing.Point(58, 382);
            this.ErrorLabelForLogIn.Name = "ErrorLabelForLogIn";
            this.ErrorLabelForLogIn.Size = new System.Drawing.Size(237, 20);
            this.ErrorLabelForLogIn.TabIndex = 36;
            this.ErrorLabelForLogIn.Text = "Incorrect username or password";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(133, 394);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Password";
            // 
            // searchIDLabel
            // 
            this.searchIDLabel.AutoSize = true;
            this.searchIDLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDLabel.Location = new System.Drawing.Point(46, 252);
            this.searchIDLabel.Name = "searchIDLabel";
            this.searchIDLabel.Size = new System.Drawing.Size(87, 18);
            this.searchIDLabel.TabIndex = 33;
            this.searchIDLabel.Text = "User Name";
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignInButton.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SignInButton.Location = new System.Drawing.Point(49, 430);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(255, 43);
            this.SignInButton.TabIndex = 32;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(88, 273);
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(216, 34);
            this.UserNameTextBox.TabIndex = 30;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.resetErrorLabel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(49, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(88, 345);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(216, 34);
            this.PasswordTextBox.TabIndex = 28;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.resetErrorLabel);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(49, 345);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 34);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.FormTitleLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 228);
            this.panel2.TabIndex = 0;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 631);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchIDLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ErrorLabelForLogIn;
    }
}