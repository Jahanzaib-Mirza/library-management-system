--CREATE TABLE BOOKS
--  (
--  BookId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
--  BookTitle VARCHAR(225) NOT NULL, 
--  BookPrice INT NOT NULL,
--  BookAuthor VARCHAR(225) NOT NULL,
--  BookEdition VARCHAR(50) NOT NULL,
--  NoOfCopies INT NOT NULL
--  );
 
----/*  ===================  INSERTING VALUES IN BOOKS TABLE    */
--INSERT INTO BOOKS (BookTitle,BookPrice,BookAuthor,BookEdition,NoOfCopies)
--VALUES
--('Probability',500,'ALBERT EINSTEIN','6TH EDITION',34),
--('DBMS',660,'William Shakespeare','4TH EDITION',42),
--('SOFTWARE DESIGN',1000,'HUMA YAMEEN','LATEST EDITION',172),
--('ARCHITECTURAL STYLES',800,'AYESHA KHAN','NEW EDITION',94),
--('DESIGN PATTERNS',950,'SABA SUNAWAR','2ND EDITION',55),
--('MATHEMATICS',270,'AHMED FARAZ','6TH EDITION',67),
--('PROGRAMMING',5000,'ALBERT EINSTEIN','6TH EDITION',67),
--('C# BASICS',5500,'William Shakespeare','9TH EDITION',100),
--('COMMUNICATION SKILLS',5900,'ALBERT EINSTEIN','7TH EDITION',150),
--('OPERATING SYSTEM',5200,'William Shakespeare','LATEST EDITION',110),
--('DESIGN PRICIPLES',5500,'ALBERT EINSTEIN','6TH EDITION',134),
--('DBMS',660,'William Shakespeare','4TH EDITION',42),
--('SOFTWARE DESIGN',1000,'HUMA YAMEEN','LATEST EDITION',172),
--('PROGRAMMING',5000,'ALBERT EINSTEIN','5TH EDITION',67),
--('C# BASICS',5900,'William Shakespeare','9TH EDITION',100),
--('Probability',4000,'ALBERT EINSTEIN','8TH EDITION',34)

-- CREATE PROCEDURE SearchBookByTitle
-- @SearchInput varchar(225)
-- AS
-- BEGIN
-- SELECT * FROM BOOKS WHERE BookTitle LIKE '%'+@SearchInput+'%'
-- END

--EXEC SearchBookByTitle 'ING'

--/*   CREATING STUDENT TABLE     */
--Create table Students
--(
--StudentID int Identity (1,1) primary key NOT NULL,
--StudentName Varchar (225) NOT NULL ,StudentEmail varchar(225) unique NOT NULL,
--StudentPassword Varchar(225) NOT NULL,StudentDepartment varchar(225) NOT NULL,StudentSemester int NOT NULL,
--StudentCity varchar(225)NOT NULL
--) ;

--/* INSERTING VALUES IN STUDENT TABLE*/
-- Insert Into Students 
-- (StudentName,StudentEmail,StudentPassword,StudentDepartment,StudentSemester,StudentCity)
-- VALUES
-- ('Saba','sabasunawar@gmail.com','password123$','Software Engineering',4,'karachi'),
-- ('Ahmed','ahmedfaraz@gmail.com','skills123$','Software Engineering',4,'Islamabad'),
-- ('Zainab','zainiir45@gmail.com','zainab123$','MBBS',3,'karachi'),
-- ('Maria Faraz','ahmedfaraz123@gmail.com','wellgood','Software Engineering',4,'Lahore'),
-- ('Zaccky','zaccky425@gmail.com','passwword12','Software Engineering',5,'karachi'),
-- ('Ahmed Ali','ahmedsem425@gmail.com','jahanpak@123','Software Engineering',3,'Lahore'),
-- ('Saim','ahmedayaz445@gmail.com','saim123@','Psycology',5,'karachi'),
-- ('Ayesha','drayesha34@gmail.com','ayesha123$','MBBS',3,'karachi'),
-- ('Rimsha','rimsha657gmail.com','rimsha123$','Mechanicl Engineer',5,'Lahore'),
-- ('Amna','amnanadeem12@gmail.com','amna123$','Software Engineering',8,'karachi');

--select * from Students

--/* CREATE TABLE LIBRARIAN*/

--Create table Librarians
--(
--LibrarianID int Identity (1,1) primary key NOT NULL,
--LibrarianName Varchar (225) NOT NULL ,LibrarianEmail varchar(225) unique NOT NULL,
--LibrarianPassword Varchar(225) NOT NULL,LibrarianCity varchar(225) NOT NULL,LibrarianSalary int  NOT NULL
--) ;

