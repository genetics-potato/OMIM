REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/29 15:24:56


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `target_polypeptides`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `target_polypeptides` (
'''   `target_id` varchar(45) NOT NULL,
'''   `drug_id` varchar(45) DEFAULT NULL,
'''   `polypeptide_id` varchar(45) DEFAULT NULL,
'''   `source` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `general_function` varchar(45) DEFAULT NULL,
'''   `specific_function` varchar(45) DEFAULT NULL,
'''   `gene_name` varchar(45) DEFAULT NULL,
'''   `locus` varchar(45) DEFAULT NULL,
'''   `cellular_location` varchar(45) DEFAULT NULL,
'''   `transmembrane_regions` varchar(45) DEFAULT NULL,
'''   `signal_regions` varchar(45) DEFAULT NULL,
'''   `theoretical_PI` varchar(45) DEFAULT NULL,
'''   `molecular_weight` varchar(45) DEFAULT NULL,
'''   `chromosome_location` varchar(45) DEFAULT NULL,
'''   `organism` varchar(45) DEFAULT NULL,
'''   `organism_ncbi_taxonomy_id` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`target_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping events for database 'drugbank'
''' --
''' 
''' --
''' -- Dumping routines for database 'drugbank'
''' --
''' /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
''' 
''' /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
''' /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
''' /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
''' /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
''' /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
''' /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
''' /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
''' 
''' -- Dump completed on 2017-03-29 15:24:51
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("target_polypeptides", Database:="drugbank", SchemaSQL:="
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class target_polypeptides: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("target_id"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45")> Public Property target_id As String
    <DatabaseField("drug_id"), DataType(MySqlDbType.VarChar, "45")> Public Property drug_id As String
    <DatabaseField("polypeptide_id"), DataType(MySqlDbType.VarChar, "45")> Public Property polypeptide_id As String
    <DatabaseField("source"), DataType(MySqlDbType.VarChar, "45")> Public Property source As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45")> Public Property name As String
    <DatabaseField("general_function"), DataType(MySqlDbType.VarChar, "45")> Public Property general_function As String
    <DatabaseField("specific_function"), DataType(MySqlDbType.VarChar, "45")> Public Property specific_function As String
    <DatabaseField("gene_name"), DataType(MySqlDbType.VarChar, "45")> Public Property gene_name As String
    <DatabaseField("locus"), DataType(MySqlDbType.VarChar, "45")> Public Property locus As String
    <DatabaseField("cellular_location"), DataType(MySqlDbType.VarChar, "45")> Public Property cellular_location As String
    <DatabaseField("transmembrane_regions"), DataType(MySqlDbType.VarChar, "45")> Public Property transmembrane_regions As String
    <DatabaseField("signal_regions"), DataType(MySqlDbType.VarChar, "45")> Public Property signal_regions As String
    <DatabaseField("theoretical_PI"), DataType(MySqlDbType.VarChar, "45")> Public Property theoretical_PI As String
    <DatabaseField("molecular_weight"), DataType(MySqlDbType.VarChar, "45")> Public Property molecular_weight As String
    <DatabaseField("chromosome_location"), DataType(MySqlDbType.VarChar, "45")> Public Property chromosome_location As String
    <DatabaseField("organism"), DataType(MySqlDbType.VarChar, "45")> Public Property organism As String
    <DatabaseField("organism_ncbi_taxonomy_id"), DataType(MySqlDbType.VarChar, "45")> Public Property organism_ncbi_taxonomy_id As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `target_polypeptides` (`target_id`, `drug_id`, `polypeptide_id`, `source`, `name`, `general_function`, `specific_function`, `gene_name`, `locus`, `cellular_location`, `transmembrane_regions`, `signal_regions`, `theoretical_PI`, `molecular_weight`, `chromosome_location`, `organism`, `organism_ncbi_taxonomy_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `target_polypeptides` (`target_id`, `drug_id`, `polypeptide_id`, `source`, `name`, `general_function`, `specific_function`, `gene_name`, `locus`, `cellular_location`, `transmembrane_regions`, `signal_regions`, `theoretical_PI`, `molecular_weight`, `chromosome_location`, `organism`, `organism_ncbi_taxonomy_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `target_polypeptides` WHERE `target_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `target_polypeptides` SET `target_id`='{0}', `drug_id`='{1}', `polypeptide_id`='{2}', `source`='{3}', `name`='{4}', `general_function`='{5}', `specific_function`='{6}', `gene_name`='{7}', `locus`='{8}', `cellular_location`='{9}', `transmembrane_regions`='{10}', `signal_regions`='{11}', `theoretical_PI`='{12}', `molecular_weight`='{13}', `chromosome_location`='{14}', `organism`='{15}', `organism_ncbi_taxonomy_id`='{16}' WHERE `target_id` = '{17}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `target_polypeptides` WHERE `target_id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, target_id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `target_polypeptides` (`target_id`, `drug_id`, `polypeptide_id`, `source`, `name`, `general_function`, `specific_function`, `gene_name`, `locus`, `cellular_location`, `transmembrane_regions`, `signal_regions`, `theoretical_PI`, `molecular_weight`, `chromosome_location`, `organism`, `organism_ncbi_taxonomy_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, target_id, drug_id, polypeptide_id, source, name, general_function, specific_function, gene_name, locus, cellular_location, transmembrane_regions, signal_regions, theoretical_PI, molecular_weight, chromosome_location, organism, organism_ncbi_taxonomy_id)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{target_id}', '{drug_id}', '{polypeptide_id}', '{source}', '{name}', '{general_function}', '{specific_function}', '{gene_name}', '{locus}', '{cellular_location}', '{transmembrane_regions}', '{signal_regions}', '{theoretical_PI}', '{molecular_weight}', '{chromosome_location}', '{organism}', '{organism_ncbi_taxonomy_id}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `target_polypeptides` (`target_id`, `drug_id`, `polypeptide_id`, `source`, `name`, `general_function`, `specific_function`, `gene_name`, `locus`, `cellular_location`, `transmembrane_regions`, `signal_regions`, `theoretical_PI`, `molecular_weight`, `chromosome_location`, `organism`, `organism_ncbi_taxonomy_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, target_id, drug_id, polypeptide_id, source, name, general_function, specific_function, gene_name, locus, cellular_location, transmembrane_regions, signal_regions, theoretical_PI, molecular_weight, chromosome_location, organism, organism_ncbi_taxonomy_id)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `target_polypeptides` SET `target_id`='{0}', `drug_id`='{1}', `polypeptide_id`='{2}', `source`='{3}', `name`='{4}', `general_function`='{5}', `specific_function`='{6}', `gene_name`='{7}', `locus`='{8}', `cellular_location`='{9}', `transmembrane_regions`='{10}', `signal_regions`='{11}', `theoretical_PI`='{12}', `molecular_weight`='{13}', `chromosome_location`='{14}', `organism`='{15}', `organism_ncbi_taxonomy_id`='{16}' WHERE `target_id` = '{17}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, target_id, drug_id, polypeptide_id, source, name, general_function, specific_function, gene_name, locus, cellular_location, transmembrane_regions, signal_regions, theoretical_PI, molecular_weight, chromosome_location, organism, organism_ncbi_taxonomy_id, target_id)
    End Function
#End Region
End Class


End Namespace
