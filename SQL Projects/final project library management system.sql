CREATE DATABASE library;

USE library;

CREATE TABLE Library_Branch (
BranchID INT NOT NULL,
BranchName varchar (200) NOT NULL,
BranchAddress varchar(300) NOT NULL
);

CREATE TABLE Publisher (
Name varchar(100) PRIMARY KEY,
PublisherAddress varchar (300),
Phone varchar (20)
);

CREATE TABLE Books (
BookID INT PRIMARY KEY,
Title varchar (200) NOT NULL,
PublisherName varchar (200) NOT NULL
);

CREATE TABLE Book_Authors (
BookID INT PRIMARY KEY,
AuthorName varchar (200) NOT NULL
);

CREATE TABLE Book_Copies (
BookID INT,
BranchID INT NOT NULL,
Copies INT NOT NULL
);

CREATE TABLE Borrower (
CardNumber INT PRIMARY KEY,
BorrowerName varchar (100) NOT NULL,
BorrowerAddress varchar (300) NOT NULL,
BorrowerPhone varchar (20) NOT NULL
);

CREATE TABLE Book_Loans (
BookID INT NOT NULL,
BranchID INT NOT NULL,
CardNumber INT NOT NULL,
CheckedOut varchar(100) NOT NULL,
DueDate varchar(100) NOT NULL
);

INSERT INTO Library_Branch 
VALUES 
(1, 'Sharpstown', '467 Penway Ave.'),
(2, 'Central', '9273 Central Way'),
(3, 'Baker', '34 Bread Street'),
(4, 'Calculus', '8467 Abacus Lane')

SELECT * FROM Library_Branch
GO

INSERT INTO Publisher 
VALUES
('Rhineland Publishing', '10 Rue des Gaulois, Luxembourg, Belgium', '+12 167-926-6390'),
('HarperCollins Publishers', '1 London Bridge St, London SE1 9GF, United Kingdom', '+2 978-279-2890'),
('Sunset Publishing', '631 US-1, North Palm Beach, Florida, United States', '607-235-5639'),
('Goose River Press', '3400 Friendship Rd, Waldoboro, Maine, United States', '578-3578-9367')

SELECT * FROM Publisher
GO

INSERT INTO Books
VALUES
(1, 'The Lost Tribe', 'Goose River Press'),
(2, 'Treasure Island','HarperCollins Publishers'),
(3, 'Swiss Family Robinson', 'Goose River Press'),
(4, 'Moby Dick', 'HarperCollins Publishers'),
(5, 'Robinson Crusoe', 'HarperCollins Publishers'),
(6,'The Lost World', 'Beacon Publishing'),
(7,'The Man Who Would Be King','Beacon Publishing'),
(8,'A Midsummer Nights Dream', 'HarperCollins Publishers'),
(9,'Jurrasic Park', 'Beacon Publishing'),
(10,'Harry Potter and the Sorcerers Stone', 'Beacon Publishing'),
(11,'Pride and Prejudice', 'Beacon Publishing'),
(12,'Catch-22', 'Rheinland Publishing'),
(13,'Of Mice and Men', 'Goose River Press'),
(14,'IT', 'Goose River Press'),
(15,'Needful Things', 'Beacon Publishing'),
(16,'The Scarlet Letter', 'Rheinland Publishing'),
(17,'Great Expectations', 'Beacon Publishing'),
(18,'A Tale of Two Cities', 'HarperCollins Publishers'),
(19,'To Kill A Mockingbird', 'Rheinland Publishing'),
(20,'Romeo and Juliet', 'HarperCollins Publishers')

SELECT * FROM Books
GO

INSERT INTO Book_Authors
VALUES 
(1, 'Nona Sapper'),
(2, 'Robert Louis Stevenson'),
(3, 'John David Wyss'),
(4, 'Herman Melville'),
(5, 'Daniel Defoe'),
(6,'Arthur Conan Doyle'),
(7,'Rudyard Kipling'),
(8,'William Shakespeare'),
(9,'Michael Crichton'),
(10,'J.K. Rowling'),
(11,'Jane Austen'),
(12,'Joseph Heller'),
(13,'John Steinbeck'),
(14,'Stephen King'),
(15,'Stephen King'),
(16,'Nathaniel Hawthorne'),
(17,'Charles Dickens'),
(18,'Charles Dickens'),
(19,'Harper Lee'),
(20,'William Shakespeare')

SELECT * FROM Book_Authors
GO

