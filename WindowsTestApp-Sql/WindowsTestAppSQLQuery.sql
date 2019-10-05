CREATE DATABASE TestApp
USE [TestApp]
CREATE TABLE TestItems(
Id INT IDENTITY(1,1),
ItemName VARCHAR(50),
ItemPrice FLOAT
)
--DROP TABLE TestItem
SELECT * FROM TestItems


CREATE TABLE Customers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),
Address VARCHAR(200),
Contact VARCHAR(50),
)

--DROP TABLE Customers
INSERT INTO Customers VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO Customers VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO Customers VALUES ('Rafi', 'BNorisal' ,'01811369369')

SELECT * FROM TestItems
SELECT * FROM Customers

--CREATE TABLE Orders
--(
--Id INT IDENTITY(1,1) PRIMARY KEY,
--CustomerId INT REFERENCES Customers (Id),
--ItemId INT REFERENCES Items (Id),
--Quantity INT,
--TotalPrice FLOAT,
--)


CREATE TABLE Orders
(
Id INT IDENTITY(1,1) PRIMARY KEY,
CustomerId INT,
ItemId INT ,
Quantity INT,
TotalPrice FLOAT,
)

--DROP TABLE Orders
INSERT INTO Orders VALUES (1, 1 , 5, 600)
INSERT INTO Orders VALUES (1, 2 , 3, 240)
INSERT INTO Orders VALUES (1, 3 , 2, 200)
INSERT INTO Orders VALUES (1, 5 , 2, 200)--

INSERT INTO Orders VALUES (2, 2 , 2, 160)
INSERT INTO Orders VALUES (2, 3 , 3, 300)
INSERT INTO Orders VALUES (2, 4 , 4, 400)
INSERT INTO Orders VALUES (2, 5 , 4, 400)--

INSERT INTO Orders VALUES (4, 3 , 2, 200)--
INSERT INTO Orders VALUES (4, 4 , 2, 200)--

INSERT INTO Orders VALUES (5, 5 , 2, 200)
INSERT INTO Orders VALUES (5, 5 , 2, 200)

SELECT o.Id, CustomerId, c.Name As Customer, ItemId, t.ItemName AS Item, Quantity, TotalPrice FROM Orders AS o
LEFT JOIN Customers AS c ON c.Id  = o.CustomerId
LEFT jOIN TestItems AS t ON t.Id  = o.ItemId