--/* INSERTING DATA IN LIBRAIANS TABLE*/
-- Insert Into Librarians
-- (LibrarianName,LibrarianEmail,LibrarianPassword,LibrarianCity,LibrarianSalary)
-- VALUES
-- ('Ahmed Shah','ahmedfaraz@gmail.com','skills123$','Karachi',55000),
-- ('Zohaib Malik','zaccky425@gmail.com','passwword12','Islamabad',20000),
-- ('Bilal Fareed','ahmedsem425@gmail.com','jahanpak@123','Karachi',55000),
-- ('Saim Shah','ahmedayaz445@gmail.com','saim123@','Lahore',5500),
-- ('Saba Rajput','drayesha34@gmail.com','ayesha123$','Lahore',99900),
-- ('Amna Gujjar','amnanadeem12@gmail.com','amna123$','Islamabad',66000),
-- ('Saba Rao','saba425@gmail.com','passwword123$','Islamabad',20000);

--/* CREATING ADMINS TABLE*/
--Create table Admins
--(
--AdminID int Identity (1,1) Primary key NOT NULL,
--AdminName Varchar (50) NOT NULL ,AdminEmail varchar(50) unique NOT NULL,AdminDesignation varchar(225),
--AdminPassword Varchar(40) NOT NULL,AdminHiredate date default getdate(), AdminRetiredate date default DateAdd(year,5,getdate())
--) ;
--/* INSERTING DATA IN ADMINS TABLE*/
-- Insert Into Admins
-- (AdminName,AdminEmail,AdminPassword,AdminDesignation)
-- VALUES
-- ('Ahmed Shah','ahmedfaraz@gmail.com','skills123$','Clustered Head'),
-- ('Zohaib Malik','zaccky425@gmail.com','passwword12','HOD'),
-- ('Bilal Fareed','ahmedsem425@gmail.com','jahanpak@123','Managing Director'),
-- ('Saim Shah','ahmedayaz445@gmail.com','saim123@','HOD'),
-- ('Saba Rajput','drayesha34@gmail.com','ayesha123$','Chief Executive'),
-- ('Amna Gujjar','amnanadeem12@gmail.com','amna123$','Managing Director'),
-- ('Saba Rao','saba425@gmail.com','passwword123$','Clustered Head');

--select * from Admins

--/* CREATING FACULTY TABLE*/
--Create table Faculty
--(
--FacultyID int Identity (1,1) primary key NOT NULL,
--FacultyName Varchar (225) NOT NULL ,FacultyEmail varchar(225) unique NOT NULL,
--FacultyPassword Varchar(225) NOT NULL,FacultyQualification Varchar(225) NOT NULL,
--FacultyHiredate date default getdate(),FacultyType varchar(255) default 'Permanent Faculty'
--) ;

--/* INSERT DATA IN FACULTY TABLE*/
-- Insert Into Faculty(FacultyName,FacultyEmail,FacultyPassword,FacultyQualification)
-- VALUES
-- ('Ayesha','sabasunawar@gmail.com','password123$','MBBS'),
-- ('Ahmed','ahmedfaraz@gmail.com','skills123$','Graduate'),
-- ('Zain','zainiir45@gmail.com','zainab123$','MBBS'),
-- ('Faraz','ahmedfaraz123@gmail.com','wellgood','Electrical Engineer'),
-- ('Zohaib','zaccky425@gmail.com','passwword12','Mechanical Engineer'),
-- ('Bilal','ahmedsem425@gmail.com','jahanpak@123','Software Engineer'),
-- ('Saim','ahmedayaz445@gmail.com','saim123@','Psycology'),
-- ('Saba','drayesha34@gmail.com','ayesha123$','MBBS'),
-- ('Amna','amnanadeem12@gmail.com','amna123$','PHD');

--/*      GETSTUDENT STORED PROCEDURE*/
-- GO
-- CREATE PROCEDURE GetStudent
-- @StudentEmail Varchar(225),@StudentPassword varchar (225)
-- AS
-- BEGIN
-- SELECT * FROM Students where StudentEmail=@StudentEmail AND StudentPassword=@StudentPassword
-- END

--/*      GETFACULTY STORED PROCEDURE*/
-- GO
-- CREATE PROCEDURE GetFaculty
-- @FacultyEmail Varchar(225),@FacultyPassword varchar (225)
-- AS
-- BEGIN
-- SELECT * FROM Faculty where FacultyEmail=@FacultyEmail AND FacultyPassword=@FacultyPassword
-- END


