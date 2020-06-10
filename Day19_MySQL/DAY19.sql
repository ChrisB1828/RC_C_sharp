USE student;

CREATE TABLE student
(
studentID INT,
studentName varchar(20),
studentLastName varchar(20),
studentCours INT
);

INSERT INTO student (studentID, studentName, studentLastName, studentCours)
VALUE(1, "Arturs", "Abols", 1),
(2, "Davis", "Krezins", 1),
(3, "Edgars", "Lakstigala", 2),
(4, "Janis", "Gavars", 2),
(5, "Emils", "Treimanis", 3),
(6, "Karlis", "Busevics", 3);

SELECT * FROM student;

SELECT * FROM student
WHERE studentName = "Janis";

SELECT * FROM student
WHERE studentCours = 1 OR studentCours = 2;