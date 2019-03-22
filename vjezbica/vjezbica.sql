USE ispit
GO

CREATE TABLE prijatelji(
	id	INT NOT NULL PRIMARY KEY,
	ime  NCHAR(50),
	prezime NCHAR(50),
	adresa NCHAR(50),
	telefon INT,
	datum_posudbe DATETIME
)
GO

CREATE TABLE zanr(
	id INT NOT NULL PRIMARY KEY,
	naziv NCHAR(50)
)
GO

CREATE TABLE cd(
	id INT NOT NULL PRIMARY KEY,
	artist NCHAR(50),
	godina_izdanja INT,
	slika_naslovnice IMAGE,
	id_zanr INT FOREIGN KEY REFERENCES zanr(id)
)
GO

CREATE TABLE cjenik(
	id INT NOT NULL PRIMARY KEY,
	kategorija NCHAR(50),
	cijena MONEY
)
GO

CREATE TABLE posudba(
	id_prijatelj INT NOT NULL FOREIGN KEY REFERENCES prijatelji(id),
	id_cd INT NOT NULL FOREIGN KEY REFERENCES cd(id),
	datum_posudbe DATETIME,
	datum_povratka DATETIME,
	id_cjenik INT NOT NULL FOREIGN KEY REFERENCES cjenik(id)
)