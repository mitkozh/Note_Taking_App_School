-- Create the NoteDB database
CREATE DATABASE NoteDB;
GO

USE NoteDB;

CREATE TABLE Notes (
    NoteID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(255),
    Content NVARCHAR(MAX),
    Timestamp DATETIME
);
GO


USE NoteDB;

INSERT INTO Notes (Title, Content, Timestamp)VALUES ('Sample Note', 'This is a test note', GETDATE());
INSERT INTO Notes (Title, Content, Timestamp)VALUES ('Another Sample Note', 'This is a test note 2', GETDATE());