--/*      GETLIBRARIAN STORED PROCEDURE*/
-- GO
-- CREATE PROCEDURE GetLibrarian
-- @LibrarianEmail Varchar(225),@LibrarianPassword varchar (225)
-- AS
-- BEGIN
-- SELECT * FROM Librarians where LibrarianEmail=@LibrarianEmail AND LibrarianPassword=@LibrarianPassword
-- END

--/*      GETADMIN STORED PROCEDURE*/
-- GO
-- CREATE PROCEDURE GetAdmin
-- @AdminEmail Varchar(225),@AdminPassword varchar (225)
-- AS
-- BEGIN
-- SELECT * FROM Admins where AdminEmail=@AdminEmail AND AdminPassword=@AdminPassword
-- END


/* STORED PROCEDURE TO ADD STUDENT*/
-- go
-- CREATE PROCEDURE InsertStudentsRecord
-- @StudentName Varchar (225)  ,@StudentEmail varchar(225),
-- @StudentPassword Varchar(225),@StudentDepartment varchar(225),@StudentSemester int ,
-- @StudentCity varchar(225)
-- AS
-- BEGIN 
-- Insert Into Students
-- (StudentName,StudentEmail,StudentPassword,StudentDepartment,StudentSemester,StudentCity)
-- Values
-- (@StudentName,@StudentEmail,@StudentPassword,@StudentDepartment,@StudentSemester,@StudentCity)
-- END

/* STORED PROCEDURE TO DELETE STUDENT*/
-- go
-- Create Procedure DeleteStudentRecord
-- @StudentID int
-- AS 
-- BEGIN 
-- Delete from Students
-- where StudentID=@StudentID
-- END

/* STORED PROCEDURE TO READ STUDENT*/

-- GO
-- CREATE PROCEDURE ReadStudentRecord
-- @StudentID Varchar(225)
-- as
-- begin
-- select * from Students WHERE StudentID = @StudentID 
-- end

/* STORED PROCEDURE TO UPDATE STUDENT*/
-- GO
-- create Procedure UpdateStudentRecord
-- @StudentID int,@StudentName Varchar (225),@Studentemail varchar(225),
-- @StudentPassword Varchar(20),@StudentDept varchar(225),
-- @StudentSemester int,@StudentCity varchar(30)
-- as
-- BEGIN  
-- UPDATE Students  
-- SET  
-- StudentName=@StudentName,Studentemail=@Studentemail,StudentPassword=@StudentPassword,
-- StudentDepartment=@StudentDept,StudentSemester=@StudentSemester,StudentCity=@StudentCity
-- where StudentID =@StudentID
-- END 
 

/* EXECUTION OR CALLING OF EACH PROCESSES FOR TESTING*/
-- Exec ReadStudentRecord 1
-- Exec UpdateStudentRecord 1,'Maliha','maliha@gmail.com','7657g','Software Engineering',4,'Islamabad'
-- Exec DeleteStudentRecord 1011
-- EXEC InsertStudentsRecord 'Talha','talha345@gmail.com','56785','Psychology',4,'Karachi'

/* STORED PROCEDURE TO ADD BOOK*/

-- go
-- CREATE PROCEDURE AddBook
-- @BookTitle Varchar(225),@BookPrice int,@BookAuthor varchar(225),@BookEdition varchar(50),@NoOfCopies int
-- AS
-- BEGIN 
-- INSERT INTO BOOKS (BookTitle,BookPrice,BookAuthor,BookEdition,NoOfCopies)
-- Values
-- (@BookTitle,@BookPrice,@BookAuthor,@BookEdition,@NoOfCopies)
-- END

/* STORED PROCEDURE TO UPDATE BOOK*/

-- go
-- CREATE PROCEDURE UpdateBook
-- @BookId INT,@BookTitle Varchar(225),@BookPrice int,@BookAuthor varchar(225),@BookEdition varchar(50),@NoOfCopies int
-- AS
-- BEGIN 
-- UPDATE BOOKS
-- SET 
-- BookTitle=@BookTitle,
-- BookPrice=@BookPrice,
-- BookAuthor=@BookAuthor,
-- BookEdition=@BookEdition,
-- NoOfCopies=@NoOfCopies
-- WHERE 
-- BookId = @BookId
-- END

/* STORED PROCEDURE TO DELETE BOOK*/
-- GO
-- CREATE PROCEDURE DeleteBook
-- @BookId int
-- AS
-- BEGIN
-- DELETE FROM BOOKS
-- WHERE 
-- BookId=@BookId
-- END

--/EXECUTION OF THESE CRUD OPERATIONS/

