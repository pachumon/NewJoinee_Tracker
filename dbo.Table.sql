CREATE TABLE [dbo].[Table]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(30) NOT NULL, 
    [Project] NCHAR(30) NOT NULL, 
    [Location] NCHAR(30) NOT NULL, 
    [BusinessUnit] NCHAR(30) NOT NULL, 
    [DateOfJoining] DATETIME NOT NULL, 
    [IsActive] BIT NOT NULL
)
