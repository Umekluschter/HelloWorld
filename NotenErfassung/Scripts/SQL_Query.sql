﻿CREATE DATABASE NotenErfassung;
Go
USE NotenErfassung;

CREATE TABLE SUBJECTS (
	ID INT PRIMARY KEY,
	NAME VARCHAR(max)
);

CREATE TABLE MARKS (
	ID_MARKS INT PRIMARY KEY,
	VALUE DECIMAL,
	DATE VARCHAR(8)
);

ALTER TABLE SUBJECTS 
ADD FOREIGN KEY (ID) REFERENCES MARKS (ID);