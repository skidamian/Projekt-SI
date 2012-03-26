CREATE DATABASE sinfo
GO
CREATE TABLE sinfo.dbo.stanowisko
(
	id INT IDENTITY(1,1) NOT NULL,
	nazwa VARCHAR(50) NOT NULL,
	CONSTRAINT id_stanowiska_PK PRIMARY KEY(id)

);
GO
CREATE TABLE sinfo.dbo.pracownicy
(
	id INT IDENTITY(1,1) NOT NULL,
	imie VARCHAR(50) NOT NULL,
	nazwisko VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	haslo VARCHAR(50) NOT NULL,
	stanowisko_id INT NOT NULL,
	CONSTRAINT id_pracownika_PK PRIMARY KEY(id),
	CONSTRAINT id_stanowiska_FK FOREIGN KEY(stanowisko_id) REFERENCES stanowisko(id)
);
GO

CREATE TABLE sinfo.dbo.samochody
(
	id INT IDENTITY(1,1) NOT NULL,
	marka VARCHAR(50) NOT NULL,
	rok_produkcji SMALLINT NOT NULL,
	oc BIT NOT NULL,
	ac BIT NOT NULL,
	nw BIT NOT NULL,
	opis TEXT NOT NULL,
	status_ VARCHAR(50) NOT NULL,
	CONSTRAINT id_samochodu_PK PRIMARY KEY(id)
);
GO

CREATE TABLE sinfo.dbo.klienci
(
	id INT IDENTITY(1,1) NOT NULL,
	imie VARCHAR(50) NOT NULL,
	nazwisko VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	haslo VARCHAR(50) NOT NULL,
	nr_prawka VARCHAR(50) NOT NULL,
	adres VARCHAR(250) NOT NULL,
	CONSTRAINT id_klienta_PK PRIMARY KEY(id),
);
GO
CREATE TABLE sinfo.dbo.rezerwacje
(
	id INT IDENTITY(1,1) NOT NULL,
	data_wypozyczenia DATE NOT NULL,
	data_zwrotu DATE,
	pracownik_id INT NOT NULL,
	klient_id INT NOT NULL,
	samochod_id INT NOT NULL,
	uwagi VARCHAR(50),
	status_ VARCHAR(50) NOT NULL,
	CONSTRAINT id_rezerwacji_PK PRIMARY KEY(id),
	CONSTRAINT id_pracownika_FK FOREIGN KEY(pracownik_id) REFERENCES pracownicy(id),
	CONSTRAINT id_klienta_FK FOREIGN KEY(klient_id) REFERENCES klienci(id),
	CONSTRAINT id_samochodu_FK FOREIGN KEY(samochod_id) REFERENCES samochody(id)
);
GO

INSERT INTO sinfo.dbo.stanowisko VALUES('Administrator');
INSERT INTO sinfo.dbo.stanowisko VALUES('Obs³uga biura');
GO

INSERT INTO sinfo.dbo.pracownicy VALUES('Jan', 'Kowalski', 'jkowalski@carrent.pl', 'kowalskirent', 2);
INSERT INTO sinfo.dbo.pracownicy VALUES('Piotr', 'Nowak', 'pnowak@carrent.pl', 'nowakrent', 1);
INSERT INTO sinfo.dbo.pracownicy VALUES('Tomasz', 'Krasinski', 'tkrasinski@carrent.pl', 'krasinskirent', 2);

GO

INSERT INTO sinfo.dbo.samochody VALUES('Opel Vectra', 2007, 1,1,1,'Sedan, silnik benzynowy, pojemnosc 1.4, 110KM', 'wolny');
INSERT INTO sinfo.dbo.samochody VALUES('Kia Ceed', 2010, 1,1,1,'Combi, silnik diesel, pojemnosc 1.8, 140KM', 'wolny');
INSERT INTO sinfo.dbo.samochody VALUES('Volkswagen Golf VI', 2011, 1,1,1,'Hatchback, silnik benzynowy, pojemnosc 2.0, 160KM', 'zarezerwowany');
INSERT INTO sinfo.dbo.samochody VALUES('Fiat Punto', 2007, 1,1,1,'Sedan, silnik benzynowy, pojemnosc 1.1, 80KM', 'wypozyczony');
INSERT INTO sinfo.dbo.samochody VALUES('Ford Galaxy', 2005, 0,0,0,'Van, silnik diesel, pojemnosc 1.6, 100KM', 'wolny');

GO

INSERT INTO sinfo.dbo.klienci VALUES('Andrzej','Kulesza', 'kulesza@wp.pl','kulesza','PR533241','Milionowa 24/13, 00-203 Warszawa');
INSERT INTO sinfo.dbo.klienci VALUES('Bartosz','Tracz', 'tracz@onet.pl','tracz','SA834230','Julianowska 188/5, 02-407 Warszawa');
INSERT INTO sinfo.dbo.klienci VALUES('Grzegorz','Serwacinski', 'serwacinski@o2.pl','serwacinski','VC998542','Holenderska 11/2, 01-101 Warszawa');
INSERT INTO sinfo.dbo.klienci VALUES('Wojciech','Daros', 'daros@gmail.pl','daros','WE112546','Dabrowskiego 99/45, 00-354 Warszawa');

GO

INSERT INTO sinfo.dbo.rezerwacje VALUES('2011/02/01','2011/02/05',1,2,3,'brak uwag','zrealizowana');
INSERT INTO sinfo.dbo.rezerwacje VALUES('2011/03/12',NULL,2,1,2,'brak uwag','przyjeta do realizacji');
INSERT INTO sinfo.dbo.rezerwacje VALUES('2011/02/15',NULL,3,3,5,'brak uwag','anulowana');
INSERT INTO sinfo.dbo.rezerwacje VALUES('2011/03/15','2011/03/23',1,4,4,'auto zostalo uszkodzone','zrealizowana');

GO

