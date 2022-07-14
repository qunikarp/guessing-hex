CREATE DATABASE HexGAME
GO
USE HexGAME
CREATE TABLE "USER"
(
UserID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
Email nvarchar(30) UNIQUE NOT NULL,
_Password nvarchar(30) NOT NULL,
NickName nvarchar(20) UNIQUE NOT NULL,
Avatar varchar(400) NOT NULL default 'avatar.jpg'
);
GO
