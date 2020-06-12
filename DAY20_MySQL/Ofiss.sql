CREATE TABLE departaments
(
departamentId INT PRIMARY KEY AUTO_INCREMENT,
departamentName VARCHAR(30) NOT NULL
);

INSERT INTO departaments(departamentName)
VALUES ("Engineering"),
("HR"),
("Marketing");

SELECT * FROM departaments;

ALTER TABLE employees
ADD departamentId INT NOT NULL;

ALTER TABLE employees
ADD FOREIGN KEY (departamentId) REFERENCES departaments(departamentId);

SELECT * FROM employees;

SELECT employees.employeeName, employees.employeeLastName, departaments.departamentName
FROM employees, departaments
WHERE employees.departamentId = departaments.departamentId;

CREATE TABLE jobs
(
jobId INT PRIMARY KEY AUTO_INCREMENT,
jobTitle VARCHAR(100) NOT NULL,
minSalary INT NOT NULL,
maxSalary INT NOT NULL
);

INSERT INTO jobs(jobId, jobTitle, minSalary, maxSalary)
VALUES (1, "Software engineer", 1000, 4000),
(2, "Project Manager", 1000, 2500),
(3, "Designer", 1000, 2000);

ALTER TABLE employees
ADD jsalary INT NOT NULL;

ALTER TABLE employees
ADD jobId INT NOT NULL;

ALTER TABLE employees
ADD FOREIGN KEY (jobId) REFERENCES jobs(jobId);

SELECT employees.employeeLastName, employees.employeeLastName, jobs.jobTitle
FROM employees, jobs
WHERE employees.jobId = jobs.jobId;

SELECT AVG(jsalary)
FROM employees;

SELECT employees.employeeLastName, employees.employeeLastName, jobs.jobTitle
FROM employees, jobs
where employees.jobId = 1 = jobs.jobId ;
