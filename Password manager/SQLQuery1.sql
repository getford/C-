﻿create database CS_Kurs;
use CS_Kurs;

CREATE TABLE introduce(
	ID int primary key NOT NULL,
	user_login nvarchar(15) NOT NULL,
	user_password nvarchar(30) NOT NULL,
	user_e_mail nvarchar(50) NOT NULL,
	user_first_name nvarchar(15),
	user_last_name nvarchar(15),
	user_sex char(1) default '-' check (user_sex in ('m', 'f')),
	user_first_question nvarchar(20) NOT NULL,
	user_first_answer nvarchar(20) NOT NULL, 
	user_secound_question nvarchar(20) NOT NULL,
	user_secound_answer nvarchar(20) NOT NULL
	);

CREATE TABLE user_site(
	ID int constraint id foreign key references introduce(ID),
	URL_site nvarchar(50) NOT NULL,
	Login_site nvarchar(20) NOT NULL,
	Password_site nvarchar(30) NOT NULL
	)


