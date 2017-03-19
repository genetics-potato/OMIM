CREATE DATABASE  IF NOT EXISTS `cosmic` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `cosmic`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: cosmic
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
-- Table structure for table `gene_expression`
--

DROP TABLE IF EXISTS `gene_expression`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gene_expression` (
  `sample_ID` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `gene_name` varchar(45) DEFAULT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `regulation` varchar(45) DEFAULT NULL COMMENT 'it could be over or under depending on the scores from different platforms if they are above or below the threshold.',
  `z_score` varchar(45) DEFAULT NULL COMMENT 'z_score serves as an indicative score taken from the gene_expression from different platforms in order of preference: IlluminaHiSeq_RNASeqV2, IlluminaGA_RNASeqV2, AgilentG4502A_07_3.',
  `id_study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this gene expression data.',
  PRIMARY KEY (`sample_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='All gene expression level 3 data from the TCGA portal for the current most release in a tab separated file Please note : The platform codes currently used to produce the COSMIC gene expression values are: IlluminaGA_RNASeqV2, IlluminaHiSeq_RNASeqV2, AgilentG4502A_07_2, AgilentG4502A_07_3. For more information on the gene expression data, please see here. (CosmicCompleteGeneExpression).\nCosmicCompleteGeneExpression.tsv.gz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gene_expression`
--

LOCK TABLES `gene_expression` WRITE;
/*!40000 ALTER TABLE `gene_expression` DISABLE KEYS */;
/*!40000 ALTER TABLE `gene_expression` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'cosmic'
--

--
-- Dumping routines for database 'cosmic'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-03-19 13:30:58
