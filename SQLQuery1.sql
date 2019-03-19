-- linijski komentar
/* blok komentar
-- CREATE DATABASE upisi
-- GO
*/
USE upisi;
CREATE TABLE #privremena(
id INT,
ime NCHAR(50),
prezime VARCHAR(50),
mjesto_stanovanja NCHAR(25)
);
INSERT INTO [dbo].[polaznici] (
[id], [ime], [prezime], [mjesto_stanovanja]) 
VALUES (0, N'Pero                                              ', 
N'Peric', 
N'Osijek                   ')
SELECT * FROM #privremena;