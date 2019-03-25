USE demo
GO

CREATE TABLE persons (
	id INT NOT NULL IDENTITY(1,1),
	name VARCHAR(50) NOT NULL,
	birth_date DATE,
	phone VARCHAR(70) NOT NULL UNIQUE
)

ALTER TABLE persons DROP COLUMN id
ALTER TABLE persons ADD id INT NOT NULL PRIMARY KEY IDENTITY(1,1)

EXEC sp_columns persons

ALTER TABLE persons ADD country VARCHAR(50) DEFAULT 'Croatia'

CREATE TABLE departments (
	dept_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	dept_name VARCHAR(50)
)

CREATE TABLE employees (
    emp_id INT NOT NULL PRIMARY KEY,
    emp_name VARCHAR(55) NOT NULL,
    hire_date DATE NOT NULL,
    salary INT,
    dept_id INT,
    FOREIGN KEY (dept_id) REFERENCES departments(dept_id)
)

ALTER TABLE employees DROP COLUMN salary

ALTER TABLE employees ADD salary INT NOT NULL CHECK (salary >= 3000 AND salary <= 10000)

EXEC sp_columns employees

EXEC sp_columns persons

INSERT INTO persons (name, birth_date, phone)
VALUES ('Bruce Wayne', '1975-01-01', 43333333)

INSERT INTO persons (name, birth_date, phone)
VALUES ('Clark Kent', '1968-01-01', '031-700800')

INSERT INTO persons (name, birth_date, phone, country)
VALUES ('Diana Price', '1969-01-06', '452-55559999', 'Themyscira')

SELECT phone
FROM persons
WHERE id=3 

UPDATE persons
SET phone='452-55559999'
WHERE id=3

SELECT *
FROM employees

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('Ethan Hunt', '1995-10-30', 5000)

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('Tony Montana', '1990-07-15', 6500)

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('Sarah Connor', '2011-04-13', 5600)

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('Rick Deckard', '2005-10-18', 7200)

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('Martin Blank', '1996-05-24', 8000)

SELECT 
	emp_id,
	emp_name,
	salary 
FROM employees
WHERE salary > 7000

SELECT *
FROM persons


UPDATE persons
SET name='Dijana Prce'
WHERE id=3

SELECT * FROM employees
WHERE salary > 5000 AND (dept_id=1 OR dept_id=5)

SELECT * FROM employees
WHERE dept_id NOT IN(1,3)

SELECT * FROM employees
WHERE salary BETWEEN 7000 AND 9000

SELECT * FROM employees
WHERE hire_date BETWEEN CAST('2006-01-01' AS date) AND CAST('2016-12-31' AS date)

SELECT * FROM employees
WHERE emp_name BETWEEN 'O' AND 'Z'

SELECT * FROM employees
ORDER BY salary DESC

CREATE TABLE trainees (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	birth_date DATE,
	gender NCHAR(10)
)
GO

INSERT INTO trainees (first_name, last_name, birth_date, gender)
VALUES ('Peter', 'Parker', '1998-03-04', 'M')

INSERT INTO trainees (first_name, last_name, birth_date, gender)
VALUES ('Harry', 'Potter', '2001-08-30', 'M')

INSERT INTO trainees (first_name, last_name, birth_date, gender)
VALUES ('Peter', 'Pan', '2004-09-19', 'M')

INSERT INTO trainees (first_name, last_name, birth_date, gender)
VALUES ('Alice', 'Kingsleigh', '1999-07-02', 'F')

INSERT INTO trainees (first_name, last_name, birth_date, gender)
VALUES ('John', 'Connor', '2002-01-15', 'M')


SELECT * FROM trainees
ORDER BY last_name

SELECT TOP 2 * FROM employees
ORDER BY salary DESC

CREATE TABLE customers (
	cust_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	cust_name VARCHAR(50),
	city VARCHAR(50),
	postal_code INT
)

SELECT DISTINCT city FROM customers

UPDATE employees
SET emp_name= 'Sarah Ann Connor'
WHERE emp_id=3

UPDATE employees
SET dept_id=4, salary=4200
WHERE emp_id=8

DELETE FROM persons
WHERE id > 4

CREATE TABLE for_truncation (
	id int not null primary key identity(1,1),
	first_name varchar(50),
	last_name varchar(50)
	)

TRUNCATE TABLE for_truncation
SELECT * FROM for_truncation

DROP TABLE for_truncation

-- Inner Join
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
INNER JOIN departments d
ON e.dept_id = d.dept_id
ORDER BY emp_name

-- Left Outer Join
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
LEFT JOIN departments d
ON e.dept_id = d.dept_id

DELETE FROM employees
WHERE emp_id > 5

-- Right Outer Join
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
RIGHT JOIN departments d
ON e.dept_id = d.dept_id
ORDER BY emp_id

-- Full Outer Join
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
FULL OUTER JOIN departments d
ON e.dept_id = d.dept_id
ORDER BY emp_name

--Union All as Full Outer Join
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
LEFT JOIN departments d
ON e.dept_id = d.dept_id
UNION -- ALL
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
RIGHT JOIN departments d
ON e.dept_id = d.dept_id
ORDER BY emp_name

-- Cross Join
SELECT e.emp_id, e.emp_name, e.hire_date, d.dept_name 
FROM employees e
CROSS JOIN departments d
ORDER BY dept_name DESC

SELECT *
FROM trainees
WHERE first_name LIKE '_et%'

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('simon simonic', '2019-02-02', 9100)

SELECT * FROM employees
WHERE emp_name  LIKE 'S%'

EXEC sp_columns shippers

CREATE TABLE shippers (
	shipper_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	shipper_name VARCHAR(60) NOT NULL,
	phone VARCHAR(60) NOT NULL,
	)

ALTER TABLE shippers
ADD fax VARCHAR(25)

ALTER TABLE shippers ADD UNIQUE (phone)

ALTER TABLE shippers DROP COLUMN fax
ALTER TABLE shippers ALTER COLUMN phone CHAR(15)

EXEC sp_rename 'shippers', 'shipper'

DECLARE @d DATETIME=GETDATE()
select FORMAT(@d, 'dd,MM,yyyy') AS 'danas'

select d.dept_name, count(e.emp_id) AS total_employees
from departments d
LEFT JOIN employees e
ON d.dept_id=e.dept_id
GROUP BY d.dept_name
HAVING count(e.emp_id) = 0

-- Create View
alter view v_emp_dept
as
select e.emp_id, e.emp_name, d.dept_name
from dbo.employees AS e
LEFT JOIN dbo.departments AS d
ON e.dept_id=d.dept_id

CREATE VIEW v_emp_names
AS
SELECT emp_name 
FROM employees

select * from v_emp_dept

SELECT cust_id, cust_name, city 
FROM customers

CREATE INDEX cust_name_idx ON customers(cust_name)

INSERT INTO employees (emp_name, hire_date, salary)
VALUES ('Adam Smith', '2015-06-24', 4500);

CREATE TABLE users (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50) NOT NULL UNIQUE,
    birth_date DATE NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP 
)

CREATE TABLE employees_clone AS employees

INSERT INTO employee_clone
SELECT *
FROM employees

SELECT * 
INTO #employees
FROM employees

SELECT *
FROM #employees

DROP TABLE #employees

SELECT *
FROM employees
WHERE dept_id IN (
SELECT dept_id FROM departments
WHERE dept_id < 4)