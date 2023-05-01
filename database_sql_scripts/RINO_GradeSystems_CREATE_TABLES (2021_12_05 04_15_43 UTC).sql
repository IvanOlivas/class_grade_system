#CREATE DATABASE rino_gs;

USE rino_gs;

CREATE TABLE users
(
	userName				VARCHAR(50) PRIMARY KEY,
	PASSWORD				VARCHAR(8)
);

CREATE TABLE Student
(
	StudentID 			INT(9) PRIMARY KEY,
	StudentName 		VARCHAR(10),
	StudentLastName 	VARCHAR(10),
	GPA 					DOUBLE(1,1)

);

CREATE TABLE Catalog
(
	CRN 				INT(6) PRIMARY KEY,
	Prefix 			VARCHAR(6),
	YEAR				VARCHAR(4),
	Semester			VARCHAR(6),
	CreditHours		INT(2)
);

CREATE TABLE StudentCourseWorkFromCatalog
(	
	CRN 				INT(6),
	StudentID		INT(9),
	Grade				VARCHAR(2),
	CONSTRAINT CRN_FK FOREIGN KEY (CRN) REFERENCES Catalog (CRN),
	CONSTRAINT StudentID_Fk FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
	
	CONSTRAINT StudentCourseWork_PK PRIMARY KEY (CRN,StudentID)
);