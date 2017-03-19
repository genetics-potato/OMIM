CREATE DATABASE  IF NOT EXISTS `drugbank` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `drugbank`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: drugbank
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `drug`
--

DROP TABLE IF EXISTS `drug`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug` (
  `type` int(11) NOT NULL,
  `created` varchar(45) DEFAULT NULL,
  `updated` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `primaryID` varchar(45) DEFAULT NULL,
  `other_IDs` varchar(45) DEFAULT NULL,
  `cas_number` varchar(45) DEFAULT NULL,
  `unii` varchar(45) DEFAULT NULL,
  `average_mass` varchar(45) DEFAULT NULL,
  `monoisotopic_Mass` varchar(45) DEFAULT NULL,
  `state` varchar(45) DEFAULT NULL,
  `synthesisReferences` varchar(45) DEFAULT NULL,
  `indication` varchar(45) DEFAULT NULL,
  `pharmacodynamics` varchar(45) DEFAULT NULL,
  `mechanism_of_action` varchar(45) DEFAULT NULL,
  `toxicity` varchar(45) DEFAULT NULL,
  `metabolism` varchar(45) DEFAULT NULL,
  `absorption` varchar(45) DEFAULT NULL,
  `halfLife` varchar(45) DEFAULT NULL,
  `route_of_elimination` varchar(45) DEFAULT NULL,
  `volume_of_distribution` varchar(45) DEFAULT NULL,
  `clearance` varchar(45) DEFAULT NULL,
  `fdaLabel` varchar(45) DEFAULT NULL,
  `msds` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drug`
--

LOCK TABLES `drug` WRITE;
/*!40000 ALTER TABLE `drug` DISABLE KEYS */;
/*!40000 ALTER TABLE `drug` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reference`
--

DROP TABLE IF EXISTS `reference`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reference` (
  `type` int(11) NOT NULL COMMENT '1. article\n2. textbook\n3. link',
  `id` varchar(45) DEFAULT NULL COMMENT 'article -> pubmedID\ntextbook -> isbn\nlink -> url',
  `title` varchar(45) DEFAULT NULL COMMENT 'article, textbook -> citation\nlink -> title',
  PRIMARY KEY (`type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reference`
--

LOCK TABLES `reference` WRITE;
/*!40000 ALTER TABLE `reference` DISABLE KEYS */;
/*!40000 ALTER TABLE `reference` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'drugbank'
--

--
-- Dumping routines for database 'drugbank'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-03-19 10:30:21
