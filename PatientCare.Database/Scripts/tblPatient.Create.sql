CREATE TABLE tblPatient (  
PatientID int IDENTITY(1,1) NOT NULL PRIMARY KEY,  
FistName varchar(20) NOT NULL ,  
MiddleInitial varchar(1) NULL , 
LastName varchar(20) NOT NULL ,  
Address1 varchar(40) NOT NULL ,  
Address2 varchar(40) NULL , 
City varchar(30) NOT NULL,
State varchar(6) NOT NULL,  
Zipcode varchar(5) NOT NULL, 
County varchar(30) NULL,
Country varchar(30) NULL, 
Gender varchar(10) NULL, 
MaritalStatus varchar(10) NULL,
Email varchar(80) NULL,
DOB varchar(10) NULL
)  
GO  