INSERT INTO Book_Copies
VALUES
(1, 1, 4),
(1, 2, 2), 
(1, 3, 5),
(1, 4, 3), 
(2, 1, 4), 
(2, 2, 2), 
(2, 3, 5),
(2, 4, 3),
(3, 1, 4), 
(3, 2, 2), 
(3, 3, 5),
(3, 4, 3),
(4, 1, 4), 
(4, 2, 2), 
(4, 3, 5),
(4, 4, 3), 
(5, 1, 4), 
(5, 2, 2), 
(5, 3, 5),
(5, 4, 3), 
(6, 1, 4), 
(6, 2, 2), 
(6, 3, 5),
(6, 4, 3), 
(7, 1, 4), 
(7, 2, 2), 
(7, 3, 5),
(7, 4, 3),
(8, 1, 4), 
(8, 2, 2), 
(8, 3, 5),
(8, 4, 3),
(9, 1, 4), 
(9, 2, 2), 
(9, 3, 5),
(9, 4, 3), 
(10, 1, 4), 
(10, 2, 2), 
(10, 3, 5),
(10, 4, 3),
(11, 1, 4), 
(11, 2, 2), 
(11, 3, 5),
(11, 4, 3), 
(12, 1, 4), 
(12, 2, 2), 
(12, 3, 5),
(12, 4, 3), 
(13, 1, 4), 
(13, 2, 2), 
(13, 3, 5),
(13, 4, 3), 
(14, 1, 4), 
(14, 2, 2), 
(14, 3, 5),
(14, 4, 3),
(15, 1, 4), 
(15, 2, 2), 
(15, 3, 5),
(15, 4, 3), 
(16, 1, 4), 
(16, 2, 2), 
(16, 3, 5),
(16, 4, 3), 
(17, 1, 4), 
(17, 2, 2), 
(17, 3, 5),
(17, 4, 3), 
(18, 1, 4), 
(18, 2, 2), 
(18, 3, 5),
(18, 4, 3), 
(19, 1, 4), 
(19, 2, 2), 
(19, 3, 5),
(19, 4, 3),
(20, 1, 4), 
(20, 2, 2), 
(20, 3, 5),
(20, 4, 3) 

SELECT * FROM Book_Copies
GO

INSERT INTO Borrower 
VALUES 
(123456, 'Abdur-Rahman Kaiser', '3590 Shinn Street', '777-123-4567'),
(789012, 'Zephaniah Henderson', '1453 Hill Street', '777-890-1234'),
(345678, 'Christie Palacios', '4620 Stutler Lane', '777-567-8901'),
(539673, 'Julius Gibbons', '2384 Bolman Court', '777-234-5678'),
(982357, 'Shivam Cobb', '1224 Fleming Street', '777-901-2345'),
(908645, 'Violet Boranda', '3908 Medical Center Drive', '777-678-9012'),
(467947, 'Darin Miller', '1466 Bryan Avenue', '777-345-6789'),
(187462, 'Fatima Jimenez', '2403 Bartlett Avenue', '777-012-3456'),
(887234, 'Hadi Irving', '1489 Lucy Lane', '777-789-0123'),
(183743, 'Maximillian Villalobos', '114 Kelley Road', '777-456-7890')

SELECT * FROM Borrower
GO

 INSERT INTO BOOK_LOANS 
 VALUES 
