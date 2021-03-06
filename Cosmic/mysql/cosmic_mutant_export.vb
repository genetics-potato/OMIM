REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/10/24 11:04:05


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' CosmicMutantExport.tsv\n\nCOSMIC Mutation Data\n\nA tab separated table of all COSMIC coding point mutations from targeted and genome wide screens from the current release. (CosmicMutantExport).
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cosmic_mutant_export`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cosmic_mutant_export` (
'''   `Gene name` varchar(45) NOT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
'''   `Accession Number` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier of the gene.',
'''   `Gene CDS length` varchar(45) DEFAULT NULL COMMENT 'Length of the gene (base pair) counts.',
'''   `HGNC id` varchar(45) DEFAULT NULL COMMENT 'if gene is in HGNC, this id helps linking it to HGNC.',
'''   `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Id Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Genome-wide screen` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome/exome is sequenced.',
'''   `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
'''   `Mutation CDS` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
'''   `Mutation AA` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society. The description of each type can be found by following the link to Mutation Overview page.',
'''   `Mutation Description` varchar(45) DEFAULT NULL COMMENT 'Type of mutation (substitution, deletion, insertion, complex, fusion, unknown etc.)',
'''   `Mutation zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
'''   `LOH` varchar(45) DEFAULT NULL COMMENT 'LOH Information on whether the gene was reported to have loss of heterozygosity in the sample: yes, no or unknown.',
'''   `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19   ',
'''   `Mutation genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnates of the mutation.',
'''   `Mutation strand` varchar(45) DEFAULT NULL COMMENT 'postive or negative.',
'''   `SNP` varchar(45) DEFAULT NULL COMMENT 'All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
'''   `Resistance Mutation` varchar(45) DEFAULT NULL COMMENT 'mutation confers drug resistance (see CosmicResistanceMutations.tsv.gz for gene/drug details).',
'''   `FATHMM prediction` varchar(45) DEFAULT NULL COMMENT 'More information about FATHMM (Functional Analysis through Hidden Markov Models) is available from here. FATHMM descriptors -\n\n        Pathogenic = Defined as Cancer or Damaging.\n        Neutral = Defined as Passenger or Tolerated.  ',
'''   `FATHMM Score` varchar(45) DEFAULT NULL COMMENT 'The scores are in the form of pvalues ranging from 0 to 1. Pvalues greater than 0.5 are pathogenic while less than 0.5 are benign. Pvalues close to 0 or 1 are the high confidence results which are more accurate. The results are annotated as 10 feature groups (separately for coding and non coding variants) details of which can be found in the original FATHMM-MKL paper.',
'''   `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.     ',
'''   `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
'''   `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
'''   `Sample source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
'''   `Tumour origin` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
'''   `Age` varchar(45) DEFAULT NULL COMMENT 'Age of the sample (if this information is provided with the publications).',
'''   PRIMARY KEY (`Gene name`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicMutantExport.tsv\n\nCOSMIC Mutation Data\n\nA tab separated table of all COSMIC coding point mutations from targeted and genome wide screens from the current release. (CosmicMutantExport).';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cosmic_mutant_export", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cosmic_mutant_export` (
  `Gene name` varchar(45) NOT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `Accession Number` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier of the gene.',
  `Gene CDS length` varchar(45) DEFAULT NULL COMMENT 'Length of the gene (base pair) counts.',
  `HGNC id` varchar(45) DEFAULT NULL COMMENT 'if gene is in HGNC, this id helps linking it to HGNC.',
  `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicMutantExport.tsv\n\nCOSMIC Mutation Data\n\nA tab separated table of all COSMIC coding point mutations from targeted and genome wide screens from the current release. (CosmicMutantExport).';")>
Public Class cosmic_mutant_export: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gene name"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene name"), XmlAttribute> Public Property Gene_name As String
''' <summary>
''' The transcript identifier of the gene.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Accession Number"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Accession Number")> Public Property Accession_Number As String
''' <summary>
''' Length of the gene (base pair) counts.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gene CDS length"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene CDS length")> Public Property Gene_CDS_length As String
''' <summary>
''' if gene is in HGNC, this id helps linking it to HGNC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("HGNC id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="HGNC id")> Public Property HGNC_id As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample name")> Public Property Sample_name As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Sample"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Sample")> Public Property Id_Sample As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id tumour"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id tumour")> Public Property Id_tumour As String
''' <summary>
''' The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary Site"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary Site")> Public Property Primary_Site As String
''' <summary>
''' Further sub classification (level 1) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site Subtype 1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site Subtype 1")> Public Property Site_Subtype_1 As String
''' <summary>
''' Further sub classification (level 2) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site Subtype 2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site Subtype 2")> Public Property Site_Subtype_2 As String
''' <summary>
''' Further sub classification (level 3) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site Subtype 3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site Subtype 3")> Public Property Site_Subtype_3 As String
''' <summary>
''' The histological classification of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary Histology"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary Histology")> Public Property Primary_Histology As String
''' <summary>
''' Further histological classification (level 1) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology Subtype 1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology Subtype 1")> Public Property Histology_Subtype_1 As String
''' <summary>
''' Further histological classification (level 2) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology Subtype 2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology Subtype 2")> Public Property Histology_Subtype_2 As String
''' <summary>
''' Further histological classification (level 3) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology Subtype 3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology Subtype 3")> Public Property Histology_Subtype_3 As String
''' <summary>
''' if the enitre genome/exome is sequenced.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Genome-wide screen"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Genome-wide screen")> Public Property Genome_wide_screen As String
''' <summary>
''' unique mutation identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation Id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Id")> Public Property Mutation_Id As String
''' <summary>
''' The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation CDS"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation CDS")> Public Property Mutation_CDS As String
''' <summary>
''' The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society. The description of each type can be found by following the link to Mutation Overview page.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation AA"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation AA")> Public Property Mutation_AA As String
''' <summary>
''' Type of mutation (substitution, deletion, insertion, complex, fusion, unknown etc.)
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation Description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Description")> Public Property Mutation_Description As String
''' <summary>
''' Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation zygosity"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation zygosity")> Public Property Mutation_zygosity As String
''' <summary>
''' LOH Information on whether the gene was reported to have loss of heterozygosity in the sample: yes, no or unknown.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("LOH"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="LOH")> Public Property LOH As String
''' <summary>
''' The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19   
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("GRCh"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="GRCh")> Public Property GRCh As String
''' <summary>
''' The genomic cooridnates of the mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation genome position"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation genome position")> Public Property Mutation_genome_position As String
''' <summary>
''' postive or negative.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation strand"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation strand")> Public Property Mutation_strand As String
''' <summary>
''' All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("SNP"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="SNP")> Public Property SNP As String
''' <summary>
''' mutation confers drug resistance (see CosmicResistanceMutations.tsv.gz for gene/drug details).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Resistance Mutation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Resistance Mutation")> Public Property Resistance_Mutation As String
''' <summary>
''' More information about FATHMM (Functional Analysis through Hidden Markov Models) is available from here. FATHMM descriptors -\n\n        Pathogenic = Defined as Cancer or Damaging.\n        Neutral = Defined as Passenger or Tolerated.  
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("FATHMM prediction"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="FATHMM prediction")> Public Property FATHMM_prediction As String
''' <summary>
''' The scores are in the form of pvalues ranging from 0 to 1. Pvalues greater than 0.5 are pathogenic while less than 0.5 are benign. Pvalues close to 0 or 1 are the high confidence results which are more accurate. The results are annotated as 10 feature groups (separately for coding and non coding variants) details of which can be found in the original FATHMM-MKL paper.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("FATHMM Score"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="FATHMM Score")> Public Property FATHMM_Score As String
''' <summary>
''' Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.     
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation somatic status"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation somatic status")> Public Property Mutation_somatic_status As String
''' <summary>
''' The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Pubmed_PMID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Pubmed_PMID")> Public Property Pubmed_PMID As String
''' <summary>
''' Lists the unique Ids of studies that have involved this sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Study")> Public Property Id_Study As String
''' <summary>
''' Describes where the sample has originated from including the tumour type.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample source"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample source")> Public Property Sample_source As String
''' <summary>
''' Describes where the sample has originated from including the tumour type.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Tumour origin"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tumour origin")> Public Property Tumour_origin As String
''' <summary>
''' Age of the sample (if this information is provided with the publications).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Age"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Age")> Public Property Age As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cosmic_mutant_export` (`Gene name`, `Accession Number`, `Gene CDS length`, `HGNC id`, `Sample name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Genome-wide screen`, `Mutation Id`, `Mutation CDS`, `Mutation AA`, `Mutation Description`, `Mutation zygosity`, `LOH`, `GRCh`, `Mutation genome position`, `Mutation strand`, `SNP`, `Resistance Mutation`, `FATHMM prediction`, `FATHMM Score`, `Mutation somatic status`, `Pubmed_PMID`, `Id Study`, `Sample source`, `Tumour origin`, `Age`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cosmic_mutant_export` (`Gene name`, `Accession Number`, `Gene CDS length`, `HGNC id`, `Sample name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Genome-wide screen`, `Mutation Id`, `Mutation CDS`, `Mutation AA`, `Mutation Description`, `Mutation zygosity`, `LOH`, `GRCh`, `Mutation genome position`, `Mutation strand`, `SNP`, `Resistance Mutation`, `FATHMM prediction`, `FATHMM Score`, `Mutation somatic status`, `Pubmed_PMID`, `Id Study`, `Sample source`, `Tumour origin`, `Age`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cosmic_mutant_export` WHERE `Gene name` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cosmic_mutant_export` SET `Gene name`='{0}', `Accession Number`='{1}', `Gene CDS length`='{2}', `HGNC id`='{3}', `Sample name`='{4}', `Id Sample`='{5}', `Id tumour`='{6}', `Primary Site`='{7}', `Site Subtype 1`='{8}', `Site Subtype 2`='{9}', `Site Subtype 3`='{10}', `Primary Histology`='{11}', `Histology Subtype 1`='{12}', `Histology Subtype 2`='{13}', `Histology Subtype 3`='{14}', `Genome-wide screen`='{15}', `Mutation Id`='{16}', `Mutation CDS`='{17}', `Mutation AA`='{18}', `Mutation Description`='{19}', `Mutation zygosity`='{20}', `LOH`='{21}', `GRCh`='{22}', `Mutation genome position`='{23}', `Mutation strand`='{24}', `SNP`='{25}', `Resistance Mutation`='{26}', `FATHMM prediction`='{27}', `FATHMM Score`='{28}', `Mutation somatic status`='{29}', `Pubmed_PMID`='{30}', `Id Study`='{31}', `Sample source`='{32}', `Tumour origin`='{33}', `Age`='{34}' WHERE `Gene name` = '{35}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cosmic_mutant_export` WHERE `Gene name` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Gene_name)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cosmic_mutant_export` (`Gene name`, `Accession Number`, `Gene CDS length`, `HGNC id`, `Sample name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Genome-wide screen`, `Mutation Id`, `Mutation CDS`, `Mutation AA`, `Mutation Description`, `Mutation zygosity`, `LOH`, `GRCh`, `Mutation genome position`, `Mutation strand`, `SNP`, `Resistance Mutation`, `FATHMM prediction`, `FATHMM Score`, `Mutation somatic status`, `Pubmed_PMID`, `Id Study`, `Sample source`, `Tumour origin`, `Age`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Gene_name, Accession_Number, Gene_CDS_length, HGNC_id, Sample_name, Id_Sample, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Genome_wide_screen, Mutation_Id, Mutation_CDS, Mutation_AA, Mutation_Description, Mutation_zygosity, LOH, GRCh, Mutation_genome_position, Mutation_strand, SNP, Resistance_Mutation, FATHMM_prediction, FATHMM_Score, Mutation_somatic_status, Pubmed_PMID, Id_Study, Sample_source, Tumour_origin, Age)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Gene_name}', '{Accession_Number}', '{Gene_CDS_length}', '{HGNC_id}', '{Sample_name}', '{Id_Sample}', '{Id_tumour}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Genome_wide_screen}', '{Mutation_Id}', '{Mutation_CDS}', '{Mutation_AA}', '{Mutation_Description}', '{Mutation_zygosity}', '{LOH}', '{GRCh}', '{Mutation_genome_position}', '{Mutation_strand}', '{SNP}', '{Resistance_Mutation}', '{FATHMM_prediction}', '{FATHMM_Score}', '{Mutation_somatic_status}', '{Pubmed_PMID}', '{Id_Study}', '{Sample_source}', '{Tumour_origin}', '{Age}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cosmic_mutant_export` (`Gene name`, `Accession Number`, `Gene CDS length`, `HGNC id`, `Sample name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Genome-wide screen`, `Mutation Id`, `Mutation CDS`, `Mutation AA`, `Mutation Description`, `Mutation zygosity`, `LOH`, `GRCh`, `Mutation genome position`, `Mutation strand`, `SNP`, `Resistance Mutation`, `FATHMM prediction`, `FATHMM Score`, `Mutation somatic status`, `Pubmed_PMID`, `Id Study`, `Sample source`, `Tumour origin`, `Age`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Gene_name, Accession_Number, Gene_CDS_length, HGNC_id, Sample_name, Id_Sample, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Genome_wide_screen, Mutation_Id, Mutation_CDS, Mutation_AA, Mutation_Description, Mutation_zygosity, LOH, GRCh, Mutation_genome_position, Mutation_strand, SNP, Resistance_Mutation, FATHMM_prediction, FATHMM_Score, Mutation_somatic_status, Pubmed_PMID, Id_Study, Sample_source, Tumour_origin, Age)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cosmic_mutant_export` SET `Gene name`='{0}', `Accession Number`='{1}', `Gene CDS length`='{2}', `HGNC id`='{3}', `Sample name`='{4}', `Id Sample`='{5}', `Id tumour`='{6}', `Primary Site`='{7}', `Site Subtype 1`='{8}', `Site Subtype 2`='{9}', `Site Subtype 3`='{10}', `Primary Histology`='{11}', `Histology Subtype 1`='{12}', `Histology Subtype 2`='{13}', `Histology Subtype 3`='{14}', `Genome-wide screen`='{15}', `Mutation Id`='{16}', `Mutation CDS`='{17}', `Mutation AA`='{18}', `Mutation Description`='{19}', `Mutation zygosity`='{20}', `LOH`='{21}', `GRCh`='{22}', `Mutation genome position`='{23}', `Mutation strand`='{24}', `SNP`='{25}', `Resistance Mutation`='{26}', `FATHMM prediction`='{27}', `FATHMM Score`='{28}', `Mutation somatic status`='{29}', `Pubmed_PMID`='{30}', `Id Study`='{31}', `Sample source`='{32}', `Tumour origin`='{33}', `Age`='{34}' WHERE `Gene name` = '{35}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Gene_name, Accession_Number, Gene_CDS_length, HGNC_id, Sample_name, Id_Sample, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Genome_wide_screen, Mutation_Id, Mutation_CDS, Mutation_AA, Mutation_Description, Mutation_zygosity, LOH, GRCh, Mutation_genome_position, Mutation_strand, SNP, Resistance_Mutation, FATHMM_prediction, FATHMM_Score, Mutation_somatic_status, Pubmed_PMID, Id_Study, Sample_source, Tumour_origin, Age, Gene_name)
    End Function
#End Region
Public Function Clone() As cosmic_mutant_export
                  Return DirectCast(MyClass.MemberwiseClone, cosmic_mutant_export)
              End Function
End Class


End Namespace
