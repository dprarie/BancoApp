-- CREAR BASE DE DATOS
CREATE DATABASE BancoDB;
GO
USE BancoDB;
GO

-- TABLA: CLIENTES
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Country NVARCHAR(100),
    Region NVARCHAR(100),
    City NVARCHAR(100),
    Address NVARCHAR(200),
    LastUpdated DATETIME DEFAULT GETDATE()
);

-- TABLA: CUENTAS
CREATE TABLE Cuentas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL,
    AccountNumber NVARCHAR(30) NOT NULL,
    Description NVARCHAR(200),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);

-- DATOS DE PRUEBA
INSERT INTO Clientes (FirstName, LastName, Username, Password, Country, Region, City, Address)
VALUES ('Juan', 'P�rez', 'juan123', '1234', 'Espa�a', 'Madrid', 'Madrid', 'Calle Falsa 123');

INSERT INTO Cuentas (ClienteId, AccountNumber, Description)
VALUES (1, 'ES1000123456789012345678', 'Cuenta principal');
  _______________________________________________________________________________________________________________________________________



-- CREAR BASE DE DATOS
IF DB_ID('BancoDB') IS NOT NULL
    DROP DATABASE BancoDB;
GO

CREATE DATABASE BancoDB;
GO
USE BancoDB;
GO

-- TABLA: CLIENTES
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Country NVARCHAR(100),
    Region NVARCHAR(100),
    City NVARCHAR(100),
    Address NVARCHAR(200),
    LastUpdated DATETIME DEFAULT GETDATE()
);

-- TABLA: CUENTAS
CREATE TABLE Cuentas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL,
    AccountNumber NVARCHAR(30) NOT NULL,
    Description NVARCHAR(200),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);

-- CLIENTES DE PRUEBA
INSERT INTO Clientes (FirstName, LastName, Username, Password, Country, Region, City, Address) VALUES
('Ana', 'L�pez', 'ana01', 'pass01', 'Espa�a', 'Galicia', 'Lugo', 'Ronda Muralla 45'),
('Carlos', 'Santos', 'carlos02', 'pass02', 'Espa�a', 'Madrid', 'Madrid', 'Calle Mayor 10'),
('Luc�a', 'Mart�nez', 'lucia03', 'pass03', 'Espa�a', 'Andaluc�a', 'Sevilla', 'Av. Constituci�n 12'),
('Pablo', 'G�mez', 'pablo04', 'pass04', 'Espa�a', 'Catalu�a', 'Barcelona', 'Passeig de Gr�cia 100'),
('Mar�a', 'Torres', 'maria05', 'pass05', 'Espa�a', 'Valencia', 'Valencia', 'Calle de la Paz 5'),
('Ra�l', 'Ruiz', 'raul06', 'pass06', 'Espa�a', 'Galicia', 'A Coru�a', 'R�a Real 78'),
('Sara', 'Gil', 'sara07', 'pass07', 'Espa�a', 'Madrid', 'Alcal� de Henares', 'Calle Libreros 9'),
('Javier', 'Navarro', 'javier08', 'pass08', 'Espa�a', 'Castilla y Le�n', 'Burgos', 'Calle Vitoria 60'),
('Clara', 'S�nchez', 'clara09', 'pass09', 'Espa�a', 'Murcia', 'Murcia', 'Plaza Circular 3'),
('David', 'Ortega', 'david10', 'pass10', 'Espa�a', 'Pa�s Vasco', 'Bilbao', 'Gran V�a 22');
('admin', 'admin', 'admin', 'admin', 'admin', 'admin admin', 'admin', 'admin 22');

-- CUENTAS PARA CADA CLIENTE (entre 2 y 4 cada uno)
INSERT INTO Cuentas (ClienteId, AccountNumber, Description) VALUES
(1, 'ES1000000000000000000001', 'Cuenta n�mina'),
(1, 'ES1000000000000000000002', 'Cuenta ahorro'),

(2, 'ES1000000000000000000003', 'Cuenta corriente'),
(2, 'ES1000000000000000000004', 'Cuenta trabajo'),
(2, 'ES1000000000000000000005', 'Cuenta ahorro'),

(3, 'ES1000000000000000000006', 'Cuenta n�mina'),
(3, 'ES1000000000000000000007', 'Cuenta trabajo'),

(4, 'ES1000000000000000000008', 'Cuenta ahorro'),
(4, 'ES1000000000000000000009', 'Cuenta corriente'),
(4, 'ES1000000000000000000010', 'Cuenta n�mina'),

(5, 'ES1000000000000000000011', 'Cuenta corriente'),
(5, 'ES1000000000000000000012', 'Cuenta ahorro'),

(6, 'ES1000000000000000000013', 'Cuenta trabajo'),
(6, 'ES1000000000000000000014', 'Cuenta corriente'),

(7, 'ES1000000000000000000015', 'Cuenta n�mina'),
(7, 'ES1000000000000000000016', 'Cuenta trabajo'),
(7, 'ES1000000000000000000017', 'Cuenta ahorro'),
(7, 'ES1000000000000000000018', 'Cuenta corriente'),

(8, 'ES1000000000000000000019', 'Cuenta n�mina'),
(8, 'ES1000000000000000000020', 'Cuenta corriente'),

(9, 'ES1000000000000000000021', 'Cuenta ahorro'),
(9, 'ES1000000000000000000022', 'Cuenta n�mina'),

(10, 'ES1000000000000000000023', 'Cuenta trabajo'),
(10, 'ES1000000000000000000024', 'Cuenta corriente'),
(10, 'ES1000000000000000000025', 'Cuenta n�mina');

(11, 'ES1000000000000000000026', 'Cuenta trabajo'),
(11, 'ES1000000000000000000027', 'Cuenta corriente'),
(11, 'ES1000000000000000000028', 'Cuenta n�mina');
