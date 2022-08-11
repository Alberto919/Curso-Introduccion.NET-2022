CREATE DATABASE CursoNet
GO

USE CursoNet
GO

CREATE TABLE Instructores(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL
);

INSERT INTO Instructores
           (Nombre, Apellido)
     VALUES
           ('Ezequiel' ,'Etchecoin'),
		   ('Ruben' ,'Benegas'),
		   ('Juaquin' ,'Mateos'),
		   ('Eugenio' ,'Serrano');

SELECT Nombre, Apellido 
FROM Instructores