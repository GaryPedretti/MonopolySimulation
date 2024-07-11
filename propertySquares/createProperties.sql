DROP TABLE IF EXISTS `monopolygamedb`.`properties`;
CREATE TABLE  `monopolygamedb`.`properties` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `name` varchar(45) NOT NULL,
  `price` int(10) unsigned NOT NULL,
  `rent` int(10) unsigned NOT NULL,
  `position` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

INSERT INTO properties (name, price, rent, position) VALUES ("Mediterranean Ave",60,2,2);
INSERT INTO properties (name, price, rent, position) VALUES ("Baltic Ave",60,4,4);
INSERT INTO properties (name, price, rent, position) VALUES ("Oriental Ave",100,6,7);
INSERT INTO properties (name, price, rent, position) VALUES ("Vermont Ave",100,6,9);
INSERT INTO properties (name, price, rent, position) VALUES ("Connecticut Ave",120,8,10);
INSERT INTO properties (name, price, rent, position) VALUES ("St. Charles Place",140,10,12);
INSERT INTO properties (name, price, rent, position) VALUES ("States Ave",140,10,14);
INSERT INTO properties (name, price, rent, position) VALUES ("Virginia Ave",160,12,15);
INSERT INTO properties (name, price, rent, position) VALUES ("St. James Place",180,14,17);
INSERT INTO properties (name, price, rent, position) VALUES ("Tennessee Ave",180,14,19);
INSERT INTO properties (name, price, rent, position) VALUES ("New York Ave",200,16,20);
INSERT INTO properties (name, price, rent, position) VALUES ("Kentucky Ave",220,18,22);
INSERT INTO properties (name, price, rent, position) VALUES ("Indiana Ave",220,18,24);
INSERT INTO properties (name, price, rent, position) VALUES ("Illinois Ave",240,20,25);
INSERT INTO properties (name, price, rent, position) VALUES ("Atlantic Ave",260,22,27);
INSERT INTO properties (name, price, rent, position) VALUES ("Ventnor Ave",260,22,28);
INSERT INTO properties (name, price, rent, position) VALUES ("Marvin Gardens",280,22,30);
INSERT INTO properties (name, price, rent, position) VALUES ("Pacific Ave",300,26,32);
INSERT INTO properties (name, price, rent, position) VALUES ("North Carolina Ave",300,26,33);
INSERT INTO properties (name, price, rent, position) VALUES ("Pennsylvania Ave",320,28,35);
INSERT INTO properties (name, price, rent, position) VALUES ("Park Place",350,35,38);
INSERT INTO properties (name, price, rent, position) VALUES ("Boardwalk",400,50,40);