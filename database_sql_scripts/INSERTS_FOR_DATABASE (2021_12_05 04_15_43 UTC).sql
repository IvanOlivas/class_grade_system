# data to insert in database locally

USE rino_gs;

INSERT INTO student VALUES (901704560, 'Ivan', 'Olivas',  3.7); 
INSERT INTO student VALUES (901603640, 'Jeronimo', 'Reyes',  3.0);
INSERT INTO student VALUES (901567830, 'Hogan', 'Mate',  3.5);
INSERT INTO student VALUES (901123456, 'Finding', 'Nemo',  2.7);
INSERT INTO student VALUES (901123457, 'Kevin', 'Mack', NULL);

INSERT INTO catalog VALUES ( 111111,'CSC190', 2018, 'Spring', 3);
INSERT INTO catalog VALUES ( 222222,'MAT234', 2018, 'Spring', 4);
INSERT INTO catalog VALUES ( 333333,'CSC310', 2019, 'Fall', 3);
INSERT INTO catalog VALUES ( 444444,'INF318', 2020, 'Winter', 3);
INSERT INTO catalog VALUES ( 555555,'CSC185', 2019, 'Summer', 3);
INSERT INTO catalog VALUES ( 666666,'CSC313', 2020, 'Fall', 3);

# bridge table between student and catalog
INSERT INTO studentcourseworkfromcatalog VALUES (111111, 901704560, 'A');
INSERT INTO studentcourseworkfromcatalog VALUES (222222, 901704560, 'B');
INSERT INTO studentcourseworkfromcatalog VALUES (333333, 901704560, 'A');

#Jeronimo
INSERT INTO studentcourseworkfromcatalog VALUES (111111, 901603640, 'A');
INSERT INTO studentcourseworkfromcatalog VALUES (222222, 901603640, 'B');
INSERT INTO studentcourseworkfromcatalog VALUES (333333, 901603640, 'A');