(4, 1, 123456, '09/01/18', '10/01/18'),
(3, 4, 789012, '09/01/18', '10/01/18'),
(8, 2, 345678, '09/01/18', '10/01/18'),
(5, 4, 887234, '09/01/18', '10/01/18'),
(8, 4, 539673, '10/01/18', '11/01/18'),
(9, 4, 345678, '10/01/18', '11/01/18'),
(11, 1, 982357, '10/01/18', '11/01/18'),
(12, 1, 123456, '10/01/18', '11/01/18'),
(20, 3, 887234, '11/01/18', '12/01/18'),
(19, 1, 887234, '11/01/18', '12/01/18'),
(13, 3, 123456, '11/01/18', '12/01/18'),
(11, 1, 789012, '11/01/18', '12/01/18'),
(2, 4, 345678, '12/01/18', '01/01/19'),
(7, 1, 887234, '12/01/18', '01/01/19'),
(5, 3, 345678, '12/01/18', '01/01/19'),
(6, 1, 908645, '12/01/18', '01/01/19'),
(1, 1, 345678, '01/01/19', '02/01/19'),
(1, 4, 908645, '01/01/19', '02/01/19'),
(1, 2, 123456, '01/01/19', '02/01/19'),
(1, 3, 908645, '01/01/19', '02/01/19'),
(2, 2, 539673, '02/01/19', '03/01/19'),
(18, 1, 123456, '02/01/19', '03/01/19'),
(4, 1, 123456, '02/01/19', '03/01/19'),
(19, 1, 908645, '02/01/19', '03/01/19'),
(6, 1, 123456, '03/01/19', '04/01/19'),
(9, 3, 982357, '03/01/19', '04/01/19'),
(2, 1, 123456, '03/01/19', '04/01/19'),
(2, 4, 345678, '03/01/19', '04/01/19'),
(10, 1, 789012, '04/01/19', '05/01/19'),
(12, 3, 123456, '04/01/19', '05/01/19'),
(12, 1, 982357, '04/01/19', '05/01/19'),
(13, 1, 183743, '04/01/19', '05/01/19'),
(7, 1, 183743, '05/01/19', '06/01/19'),
(9, 1, 789012, '05/01/19', '06/01/19'),
(19, 4, 123456, '05/01/19', '06/01/19'),
(7, 1, 123456, '05/01/19', '06/01/19'),
(8, 1, 887234, '06/01/19', '07/01/19'),
(10, 1, 123456, '06/01/19', '07/01/19'),
(20, 2, 982357, '06/01/19', '07/01/19'),
(14, 2, 789012, '06/01/19', '07/01/19'),
(11, 2, 467947, '07/01/19', '08/01/19'),
(9, 2, 345678, '07/01/19', '08/01/19'),
(2, 2, 183743, '07/01/19', '08/01/19'),
(1, 1, 887234, '07/01/19', '08/01/19'),
(4, 2, 345678, '08/01/19', '09/01/19'),
(5, 1, 887234, '08/01/19', '09/01/19'),
(9, 1, 908645, '08/01/19', '09/01/19'),
(10, 1, 982357, '08/01/19', '09/01/19'),
(10, 1, 467947, '09/01/19', '10/01/19'),
(19, 1, 539673, '09/01/19', '10/01/19'),
(17, 1, 789012, '09/01/19', '10/01/19'),
(3, 2, 123456, '09/01/19', '10/01/19')

SELECT * FROM Book_Loans
GO

-- Selects all copies of "The Lost Tribe" from the Sharpstown branch.

CREATE PROCEDURE dbo.uspLostTribeSharpstown
AS
SELECT Copies
FROM Book_Copies
WHERE BranchID = 1
AND BookID = 1
GO

EXEC dbo.uspLostTribeSharpstown
GO

-- Selects all copies of "The Lost Tribe" from all branches.

CREATE PROCEDURE dbo.uspLostTribeAllBranches
AS
SELECT Copies
FROM Book_Copies
WHERE BookID = 1
GO

EXEC dbo.uspLostTribeAllBranches
GO

-- Selects all borrowers who currently have no books checked out.

CREATE PROCEDURE dbo.uspBorrowersWithoutBooks
AS
SELECT BorrowerName
FROM Borrower
JOIN Book_Loans ON Book_Loans.CardNumber = Borrower.CardNumber
WHERE Book_Loans.DueDate >= CONVERT(datetime, '10/01/19')
GO

EXEC dbo.uspBorrowersWithoutBooks
GO

-- Selects the name and address of each borrower who has checked out a book
-- from the Sharpstown branch and is due back on 10/01/19

CREATE PROCEDURE dbo.uspBranchBooksLoaned
AS
SELECT BorrowerName, BorrowerAddress
FROM Borrower
JOIN Book_Loans ON Book_Loans.CardNumber = Borrower.CardNumber
WHERE Book_Loans.DueDate = CONVERT(datetime, '10/01/19')
GO

EXEC dbo.uspBranchBooksLoaned
GO

-- Retrieves the names, addresses, and the number of books checked out
-- for all borrowers who have checked out more than five books

CREATE PROCEDURE dbo.uspMoreThanFiveBooks
AS
SELECT Borrower.BorrowerName, Borrower.BorrowerAddress,
		COUNT(Book_Loans.CardNumber)AS CheckedOut
FROM Borrower
JOIN Book_Loans ON Borrower.CardNumber = Book_Loans.CardNumber
WHERE Book_Loans.CardNumber = Borrower.CardNumber
GROUP BY BorrowerName, BorrowerAddress, Book_Loans.CardNumber
HAVING COUNT(CheckedOut) > 5
GO

EXEC dbo.uspMoreThanFiveBooks
GO

-- Retrieves the title and number of copies of every book
-- in the Central branch that was authored by Stephen King

CREATE PROCEDURE dbo.uspStephenKingCentral
AS
SELECT Books.Title, Book_Copies.Copies
FROM Books
JOIN Book_Copies ON Books.BookID = Book_Copies.BookID
JOIN Book_Authors ON Books.BookID = Book_Authors.BookID
WHERE BranchID = 2 AND AuthorName = 'Stephen King'
GO

EXEC dbo.uspStephenKingCentral
GO