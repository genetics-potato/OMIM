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
''' All gene expression level 3 data from the TCGA portal for the current most release in a tab separated file Please note : The platform codes currently used to produce the COSMIC gene expression values are: IlluminaGA_RNASeqV2, IlluminaHiSeq_RNASeqV2, AgilentG4502A_07_2, AgilentG4502A_07_3. For more information on the gene expression data, please see here. (CosmicCompleteGeneExpression).\nCosmicCompleteGeneExpression.tsv.gz
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `gene_expression`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `gene_expression` (
'''   `sample_ID` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `gene_name` varchar(45) DEFAULT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
'''   `regulation` varchar(45) DEFAULT NULL COMMENT 'it could be over or under depending on the scores from different platforms if they are above or below the threshold.',
'''   `z_score` double DEFAULT NULL COMMENT 'z_score serves as an indicative score taken from the gene_expression from different platforms in order of preference: IlluminaHiSeq_RNASeqV2, IlluminaGA_RNASeqV2, AgilentG4502A_07_3.',
'''   `id_study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this gene expression data.',
'''   PRIMARY KEY (`sample_ID`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='All gene expression level 3 data from the TCGA portal for the current most release in a tab separated file Please note : The platform codes currently used to produce the COSMIC gene expression values are: IlluminaGA_RNASeqV2, IlluminaHiSeq_RNASeqV2, AgilentG4502A_07_2, AgilentG4502A_07_3. For more information on the gene expression data, please see here. (CosmicCompleteGeneExpression).\nCosmicCompleteGeneExpression.tsv.gz';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("gene_expression", Database:="cosmic", SchemaSQL:="
CREATE TABLE `gene_expression` (
  `sample_ID` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `gene_name` varchar(45) DEFAULT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `regulation` varchar(45) DEFAULT NULL COMMENT 'it could be over or under depending on the scores from different platforms if they are above or below the threshold.',
  `z_score` double DEFAULT NULL COMMENT 'z_score serves as an indicative score taken from the gene_expression from different platforms in order of preference: IlluminaHiSeq_RNASeqV2, IlluminaGA_RNASeqV2, AgilentG4502A_07_3.',
  `id_study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this gene expression data.',
  PRIMARY KEY (`sample_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='All gene expression level 3 data from the TCGA portal for the current most release in a tab separated file Please note : The platform codes currently used to produce the COSMIC gene expression values are: IlluminaGA_RNASeqV2, IlluminaHiSeq_RNASeqV2, AgilentG4502A_07_2, AgilentG4502A_07_3. For more information on the gene expression data, please see here. (CosmicCompleteGeneExpression).\nCosmicCompleteGeneExpression.tsv.gz';")>
Public Class gene_expression: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("sample_ID"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="sample_ID"), XmlAttribute> Public Property sample_ID As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("sample_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="sample_name")> Public Property sample_name As String
''' <summary>
''' The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("gene_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="gene_name")> Public Property gene_name As String
''' <summary>
''' it could be over or under depending on the scores from different platforms if they are above or below the threshold.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("regulation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="regulation")> Public Property regulation As String
''' <summary>
''' z_score serves as an indicative score taken from the gene_expression from different platforms in order of preference: IlluminaHiSeq_RNASeqV2, IlluminaGA_RNASeqV2, AgilentG4502A_07_3.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("z_score"), DataType(MySqlDbType.Double), Column(Name:="z_score")> Public Property z_score As Double
''' <summary>
''' Lists the unique Ids of studies that have involved this gene expression data.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("id_study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="id_study")> Public Property id_study As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `gene_expression` (`sample_ID`, `sample_name`, `gene_name`, `regulation`, `z_score`, `id_study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `gene_expression` (`sample_ID`, `sample_name`, `gene_name`, `regulation`, `z_score`, `id_study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `gene_expression` WHERE `sample_ID` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `gene_expression` SET `sample_ID`='{0}', `sample_name`='{1}', `gene_name`='{2}', `regulation`='{3}', `z_score`='{4}', `id_study`='{5}' WHERE `sample_ID` = '{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `gene_expression` WHERE `sample_ID` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, sample_ID)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `gene_expression` (`sample_ID`, `sample_name`, `gene_name`, `regulation`, `z_score`, `id_study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, sample_ID, sample_name, gene_name, regulation, z_score, id_study)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{sample_ID}', '{sample_name}', '{gene_name}', '{regulation}', '{z_score}', '{id_study}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `gene_expression` (`sample_ID`, `sample_name`, `gene_name`, `regulation`, `z_score`, `id_study`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, sample_ID, sample_name, gene_name, regulation, z_score, id_study)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `gene_expression` SET `sample_ID`='{0}', `sample_name`='{1}', `gene_name`='{2}', `regulation`='{3}', `z_score`='{4}', `id_study`='{5}' WHERE `sample_ID` = '{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, sample_ID, sample_name, gene_name, regulation, z_score, id_study, sample_ID)
    End Function
#End Region
Public Function Clone() As gene_expression
                  Return DirectCast(MyClass.MemberwiseClone, gene_expression)
              End Function
End Class


End Namespace
