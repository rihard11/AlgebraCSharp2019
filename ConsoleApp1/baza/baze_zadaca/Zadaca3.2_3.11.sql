USE Fakultet
GO

-- Zadatak 3.2
SELECT imeNastavnik,
prezNastavnik
FROM dbo.nastavnik
GO

-- Zadatak 3.3
SELECT mbrStud,
imeStud + ' ' 
+ prezStud AS 'ime i prezime'
FROM dbo.stud
GO

-- Zadatak 3.4
SELECT	DISTINCT imeStud
FROM	dbo.stud
ORDER BY imeStud DESC
GO

-- Zadatak 3.5
SELECT	mbrStud
FROM	dbo.ispit
WHERE	sifPred=146
GO

-- Zadatak 3.6
SELECT imeNastavnik,
prezNastavnik,
(koef + 0.4) * 800 AS 'Placa'
FROM dbo.nastavnik
ORDER BY 'Placa' DESC
GO

-- Zadatak 3.7
SELECT imeNastavnik,
prezNastavnik,
(koef + 0.4) * 800 AS 'Placa'
FROM dbo.nastavnik
WHERE ((koef + 0.4) * 800 < 3500) OR ((koef + 0.4) * 800 > 8000)
ORDER BY 'Placa' ASC
GO

-- Zadatak 3.8
SELECT * 
 FROM dbo.stud
 WHERE imeStud LIKE '[a e i o u]%[a e i o u]'
 GO


-- Zadatak 3.9
SELECT * 
FROM stud
 WHERE imeStud LIKE '[^aeiou]%[^aeiou]'
 GO

-- Zadatak 3.10
SELECT *
FROM dbo.stud
WHERE imeStud LIKE '[aeiou]%' OR imeStud LIKE '%[aeiou]'
GO

-- Zadatak 3.11
SELECT *
FROM dbo.stud
WHERE imeStud LIKE '%nk%' OR prezStud LIKE '%nk%'
GO