--Exec AddBook 'Story Book',699,'Huma Yasmeen','7th Edition', 45
--Exec DeleteBook '5'
--Exec UpdateBook 6,'Story Book',699,'Huma Yasmeen','7th Edition', 45


--Create table Reports(
--ReportID int identity(1,1) primary key,
--BookID int Foreign key references Books(BookID) NOT NULL,
--StudentID int Foreign key references Students(StudentID) NOT NULL,
--LibrarianID int Foreign key references Librarians(LibrarianID) NOT NULL,
--IssueDate date default getDate(),
--)

-- GO
-- Create procedure GenerateReport
-- @BookID int,
-- @StudentID int,
-- @LibrarianID int
-- AS
-- BEGIN
-- INSERT INTO Reports(BookID, StudentiD, LibrarianID)
-- VALUES (@BookID, @StudentiD, @LibrarianID)
-- END

select * from Admins
select * from Faculty
select * from Students
select * from Librarians
select * from Reports
-- Exec GenerateReport 2,4,3
--Exec GenerateReport 1,5,3
--Exec GenerateReport 3,7,4
--Exec GenerateReport 2,2,4
--Exec GenerateReport 4,1,4

-- Create table History (
-- HistoryID int identity(1,1) primary key,
-- LibrarianID int NOT NULL Foreign key references Librarians(LibrarianID),
-- IssueDate date default getDate(),
-- HistoryAction varchar(10) NOT NULL,
-- );



----/* AFTER INSERT TRIGGER*/
-- GO
-- create trigger InsertHistory on Reports 
-- For Insert
-- as
-- declare @LibrarianID int, @Action varchar(10)
-- select @LibrarianID=i.LibrarianID from inserted i;
-- set @Action ='Insert';
-- Insert Into History(LibrarianID, HistoryAction)
-- values (@LibrarianID, @Action);
-- print 'Values Inserted - History Updated - Trigger After Insert Fired Successfully'


--/* AFTER UPDATE TRIGGER*/
-- GO
-- create trigger TriggerAfterUpdate ON History 
-- after update 
-- as declare @id int, @cname varchar(40),@phone varchar(24),@action varchar(50);
-- select @id=i.ShipperID from inserted i;
-- select @cname=i.CompanyName from inserted i;
-- select @phone=i.Phone from inserted i;
-- set @action='Update';
-- insert into Histort values(@id,@cname,@phone,@action);
-- print 'Values Updated - Trigger After Update Fired Successfully'

--/* AFTER DELETE TRIGGER*/
go
create trigger TriggerAfterDelete on History
after delete 
--as declare @id int, @cname varchar(40),@phone varchar(24),@action varchar(50);
--select @id=i.ShipperID from deleted i;  
--select @cname=i.CompanyName from deleted i;
--select @phone=i.Phone from deleted i;
--set @action='Delete';
--insert into Shippers_Audit values(@id,@cname,@phone,@action);
--print 'Values Deleted - Trigger After Delete Fired Successfully'


--select * from reports


--Exec GenerateReport 1,5,1
--Exec GenerateReport 2,4,1
--Exec GenerateReport 3,3,1
--Exec GenerateReport 4,2,1
--Exec GenerateReport 5,1,1
--Exec GenerateReport 1,2,1
--Exec GenerateReport 1,5,2
--Exec GenerateReport 2,4,2
--Exec GenerateReport 3,3,2
--Exec GenerateReport 4,2,3
--Exec GenerateReport 5,1,3
--Exec GenerateReport 1,2,3
--Exec GenerateReport 3,3,4
--Exec GenerateReport 4,2,4

-- truncate table History
-- create view LibrarianHistoryForBooks
-- As
-- select Librarians.LibrarianName, Count(History.LibrarianID) as TotalBookIssuedByLibrarian from History
-- Inner Join Librarians
-- On History.LibrarianID = Librarians.LibrarianID
-- where History.HistoryAction = 'Insert'
-- Group By Librarians.LibrarianName

--select * from admins

-- Create table StudentRegHistory (
-- HistoryID int identity(1,1),
-- AdminID int NOT NULL Foreign key References Admins(AdminID),
-- StudentId int Not Null Foreign Key References Students(StudentID),
-- RegDate date default getDate(),
-- Action varchar(10) NOT NULL,
-- )
-- Create table LibrarianRegHistory (
-- HistoryID int identity(1,1),
-- AdminID int NOT NULL Foreign key References Admins(AdminID),
-- LibrarianID int Not Null Foreign Key References Librarians(LibrarianID),
-- RegDate date default getDate(),
-- Action varchar(10) NOT NULL,
-- )
-- Create table FacultyRegHistory (
-- HistoryID int identity(1,1),
-- AdminID int NOT NULL Foreign key References Admins(AdminID),
-- FacultyID int Not Null Foreign Key References Faculty(FacultyID),
-- RegDate date default getDate(),
-- Action varchar(10) NOT NULL,
-- )

