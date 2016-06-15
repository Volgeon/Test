--FI4F M.König
USE DbLKoh05; -- Klassendatenbank auswählen
--Tabellen anlegen
CREATE TABLE tbl_06aPersonal
(
  --Attributbezeichner***DatenTyp***Funktion
  	Persnr                INTEGER     	PRIMARY KEY,
  	Name                  CHAR(35)    	NOT NULL,
  	Ort                   CHAR(25),
  	Vorgesetzt            INTEGER		REFERENCES tbl_06aPersonal,
  	Gehalt                NUMERIC(9,2)
);
-- ...
--FK -> muss selben Datentyp wie PK haben
--Numeric ->
-- ...
CREATE TABLE tbl_06aKunde
(
  	Nr                		INTEGER     PRIMARY KEY,
  	Name                  	CHAR(35)    NOT NULL,
 	Strasse					CHAR(25),
  	PLZ						CHAR(5),
  	Ort                   	CHAR(25),
);
CREATE TABLE tbl_06aAuftrag
(
  	Auftrnr               	INTEGER     PRIMARY KEY,
  	Name                  	CHAR(35)    NOT NULL,
  	Datum					DATETIME,
	Kundnr					INTEGER 	REFERENCES tbl_06aPersonal,
	Persnr					INTEGER		REFERENCES tbl_06aKunde
);
--***wegen Referenzen auf Reihefolge achten !!!

--***Tabelle befüllen

--INSERT "Affe" INTO tbl_06aPersonal.Name

--***Tabellen löschen -> Vorsicht mit Daten
--DROP TABLE tbl_06aPersonal;
--***27.11.2014