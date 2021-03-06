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
''' TCGA Level 3 methylation data from the ICGC portal for the current release in a tab separated file. More information on the methylation data is available from here. (CosmicCompleteDifferentialMethylation).\nCosmicCompleteDifferentialMethylation.tsv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `complete_differential_methylation`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `complete_differential_methylation` (
'''   `Study_ID` varchar(45) NOT NULL COMMENT 'The study Id for these data.',
'''   `Id_Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.',
'''   `Sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.',
'''   `Id_tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.',
'''   `Primary_Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary_Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Fragment_Id` varchar(45) DEFAULT NULL COMMENT 'The unique probe Id for a specific CpG.',
'''   `Genome_Version` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19',
'''   `Chromosome` varchar(45) DEFAULT NULL COMMENT 'The chromosome location of the probe (1-22, X or Y).',
'''   `Position` varchar(45) DEFAULT NULL COMMENT 'The genome location of the CpG targeted by the probe (1-based coordinates).',
'''   `Gene_Name` varchar(45) DEFAULT NULL COMMENT 'The gene name (if the probe falls within the coding region of a COSMIC gene) or the probe annotation as descibed by Illumina.',
'''   `Methylation` varchar(45) DEFAULT NULL COMMENT 'The methylation level; H (High, beta-value >0.8) or L (Low, beta-value &lt; 0.2).',
'''   `Avg_Beta_Value_Normal` varchar(45) DEFAULT NULL COMMENT 'The average beta-value across the normal population. The beta-value of the tumour must differ from this value by >0.5 to be considered a variant.',
'''   `Beta_Value` varchar(45) DEFAULT NULL COMMENT 'The beta-value for the probe in the tumour sample. Only values >0.8 (High) or &lt;0.2 (Low) are included.',
'''   `Two_Sided_P_Value` varchar(45) DEFAULT NULL COMMENT 'The two sided p-value.',
'''   PRIMARY KEY (`Study_ID`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='TCGA Level 3 methylation data from the ICGC portal for the current release in a tab separated file. More information on the methylation data is available from here. (CosmicCompleteDifferentialMethylation).\nCosmicCompleteDifferentialMethylation.tsv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("complete_differential_methylation", Database:="cosmic", SchemaSQL:="
CREATE TABLE `complete_differential_methylation` (
  `Study_ID` varchar(45) NOT NULL COMMENT 'The study Id for these data.',
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
  `Methylation` varchar(45) DEFAULT NULL COMMENT 'The methylation level; H (High, beta-value >0.8) or L (Low, beta-value &lt; 0.2).',
  `Avg_Beta_Value_Normal` varchar(45) DEFAULT NULL COMMENT 'The average beta-value across the normal population. The beta-value of the tumour must differ from this value by >0.5 to be considered a variant.',
  `Beta_Value` varchar(45) DEFAULT NULL COMMENT 'The beta-value for the probe in the tumour sample. Only values >0.8 (High) or &lt;0.2 (Low) are included.',
  `Two_Sided_P_Value` varchar(45) DEFAULT NULL COMMENT 'The two sided p-value.',
  PRIMARY KEY (`Study_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='TCGA Level 3 methylation data from the ICGC portal for the current release in a tab separated file. More information on the methylation data is available from here. (CosmicCompleteDifferentialMethylation).\nCosmicCompleteDifferentialMethylation.tsv';")>
Public Class complete_differential_methylation: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' The study Id for these data.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Study_ID"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Study_ID"), XmlAttribute> Public Property Study_ID As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id_Sample"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id_Sample")> Public Property Id_Sample As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_name")> Public Property Sample_name As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id_tumour"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id_tumour")> Public Property Id_tumour As String
''' <summary>
''' The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary_Site"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary_Site")> Public Property Primary_Site As String
''' <summary>
''' Further sub classification (level 1) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype_1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype_1")> Public Property Site_Subtype_1 As String
''' <summary>
''' Further sub classification (level 2) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype_2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype_2")> Public Property Site_Subtype_2 As String
''' <summary>
''' Further sub classification (level 3) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype_3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype_3")> Public Property Site_Subtype_3 As String
''' <summary>
''' The histological classification of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary_Histology"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary_Histology")> Public Property Primary_Histology As String
''' <summary>
''' Further histological classification (level 1) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_Subtype_1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_Subtype_1")> Public Property Histology_Subtype_1 As String
''' <summary>
''' Further histological classification (level 2) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_Subtype_2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_Subtype_2")> Public Property Histology_Subtype_2 As String
''' <summary>
''' Further histological classification (level 3) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_Subtype_3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_Subtype_3")> Public Property Histology_Subtype_3 As String
''' <summary>
''' The unique probe Id for a specific CpG.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Fragment_Id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Fragment_Id")> Public Property Fragment_Id As String
''' <summary>
''' The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Genome_Version"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Genome_Version")> Public Property Genome_Version As String
''' <summary>
''' The chromosome location of the probe (1-22, X or Y).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Chromosome"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Chromosome")> Public Property Chromosome As String
''' <summary>
''' The genome location of the CpG targeted by the probe (1-based coordinates).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Position"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Position")> Public Property Position As String
''' <summary>
''' The gene name (if the probe falls within the coding region of a COSMIC gene) or the probe annotation as descibed by Illumina.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gene_Name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene_Name")> Public Property Gene_Name As String
''' <summary>
''' The methylation level; H (High, beta-value >0.8) or L (Low, beta-value &lt; 0.2).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Methylation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Methylation")> Public Property Methylation As String
''' <summary>
''' The average beta-value across the normal population. The beta-value of the tumour must differ from this value by >0.5 to be considered a variant.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Avg_Beta_Value_Normal"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Avg_Beta_Value_Normal")> Public Property Avg_Beta_Value_Normal As String
''' <summary>
''' The beta-value for the probe in the tumour sample. Only values >0.8 (High) or &lt;0.2 (Low) are included.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Beta_Value"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Beta_Value")> Public Property Beta_Value As String
''' <summary>
''' The two sided p-value.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Two_Sided_P_Value"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Two_Sided_P_Value")> Public Property Two_Sided_P_Value As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `complete_differential_methylation` (`Study_ID`, `Id_Sample`, `Sample_name`, `Id_tumour`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Fragment_Id`, `Genome_Version`, `Chromosome`, `Position`, `Gene_Name`, `Methylation`, `Avg_Beta_Value_Normal`, `Beta_Value`, `Two_Sided_P_Value`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `complete_differential_methylation` (`Study_ID`, `Id_Sample`, `Sample_name`, `Id_tumour`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Fragment_Id`, `Genome_Version`, `Chromosome`, `Position`, `Gene_Name`, `Methylation`, `Avg_Beta_Value_Normal`, `Beta_Value`, `Two_Sided_P_Value`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `complete_differential_methylation` WHERE `Study_ID` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `complete_differential_methylation` SET `Study_ID`='{0}', `Id_Sample`='{1}', `Sample_name`='{2}', `Id_tumour`='{3}', `Primary_Site`='{4}', `Site_Subtype_1`='{5}', `Site_Subtype_2`='{6}', `Site_Subtype_3`='{7}', `Primary_Histology`='{8}', `Histology_Subtype_1`='{9}', `Histology_Subtype_2`='{10}', `Histology_Subtype_3`='{11}', `Fragment_Id`='{12}', `Genome_Version`='{13}', `Chromosome`='{14}', `Position`='{15}', `Gene_Name`='{16}', `Methylation`='{17}', `Avg_Beta_Value_Normal`='{18}', `Beta_Value`='{19}', `Two_Sided_P_Value`='{20}' WHERE `Study_ID` = '{21}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `complete_differential_methylation` WHERE `Study_ID` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Study_ID)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `complete_differential_methylation` (`Study_ID`, `Id_Sample`, `Sample_name`, `Id_tumour`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Fragment_Id`, `Genome_Version`, `Chromosome`, `Position`, `Gene_Name`, `Methylation`, `Avg_Beta_Value_Normal`, `Beta_Value`, `Two_Sided_P_Value`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Study_ID, Id_Sample, Sample_name, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Fragment_Id, Genome_Version, Chromosome, Position, Gene_Name, Methylation, Avg_Beta_Value_Normal, Beta_Value, Two_Sided_P_Value)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Study_ID}', '{Id_Sample}', '{Sample_name}', '{Id_tumour}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Fragment_Id}', '{Genome_Version}', '{Chromosome}', '{Position}', '{Gene_Name}', '{Methylation}', '{Avg_Beta_Value_Normal}', '{Beta_Value}', '{Two_Sided_P_Value}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `complete_differential_methylation` (`Study_ID`, `Id_Sample`, `Sample_name`, `Id_tumour`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Fragment_Id`, `Genome_Version`, `Chromosome`, `Position`, `Gene_Name`, `Methylation`, `Avg_Beta_Value_Normal`, `Beta_Value`, `Two_Sided_P_Value`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Study_ID, Id_Sample, Sample_name, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Fragment_Id, Genome_Version, Chromosome, Position, Gene_Name, Methylation, Avg_Beta_Value_Normal, Beta_Value, Two_Sided_P_Value)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `complete_differential_methylation` SET `Study_ID`='{0}', `Id_Sample`='{1}', `Sample_name`='{2}', `Id_tumour`='{3}', `Primary_Site`='{4}', `Site_Subtype_1`='{5}', `Site_Subtype_2`='{6}', `Site_Subtype_3`='{7}', `Primary_Histology`='{8}', `Histology_Subtype_1`='{9}', `Histology_Subtype_2`='{10}', `Histology_Subtype_3`='{11}', `Fragment_Id`='{12}', `Genome_Version`='{13}', `Chromosome`='{14}', `Position`='{15}', `Gene_Name`='{16}', `Methylation`='{17}', `Avg_Beta_Value_Normal`='{18}', `Beta_Value`='{19}', `Two_Sided_P_Value`='{20}' WHERE `Study_ID` = '{21}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Study_ID, Id_Sample, Sample_name, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Fragment_Id, Genome_Version, Chromosome, Position, Gene_Name, Methylation, Avg_Beta_Value_Normal, Beta_Value, Two_Sided_P_Value, Study_ID)
    End Function
#End Region
Public Function Clone() As complete_differential_methylation
                  Return DirectCast(MyClass.MemberwiseClone, complete_differential_methylation)
              End Function
End Class


End Namespace
