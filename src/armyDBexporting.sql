BEGIN TRANSACTION;
CREATE TABLE "PropertyRecord"(
"Name" varchar(140) primary key not null ,
"Value" varchar(140) );
INSERT INTO PropertyRecord VALUES('ColumnVisibility','TTTTTFFFTTFFFFFFTTTFFFFFFFF');
CREATE TABLE "SoldierRecord"(
"Id" integer primary key autoincrement not null ,
"Onoma" varchar(140) ,
"Epitheto" varchar(140) ,
"Asm" integer ,
"Klasi" integer ,
"Seira" varchar(140) ,
"ArithmosPolitikisTaytotitas" integer ,
"ImerominiaGenniseos" datetime ,
"Bathmos" varchar(140) ,
"Idikotita" varchar(140) ,
"EinaiEfedros" varchar(140) ,
"DieythinsiSpitiou" varchar(140) ,
"DieythinsiErgasias" varchar(140) ,
"Til_oikias" varchar(140) ,
"Til_kinito" varchar(140) ,
"Til_ergasias" varchar(140) ,
"Loxos" varchar(140) ,
"Dimiria" varchar(140) ,
"Omada" varchar(140) ,
"Kathikonta" varchar(140) ,
"ArithmosOplou" varchar(140) ,
"ArithmosXyfoloxis" varchar(140) ,
"AllosOplismos" varchar(140) ,
"Sxolia" varchar(140) ,
"LoipaStoixia" varchar(140) ,
"CreationDate" datetime ,
"LastUpdateDate" datetime );
INSERT INTO SoldierRecord VALUES(1,'Αντρεας','Καπαρτης',880115,111,11111,111111111,'1975-06-02 00:00:00','ΣΤΡΤΗΣ','Τ/Φ','Κληρωτός',NULL,NULL,NULL,NULL,NULL,'1ος','1η','1η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 13:24:42','2013-06-12 10:39:54');
INSERT INTO SoldierRecord VALUES(2,'Κυριάκος','Ξιουρουπας',2323,3323,'233φ',0,'1993-01-28 00:00:00','ΔΝΕΑΣ','Α/Τ','Έφεδρος','διευθυνση 1','διεύθυβση 2',333333,5555555,44444,'2ος','2η','1η',NULL,7455634,4564,NULL,'σχολια 322','λοιπά στοιχεία','2013-06-11 13:24:44','2013-06-11 14:42:08');
INSERT INTO SoldierRecord VALUES(3,'Ζαχαρίας','Σταυράκης',837976,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','1η','1η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 13:24:45','2013-06-12 10:39:07');
INSERT INTO SoldierRecord VALUES(4,'Βαρνάβας','Θεμιστοκλέους',567343,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','1η','2η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:17','2013-06-12 10:36:28');
INSERT INTO SoldierRecord VALUES(5,'Ελευθέριος','Καυστήρας',72778,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','1η','2η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:19','2013-06-12 10:38:59');
INSERT INTO SoldierRecord VALUES(6,'Παναγιώτης','Φλουρέντζου',16893,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','1η','3η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:21','2013-06-12 10:38:36');
INSERT INTO SoldierRecord VALUES(9,'Σπυρίδον','Αντρέου',233101,0,NULL,333,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','1η','3η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:26','2013-06-12 10:39:40');
INSERT INTO SoldierRecord VALUES(11,'Χρίστος','Βορκάς',41003,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','2η','1η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:30','2013-06-12 10:40:45');
INSERT INTO SoldierRecord VALUES(12,'Θεμιστοκλής','Ριγάκης',31908,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','2η','1η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:32','2013-06-12 10:41:21');
INSERT INTO SoldierRecord VALUES(13,'Βρασιδας','Νεομενέας',9012,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','2η','2η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:33','2013-06-12 10:42:04');
INSERT INTO SoldierRecord VALUES(14,'Ιωάννης','Κλατσιάς',6230,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','2η','2η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:34','2013-06-12 10:43:01');
INSERT INTO SoldierRecord VALUES(17,'Νικόλας','Φανής',4044,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','2η','3η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:39','2013-06-12 10:44:23');
INSERT INTO SoldierRecord VALUES(18,'Δημήτρης','Αππιος',3604,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','2η','3η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:41','2013-06-12 10:45:09');
INSERT INTO SoldierRecord VALUES(19,'Ιάσονας','Φιλίπου',9281,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1ος','3η','1η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 14:39:43','2013-06-12 10:45:54');
INSERT INTO SoldierRecord VALUES(20,'Φραγκίσκος','Σταύρου',30294,0,NULL,2222,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2ος','1η','2η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-11 15:29:34','2013-06-12 10:47:18');
INSERT INTO SoldierRecord VALUES(21,'Δεσπότης','Νικάνδρου',78390,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2ος','1η','2η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-12 10:47:20','2013-06-12 10:47:20');
INSERT INTO SoldierRecord VALUES(22,'Γιώργος','Πραστήτης',83657,0,NULL,0,'1900-01-01 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2ος','1η','1η',NULL,NULL,NULL,NULL,NULL,NULL,'2013-06-12 10:48:30','2013-06-12 10:48:30');
CREATE TABLE sqlite_sequence(name,seq);
INSERT INTO sqlite_sequence VALUES('SoldierRecord',22);
COMMIT;
