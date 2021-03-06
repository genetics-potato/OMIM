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
''' CosmicBreakpointsExport.tsv\n\nAll breakpoint data from the current release in a tab separated file (CosmicBreakpointsExport).
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cosmic_breakpoints_export`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cosmic_breakpoints_export` (
'''   `Sample name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Mutation Type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.',
'''   `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
'''   `Breakpoint Order` varchar(45) DEFAULT NULL COMMENT 'For variants involving multiple breakpoints, the predicted order along chromosome(s).Otherwise ''0''.',
'''   `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
'''   `Chrom From` varchar(45) DEFAULT NULL COMMENT 'The chromosome where the first variant/breakpoint occurs.',
'''   `Location From min` varchar(45) DEFAULT NULL COMMENT 'The first position in breakpoint range.',
'''   `Location From max` varchar(45) DEFAULT NULL COMMENT 'The last position in breakpoint range.',
'''   `Strand From` varchar(45) DEFAULT NULL COMMENT 'positive or negative.',
'''   `Chrom To` varchar(45) DEFAULT NULL COMMENT 'The chromosome where the last variant/breakpoint occurs.',
'''   `Location To min` varchar(45) DEFAULT NULL COMMENT 'The first position in breakpoint range.',
'''   `Location To max` varchar(45) DEFAULT NULL COMMENT 'The last position in breakpoint range.',
'''   `Strand To` varchar(45) DEFAULT NULL COMMENT 'positive or negative.',
'''   `Non-templated ins seq` varchar(45) DEFAULT NULL COMMENT 'Non Templated Sequence (if any) which is inserted at the breakpoint. The sequence is not encoded.',
'''   `Pubmed_ID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
'''   `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this structural mutation.',
'''   PRIMARY KEY (`Sample name`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicBreakpointsExport.tsv\n\nAll breakpoint data from the current release in a tab separated file (CosmicBreakpointsExport).';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cosmic_breakpoints_export", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cosmic_breakpoints_export` (
  `Sample name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
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
  `Pubmed_ID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this structural mutation.',
  PRIMARY KEY (`Sample name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicBreakpointsExport.tsv\n\nAll breakpoint data from the current release in a tab separated file (CosmicBreakpointsExport).';")>
Public Class cosmic_breakpoints_export: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample name"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample name"), XmlAttribute> Public Property Sample_name As String
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
''' Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation Type"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Type")> Public Property Mutation_Type As String
''' <summary>
''' unique mutation identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation Id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Id")> Public Property Mutation_Id As String
''' <summary>
''' For variants involving multiple breakpoints, the predicted order along chromosome(s).Otherwise ''0''.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Breakpoint Order"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Breakpoint Order")> Public Property Breakpoint_Order As String
''' <summary>
''' The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("GRCh"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="GRCh")> Public Property GRCh As String
''' <summary>
''' The chromosome where the first variant/breakpoint occurs.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Chrom From"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Chrom From")> Public Property Chrom_From As String
''' <summary>
''' The first position in breakpoint range.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Location From min"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Location From min")> Public Property Location_From_min As String
''' <summary>
''' The last position in breakpoint range.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Location From max"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Location From max")> Public Property Location_From_max As String
''' <summary>
''' positive or negative.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Strand From"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Strand From")> Public Property Strand_From As String
''' <summary>
''' The chromosome where the last variant/breakpoint occurs.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Chrom To"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Chrom To")> Public Property Chrom_To As String
''' <summary>
''' The first position in breakpoint range.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Location To min"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Location To min")> Public Property Location_To_min As String
''' <summary>
''' The last position in breakpoint range.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Location To max"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Location To max")> Public Property Location_To_max As String
''' <summary>
''' positive or negative.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Strand To"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Strand To")> Public Property Strand_To As String
''' <summary>
''' Non Templated Sequence (if any) which is inserted at the breakpoint. The sequence is not encoded.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Non-templated ins seq"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Non-templated ins seq")> Public Property Non_templated_ins_seq As String
''' <summary>
''' The PUBMED ID for the paper that the sample was noted in.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Pubmed_ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Pubmed_ID")> Public Property Pubmed_ID As String
''' <summary>
''' Lists the unique Ids of studies that have involved this structural mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Study")> Public Property Id_Study As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cosmic_breakpoints_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Type`, `Mutation Id`, `Breakpoint Order`, `GRCh`, `Chrom From`, `Location From min`, `Location From max`, `Strand From`, `Chrom To`, `Location To min`, `Location To max`, `Strand To`, `Non-templated ins seq`, `Pubmed_ID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cosmic_breakpoints_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Type`, `Mutation Id`, `Breakpoint Order`, `GRCh`, `Chrom From`, `Location From min`, `Location From max`, `Strand From`, `Chrom To`, `Location To min`, `Location To max`, `Strand To`, `Non-templated ins seq`, `Pubmed_ID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cosmic_breakpoints_export` WHERE `Sample name` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cosmic_breakpoints_export` SET `Sample name`='{0}', `Primary Site`='{1}', `Site Subtype 1`='{2}', `Site Subtype 2`='{3}', `Site Subtype 3`='{4}', `Primary Histology`='{5}', `Histology Subtype 1`='{6}', `Histology Subtype 2`='{7}', `Histology Subtype 3`='{8}', `Mutation Type`='{9}', `Mutation Id`='{10}', `Breakpoint Order`='{11}', `GRCh`='{12}', `Chrom From`='{13}', `Location From min`='{14}', `Location From max`='{15}', `Strand From`='{16}', `Chrom To`='{17}', `Location To min`='{18}', `Location To max`='{19}', `Strand To`='{20}', `Non-templated ins seq`='{21}', `Pubmed_ID`='{22}', `Id Study`='{23}' WHERE `Sample name` = '{24}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cosmic_breakpoints_export` WHERE `Sample name` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Sample_name)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cosmic_breakpoints_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Type`, `Mutation Id`, `Breakpoint Order`, `GRCh`, `Chrom From`, `Location From min`, `Location From max`, `Strand From`, `Chrom To`, `Location To min`, `Location To max`, `Strand To`, `Non-templated ins seq`, `Pubmed_ID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Mutation_Type, Mutation_Id, Breakpoint_Order, GRCh, Chrom_From, Location_From_min, Location_From_max, Strand_From, Chrom_To, Location_To_min, Location_To_max, Strand_To, Non_templated_ins_seq, Pubmed_ID, Id_Study)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Sample_name}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Mutation_Type}', '{Mutation_Id}', '{Breakpoint_Order}', '{GRCh}', '{Chrom_From}', '{Location_From_min}', '{Location_From_max}', '{Strand_From}', '{Chrom_To}', '{Location_To_min}', '{Location_To_max}', '{Strand_To}', '{Non_templated_ins_seq}', '{Pubmed_ID}', '{Id_Study}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cosmic_breakpoints_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Type`, `Mutation Id`, `Breakpoint Order`, `GRCh`, `Chrom From`, `Location From min`, `Location From max`, `Strand From`, `Chrom To`, `Location To min`, `Location To max`, `Strand To`, `Non-templated ins seq`, `Pubmed_ID`, `Id Study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Mutation_Type, Mutation_Id, Breakpoint_Order, GRCh, Chrom_From, Location_From_min, Location_From_max, Strand_From, Chrom_To, Location_To_min, Location_To_max, Strand_To, Non_templated_ins_seq, Pubmed_ID, Id_Study)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cosmic_breakpoints_export` SET `Sample name`='{0}', `Primary Site`='{1}', `Site Subtype 1`='{2}', `Site Subtype 2`='{3}', `Site Subtype 3`='{4}', `Primary Histology`='{5}', `Histology Subtype 1`='{6}', `Histology Subtype 2`='{7}', `Histology Subtype 3`='{8}', `Mutation Type`='{9}', `Mutation Id`='{10}', `Breakpoint Order`='{11}', `GRCh`='{12}', `Chrom From`='{13}', `Location From min`='{14}', `Location From max`='{15}', `Strand From`='{16}', `Chrom To`='{17}', `Location To min`='{18}', `Location To max`='{19}', `Strand To`='{20}', `Non-templated ins seq`='{21}', `Pubmed_ID`='{22}', `Id Study`='{23}' WHERE `Sample name` = '{24}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Mutation_Type, Mutation_Id, Breakpoint_Order, GRCh, Chrom_From, Location_From_min, Location_From_max, Strand_From, Chrom_To, Location_To_min, Location_To_max, Strand_To, Non_templated_ins_seq, Pubmed_ID, Id_Study, Sample_name)
    End Function
#End Region
Public Function Clone() As cosmic_breakpoints_export
                  Return DirectCast(MyClass.MemberwiseClone, cosmic_breakpoints_export)
              End Function
End Class


End Namespace
