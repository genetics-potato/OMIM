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
''' CosmicFusionExport.tsv\n\nComplete Fusion Export\n\nAll gene fusion mutation data from the current release in a tab separated file. (CosmicFusionExport).
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cosmic_fusion_export`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cosmic_fusion_export` (
'''   `Sample Id` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Sample name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Fusion Id` varchar(45) DEFAULT NULL COMMENT 'Unique fusion mutation identifier.',
'''   `Translocation Name` varchar(45) DEFAULT NULL COMMENT 'Syntax describing the portions of mRNA present (in HGVS ''r.'' format) from each gene (allows representation of UTR sequences).',
'''   `Fusion type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation.',
'''   `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
'''   `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this fusion mutation.',
'''   PRIMARY KEY (`Sample Id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicFusionExport.tsv\n\nComplete Fusion Export\n\nAll gene fusion mutation data from the current release in a tab separated file. (CosmicFusionExport).';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cosmic_fusion_export", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cosmic_fusion_export` (
  `Sample Id` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
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
  PRIMARY KEY (`Sample Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicFusionExport.tsv\n\nComplete Fusion Export\n\nAll gene fusion mutation data from the current release in a tab separated file. (CosmicFusionExport).';")>
Public Class cosmic_fusion_export: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample Id"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample Id"), XmlAttribute> Public Property Sample_Id As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample name")> Public Property Sample_name As String
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
''' Unique fusion mutation identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Fusion Id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Fusion Id")> Public Property Fusion_Id As String
''' <summary>
''' Syntax describing the portions of mRNA present (in HGVS ''r.'' format) from each gene (allows representation of UTR sequences).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Translocation Name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Translocation Name")> Public Property Translocation_Name As String
''' <summary>
''' Type of mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Fusion type"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Fusion type")> Public Property Fusion_type As String
''' <summary>
''' The PUBMED ID for the paper that the sample was noted in.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Pubmed_PMID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Pubmed_PMID")> Public Property Pubmed_PMID As String
''' <summary>
''' Lists the unique Ids of studies that have involved this fusion mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Study")> Public Property Id_Study As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cosmic_fusion_export` (`Sample Id`, `Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Fusion Id`, `Translocation Name`, `Fusion type`, `Pubmed_PMID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cosmic_fusion_export` (`Sample Id`, `Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Fusion Id`, `Translocation Name`, `Fusion type`, `Pubmed_PMID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cosmic_fusion_export` WHERE `Sample Id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cosmic_fusion_export` SET `Sample Id`='{0}', `Sample name`='{1}', `Primary Site`='{2}', `Site Subtype 1`='{3}', `Site Subtype 2`='{4}', `Site Subtype 3`='{5}', `Primary Histology`='{6}', `Histology Subtype 1`='{7}', `Histology Subtype 2`='{8}', `Histology Subtype 3`='{9}', `Fusion Id`='{10}', `Translocation Name`='{11}', `Fusion type`='{12}', `Pubmed_PMID`='{13}', `Id Study`='{14}' WHERE `Sample Id` = '{15}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cosmic_fusion_export` WHERE `Sample Id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Sample_Id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cosmic_fusion_export` (`Sample Id`, `Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Fusion Id`, `Translocation Name`, `Fusion type`, `Pubmed_PMID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Sample_Id, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Fusion_Id, Translocation_Name, Fusion_type, Pubmed_PMID, Id_Study)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Sample_Id}', '{Sample_name}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Fusion_Id}', '{Translocation_Name}', '{Fusion_type}', '{Pubmed_PMID}', '{Id_Study}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cosmic_fusion_export` (`Sample Id`, `Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Fusion Id`, `Translocation Name`, `Fusion type`, `Pubmed_PMID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Sample_Id, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Fusion_Id, Translocation_Name, Fusion_type, Pubmed_PMID, Id_Study)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cosmic_fusion_export` SET `Sample Id`='{0}', `Sample name`='{1}', `Primary Site`='{2}', `Site Subtype 1`='{3}', `Site Subtype 2`='{4}', `Site Subtype 3`='{5}', `Primary Histology`='{6}', `Histology Subtype 1`='{7}', `Histology Subtype 2`='{8}', `Histology Subtype 3`='{9}', `Fusion Id`='{10}', `Translocation Name`='{11}', `Fusion type`='{12}', `Pubmed_PMID`='{13}', `Id Study`='{14}' WHERE `Sample Id` = '{15}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Sample_Id, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Fusion_Id, Translocation_Name, Fusion_type, Pubmed_PMID, Id_Study, Sample_Id)
    End Function
#End Region
Public Function Clone() As cosmic_fusion_export
                  Return DirectCast(MyClass.MemberwiseClone, cosmic_fusion_export)
              End Function
End Class


End Namespace
