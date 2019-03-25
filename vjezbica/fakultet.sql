USE Fakultet
GO

SELECT  DISTINCT m.nazMjesto
FROM mjesto m
LEFT JOIN stud s
ON m.pbr=s.pbrStan
WHERE pbrStan IS NOT NULL


SELECT  DISTINCT m.nazMjesto
FROM mjesto m
LEFT JOIN stud s
ON m.pbr=s.pbrStan
WHERE pbrStan <> pbrRod

SELECT
	p.nazPred AS 'Naziv predavanja' 
	,d.oznDvorana AS 'Oznaka Dvorane' 
	,p.sifOrgjed AS 'Sifra Organizacijeske jedinice'
	FROM pred p
	LEFT JOIN rezervacija rez
	ON p.sifPred=rez.sifPred
	LEFT JOIN dvorana d
	ON rez.oznDvorana=d.oznDvorana

SELECT s.prezStud, n.prezNastavnik
FROM stud s
INNER JOIN nastavnik n
ON s.prezStud=n.prezNastavnik
ORDER BY prezStud ASC

SELECT DISTINCT s.*, i.sifPred, i.ocjena, m.nazMjesto
FROM stud s
INNER JOIN mjesto m
ON s.pbrStan=m.pbr
LEFT JOIN ispit i
ON s.mbrStud=i.mbrStud
LEFT Join pred p
ON i.sifPred=p.sifPred
WHERE i.sifPred = 658 AND i.ocjena = 1


SELECT 
	n.imeNastavnik
	,n.prezNastavnik
	,p.nazPred
	,m.nazMjesto
	,z.nazZupanija
	,i.ocjena
FROM nastavnik n
left join ispit i
ON n.sifNastavnik=i.sifNastavnik
left join pred p
ON i.sifPred=p.sifPred
left join mjesto m
ON n.pbrStan=m.pbr
left join zupanija z
ON m.sifZupanija=z.sifZupanija
WHERE i.ocjena = 2 OR i.ocjena = 3