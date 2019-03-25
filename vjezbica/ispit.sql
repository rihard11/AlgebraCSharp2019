

USE ispit
GO

CREATE TABLE prijatelji (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ime VARCHAR(50) NOT NULL,
	prezime VARCHAR(50) NOT NULL
)

CREATE TABLE medij (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	naziv VARCHAR(50) NOT NULL,
	izvodjac VARCHAR(50) NOT NULL,
	vrsta VARCHAR(50) NOT NULL
)

CREATE TABLE posudba (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	datum_posudbe DATETIME,
	datum_povratka DATETIME,
	id_prijatelja INT NOT NULL FOREIGN KEY REFERENCES prijatelji(id),
	id_medija INT NOT NULL FOREIGN KEY REFERENCES medij(id)
)

-- Ubacivanje podataka
INSERT INTO prijatelji (ime, prezime)
VALUES('Bruce', 'Wayne')

INSERT INTO prijatelji (ime, prezime)
VALUES('Clarck', 'Kent')

INSERT INTO prijatelji (ime, prezime)
VALUES('Diana', 'Prince')

INSERT INTO medij (naziv, vrsta, izvodjac)
VALUES('Roots', 'CD', 'Sepultura')

INSERT INTO medij (naziv, vrsta, izvodjac)
VALUES('MTV Unpluged', 'DVD', 'Nirvana')

INSERT INTO medij (naziv, vrsta, izvodjac)
VALUES('Lateralus', 'CD', 'Tool')

INSERT INTO posudba (datum_posudbe, datum_povratka, id_prijatelja, id_medija)
VALUES('2017-04-23', NULL, 2, 3)

INSERT INTO posudba (datum_posudbe, datum_povratka, id_prijatelja, id_medija)
VALUES('2018-08-18', '2018-11-26', 3, 2)

INSERT INTO posudba (datum_posudbe, datum_povratka, id_prijatelja, id_medija)
VALUES('2019-02-02', NULL, 1, 1)

-- Selektanje
SELECT ime AS 'Ime', prezime AS 'Prezime',
DATEDIFF(day, datum_posudbe, GETDATE()) AS 'Dana posudjeno'
FROM prijatelji AS pr
LEFT JOIN posudba AS po
ON pr.id=po.id_prijatelja
LEFT JOIN medij AS m
ON po.id_medija=m.id
-- WHERE datum_povratka IS NULL

UPDATE posudba SET datum_povratka = GETDATE()
WHERE datum_povratka IS NULL

