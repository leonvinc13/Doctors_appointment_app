CREATE DATABASE lijecnik

USE lijecnik

CREATE TABLE Lijecnik (
    ID_lijecnika INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Ime_lijecnika VARCHAR(50) NOT NULL,
    Prezime_lijecnika VARCHAR(50) NOT NULL,
    Specijalizacija INT FOREIGN KEY REFERENCES Specijalizacija(ID_specijalizacije),
	Radno_vrijeme VARCHAR(50),
    Broj_telefona VARCHAR(15),
    Email VARCHAR(100),
	Lozinka VARCHAR(50)
)

CREATE TABLE Pacijent (
    ID_pacijenta INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Ime_pacijenta VARCHAR(50) NOT NULL,
    Prezime_pacijenta VARCHAR(50) NOT NULL,
    Datum_rodjenja DATE,
    Spol CHAR(1),
    Adresa_stanovanja VARCHAR(100),
    Broj_telefona VARCHAR(15),
	Email VARCHAR(100),
	Lozinka VARCHAR(50)
)

CREATE TABLE Bolest (
	ID_bolesti INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Naziv_bolesti VARCHAR(50),
	Opis_bolesti VARCHAR(100)
)

CREATE TABLE Lijek (
	ID_lijeka INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Naziv_lijeka VARCHAR(50),
	Proizvodjac VARCHAR(50),
	Opis_lijeka VARCHAR(100),
)

CREATE TABLE Cjepivo (
	ID_cjepiva INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Vrsta_cjepiva VARCHAR(50)
)

CREATE TABLE Posjeta (
	ID_posjete INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_pacijenta INT FOREIGN KEY REFERENCES Pacijent(ID_pacijenta),
	ID_lijecnika INT FOREIGN KEY REFERENCES Lijecnik(ID_lijecnika),
	Datum_posjete DATE,
	Razlog_posjete VARCHAR(100)
)

CREATE TABLE Posjeta_lijek (
	ID_posjeta_lijek INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_posjete INT FOREIGN KEY REFERENCES Posjeta(ID_posjete),
	ID_lijeka INT FOREIGN KEY REFERENCES Lijek(ID_lijeka),
	Doza VARCHAR(50),
	Nacin_primjene VARCHAR(100)
)

CREATE TABLE Posjeta_bolest (
	ID_posjeta_bolest INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_posjete INT FOREIGN KEY REFERENCES Posjeta(ID_posjete),
	ID_bolesti INT FOREIGN KEY REFERENCES Bolest(ID_bolesti)
)

CREATE TABLE Cijepljenje (
	ID_cijepljenja INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_pacijenta INT FOREIGN KEY REFERENCES Pacijent(ID_pacijenta),
	ID_cjepiva INT FOREIGN KEY REFERENCES Cjepivo(ID_cjepiva),
	Datum_cjepljenja DATE,
	Nuspojave VARCHAR(100)
)

CREATE TABLE Specijalizacija (
	ID_specijalizacije INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Naziv_specijalizacije VARCHAR(50)
)



