CREATE DATABASE IF NOT EXISTS speicher;
USE speicher;

CREATE TABLE IF NOT EXISTS Player (
`spielerid` INT(4) NOT NULL,
`inventoryid` INT(4) NOT NULL,
PRIMARY KEY (spielerid),
CONSTRAINT FK_Inventory FOREIGN KEY (inventoryid) REFERENCES Inventory(inventoryid) ON DELETE SET NULL);

CREATE TABLE IF NOT EXISTS Items (
`id` INT(4) NOT NULL,
`name` VARCHAR(20) NOT NULL,
PRIMARY KEY (id));

CREATE TABLE IF NOT EXISTS Inventory (
`inventoryid` INT(4) NOT NULL,
PRIMARY KEY (inventoryid));

