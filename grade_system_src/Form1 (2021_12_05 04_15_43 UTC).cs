using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Team_Grade_System
{
    public partial class Form1 : Form
    {
        //global variables to interact between classes as objects
        CourseWork thisCoursework;
        StaffMember thisStaffMember;
        private String currentButtonSelected = "";
        public String currentGrade;

        //Global ArrayList to store all the courses once they have been retrieved.
        ArrayList listsOfCoursesStudentHasTaken = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            courseInformationPanel.Visible = false;
            formPanel.Visible = false;
            showAlertPanel(false);
            CourseListView.Visible = false;
        }

        private void resetSettingsComingFromOtherFunctionality()
        {
            showAlertPanel(false);
            //reset button functionalities when accessing add new entry use case
            IDTexbox.Enabled = true;
            searchButton.Enabled = true;
            CancelSearchButton.Enabled = true;
            ErrorLabel.Text = "";       
            IDTexbox.Clear();         
        }

        //### New Entry Button Clicked #######
        private void addNewEntryButton_Click(object sender, EventArgs e)
        {
            //Hide edit and delete button until a course has been selected
            DeleteButton.Visible = false;
            EditGradeButton.Visible = false;

            currentButtonSelected = "Add";
            resetSettingsComingFromOtherFunctionality();

            //make information panel Visible to the user
            courseInformationPanel.Visible = true;
            CourseListView.Visible = false;     //Disable listView
            disableEnableButtons(false,"");     //Disable top menu buttons
        }

        //################### EDIT/DELETE Button Click ####################################
        private void edtiDeleteButtonClicked(object sender, EventArgs e)
        {
            //Hide Edit and Delete Button Until a Course Has been selected
            DeleteButton.Visible = false;
            EditGradeButton.Visible = false;

            CourseListView.Items.Clear();   //empty listview

            //Disable listview until user clicks searchButton to find the coursesList based on studentID
            CourseListView.Visible = false;

            currentButtonSelected = "Edit"; //current use case

            //Hide Alert panel 
            showAlertPanel(false);

            resetSettingsComingFromOtherFunctionality();
            courseInformationPanel.Visible = true;

            disableEnableButtons(false, "");    //disable top menu buttons

        }

        private void disableEnableButtons(Boolean willShow,String currentCancelButton)
        {
            switch(currentCancelButton){
                case "CancelSearchButton":
                    //Disable all other buttons until user cancels the current use case
                    importDataButton.Enabled = willShow;
                    editDeleteButton.Enabled = willShow;
                    printReportButton.Enabled = willShow;
                    addNewEntryButton.Enabled = willShow;
                    ErrorLabel.Text = "";          
                    IDTexbox.Clear();

                    //hide the student information panel
                    courseInformationPanel.Visible = false; 
                    break;
                case "CancelButton":
                    //Disable all other buttons until user cancels the current use case
                    importDataButton.Enabled = willShow;
                    editDeleteButton.Enabled = willShow;
                    printReportButton.Enabled = willShow;
                    addNewEntryButton.Enabled = willShow;
                    ErrorLabel.Text = "";              
                    IDTexbox.Clear();            

                    //hide the student information panel
                    courseInformationPanel.Visible = false;
                    formPanel.Visible = false;

                    //Enable the textboxes once the data insertion, update has been successful from form panel. 
                    enableTextBoxes(true);
                    SubmitButton.Text = "Check";
                    clearTextBoxes();
                    break; 
                default:
                    //Disable all other buttons until user cancels the current use case
                    importDataButton.Enabled = willShow;
                    editDeleteButton.Enabled = willShow;
                    printReportButton.Enabled = willShow;
                    addNewEntryButton.Enabled = willShow;
                    break; 
            }
            
        }

        //############## Search button Clicked ################
        private void searchButton_Click(object sender, EventArgs e)
        {
            //find if the StudentID is in the database
            String studentID = IDTexbox.Text;       //Read the textbox
            Boolean isStudentInDatabase = Student.retrievedStudentID(studentID); 
            
            //Perform the corresponding actions based on what use case the user is in
            switch (currentButtonSelected)
            {
                case "Add":
                    underAddNewEntryButton(isStudentInDatabase);
                    break;
                case "Edit":
                    underEditButton(isStudentInDatabase, studentID);
                    break;
            }
        }

        //################# EditButton Use Case #############################
        private void underEditButton(Boolean isStudentInDatabase, String studentID)
        {
            if (isStudentInDatabase)
            {
                Console.WriteLine("Student Found");

                //Display Form Panel to user
                enableTextBoxes(false);             
                CheckCRNLabel.Text = "";

                //Disable the searchBox and Buttons
                Console.WriteLine("ListView should be populated");

                //We should populate the listview based on the course information
                //Find all the courses a student has taken
                listsOfCoursesStudentHasTaken = CourseWork.RetrieveCourseWorkInformationUsingStudent(studentID);

                //display ListOfCourses
                display(listsOfCoursesStudentHasTaken);
                CourseListView.Visible = true;
                IDTexbox.Enabled = false;
                searchButton.Enabled = false;
            }
            else
            {
                //error label due to a missing field
                updateLabelWhenStudentIdBoxIsEmpty();
            }
        }

        private void updateLabelWhenStudentIdBoxIsEmpty()   //Error handling
        {
            if (IDTexbox.Text == "")   
            {
                ErrorLabel.Text = "Student ID is required";
            }
            else
            {
                //Alert user that student not in the database.
                ErrorLabel.Text = "Student not found";
                //Console.WriteLine("Student not found");

            }
        }

        //Reset label whenever a user retypes in the textIDBox(studentID)
        private void resetErrorLabel(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
        }

        //#################Method to display ListOfCourses ################################################
        private void display(ArrayList listsOfCoursesStudentHasTaken)
        {
            if (listsOfCoursesStudentHasTaken.Count > 0)    //List Not Empty
            {
                ErrorLabel.Text = "Please select a CRN from the list.";
                CourseListView.Items.Clear();

                //populate list view for each course
                foreach ( CourseWork items in listsOfCoursesStudentHasTaken)
                {
                    ListViewItem courseView;

                    courseView = CourseListView.Items.Add(items.getCRN().ToString());
                    courseView.SubItems.Add(items.getPrefix());
                    courseView.SubItems.Add(items.getSemester());
                    courseView.SubItems.Add(items.getYear());
                    courseView.SubItems.Add(items.getGrade()); 
                    
                }
            }
            else
            {
                ErrorLabel.Text = "No classes found for student";
            }
        }

        private void getSelectedCourseFromListView(object sender, EventArgs e)
        {
            String currentIndex = CourseListView.SelectedItems[0].Text;     //find the current course selected by user

            //Iterate the CourseWork objects to find the current selectedItem 
            foreach(CourseWork coursework in listsOfCoursesStudentHasTaken)
            {
                if (currentIndex.Equals(coursework.getCRN().ToString()))
                {
                    //Allow user to see EDIT and DELETE buttons
                    thisCoursework = coursework;        //Update the current coursework object
                    EditGradeButton.Visible = true;
                    DeleteButton.Visible = true;
                    //Console.WriteLine("Current CRN " + coursework.getCRN().ToString() + " has a grade = " + coursework.getGrade());
                    //Console.WriteLine("This course has a total of "+coursework.getCreditHours() + "credit hours");
                }
            }
            
        }

        //################## Function to Delete A course From database and tabelView #########################################
        private void deleteCourseFromDatabaseAndTableView(object sender, EventArgs e)
        {
            //Delete course that user selected
            if(thisCoursework.DeleteCourse(thisCoursework.getCRN().ToString(), thisCoursework.getStudentID().ToString()))
            {
                ErrorLabel.Text = "Course deleted successfully!";
                //Update the table view by removing the recent deleted course
                if(CourseListView.SelectedItems.Count > 0)      //Prevent null selection
                {
                    CourseListView.Items.Remove(CourseListView.SelectedItems[0]);
                }
                else
                {
                    ErrorLabel.Text = "Please select a course to delete!";
                }
                
            }
            else
            {
                ErrorLabel.Text = "Something went wrong";
            }

        }

        private void EditGradeButtonClick(object sender, EventArgs e)
        {
            if (CourseListView.SelectedItems.Count > 0)      //Prevent null selection
            {
                String updatedGrade;
                //Show EditGradeForm to ask for the new grade
                EditForm editForm = new EditForm();
                editForm.ShowDialog();

                //Get Grade From EditViewForm
                updatedGrade = editForm.grade;  
                //Console.WriteLine(updatedGrade);
                
                //update the grade, check if grade returned is not empty
                if (!importedGradeisEmpty(updatedGrade))
                {
                    updateCourseWork(thisCoursework.getCRN().ToString(), thisCoursework.getStudentID().ToString(), updatedGrade);

                    //Update the ListView to the new grade entered
                    updateListView(updatedGrade);
                    //Console.WriteLine("the previuos grade was " + thisCoursework.getGrade() + " now the grade is " + updatedGrade);
                }
            }
            else
            {
                ErrorLabel.Text = "Please select a course to Edit!";
            }


        }

        //Check if grade obtained from form 2 is empty
        private Boolean importedGradeisEmpty(String importedGrade)
        {
            if(String.IsNullOrEmpty(importedGrade))
            {
                Console.WriteLine("textEmpty");
                return true;    
            }
            return false;
        }

        private void updateListView(String replaceGrade)
        {
            //updating listview locally using coursework object
            CourseListView.SelectedItems[0].SubItems[4].Text = replaceGrade;
        }

        //################# AddNewEntry Use Case #####################
        private void underAddNewEntryButton(Boolean isStudentInDatabase)
        {
            if (isStudentInDatabase)
            {
                Console.WriteLine("Student Found");
                //Display Form Panel to user
                enableTextBoxes(false);         
                formPanel.Visible = true;
                CheckCRNLabel.Text = "";

                //Disable the searchBox and Buttons
                IDTexbox.Enabled = false;
                searchButton.Enabled = false;
                CancelSearchButton.Enabled = false;
            }
            else
            {
                updateLabelWhenStudentIdBoxIsEmpty();
            }
        }

        // ##################################### Print Report ######################################
        private void printReportButton_Click(object sender, EventArgs e)
        {
            PrintForm printReportForm = new PrintForm();
            printReportForm.ShowDialog();

            //import the student ID from printReport From           
            if (!String.IsNullOrEmpty(printReportForm.studentID))
            {
                string studentID = printReportForm.studentID;
                //Console.WriteLine(studentID);

                //Find the student records and then save them in a PDF file 
                listsOfCoursesStudentHasTaken = CourseWork.RetrieveCourseWorkInformationUsingStudent(studentID);
                Console.WriteLine("Student Courses are in the list");

                //calculating GPA
                double gpa = CalculateGPA();
                String displayGPA = "";
                if(gpa%2 == 0)
                {
                    displayGPA = gpa.ToString() + ".0";
                }
                else
                {
                    displayGPA = gpa.ToString("#.#");
                }

                //generate report
                createPDF(studentID,displayGPA);
            }

        }

        //Calculate the student GPA
        private double CalculateGPA()
        {
            double totalNumberOfCreditHours = 0.0;
            double totalNumberOfCreditsEarned = 0.0;

            double currentGPA = 0.0;

            //iterate the list to find the above values for each course 
            foreach( CourseWork coursework in listsOfCoursesStudentHasTaken)
            {
                thisCoursework = coursework;
                totalNumberOfCreditHours += coursework.getCreditHours();
                totalNumberOfCreditsEarned += coursework.getCreditHours() * switchValueUsing(coursework.getGrade());
            }

            currentGPA = totalNumberOfCreditsEarned / totalNumberOfCreditHours;
            return currentGPA;
        }

        //derive number values for each letter grade
        private int switchValueUsing(String grade)
        {
            switch(grade){

                case "A":
                    return 4;
                case "B":
                    return 3;
                case "C":
                    return 2;
                case "D":
                    return 1;
                default:
                    return 0;

            }
        }

        //Function to create a PDF file with the student's information 
        private void createPDF(String UsingThisStudentID, String withGPA)
        {
            //Set path for the location to save the file
            FileStream fileStream = new FileStream(@"C:\Users\CSC210\Documents\Transcript.pdf", FileMode.Create);
            Document document = new Document(PageSize.LETTER,5,5,7,7); //set size of document
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream); 

            document.Open();

            Paragraph title = new Paragraph("EKU Transcript");
            title.Alignment = Element.ALIGN_CENTER;
            title.Font.Size = 20;

            //Define font to use
            iTextSharp.text.Font useFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Write a header 
            document.Add(title);
            document.Add(Chunk.NEWLINE);

            //Column Headers
            PdfPTable tableCourses = new PdfPTable(4);
            tableCourses.WidthPercentage = 95;

            //column head titles 
            PdfPCell colunmPrefix = new PdfPCell(new Phrase("Prefix", useFont));
            colunmPrefix.BorderWidth = 0;
            colunmPrefix.BorderWidthBottom = 0.75f;

            PdfPCell colunmSemester = new PdfPCell(new Phrase("Semester", useFont));
            colunmPrefix.BorderWidth = 0;
            colunmPrefix.BorderWidthBottom = 0.75f;

            PdfPCell colunmYear = new PdfPCell(new Phrase("Year", useFont));
            colunmPrefix.BorderWidth = 0;
            colunmPrefix.BorderWidthBottom = 0.75f;

            PdfPCell colunmGrade = new PdfPCell(new Phrase("Grade", useFont));
            colunmPrefix.BorderWidth = 0;
            colunmPrefix.BorderWidthBottom = 0.75f;

            tableCourses.AddCell(colunmPrefix);
            tableCourses.AddCell(colunmSemester);
            tableCourses.AddCell(colunmYear);
            tableCourses.AddCell(colunmGrade);

            //adding courses of a student to the table (that will be used to add to the file later)
            foreach (CourseWork coursework in listsOfCoursesStudentHasTaken)
            {
                colunmPrefix = new PdfPCell(new Phrase(coursework.getPrefix().ToString(), useFont));
                colunmPrefix.BorderWidth = 0;

                colunmSemester = new PdfPCell(new Phrase(coursework.getSemester().ToString(), useFont));
                colunmSemester.BorderWidth = 0;

                colunmYear = new PdfPCell(new Phrase(coursework.getYear().ToString(), useFont));
                colunmYear.BorderWidth = 0;

                colunmGrade = new PdfPCell(new Phrase(coursework.getGrade().ToString(), useFont));
                colunmGrade.BorderWidth = 0;

                tableCourses.AddCell(colunmPrefix);
                tableCourses.AddCell(colunmSemester);
                tableCourses.AddCell(colunmYear);
                tableCourses.AddCell(colunmGrade);

            }

            //write courses, using the table, to PDF
            document.Add(tableCourses);

            //Blank lines
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);

            //Create labels with student information
            Paragraph studentName = new Paragraph("Student ID: "+ UsingThisStudentID);
            studentName.Font.Size = 14;
            studentName.Alignment = Element.ALIGN_JUSTIFIED;

            document.Add(Chunk.NEWLINE);
            Paragraph studentGPA = new Paragraph("Students GPA: " + withGPA);
            studentGPA.Font.Size = 14;
            studentGPA.Alignment = Element.ALIGN_JUSTIFIED;

            //add labels to file
            document.Add(studentName);
            document.Add(studentGPA);

            document.Close();
            pdfWriter.Close();
            MessageBox.Show("Your document has been created successfully", " ",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //################################# End of Print Report ####################################

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn userLogsOut = new LogIn();
            userLogsOut.ShowDialog();
            this.Close();
        }

        private void importDataButtonClicked(object sender, EventArgs e)
        {
            Import_Data importdata = new Import_Data();
            importdata.ShowDialog();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            disableEnableButtons(true, (sender as Button).Name);
        }

        private void clearTextBoxes()
        {
            CRNTextBox.Clear();
            PrefixTextBox.Clear();
            YearTextBox.Clear();
            SemesterTextBox.Clear();
            CreditHoursTextBox.Clear();
            GradeTextBox.Clear();
        }

        //############## Submit Button Click ##########################
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            if (CRNTextBoxisEmpty())
            {
                //Display Error Message
                CheckCRNLabel.Text = "ERROR, please enter a CRN";
            }
            else
            {
                //Allow system to check if CRN is in database and set to boolean to use later for displaying labels & buttons
                Boolean isCRNInDataBase = CourseWork.retrieveCRN(CRNTextBox.Text);
                //Console.WriteLine((sender as Button).Text);             

                //depending on button text, enable/disable certain buttons and functionalities
                switch ((sender as Button).Text)
                {
                    case "Submit":
                        //All fields must be filled out else display error to user.
                        if (textBoxesAreEmpty() && !isCRNInDataBase)
                        {
                            CheckCRNLabel.Text = "ERROR, All Textboxes must be filled out!";
                            showAlertPanel(false);
                        }
                        else if(CRNandGradeAreEmpty() && isCRNInDataBase) {
                                CheckCRNLabel.Text = "ERROR, Grade and CRN must be filled out!";
                                showAlertPanel(false);
                        }
                        else
                        {
                            //Check if the current Button text is set to "Submit", then fill out the form
                            ReadTextBoxes(isCRNInDataBase);

                            //Make the AlertPanel Visible.
                            showAlertPanel(true);
                            clearTextBoxes();
                            (sender as Button).Text = "Check";
                        }
                        break;
                    case "Check":
                        //Enabled GradeTextBox, if CRN is in database
                        if (isCRNInDataBase)
                        {
                            GradeTextBox.Enabled = true;
                            CheckCRNLabel.Text = "CRN already exists, please enter a grade for this course:";
                            (sender as Button).Text = "Submit";

                        }
                        else
                        {
                            CheckCRNLabel.Text = "CRN does not exists, add it:";
                            enableTextBoxes(true);
                            (sender as Button).Text = "Submit";
                        }

                        break;
                    default:
                        break;
                }

            }
        }//###################################### Submit Button Click ######################################

        //Check if textBoxes are empty
        private Boolean textBoxesAreEmpty()
        {
            if(CRNTextBox.Text != "" && PrefixTextBox.Text != "" && YearTextBox.Text != "" && SemesterTextBox.Text != "" && CreditHoursTextBox.Text != "" && GradeTextBox.Text != "")
            {
                return false;
            }
            return true;
        }

        //Check CRN and Grade TextBox are not empty
        private Boolean CRNandGradeAreEmpty()
        {
            if(CRN.Text != "" && GradeTextBox.Text != "")
            {
                return false;
            }
            else
            {
                return true; 
            }
        }

        //if CRNTextbox is empty
        private Boolean CRNTextBoxisEmpty()
        {
            if(CRNTextBox.Text != "")
            {
                return false;
            }
            return true;
        }

        //Function to Show AlertPanel
        private void showAlertPanel(Boolean willShow)
        {
            AlertPanel.Visible = willShow;
        }

        //Function to Interact with OKButton in side AlertPanel
        private void OKButtonClick(object sender, EventArgs e)
        {
            //Clear Form textBoxes
            clearTextBoxes();
            //Clear StudentIDTexBox
            IDTexbox.Clear();

            //Go back to main menu by hiding formPanel and Interaction panel
            courseInformationPanel.Visible = false;
            formPanel.Visible = false;

            //Enable main menu buttons
            disableEnableButtons(true, "");
        }

        //Function To disable all textBoxes, except CRN to check if it's in the database first
        private void enableTextBoxes(Boolean willShow)
        {
            PrefixTextBox.Enabled = willShow;
            YearTextBox.Enabled = willShow;
            SemesterTextBox.Enabled = willShow;
            CreditHoursTextBox.Enabled = willShow;
            GradeTextBox.Enabled = willShow; 
        }

        private void ReadTextBoxes(Boolean isCRNInDataBase)
        {   
            if (isCRNInDataBase)
            {
                String grade = GradeTextBox.Text;
                String studentID = IDTexbox.Text;
                //Console.WriteLine("CRN in database");

                if (CourseWork.hasStudentTakenThisCourse(CRNTextBox.Text, studentID))
                {
                    //if student already has a grade for this course, update the grade 
                    updateCourseWork(CRNTextBox.Text, studentID, grade);
                } else {
                    //if student does not have grade for this course, insert new coursework entry
                    InsertIntoCourseWork(CRNTextBox.Text, studentID, grade);
                }
                
            }
            else
            {
                //read and set all the textBoxes to variables. 
                String cRN = CRNTextBox.Text;
                String prefix = PrefixTextBox.Text;
                String year = YearTextBox.Text;
                String semester = SemesterTextBox.Text;
                String creditHours = CreditHoursTextBox.Text;
                
                //Console.WriteLine("CRN not in database");
                //add the course to the student's coursework
                insertIntoCatalogAndCourseWork(cRN, prefix, year, semester, creditHours, GradeTextBox.Text, IDTexbox.Text);
            }
        }

        //If class(CRN) does not exists, add it to the catalog first and then into the coursework table
        private void insertIntoCatalogAndCourseWork(String cRN, String prefix, String year, String semester, String creditHours, String grade, String studentID)
        {
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            //Insert values to Catalog Table 
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO catalog VALUES ( @CRN, @prefix, @year, @semester, @creditHours);";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cRN", cRN);
                cmd.Parameters.AddWithValue("@prefix", prefix);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@semester", semester);
                cmd.Parameters.AddWithValue("@creditHours", creditHours);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Insertion to catalog Successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            InsertIntoCourseWork(cRN, studentID, grade);
            Console.WriteLine("Done.");
        }

        //#########If class already exits, update the current grade of CourseWork table in the database#############
        private void updateCourseWork(String cRN, String studentID, String grade)
        {
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE studentcourseworkfromcatalog SET Grade = @grade WHERE CRN = @CRN AND studentID = @studentID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cRN", cRN);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
                Console.WriteLine("we did it boiiiiz We updated coursework table");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }//End of Adding CourseWork to database table

        //Insert into CourseWork when CRN does not exists in the database.
        private void InsertIntoCourseWork(String cRN, String studentID, String grade)
        {
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "Insert INTO studentcourseworkfromcatalog VALUES (@cRN, @StudentID, @grade);";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cRN", cRN);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
                //Console.WriteLine("Added to coursework table");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }   
    }
}
