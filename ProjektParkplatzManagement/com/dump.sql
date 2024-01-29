CREATE TABLE `booking` (
  `id` int NOT NULL AUTO_INCREMENT,
  `start` datetime NOT NULL,
  `end` datetime NOT NULL,
  `plate` varchar(45) NOT NULL,
  `userId` int NOT NULL,
  `parkinglotId` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

INSERT INTO `booking` VALUES 
(7,'2024-01-23 13:00:00','2024-01-23 13:30:00','2',2,0),
(8,'2024-01-30 22:29:00','2024-01-30 22:59:00','2',2,1),
(9,'2024-01-30 03:29:00','2024-01-30 05:59:00','2',2,0);

CREATE TABLE `parkinglot` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `typeId` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `parkinglot` VALUES 
(0,'Parkplatz 1',0),
(1,'Parkplatz 2',0),
(2,'Parkplatz 3',0),
(3,'Parkplatz 4',1),
(4,'Parkplatz 5',1),
(5,'Parkplatz 6',1),
(6,'Parkplatz 7',2),
(7,'Parkplatz 8',3),
(8,'Parkplatz 9',4);

CREATE TABLE `parkinglottypes` (
  `id` int NOT NULL,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `parkinglottypes` VALUES 
(0,'DEFAULT'),
(1,'EPARKING'),
(3,'BIOGAS'),
(4,'PETROL'),
(5,'DISEL');

CREATE TABLE `sensor` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `status` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `sensor` VALUES 
(1,'Parkplatz 1',_binary '0'),
(2,'Parkplatz 2',_binary '1');

CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `prename` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `plate` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `penalties` int NOT NULL,
  `password` varchar(255) NOT NULL,
  `permission` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

INSERT INTO `user` VALUES 
(2,'2','2','2','2',0,'D4735E3A265E16EEE03F59718B9B5D03019C07D8B6C51F90DA3A666EEC13AB35','DEFAULT'),
(3,'superuser','superuser','superuser','superuser',0,'382132701c4733c3402706cfdd3c8fc7f41f80a88dce5428d145259a41c5f12f','ADMIN');
