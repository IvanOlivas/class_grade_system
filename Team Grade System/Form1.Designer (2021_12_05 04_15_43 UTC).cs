namespace Team_Grade_System
{
    partial class Form1
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.AlertPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.CheckCRNLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.CreditHoursTextBox = new System.Windows.Forms.TextBox();
            this.SemesterTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.PrefixTextBox = new System.Windows.Forms.TextBox();
            this.CRNTextBox = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.CreditHoursLabel = new System.Windows.Forms.Label();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.PrefixLabel = new System.Windows.Forms.Label();
            this.CRNLabel = new System.Windows.Forms.Label();
            this.courseInformationPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditGradeButton = new System.Windows.Forms.Button();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CourseListView = new System.Windows.Forms.ListView();
            this.CRN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchIDLabel = new System.Windows.Forms.Label();
            this.IDTexbox = new System.Windows.Forms.TextBox();
            this.logoNameLabel = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.importDataButton = new System.Windows.Forms.Button();
            this.printReportButton = new System.Windows.Forms.Button();
            this.editDeleteButton = new System.Windows.Forms.Button();
            this.addNewEntryButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.AlertPanel.SuspendLayout();
            this.courseInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Azure;
            this.MainPanel.Controls.Add(this.formPanel);
            this.MainPanel.Controls.Add(this.courseInformationPanel);
            this.MainPanel.Controls.Add(this.logoNameLabel);
            this.MainPanel.Controls.Add(this.logoImage);
            this.MainPanel.Controls.Add(this.logOutButton);
            this.MainPanel.Controls.Add(this.importDataButton);
            this.MainPanel.Controls.Add(this.printReportButton);
            this.MainPanel.Controls.Add(this.editDeleteButton);
            this.MainPanel.Controls.Add(this.addNewEntryButton);
            this.MainPanel.Location = new System.Drawing.Point(0, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1011, 629);
            this.MainPanel.TabIndex = 0;
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.AlertPanel);
            this.formPanel.Controls.Add(this.CheckCRNLabel);
            this.formPanel.Controls.Add(this.CancelButton);
            this.formPanel.Controls.Add(this.SubmitButton);
            this.formPanel.Controls.Add(this.FormTitleLabel);
            this.formPanel.Controls.Add(this.GradeTextBox);
            this.formPanel.Controls.Add(this.CreditHoursTextBox);
            this.formPanel.Controls.Add(this.SemesterTextBox);
            this.formPanel.Controls.Add(this.YearTextBox);
            this.formPanel.Controls.Add(this.PrefixTextBox);
            this.formPanel.Controls.Add(this.CRNTextBox);
            this.formPanel.Controls.Add(this.GradeLabel);
            this.formPanel.Controls.Add(this.CreditHoursLabel);
            this.formPanel.Controls.Add(this.SemesterLabel);
            this.formPanel.Controls.Add(this.YearLabel);
            this.formPanel.Controls.Add(this.PrefixLabel);
            this.formPanel.Controls.Add(this.CRNLabel);
            this.formPanel.Location = new System.Drawing.Point(506, 115);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(499, 456);
            this.formPanel.TabIndex = 11;
            // 
            // AlertPanel
            // 
            this.AlertPanel.BackColor = System.Drawing.Color.LightBlue;
            this.AlertPanel.Controls.Add(this.OKButton);
            this.AlertPanel.Controls.Add(this.AlertLabel);
            this.AlertPanel.Location = new System.Drawing.Point(76, 257);
            this.AlertPanel.Name = "AlertPanel";
            this.AlertPanel.Size = new System.Drawing.Size(398, 182);
            this.AlertPanel.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.GhostWhite;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(152, 90);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(107, 34);
            this.OKButton.TabIndex = 25;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButtonClick);
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertLabel.ForeColor = System.Drawing.Color.Red;
            this.AlertLabel.Location = new System.Drawing.Point(104, 46);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(205, 20);
            this.AlertLabel.TabIndex = 24;
            this.AlertLabel.Text = "Process Successfully Done!";
            // 
            // CheckCRNLabel
            // 
            this.CheckCRNLabel.AutoSize = true;
            this.CheckCRNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCRNLabel.ForeColor = System.Drawing.Color.Red;
            this.CheckCRNLabel.Location = new System.Drawing.Point(4, 63);
            this.CheckCRNLabel.Name = "CheckCRNLabel";
            this.CheckCRNLabel.Size = new System.Drawing.Size(404, 20);
            this.CheckCRNLabel.TabIndex = 23;
            this.CheckCRNLabel.Text = "CRN already exists, please enter a grade for this course:";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(376, 405);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 34);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.GhostWhite;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(263, 405);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(107, 34);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Check";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.Location = new System.Drawing.Point(3, 26);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(382, 25);
            this.FormTitleLabel.TabIndex = 20;
            this.FormTitleLabel.Text = "Please fill out the following form:";
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeTextBox.Location = new System.Drawing.Point(17, 405);
            this.GradeTextBox.Multiline = true;
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(216, 34);
            this.GradeTextBox.TabIndex = 19;
            // 
            // CreditHoursTextBox
            // 
            this.CreditHoursTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditHoursTextBox.Location = new System.Drawing.Point(17, 347);
            this.CreditHoursTextBox.Multiline = true;
            this.CreditHoursTextBox.Name = "CreditHoursTextBox";
            this.CreditHoursTextBox.Size = new System.Drawing.Size(216, 34);
            this.CreditHoursTextBox.TabIndex = 18;
            // 
            // SemesterTextBox
            // 
            this.SemesterTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterTextBox.Location = new System.Drawing.Point(17, 289);
            this.SemesterTextBox.Multiline = true;
            this.SemesterTextBox.Name = "SemesterTextBox";
            this.SemesterTextBox.Size = new System.Drawing.Size(216, 34);
            this.SemesterTextBox.TabIndex = 17;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(17, 231);
            this.YearTextBox.Multiline = true;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(216, 34);
            this.YearTextBox.TabIndex = 16;
            // 
            // PrefixTextBox
            // 
            this.PrefixTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefixTextBox.Location = new System.Drawing.Point(17, 173);
            this.PrefixTextBox.Multiline = true;
            this.PrefixTextBox.Name = "PrefixTextBox";
            this.PrefixTextBox.Size = new System.Drawing.Size(216, 34);
            this.PrefixTextBox.TabIndex = 15;
            // 
            // CRNTextBox
            // 
            this.CRNTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRNTextBox.Location = new System.Drawing.Point(17, 115);
            this.CRNTextBox.Multiline = true;
            this.CRNTextBox.Name = "CRNTextBox";
            this.CRNTextBox.Size = new System.Drawing.Size(216, 34);
            this.CRNTextBox.TabIndex = 14;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeLabel.Location = new System.Drawing.Point(14, 384);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(56, 18);
            this.GradeLabel.TabIndex = 13;
            this.GradeLabel.Text = "Grade:";
            // 
            // CreditHoursLabel
            // 
            this.CreditHoursLabel.AutoSize = true;
            this.CreditHoursLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditHoursLabel.Location = new System.Drawing.Point(14, 326);
            this.CreditHoursLabel.Name = "CreditHoursLabel";
            this.CreditHoursLabel.Size = new System.Drawing.Size(109, 18);
            this.CreditHoursLabel.TabIndex = 12;
            this.CreditHoursLabel.Text = "Credit Hours:";
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(14, 268);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(76, 18);
            this.SemesterLabel.TabIndex = 11;
            this.SemesterLabel.Text = "Semester:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(14, 210);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(48, 18);
            this.YearLabel.TabIndex = 10;
            this.YearLabel.Text = "Year:";
            // 
            // PrefixLabel
            // 
            this.PrefixLabel.AutoSize = true;
            this.PrefixLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefixLabel.Location = new System.Drawing.Point(14, 152);
            this.PrefixLabel.Name = "PrefixLabel";
            this.PrefixLabel.Size = new System.Drawing.Size(60, 18);
            this.PrefixLabel.TabIndex = 9;
            this.PrefixLabel.Text = "Prefix:";
            // 
            // CRNLabel
            // 
            this.CRNLabel.AutoSize = true;
            this.CRNLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRNLabel.Location = new System.Drawing.Point(14, 94);
            this.CRNLabel.Name = "CRNLabel";
            this.CRNLabel.Size = new System.Drawing.Size(47, 18);
            this.CRNLabel.TabIndex = 8;
            this.CRNLabel.Text = "CRN:";
            // 
            // courseInformationPanel
            // 
            this.courseInformationPanel.Controls.Add(this.DeleteButton);
            this.courseInformationPanel.Controls.Add(this.EditGradeButton);
            this.courseInformationPanel.Controls.Add(this.CancelSearchButton);
            this.courseInformationPanel.Controls.Add(this.ErrorLabel);
            this.courseInformationPanel.Controls.Add(this.CourseListView);
            this.courseInformationPanel.Controls.Add(this.searchButton);
            this.courseInformationPanel.Controls.Add(this.searchIDLabel);
            this.courseInformationPanel.Controls.Add(this.IDTexbox);
            this.courseInformationPanel.Location = new System.Drawing.Point(12, 115);
            this.courseInformationPanel.Name = "courseInformationPanel";
            this.courseInformationPanel.Size = new System.Drawing.Size(488, 456);
            this.courseInformationPanel.TabIndex = 10;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.GhostWhite;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(357, 231);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 34);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.deleteCourseFromDatabaseAndTableView);
            // 
            // EditGradeButton
            // 
            this.EditGradeButton.BackColor = System.Drawing.Color.GhostWhite;
            this.EditGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGradeButton.Location = new System.Drawing.Point(357, 173);
            this.EditGradeButton.Name = "EditGradeButton";
            this.EditGradeButton.Size = new System.Drawing.Size(107, 34);
            this.EditGradeButton.TabIndex = 13;
            this.EditGradeButton.Text = "Edit";
            this.EditGradeButton.UseVisualStyleBackColor = false;
            this.EditGradeButton.Click += new System.EventHandler(this.EditGradeButtonClick);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSearchButton.Location = new System.Drawing.Point(112, 94);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(107, 34);
            this.CancelSearchButton.TabIndex = 12;
            this.CancelSearchButton.Text = "Cancel";
            this.CancelSearchButton.UseVisualStyleBackColor = false;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(32, 63);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(142, 20);
            this.ErrorLabel.TabIndex = 11;
            this.ErrorLabel.Text = "Student not found!";
            // 
            // CourseListView
            // 
            this.CourseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CRN,
            this.Prefix,
            this.Term,
            this.Year,
            this.Grade});
            this.CourseListView.FullRowSelect = true;
            this.CourseListView.HideSelection = false;
            this.CourseListView.Location = new System.Drawing.Point(3, 143);
            this.CourseListView.MultiSelect = false;
            this.CourseListView.Name = "CourseListView";
            this.CourseListView.Size = new System.Drawing.Size(316, 310);
            this.CourseListView.TabIndex = 10;
            this.CourseListView.UseCompatibleStateImageBehavior = false;
            this.CourseListView.View = System.Windows.Forms.View.Details;
            this.CourseListView.Click += new System.EventHandler(this.getSelectedCourseFromListView);
            // 
            // CRN
            // 
            this.CRN.Text = "CRN";
            this.CRN.Width = 52;
            // 
            // Prefix
            // 
            this.Prefix.Text = "Prefix";
            // 
            // Term
            // 
            this.Term.Text = "Term";
            this.Term.Width = 70;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 59;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 81;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.GhostWhite;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(3, 94);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 34);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchIDLabel
            // 
            this.searchIDLabel.AutoSize = true;
            this.searchIDLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDLabel.Location = new System.Drawing.Point(0, 5);
            this.searchIDLabel.Name = "searchIDLabel";
            this.searchIDLabel.Size = new System.Drawing.Size(219, 18);
            this.searchIDLabel.TabIndex = 7;
            this.searchIDLabel.Text = "Enter a Student ID number:";
            // 
            // IDTexbox
            // 
            this.IDTexbox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTexbox.Location = new System.Drawing.Point(3, 26);
            this.IDTexbox.Multiline = true;
            this.IDTexbox.Name = "IDTexbox";
            this.IDTexbox.Size = new System.Drawing.Size(216, 34);
            this.IDTexbox.TabIndex = 8;
            this.IDTexbox.TextChanged += new System.EventHandler(this.resetErrorLabel);
            // 
            // logoNameLabel
            // 
            this.logoNameLabel.AutoSize = true;
            this.logoNameLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoNameLabel.Location = new System.Drawing.Point(110, 37);
            this.logoNameLabel.Name = "logoNameLabel";
            this.logoNameLabel.Size = new System.Drawing.Size(65, 36);
            this.logoNameLabel.TabIndex = 6;
            this.logoNameLabel.Text = " RINO \r\nSystems";
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImage = global::Team_Grade_System.Properties.Resources.logo;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoImage.Location = new System.Drawing.Point(28, 10);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(94, 77);
            this.logoImage.TabIndex = 5;
            this.logoImage.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.GhostWhite;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(12, 577);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(110, 40);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // importDataButton
            // 
            this.importDataButton.BackColor = System.Drawing.Color.GhostWhite;
            this.importDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importDataButton.Location = new System.Drawing.Point(230, 24);
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(163, 63);
            this.importDataButton.TabIndex = 3;
            this.importDataButton.Text = "Import Data";
            this.importDataButton.UseVisualStyleBackColor = false;
            this.importDataButton.Click += new System.EventHandler(this.importDataButtonClicked);
            // 
            // printReportButton
            // 
            this.printReportButton.BackColor = System.Drawing.Color.GhostWhite;
            this.printReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReportButton.Location = new System.Drawing.Point(779, 24);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(163, 63);
            this.printReportButton.TabIndex = 2;
            this.printReportButton.Text = "Print Report";
            this.printReportButton.UseVisualStyleBackColor = false;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // editDeleteButton
            // 
            this.editDeleteButton.BackColor = System.Drawing.Color.GhostWhite;
            this.editDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDeleteButton.Location = new System.Drawing.Point(596, 24);
            this.editDeleteButton.Name = "editDeleteButton";
            this.editDeleteButton.Size = new System.Drawing.Size(163, 63);
            this.editDeleteButton.TabIndex = 1;
            this.editDeleteButton.Text = "Edit / Delete";
            this.editDeleteButton.UseVisualStyleBackColor = false;
            this.editDeleteButton.Click += new System.EventHandler(this.edtiDeleteButtonClicked);
            // 
            // addNewEntryButton
            // 
            this.addNewEntryButton.BackColor = System.Drawing.Color.GhostWhite;
            this.addNewEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEntryButton.Location = new System.Drawing.Point(413, 24);
            this.addNewEntryButton.Name = "addNewEntryButton";
            this.addNewEntryButton.Size = new System.Drawing.Size(163, 63);
            this.addNewEntryButton.TabIndex = 0;
            this.addNewEntryButton.Text = "Add New Entry";
            this.addNewEntryButton.UseVisualStyleBackColor = false;
            this.addNewEntryButton.Click += new System.EventHandler(this.addNewEntryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 631);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade System ";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.AlertPanel.ResumeLayout(false);
            this.AlertPanel.PerformLayout();
            this.courseInformationPanel.ResumeLayout(false);
            this.courseInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button importDataButton;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.Button editDeleteButton;
        private System.Windows.Forms.Button addNewEntryButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label logoNameLabel;
        private System.Windows.Forms.TextBox IDTexbox;
        private System.Windows.Forms.Label searchIDLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel courseInformationPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.ListView CourseListView;
        private System.Windows.Forms.ColumnHeader CRN;
        private System.Windows.Forms.ColumnHeader Prefix;
        private System.Windows.Forms.ColumnHeader Term;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox GradeTextBox;
        private System.Windows.Forms.TextBox CreditHoursTextBox;
        private System.Windows.Forms.TextBox SemesterTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox PrefixTextBox;
        private System.Windows.Forms.TextBox CRNTextBox;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label CreditHoursLabel;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label PrefixLabel;
        private System.Windows.Forms.Label CRNLabel;
        private System.Windows.Forms.Label FormTitleLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.Label CheckCRNLabel;
        private System.Windows.Forms.Panel AlertPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditGradeButton;
    }
}

