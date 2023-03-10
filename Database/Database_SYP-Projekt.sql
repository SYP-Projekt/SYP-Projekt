CREATE DATABASE IF NOT EXISTS speicher_DB;
USE speicher_DB;

CREATE TABLE IF NOT EXISTS Player (
`spielerID` INT(1) NOT NULL AUTO_INCREMENT,
`inventoryID` INT(1) NOT NULL,
`xkoord` FLOAT(8) NOT NULL,
`ykoord` FLOAT(8) NOT NULL,
`zkoord` FLOAT(8) NOT NULL,
PRIMARY KEY(spielerID),
CONSTRAINT FK_inventoryID FOREIGN KEY (inventoryID) REFERENCES Inventory(inventoryID));

CREATE TABLE IF NOT EXISTS Items (
`ID` INT(4) NOT NULL AUTO_INCREMENT,
`name` VARCHAR(20) NOT NULL,
PRIMARY KEY(id));

CREATE TABLE IF NOT EXISTS ItemList (
`itemListID` INT(1) NOT NULL AUTO_INCREMENT,
`itemID` INT(2) NOT NULL,
`anzahl` INT(9) NOT NULL,
PRIMARY KEY(itemListID),
CONSTRAINT FK_item FOREIGN KEY (itemID) REFERENCES Items(ID));

CREATE TABLE IF NOT EXISTS Inventory (
`inventoryID` INT(1) NOT NULL AUTO_INCREMENT,
`itemListID` INT(1) NOT NULL,
PRIMARY KEY(inventoryid),
CONSTRAINT FK_item FOREIGN KEY (itemListID) REFERENCES Items(ID));
