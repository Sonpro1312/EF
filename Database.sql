CREATE DATABASE [Companies]
GO
USE [Companies]
GO
CREATE TABLE [Company] (
	[Id] int PRIMARY KEY IDENTITY(1, 1),
	[Name] nvarchar(50) NOT NULL
)
GO
CREATE TABLE [Department] (
	[Id] int PRIMARY KEY IDENTITY(1, 1),
	[Name] nvarchar(50) NOT NULL,
)
CREATE TABLE [Employee] (
	[Id] int PRIMARY KEY IDENTITY(1, 1),
	[Name] nvarchar(50) NOT NULL,
	[Gender] bit NOT NULL,
	[Age] int NOT NULL,
	[DepartmentId] int FOREIGN KEY REFERENCES [Department]([id]) NOT NULL,
	[CompanyId] int FOREIGN KEY REFERENCES [Company]([id]) NOT NULL,
	CONSTRAINT CHECK_Employee_Age CHECK ([Age] >= 18)
)

INSERT INTO [Company]
VALUES
	('Co-op mart'),
	('Microsoft'),
	('Apple'),
	('Google'),
	('Amazon'),
	('SCB Bank'),
	('Shopee'),
	('Grab'),
	('Intel'),
	('AMD');

INSERT INTO [Department]
VALUES
	('IT'),
	('Marketing'),
	('Data'),
	('Engineer'),
	('Finance'),
	('Director'),
	('Development'),
	('Customer Support'),
	('Product Management'),
	('Entertainment');

INSERT INTO [Employee]
VALUES
	('Hoang Van Son', 1, 20, 1, 2),
	('Huynh Kim Thang', 1, 20, 1, 3),
	('Do Le Thanh Tuan', 1, 22, 5, 4),
	('Huynh Van Toan', 1, 21, 3, 3),
	('Hoang Van Thong', 1, 23, 3, 1),
	('Hoang Thi Thao', 0, 25, 4, 4),
	('Do Nhat Huy', 1, 24, 6, 8),
	('Taylor Swift', 0, 28, 5, 6),
	('Cristiano Ronaldo', 1, 39, 5, 10),
	('Donald Trump', 1, 68, 6, 5),
	('David Beckham', 1, 47, 3, 6),
	('Son Tung', 1, 32, 1, 1),
	('Wayne Rooney', 1, 39, 7, 9),
	('Roberto Carlos', 1, 48, 4, 1),
	('Michael Jordan', 1, 37, 2, 3),
	('Pham Van Thinh', 1, 37, 2, 3),
	('Ho Thai Son', 1, 36, 3, 4),
	('Michael Jackson', 1, 40, 3, 8),
	('James Rodriguez', 1, 32, 2, 2),
	('La Lisa', 0, 28, 1, 8),
	('Harry Maguire', 1, 32, 3, 2),
	('Hoang Thi Rose', 0, 32, 2, 7),
	('Rio Ferdinand', 1, 48, 7, 7),
	('Scott McTominay', 1, 33, 2, 2),
	('Hoang Thi Thanh Tuyen', 0, 21, 2, 3),
	('Patrick Viera', 1, 45, 2, 9),
	('Elizabeth Queen', 0, 88, 2, 4),
	('Djokovic', 1, 35, 2, 3),
	('Brandon William', 1, 19, 4, 4),
	('Nguyen Cong Phuong', 1, 30, 2, 1);