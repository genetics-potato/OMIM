CREATE DATABASE  IF NOT EXISTS `drugbank` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `drugbank`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: drugbank
-- ------------------------------------------------------
-- Server version	5.7.17-log

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
  `primaryID` varchar(45) NOT NULL COMMENT 'drugbank-id primary',
  `other_IDs` varchar(45) DEFAULT NULL COMMENT 'drugbank-id',
  `type` char(45) DEFAULT NULL,
  `created` varchar(45) DEFAULT NULL,
  `updated` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
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
  `references` varchar(45) DEFAULT NULL,
  `pdb_entry` varchar(45) DEFAULT NULL COMMENT 'pdb database entry list, using ; character as delimiter',
  PRIMARY KEY (`primaryID`),
  UNIQUE KEY `primaryID_UNIQUE` (`primaryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_atc_code`
--

DROP TABLE IF EXISTS `drug_atc_code`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_atc_code` (
  `drug` varchar(45) NOT NULL,
  `code` varchar(45) DEFAULT NULL,
  `level1_code` varchar(45) DEFAULT NULL,
  `level1_description` varchar(45) DEFAULT NULL,
  `level2_code` varchar(45) DEFAULT NULL,
  `level2_description` varchar(45) DEFAULT NULL,
  `level3_code` varchar(45) DEFAULT NULL,
  `level3_description` varchar(45) DEFAULT NULL,
  `level4_code` varchar(45) DEFAULT NULL,
  `level4_description` varchar(45) DEFAULT NULL,
  `level5_code` varchar(45) DEFAULT NULL,
  `level5_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_calculated_properties`
--

DROP TABLE IF EXISTS `drug_calculated_properties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_calculated_properties` (
  `drug` varchar(45) NOT NULL,
  `kind` varchar(45) DEFAULT NULL,
  `value` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_category`
--

DROP TABLE IF EXISTS `drug_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_category` (
  `drug` varchar(45) NOT NULL,
  `category` varchar(45) DEFAULT NULL,
  `mesh_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_classification`
--

DROP TABLE IF EXISTS `drug_classification`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_classification` (
  `drug` varchar(45) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `direct_parent` varchar(45) DEFAULT NULL,
  `kingdom` varchar(45) DEFAULT NULL,
  `superclass` varchar(45) DEFAULT NULL,
  `class` varchar(45) DEFAULT NULL,
  `subclass` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_dosage`
--

DROP TABLE IF EXISTS `drug_dosage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_dosage` (
  `drug` varchar(45) NOT NULL,
  `form` varchar(45) DEFAULT NULL,
  `route` varchar(45) DEFAULT NULL,
  `strength` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_experimental_properties`
--

DROP TABLE IF EXISTS `drug_experimental_properties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_experimental_properties` (
  `drug` varchar(45) NOT NULL,
  `kind` varchar(45) DEFAULT NULL,
  `value` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_external_identifiers`
--

DROP TABLE IF EXISTS `drug_external_identifiers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_external_identifiers` (
  `drug` varchar(45) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `ID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_external_links`
--

DROP TABLE IF EXISTS `drug_external_links`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_external_links` (
  `drug` varchar(45) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `url` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_interactions`
--

DROP TABLE IF EXISTS `drug_interactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_interactions` (
  `drug` varchar(45) NOT NULL,
  `partner` varchar(45) DEFAULT NULL,
  `partner_name` varchar(45) DEFAULT NULL,
  `partner_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_manufacturers`
--

DROP TABLE IF EXISTS `drug_manufacturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_manufacturers` (
  `drug` varchar(45) NOT NULL,
  `generic` varchar(45) DEFAULT NULL,
  `url` varchar(45) DEFAULT NULL,
  `manufacturer` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_mixtures`
--

DROP TABLE IF EXISTS `drug_mixtures`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_mixtures` (
  `drug` varchar(45) NOT NULL,
  `mixture_name` varchar(45) DEFAULT NULL,
  `ingredients` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_packagers`
--

DROP TABLE IF EXISTS `drug_packagers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_packagers` (
  `drug` varchar(45) NOT NULL,
  `packager_name` varchar(45) DEFAULT NULL,
  `url` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_patents`
--

DROP TABLE IF EXISTS `drug_patents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_patents` (
  `drug` varchar(45) NOT NULL,
  `number` varchar(45) DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `approved` varchar(45) DEFAULT NULL,
  `expires` varchar(45) DEFAULT NULL,
  `pediatric_extension` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_pathways`
--

DROP TABLE IF EXISTS `drug_pathways`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_pathways` (
  `drug` varchar(45) NOT NULL,
  `smpdb_id` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `category` varchar(45) DEFAULT NULL,
  `enzymes` varchar(45) DEFAULT NULL COMMENT 'using ; character as delimiter',
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_price`
--

DROP TABLE IF EXISTS `drug_price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_price` (
  `drug` varchar(45) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `cost` varchar(45) DEFAULT NULL,
  `unit` varchar(45) DEFAULT NULL,
  `currency` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_products`
--

DROP TABLE IF EXISTS `drug_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_products` (
  `drug` varchar(45) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `labeller` varchar(45) DEFAULT NULL,
  `ndc_id` varchar(45) DEFAULT NULL,
  `ndc_product_code` varchar(45) DEFAULT NULL,
  `dpd_id` varchar(45) DEFAULT NULL,
  `start_marketing_on` varchar(45) DEFAULT NULL,
  `ended_marketting_on` varchar(45) DEFAULT NULL,
  `dosage_form` varchar(45) DEFAULT NULL,
  `strength` varchar(45) DEFAULT NULL,
  `route` varchar(45) DEFAULT NULL,
  `fda_application_number` varchar(45) DEFAULT NULL,
  `generic` varchar(45) DEFAULT NULL,
  `over_the_counter` varchar(45) DEFAULT NULL,
  `approved` varchar(45) DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_reactions`
--

DROP TABLE IF EXISTS `drug_reactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_reactions` (
  `drug` varchar(45) NOT NULL,
  `sequence` varchar(45) DEFAULT NULL,
  `left1` varchar(45) DEFAULT NULL,
  `left2` varchar(45) DEFAULT NULL,
  `left3` varchar(45) DEFAULT NULL,
  `left4` varchar(45) DEFAULT NULL,
  `left5` varchar(45) DEFAULT NULL,
  `right1` varchar(45) DEFAULT NULL,
  `right2` varchar(45) DEFAULT NULL,
  `right3` varchar(45) DEFAULT NULL,
  `right4` varchar(45) DEFAULT NULL,
  `right5` varchar(45) DEFAULT NULL,
  `enzymes` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_snp_effects`
--

DROP TABLE IF EXISTS `drug_snp_effects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_snp_effects` (
  `drug` varchar(45) NOT NULL,
  `protein_name` varchar(45) DEFAULT NULL,
  `gene_symbol` varchar(45) DEFAULT NULL,
  `uniprot` varchar(45) DEFAULT NULL,
  `rs_ID` varchar(45) DEFAULT NULL,
  `defining_change` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `allele` varchar(45) DEFAULT NULL,
  `pubmed_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_synonym`
--

DROP TABLE IF EXISTS `drug_synonym`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_synonym` (
  `drug` varchar(45) NOT NULL,
  `synonym` varchar(45) DEFAULT NULL,
  `language` varchar(45) DEFAULT NULL,
  `coder` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drug_targets`
--

DROP TABLE IF EXISTS `drug_targets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug_targets` (
  `drug` varchar(45) NOT NULL,
  `target_id` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `organism` varchar(45) DEFAULT NULL,
  `actions` varchar(45) DEFAULT NULL,
  `known_action` varchar(45) DEFAULT NULL,
  `polypeptide` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pathway_drugs`
--

DROP TABLE IF EXISTS `pathway_drugs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pathway_drugs` (
  `pathway_smpdb_id` varchar(45) NOT NULL,
  `drug` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pathway_smpdb_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `polypeptide_external_ids`
--

DROP TABLE IF EXISTS `polypeptide_external_ids`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `polypeptide_external_ids` (
  `polypeptide` varchar(45) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`polypeptide`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `polypeptide_sequences`
--

DROP TABLE IF EXISTS `polypeptide_sequences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `polypeptide_sequences` (
  `polypeptide` varchar(45) NOT NULL,
  `aa` varchar(45) DEFAULT NULL,
  `nt` varchar(45) DEFAULT NULL,
  `pfam` varchar(45) DEFAULT NULL COMMENT 'pfam ID list, using ; character as the delimiter',
  `go_bp` varchar(45) DEFAULT NULL,
  `go_cc` varchar(45) DEFAULT NULL,
  `go_mf` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`polypeptide`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='polypeptide sequence data and function annotations';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `polypeptide_synonyms`
--

DROP TABLE IF EXISTS `polypeptide_synonyms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `polypeptide_synonyms` (
  `polypeptide` varchar(45) NOT NULL,
  `synonym1` varchar(45) DEFAULT NULL,
  `synonym2` varchar(45) DEFAULT NULL,
  `synonym3` varchar(45) DEFAULT NULL,
  `synonym4` varchar(45) DEFAULT NULL,
  `synonym5` varchar(45) DEFAULT NULL,
  `synonym6` varchar(45) DEFAULT NULL,
  `synonym7` varchar(45) DEFAULT NULL,
  `synonym8` varchar(45) DEFAULT NULL,
  `synonym9` varchar(45) DEFAULT NULL,
  `synonym10` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`polypeptide`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `reference`
--

DROP TABLE IF EXISTS `reference`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reference` (
  `type` varchar(45) NOT NULL COMMENT '1. article\n2. textbook\n3. link',
  `id` varchar(45) DEFAULT NULL COMMENT 'article -> pubmedID\ntextbook -> isbn\nlink -> url',
  `title` varchar(45) DEFAULT NULL COMMENT 'article, textbook -> citation\nlink -> title',
  PRIMARY KEY (`type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `target_polypeptides`
--

DROP TABLE IF EXISTS `target_polypeptides`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `target_polypeptides` (
  `target_id` varchar(45) NOT NULL,
  `drug_id` varchar(45) DEFAULT NULL,
  `polypeptide_id` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `general_function` varchar(45) DEFAULT NULL,
  `specific_function` varchar(45) DEFAULT NULL,
  `gene_name` varchar(45) DEFAULT NULL,
  `locus` varchar(45) DEFAULT NULL,
  `cellular_location` varchar(45) DEFAULT NULL,
  `transmembrane_regions` varchar(45) DEFAULT NULL,
  `signal_regions` varchar(45) DEFAULT NULL,
  `theoretical_PI` varchar(45) DEFAULT NULL,
  `molecular_weight` varchar(45) DEFAULT NULL,
  `chromosome_location` varchar(45) DEFAULT NULL,
  `organism` varchar(45) DEFAULT NULL,
  `organism_ncbi_taxonomy_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`target_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

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

-- Dump completed on 2017-03-29 14:13:57
