CREATE DATABASE IF NOT EXISTS speicher_DB;
USE speicher_DB;

CREATE TABLE IF NOT EXISTS Player (
`spielerID` INT(4) NOT NULL AUTO_INCREMENT,
`xkoord` FLOAT(8) NOT NULL,
`ykoord` FLOAT(8) NOT NULL,
#z
PRIMARY KEY (spielerID);

CREATE TABLE IF NOT EXISTS Items (
`ID` INT(4) NOT NULL AUTO_INCREMENT,
`name` VARCHAR(20) NOT NULL,
#Values of Items
PRIMARY KEY (id));

CREATE TABLE IF NOT EXISTS Inventory (
`inventoryID` INT(4) NOT NULL AUTO_INCREMENT,
`itemID` INT(4) NOT NULL,
#items nua zua listn hinzu ned zum inventar
PRIMARY KEY (inventoryid),
CONSTRAINT FK_item FOREIGN KEY (itemID) REFERENCES Items(ID));