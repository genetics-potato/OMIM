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
-- Table structure for table `ascat_acf_ploidy`
--

DROP TABLE IF EXISTS `ascat_acf_ploidy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ascat_acf_ploidy` (
  `Cancer_Type_Code` int(11) NOT NULL COMMENT 'The disease code (decode available from https://tcga-data.nci.nih.gov/datareports/codeTablesReport.htm).',
  `Sample` varchar(45) DEFAULT NULL COMMENT 'The name of the sample.',
  `Aberrant_Cell_Fraction(Purity)` varchar(45) DEFAULT NULL COMMENT 'The aberrant cell fraction (purity estimate).',
  `Ploidy` varchar(45) DEFAULT NULL COMMENT 'The ploidy of the genome.',
  PRIMARY KEY (`Cancer_Type_Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the ploidy and aberrant cell fraction (purity estimate), for TCGA samples re-analysed using ASCAT. (ascat_acf_ploidy).\nascat_acf_ploidy.tsv';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cancer_gene_census`
--

DROP TABLE IF EXISTS `cancer_gene_census`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cancer_gene_census` (
  `Gene Symbol` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Entrez GeneId` varchar(45) DEFAULT NULL,
  `Genome Location` varchar(45) DEFAULT NULL,
  `Chr Band` varchar(45) DEFAULT NULL,
  `Somatic` varchar(45) DEFAULT NULL,
  `Germline` varchar(45) DEFAULT NULL,
  `Tumour Types(Somatic)` varchar(45) DEFAULT NULL,
  `Tumour Types(Germline)` varchar(45) DEFAULT NULL,
  `Cancer Syndrome` varchar(45) DEFAULT NULL,
  `Tissue Type` varchar(45) DEFAULT NULL,
  `Molecular Genetics` varchar(45) DEFAULT NULL,
  `Role in Cancer` varchar(45) DEFAULT NULL,
  `Mutation Types` varchar(45) DEFAULT NULL,
  `Translocation Partner` varchar(45) DEFAULT NULL,
  `Other Germline Mut` varchar(45) DEFAULT NULL,
  `Other Syndrome` varchar(45) DEFAULT NULL,
  `Synonyms` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Gene Symbol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='cancer_gene_census.csv\n\nA list of all cancer census genes from the current release in a comma separated file. This file is exported from here and the format is the same. (cancer_gene_census).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `classification`
--

DROP TABLE IF EXISTS `classification`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classification` (
  `Site_Primary` int(11) NOT NULL COMMENT 'Primary tissue specified in the publication.',
  `Site_Subtype1` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
  `Site_Subtype2` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
  `Site_Subtype3` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
  `Histology` varchar(45) DEFAULT NULL COMMENT 'Primary histology specified in the publication.',
  `Hist_Subtype1` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
  `Hist_Subtype2` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
  `Hist_Subtype3` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
  `Site_Primary_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Primary tissue specified in COSMIC.',
  `Site_Subtype1_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
  `Site_Subtype2_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
  `Site_Subtype3_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
  `Histology_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Primary histology specified in COSMIC.',
  `Hist_Subtype1_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
  `Hist_Subtype2_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
  `Hist_Subtype3_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
  PRIMARY KEY (`Site_Primary`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A comma separated table of COSMIC cancer classification information. (classification).\nclassification.csv';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `complete_differential_methylation`
--

DROP TABLE IF EXISTS `complete_differential_methylation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `complete_differential_methylation` (
  `Study_ID` int(11) NOT NULL COMMENT 'The study Id for these data.',
  `Id_Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.',
  `Sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.',
  `Id_tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.',
  `Primary_Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary_Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Fragment_Id` varchar(45) DEFAULT NULL COMMENT 'The unique probe Id for a specific CpG.',
  `Genome_Version` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19',
  `Chromosome` varchar(45) DEFAULT NULL COMMENT 'The chromosome location of the probe (1-22, X or Y).',
  `Position` varchar(45) DEFAULT NULL COMMENT 'The genome location of the CpG targeted by the probe (1-based coordinates).',
  `Gene_Name` varchar(45) DEFAULT NULL COMMENT 'The gene name (if the probe falls within the coding region of a COSMIC gene) or the probe annotation as descibed by Illumina.',
  `Methylation` varchar(45) DEFAULT NULL COMMENT 'The methylation level; H (High, beta-value >0.8) or L (Low, beta-value < 0.2).',
  `Avg_Beta_Value_Normal` varchar(45) DEFAULT NULL COMMENT 'The average beta-value across the normal population. The beta-value of the tumour must differ from this value by >0.5 to be considered a variant.',
  `Beta_Value` varchar(45) DEFAULT NULL COMMENT 'The beta-value for the probe in the tumour sample. Only values >0.8 (High) or <0.2 (Low) are included.',
  `Two_Sided_P_Value` varchar(45) DEFAULT NULL COMMENT 'The two sided p-value.',
  PRIMARY KEY (`Study_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='TCGA Level 3 methylation data from the ICGC portal for the current release in a tab separated file. More information on the methylation data is available from here. (CosmicCompleteDifferentialMethylation).\nCosmicCompleteDifferentialMethylation.tsv';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_breakpoints_export`
--

DROP TABLE IF EXISTS `cosmic_breakpoints_export`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_breakpoints_export` (
  `Sample name` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Mutation Type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Breakpoint Order` varchar(45) DEFAULT NULL COMMENT 'For variants involving multiple breakpoints, the predicted order along chromosome(s).Otherwise ''0''.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
  `Chrom From` varchar(45) DEFAULT NULL COMMENT 'The chromosome where the first variant/breakpoint occurs.',
  `Location From min` varchar(45) DEFAULT NULL COMMENT 'The first position in breakpoint range.',
  `Location From max` varchar(45) DEFAULT NULL COMMENT 'The last position in breakpoint range.',
  `Strand From` varchar(45) DEFAULT NULL COMMENT 'positive or negative.',
  `Chrom To` varchar(45) DEFAULT NULL COMMENT 'The chromosome where the last variant/breakpoint occurs.',
  `Location To min` varchar(45) DEFAULT NULL COMMENT 'The first position in breakpoint range.',
  `Location To max` varchar(45) DEFAULT NULL COMMENT 'The last position in breakpoint range.',
  `Strand To` varchar(45) DEFAULT NULL COMMENT 'positive or negative.',
  `Non-templated ins seq` varchar(45) DEFAULT NULL COMMENT 'Non Templated Sequence (if any) which is inserted at the breakpoint. The sequence is not encoded.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this structural mutation.',
  PRIMARY KEY (`Sample name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicBreakpointsExport.tsv\n\nAll breakpoint data from the current release in a tab separated file (CosmicBreakpointsExport).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_complete_cna`
--

DROP TABLE IF EXISTS `cosmic_complete_cna`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_complete_cna` (
  `CNV_ID` int(11) NOT NULL COMMENT 'The unique identifier for the variant (not stable, differs between releases).',
  `Id gene` varchar(45) DEFAULT NULL COMMENT 'The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).',
  `Gene name` varchar(45) DEFAULT NULL COMMENT 'The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).',
  `Sample id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Sample Name` varchar(45) DEFAULT NULL COMMENT 'The name of the sample.',
  `Total_CN` varchar(45) DEFAULT NULL COMMENT 'The sum of the major and minor allele counts eg if ABB, total copy number = 3.',
  `Minor Allele` varchar(45) DEFAULT NULL COMMENT 'The number of copies of the least frequent allele eg if ABB, minor allele = A ( 1 copy) and major allele = B ( 2 copies).',
  `Mut Type` varchar(45) DEFAULT NULL COMMENT 'Defined as Gain or Loss. For ICGC samples; as defined in the original data. For TCGA samples reanalysed with ASCAT -\n\n        GAIN = average genome ploidy <= 2.7 AND total copy number >= 5 OR average genome ploidy > 2.7 AND total copy number >= 9\n        LOSS = average genome ploidy <= 2.7 AND total copy number = 0 OR average ge',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this copy number variation.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
  `Chromosome:G_Start..G_Stop` varchar(45) DEFAULT NULL COMMENT 'The genomic coordinates of the variation.',
  PRIMARY KEY (`CNV_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicCompleteCNA.tsv\n\nCopy Number Variants\n\nAll copy number abberations from the current release in a tab separated file. For more information on copy number data, please see here. (CosmicCompleteCNA).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_complete_targeted_screens_mutant_export`
--

DROP TABLE IF EXISTS `cosmic_complete_targeted_screens_mutant_export`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_complete_targeted_screens_mutant_export` (
  `Gene name` int(11) NOT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC symbol.',
  `Accession Number` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier of the gene.',
  `Gene CDS length` varchar(45) DEFAULT NULL COMMENT 'Length of the gene (base pair) counts.',
  `HGNC id` varchar(45) DEFAULT NULL COMMENT 'Unique HGNC identifier, if the gene is in HGNC.',
  `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Genome-wide screen` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome/exome is sequenced.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Mutation CDS` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
  `Mutation AA` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society. The description of each type can be found by following the link to Mutation Overview page.',
  `Mutation Description` varchar(45) DEFAULT NULL COMMENT 'Type of mutation (substitution, deletion, insertion, complex, fusion, unknown etc.)',
  `Mutation zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `LOH` varchar(45) DEFAULT NULL COMMENT 'LOH Information on whether the gene was reported to have loss of heterozygosity in the sample: yes, no or unknown.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19   ',
  `Mutation genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnates of the mutation.',
  `Mutation strand` varchar(45) DEFAULT NULL COMMENT 'Positive or negative.',
  `SNP` varchar(45) DEFAULT NULL COMMENT 'All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
  `Resistance Mutation` varchar(45) DEFAULT NULL COMMENT 'The mutation confers drug resistance (see CosmicResistanceMutations.tsv.gz for gene/drug details).',
  `FATHMM prediction` varchar(45) DEFAULT NULL COMMENT 'More information about FATHMM (Functional Analysis through Hidden Markov Models) is available from here. FATHMM descriptors -\n\n        Pathogenic = Defined as Cancer or Damaging.\n        Neutral = Defined as Passenger or Tolerated.  ',
  `FATHMM Score` varchar(45) DEFAULT NULL COMMENT 'The scores are in the form of pvalues ranging from 0 to 1. Pvalues greater than 0.5 are pathogenic while less than 0.5 are benign. Pvalues close to 0 or 1 are the high confidence results which are more accurate. The results are annotated as 10 feature groups (separately for coding and non coding variants) details of which can be found in the original FATHMM-MKL paper.',
  `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
  `Sample source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Tumour origin` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Age` varchar(45) DEFAULT NULL COMMENT 'Age of the individual (if this information is provided with the publications).',
  PRIMARY KEY (`Gene name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicCompleteTargetedScreensMutantExport.tsv\n\nCOSMIC Complete Mutation Data (Targeted Screens)\n\nA tab separated table of the complete curated COSMIC dataset (targeted screens) from the current release. It includes all coding point mutations, and the negative data set. (CosmicCompleteTargetedScreensMutantExport).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_fusion_export`
--

DROP TABLE IF EXISTS `cosmic_fusion_export`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_fusion_export` (
  `Sample id` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Fusion Id` varchar(45) DEFAULT NULL COMMENT 'Unique fusion mutation identifier.',
  `Translocation Name` varchar(45) DEFAULT NULL COMMENT 'Syntax describing the portions of mRNA present (in HGVS ''r.'' format) from each gene (allows representation of UTR sequences).',
  `Fusion type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this fusion mutation.',
  PRIMARY KEY (`Sample id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicFusionExport.tsv\n\nComplete Fusion Export\n\nAll gene fusion mutation data from the current release in a tab separated file. (CosmicFusionExport).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_genome_screens_mutant_export`
--

DROP TABLE IF EXISTS `cosmic_genome_screens_mutant_export`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_genome_screens_mutant_export` (
  `Gene name` int(11) NOT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `Accession Number` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier of the gene.',
  `Gene CDS length` varchar(45) DEFAULT NULL COMMENT 'Length of the gene (base pair) counts.',
  `HGNC id` varchar(45) DEFAULT NULL COMMENT 'Unique HGNC identifier, if the gene is in HGNC.',
  `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Genome-wide screen` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome/exome is sequenced.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Mutation CDS` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
  `Mutation AA` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society. The description of each type can be found by following the link to Mutation Overview page.',
  `Mutation Description` varchar(45) DEFAULT NULL COMMENT 'Type of mutation (substitution, deletion, insertion, complex, fusion, unknown etc.)',
  `Mutation zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `LOH` varchar(45) DEFAULT NULL COMMENT 'LOH Information on whether the gene was reported to have loss of heterozygosity in the sample: yes, no or unknown.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19 ',
  `Mutation genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnates of the mutation.',
  `Mutation strand` varchar(45) DEFAULT NULL COMMENT 'positive or negative.',
  `SNP` varchar(45) DEFAULT NULL COMMENT 'All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
  `FATHMM prediction` varchar(45) DEFAULT NULL COMMENT 'More information about FATHMM (Functional Analysis through Hidden Markov Models) is available from here. FATHMM descriptors -\n\n        Pathogenic = Defined as Cancer or Damaging.\n        Neutral = Defined as Passenger or Tolerated. ',
  `FATHMM Score` varchar(45) DEFAULT NULL COMMENT 'The scores are in the form of pvalues ranging from 0 to 1. Pvalues greater than 0.5 are pathogenic while less than 0.5 are benign. Pvalues close to 0 or 1 are the high confidence results which are more accurate. The results are annotated as 10 feature groups (separately for coding and non coding variants) details of which can be found in the original FATHMM-MKL paper.',
  `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
  `Sample source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Tumour origin` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Age` varchar(45) DEFAULT NULL COMMENT 'Age of the individual (if this information is provided with the publications).',
  PRIMARY KEY (`Gene name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicGenomeScreensMutantExport.tsv\n\nA tab separated table of coding point mutations from genome wide screens (including whole exome sequencing). (CosmicGenomeScreensMutantExport).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_mutant_export`
--

DROP TABLE IF EXISTS `cosmic_mutant_export`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_mutant_export` (
  `Gene name` int(11) NOT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `Accession Number` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier of the gene.',
  `Gene CDS length` varchar(45) DEFAULT NULL COMMENT 'Length of the gene (base pair) counts.',
  `HGNC id` varchar(45) DEFAULT NULL COMMENT 'if gene is in HGNC, this id helps linking it to HGNC.',
  `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Genome-wide screen` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome/exome is sequenced.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Mutation CDS` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
  `Mutation AA` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society. The description of each type can be found by following the link to Mutation Overview page.',
  `Mutation Description` varchar(45) DEFAULT NULL COMMENT 'Type of mutation (substitution, deletion, insertion, complex, fusion, unknown etc.)',
  `Mutation zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `LOH` varchar(45) DEFAULT NULL COMMENT 'LOH Information on whether the gene was reported to have loss of heterozygosity in the sample: yes, no or unknown.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19   ',
  `Mutation genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnates of the mutation.',
  `Mutation strand` varchar(45) DEFAULT NULL COMMENT 'postive or negative.',
  `SNP` varchar(45) DEFAULT NULL COMMENT 'All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
  `Resistance Mutation` varchar(45) DEFAULT NULL COMMENT 'mutation confers drug resistance (see CosmicResistanceMutations.tsv.gz for gene/drug details).',
  `FATHMM prediction` varchar(45) DEFAULT NULL COMMENT 'More information about FATHMM (Functional Analysis through Hidden Markov Models) is available from here. FATHMM descriptors -\n\n        Pathogenic = Defined as Cancer or Damaging.\n        Neutral = Defined as Passenger or Tolerated.  ',
  `FATHMM Score` varchar(45) DEFAULT NULL COMMENT 'The scores are in the form of pvalues ranging from 0 to 1. Pvalues greater than 0.5 are pathogenic while less than 0.5 are benign. Pvalues close to 0 or 1 are the high confidence results which are more accurate. The results are annotated as 10 feature groups (separately for coding and non coding variants) details of which can be found in the original FATHMM-MKL paper.',
  `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.     ',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
  `Sample source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Tumour origin` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Age` varchar(45) DEFAULT NULL COMMENT 'Age of the sample (if this information is provided with the publications).',
  PRIMARY KEY (`Gene name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicMutantExport.tsv\n\nCOSMIC Mutation Data\n\nA tab separated table of all COSMIC coding point mutations from targeted and genome wide screens from the current release. (CosmicMutantExport).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_mutant_export_census`
--

DROP TABLE IF EXISTS `cosmic_mutant_export_census`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_mutant_export_census` (
  `Gene name` int(11) NOT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `Accession Number` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier of the gene.',
  `Gene CDS length` varchar(45) DEFAULT NULL COMMENT 'Length of the gene (base pair) counts.',
  `HGNC id` varchar(45) DEFAULT NULL COMMENT 'if gene is in HGNC, this id helps linking it to HGNC.',
  `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Genome-wide screen` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome/exome is sequenced.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Mutation CDS` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
  `Mutation AA` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society. The description of each type can be found by following the link to Mutation Overview page.',
  `Mutation Description` varchar(45) DEFAULT NULL COMMENT 'Type of mutation (substitution, deletion, insertion, complex, fusion etc.)',
  `Mutation zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `LOH` varchar(45) DEFAULT NULL COMMENT 'LOH Information on whether the gene was reported to have loss of heterozygosity in the sample: yes, no or unknown.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19',
  `Mutation genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnates of the mutation.',
  `Mutation strand` varchar(45) DEFAULT NULL COMMENT 'positive or negative.',
  `SNP` varchar(45) DEFAULT NULL COMMENT 'All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
  `Resistance Mutation` varchar(45) DEFAULT NULL COMMENT 'mutation confers drug resistance (see CosmicResistanceMutations.tsv.gz for gene/drug details).',
  `FATHMM prediction` varchar(45) DEFAULT NULL COMMENT 'More information about FATHMM (Functional Analysis through Hidden Markov Models) is available from here. FATHMM descriptors -\n\n        Pathogenic = Defined as Cancer or Damaging.\n        Neutral = Defined as Passenger or Tolerated.     ',
  `FATHMM score` varchar(45) DEFAULT NULL COMMENT 'The FATHMM-MKL functional score is a p-value, ranging from 0 to 1. Scores above 0.5 are deleterious, but in order to highlight the most significant data in COSMIC, only scores >= 0.7 are classified as ''Pathogenic''. Mutations are classed as ''Neutral'' if the score is <= 0.5.',
  `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.  ',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
  `Sample source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Tumour origin` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Age` varchar(45) DEFAULT NULL COMMENT 'Age of the sample (if this information is provided with the publications).',
  PRIMARY KEY (`Gene name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicMutantExportCensus.tsv\n\nAll Mutations in Census Genes\n\nAll coding mutations in genes listed in the Cancer Gene Census in a tab separated file. here (CosmicMutantExportCensus).';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_ncv`
--

DROP TABLE IF EXISTS `cosmic_ncv`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_ncv` (
  `Sample name` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id NCV` varchar(45) DEFAULT NULL COMMENT 'unique non-coding variant identifier.',
  `Zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
  `Genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnate of the mutation.',
  `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.   ',
  `WT SEQ` varchar(45) DEFAULT NULL COMMENT 'wild type sequence.',
  `MUT SEQ` varchar(45) DEFAULT NULL COMMENT 'Mutated sequence.',
  `SNP` varchar(45) DEFAULT NULL COMMENT ' All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
  `FATHMM_MKL_NON_CODING_SCORE` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL non-coding score. A p-value ranging from 0 to 1 where >= 0.7 is functionally significant.',
  `FATHMM_MKL_NON_CODING_GROUPS` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL group classification. More details from here.',
  `FATHMM_MKL_CODING_SCORE` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL coding score (p-value ranging from 0 to 1).',
  `FATHMM_MKL_CODING_GROUPS` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL group classification (coding). More details from here.',
  `Whole Genome Reseq` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome is sequenced.',
  `Whole_Exome` varchar(45) DEFAULT NULL COMMENT 'if the enitre exome is sequenced.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this non coding mutation.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  PRIMARY KEY (`Sample name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicNCV.tsv\n\nNon coding variants\n\nA tab separated file of all non-coding mutations from the current release. (CosmicNCV).\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cosmic_struct_export`
--

DROP TABLE IF EXISTS `cosmic_struct_export`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cosmic_struct_export` (
  `Sample name` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Mutation Type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19 ',
  `Description` varchar(45) DEFAULT NULL COMMENT 'A syntax which describes the structural variant, based on HGVS recommendations.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  `ID_STUDY` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this structural mutation.',
  PRIMARY KEY (`Sample name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicStructExport.tsv\n\nStructural Variants\n\nAll structural variants from the current release in a tab separated file. (CosmicStructExport).';
/*!40101 SET character_set_client = @saved_cs_client */;

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
  `z_score` double DEFAULT NULL COMMENT 'z_score serves as an indicative score taken from the gene_expression from different platforms in order of preference: IlluminaHiSeq_RNASeqV2, IlluminaGA_RNASeqV2, AgilentG4502A_07_3.',
  `id_study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this gene expression data.',
  PRIMARY KEY (`sample_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='All gene expression level 3 data from the TCGA portal for the current most release in a tab separated file Please note : The platform codes currently used to produce the COSMIC gene expression values are: IlluminaGA_RNASeqV2, IlluminaHiSeq_RNASeqV2, AgilentG4502A_07_2, AgilentG4502A_07_3. For more information on the gene expression data, please see here. (CosmicCompleteGeneExpression).\nCosmicCompleteGeneExpression.tsv.gz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `hgnc`
--

DROP TABLE IF EXISTS `hgnc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hgnc` (
  `cosmic_ID` int(11) NOT NULL COMMENT 'COSMIC Gene ID (COSG*).',
  `cosmic_gene_name` varchar(45) DEFAULT NULL COMMENT 'Gene name used in COSMIC.',
  `entrez_ID` varchar(45) DEFAULT NULL COMMENT 'Entrez ID mapping.',
  `HGNC_ID` varchar(45) DEFAULT NULL COMMENT 'HGNC mapping.',
  `mutated` varchar(45) DEFAULT NULL COMMENT 'Does the gene have coding mutations y/n.',
  `cancer_census` varchar(45) DEFAULT NULL COMMENT 'Is the gene in the Cancer gene census y/n.',
  `expert_curated` varchar(45) DEFAULT NULL COMMENT 'Has the gene been manually curated by the team of expert curators y/n.',
  PRIMARY KEY (`cosmic_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file showing the relationship between the Cancer Gene Census, COSMIC ID, Gene Name, HGNC ID and Entrez ID. (CosmicHGNC).\nCosmicHGNC.tsv';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `resistance_mutations`
--

DROP TABLE IF EXISTS `resistance_mutations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `resistance_mutations` (
  `Sample_name` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample_id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Gene_Name` varchar(45) DEFAULT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `Transcript` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier (accession number) of the gene.',
  `Census_Gene` varchar(45) DEFAULT NULL COMMENT 'Is the gene in the Cancer Gene Census (Yes, or No).',
  `Drug_Name` varchar(45) DEFAULT NULL COMMENT ' The name of the drug which the mutation confers resistance to.',
  `ID_Mutation` varchar(45) DEFAULT NULL COMMENT 'The unique mutation identifier (COSM).',
  `AA_Mutation` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society.',
  `CDS_Mutation` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
  `Primary_Tissue` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Tissue_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Tissue_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Pubmed_ID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
  `CGP_Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
  `Somatic_Status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper. ',
  `Sample_Source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `Genome_Coordinates_GRCh37_38` varchar(45) DEFAULT NULL COMMENT 'The genome location of the mutation (chr:start..end), on the specified genome version.',
  PRIMARY KEY (`Sample_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the details of all mutations in COSMIC which are known to confer drug resistance. (CosmicResistanceMutations).\nCosmicResistanceMutations.tsv';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `sample_features`
--

DROP TABLE IF EXISTS `sample_features`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sample_features` (
  `Sample_id` int(11) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Id_tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Id_Individual` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Primary_Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary_Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Therapy_Relationship` varchar(45) DEFAULT NULL COMMENT 'Relates the time-point of tissue sampling to the drug therapy used to treat the tumour.',
  `Sample_Differentiator` varchar(45) DEFAULT NULL COMMENT 'Gives additional information if more than one sample (e.g. carcinomatous and sarcomatous components) from a tumour has been screened for mutations or if samples from a tumour were taken at different time points.',
  `Mutation_Allele_Specification` varchar(45) DEFAULT NULL COMMENT 'Where a publication has information on more than one mutation for one gene in a sample and reports whether or not the mutations occurred on the same or different chromosomes.',
  `Msi` varchar(45) DEFAULT NULL COMMENT 'If microsatellite instability data is given in the publication per sample then High, Low, Stable/Low, MSI or Stable is reported in COSMIC. Unknown is the default.',
  `Average_Ploidy` varchar(45) DEFAULT NULL COMMENT 'The average ploidy of the sample, calculated from copy number data (where available).',
  `Whole_Genome_Screen` varchar(45) DEFAULT NULL COMMENT '''y'' if the sample was whole genome screened.',
  `Whole_Exome_Screen` varchar(45) DEFAULT NULL COMMENT '''y'' if the sample was whole exome sequenced.',
  `Sample_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional sample information e.g. % mutant allele burden.',
  `Drug_Response` varchar(45) DEFAULT NULL COMMENT 'Clinical and in vitro responses to drugs (particularly targeted drugs). Phrasing based on RECIST guidelines. Note that in COSMIC, SD (stable disease) and PD (progressive disease) = clinical primary non response.',
  `Grade` varchar(45) DEFAULT NULL COMMENT 'Grade of tumour. The phrase ''Some Grade data are given in publication'' is used when publication reports grade data or when data hasn''t been given per sample. More detailed data follow commonly used grading systems in tumours.',
  `Age_at_tumour_recurrence` varchar(45) DEFAULT NULL COMMENT 'Where both primary and recurrent tumour samples from an individual have been screened for mutations and the age (in years) of the patient at the time of the recurrence is different to that at diagnosis.',
  `Stage` varchar(45) DEFAULT NULL COMMENT 'Stage of tumour. The phrase ''Some Stage data are given in publication'' is used when publication reports stage data or when data hasn''t been given per sample. More detailed data follow commonly used staging systems in tumours.',
  `Cytogenetics` varchar(45) DEFAULT NULL COMMENT 'Karyotype of the tumour.',
  `Metastatic_Site` varchar(45) DEFAULT NULL COMMENT 'Tissue site of any metastases identified in an individual.',
  `Tumour_Source` varchar(45) DEFAULT NULL COMMENT 'Source of tumour tissue sample e.g. primary, metastasis.',
  `Tumour_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional tumour information e.g. metachronous tumour.',
  `Age` varchar(45) DEFAULT NULL COMMENT 'Age (in years) of individual at diagnosis.',
  `Ethnicity` varchar(45) DEFAULT NULL COMMENT 'Ethnicity (e.g. Caucasian) of individual.',
  `Environmental_Variables` varchar(45) DEFAULT NULL COMMENT 'Environmental variables to which an individual has been exposed (e.g. viral exposure, smoking status).',
  `Germline_Mutation` varchar(45) DEFAULT NULL COMMENT 'Gene name/mutation if a germline mutation as well as a somatic mutation has been detected in the same gene in the same tumour sample.',
  `Therapy` varchar(45) DEFAULT NULL COMMENT 'Any significant treatment an individual has received prior to mutation screening.',
  `Family` varchar(45) DEFAULT NULL COMMENT 'Any familial cancer history for an individual or familial relationships of individuals screened for mutations in the same publication.',
  `Normal_tissue_tested` varchar(45) DEFAULT NULL COMMENT 'If normal tissue from the same individual has been screened for mutations.',
  `Gender` varchar(45) DEFAULT NULL COMMENT 'Sex of individual.',
  `Individual_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional individual information (e.g. age group, hereditary syndromes).',
  `NCI_code` varchar(45) DEFAULT NULL COMMENT 'NCI thesaurus code for tumour histological classification.',
  PRIMARY KEY (`Sample_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='ll the features related to a sample from the current release in a tab separated file. (CosmicSample).\nCosmicSample.tsv';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `transcripts`
--

DROP TABLE IF EXISTS `transcripts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transcripts` (
  `Gene_ID` int(11) NOT NULL COMMENT 'The unique ID of the gene.',
  `gene_name` varchar(45) DEFAULT NULL COMMENT 'The name of the gene.',
  `transcript_ID` varchar(45) DEFAULT NULL COMMENT 'The accession of the transcript.',
  PRIMARY KEY (`Gene_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the gene name and transcript accession for each gene ID. (CosmicTranscripts).\nCosmicTranscripts.tsv';
/*!40101 SET character_set_client = @saved_cs_client */;

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

-- Dump completed on 2017-03-28 21:34:57
