CREATE DATABASE DEMOTIMEDATE
USE DEMOTIMEDATE

CREATE TABLE testdatetime(
	id			INT				PRIMARY KEY IDENTITY(1,1),
	time1		datetime		DEFAULT GETDATE(),
	time2		date			DEFAULT	GETDATE(),
	note		nvarchar(20)	NULL
)

INSERT INTO dbo.testdatetime(note) VALUES
--('1'),
--('2'),
('3')

--DELETE FROM dbo.testdatetime

SELECT * FROM dbo.testdatetime