--Drop table LabrianRegHistory
--Drop table FacultyRegHistory


--/* AFTER INSERT TRIGGER*/
-- GO
-- create trigger InsertStudentHistory on Students 
-- For Insert
-- as
-- declare @adminID int, @StudentID int, @RegDate date, @Action varchar(10)
-- select @adminID=i.RegBy from inserted i;
-- select @StudentID=i.studentID from inserted i;
-- set @Action ='Insert';
-- Insert Into StudentRegHistory(AdminID, StudentID, Action)
-- values (@adminID, @StudentID, @Action);
-- print 'Values Inserted - History Student Reg Updated - Trigger After Insert Fired Successfully'

--drop trigger InsertStudentHistory

-- Alter Table Students
-- Add RegBy int;

-- update Students
-- set Regby = 1

select * from StudentRegHistory
select * from Students

-- select StudentName 

-- go
-- CREATE PROCEDURE InsertStudentsRecord
-- @StudentName Varchar (225)  ,@StudentEmail varchar(225),
-- @StudentPassword Varchar(225),@StudentDepartment varchar(225),@StudentSemester int ,
-- @StudentCity varchar(225), @RegBy int
-- AS
-- BEGIN 
-- Insert Into Students
-- (StudentName,StudentEmail,StudentPassword,StudentDepartment,StudentSemester,StudentCity, RegBy)
-- Values
-- (@StudentName,@StudentEmail,@StudentPassword,@StudentDepartment,@StudentSemester,@StudentCity, @RegBy)
-- END

--drop procedure InsertStudentsRecord

--Exec InsertStudentsRecord 'Ahmed','ahmedfaraz11@gmail.com','skills123$','Software Engineering',4,'Islamabad',4
--Exec InsertStudentsRecord 'Ahmed','ahmedfaraz21@gmail.com','skills123$','Software Engineering',4,'Islamabad',4
--Exec InsertStudentsRecord 'Ahmed','ahmedfaraz31@gmail.com','skills123$','Software Engineering',4,'Islamabad',4
--Exec InsertStudentsRecord 'Ahmed','ahmedfaraz12@gmail.com','skills123$','Software Engineering',4,'Islamabad',4
--Exec InsertStudentsRecord 'Ahmed','ahmedfaraz22@gmail.com','skills123$','Software Engineering',4,'Islamabad',4
--Exec InsertStudentsRecord 'Ahmed','ahmedfaraz32@gmail.com','skills123$','Software Engineering',4,'Islamabad',4


--select * from LibrarianHistoryForBooks

-- select * from StudentRegHistory
-- create view LastMonthData
-- As
-- select * from StudentRegHistory where RegDate <= GETDATE() AND RegDate >= DATEADD(Month, -1, GETDATE())


--*******************************************************************************************
-- QUERY - 1
select * from LibrarianHistoryForBooks 
Where TotalBookIssuedByLibrarian = ( select MAX(TotalBookIssuedByLibrarian) from LibrarianHistoryForBooks)
--*******************************************************************************************
--QUERY - 2
Select AdminID, Count(StudentID) as TotalRegStudents from LastMonthData group by AdminID
--*******************************************************************************************




function findBestPath(graph, initialPosition, destination):
    priorityQueue = createPriorityQueue()  // Priority queue to store paths //1
    visited = createEmptySet()  // Set to track visited islands   //1

    // Initialize the path from the initial position with toll of 0
    initialPath = createPath(initialPosition, 0)
    priorityQueue.enqueue(initialPath)

    while not priorityQueue.isEmpty():
        currentPath = priorityQueue.dequeue()
        currentIsland = currentPath.lastIsland()

        // Check if destination is reached
        if currentIsland == destination:
            return currentPath

        // Check if the current island has been visited before
        if currentIsland not in visited:
            visited.add(currentIsland)

            // Explore neighboring islands
            neighbors = graph.getNeighbors(currentIsland)
            for neighbor in neighbors:
                toll = graph.getToll(currentIsland, neighbor)
                extendedPath = extendPath(currentPath, neighbor, toll)
                priorityQueue.enqueue(extendedPath)

    // No path found to the destination
    return null

function extendPath(path, island, toll):
    // Extend the current path to a new island with the given toll
    extendedPath = copy(path)
    extendedPath.addIsland(island)
    extendedPath.incrementToll(toll)
    return extendedPath
