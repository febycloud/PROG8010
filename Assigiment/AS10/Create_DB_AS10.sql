CREATE TABLE Employee (
	ID INT PRIMARY KEY IDENTITY (1, 1),
	firstName VARCHAR (50) NOT NULL,
	lastName VARCHAR (50) NOT NULL,
	position VARCHAR (50) NOT NULL,
	hourlyPayRate decimal(5,2) NOT NULL
);

INSERT INTO Employee (firstName, lastName, position, hourlyPayRate) VALUES 
	('Homer', 'Simpson', 'HR', 12.52),
	('Bart', 'Simpson', 'Guard', 15.28),
	('Lisa', 'Simpson', 'CEO', 18.26),
	('Marge', 'Simpson', 'Developer', 16.25),
	('Apu', 'Nahapuriman', 'The man who sold the world', 80);