-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: parkingdatabase
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking` (
  `id` int NOT NULL AUTO_INCREMENT,
  `start` datetime NOT NULL,
  `end` datetime NOT NULL,
  `plate` varchar(45) NOT NULL,
  `userId` int NOT NULL,
  `parkinglotId` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` VALUES (7,'2024-01-23 13:00:00','2024-01-23 13:30:00','2',2,0),(8,'2024-01-30 22:29:00','2024-01-30 22:59:00','2',2,1),(9,'2024-01-30 03:29:00','2024-01-30 05:59:00','2',2,0);
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parkinglot`
--

DROP TABLE IF EXISTS `parkinglot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parkinglot` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `typeId` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parkinglot`
--

LOCK TABLES `parkinglot` WRITE;
/*!40000 ALTER TABLE `parkinglot` DISABLE KEYS */;
INSERT INTO `parkinglot` VALUES (0,'Parkplatz 1',0),(1,'Parkplatz 2',0),(2,'Parkplatz 3',0),(3,'Parkplatz 4',1),(4,'Parkplatz 5',1),(5,'Parkplatz 6',1),(6,'Parkplatz 7',2),(7,'Parkplatz 8',3),(8,'Parkplatz 9',4);
/*!40000 ALTER TABLE `parkinglot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parkinglottypes`
--

DROP TABLE IF EXISTS `parkinglottypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parkinglottypes` (
  `id` int NOT NULL,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parkinglottypes`
--

LOCK TABLES `parkinglottypes` WRITE;
/*!40000 ALTER TABLE `parkinglottypes` DISABLE KEYS */;
INSERT INTO `parkinglottypes` VALUES (0,'DEFAULT'),(1,'EPARKING'),(3,'BIOGAS'),(4,'PETROL'),(5,'DISEL');
/*!40000 ALTER TABLE `parkinglottypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sensor`
--

DROP TABLE IF EXISTS `sensor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sensor` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `status` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sensor`
--

LOCK TABLES `sensor` WRITE;
/*!40000 ALTER TABLE `sensor` DISABLE KEYS */;
INSERT INTO `sensor` VALUES (1,'Parkplatz 1',_binary '0'),(2,'Parkplatz 2',_binary '1');
/*!40000 ALTER TABLE `sensor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (2,'2','2','2','2',0,'D4735E3A265E16EEE03F59718B9B5D03019C07D8B6C51F90DA3A666EEC13AB35','DEFAULT'),(3,'superuser','superuser','superuser','superuser',0,'382132701c4733c3402706cfdd3c8fc7f41f80a88dce5428d145259a41c5f12f','ADMIN');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-29  9:35:26
