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
''' DROP TABLE IF EXISTS `pathway_enzymes`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `pathway_enzymes` (
'''   `uniprotID` varchar(45) NOT NULL,
'''   `pathway_smpdb_id` varchar(45) NOT NULL,
'''   `drugID` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `enzyme_drugbankID` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`uniprotID`,`pathway_smpdb_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("pathway_enzymes", Database:="drugbank", SchemaSQL:="
CREATE TABLE `pathway_enzymes` (
  `uniprotID` varchar(45) NOT NULL,
  `pathway_smpdb_id` varchar(45) NOT NULL,
  `drugID` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `enzyme_drugbankID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`uniprotID`,`pathway_smpdb_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class pathway_enzymes: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uniprotID"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45")> Public Property uniprotID As String
    <DatabaseField("pathway_smpdb_id"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45")> Public Property pathway_smpdb_id As String
    <DatabaseField("drugID"), DataType(MySqlDbType.VarChar, "45")> Public Property drugID As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45")> Public Property name As String
    <DatabaseField("enzyme_drugbankID"), DataType(MySqlDbType.VarChar, "45")> Public Property enzyme_drugbankID As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `pathway_enzymes` WHERE `uniprotID`='{0}' and `pathway_smpdb_id`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `pathway_enzymes` SET `uniprotID`='{0}', `pathway_smpdb_id`='{1}', `drugID`='{2}', `name`='{3}', `enzyme_drugbankID`='{4}' WHERE `uniprotID`='{5}' and `pathway_smpdb_id`='{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `pathway_enzymes` WHERE `uniprotID`='{0}' and `pathway_smpdb_id`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uniprotID, pathway_smpdb_id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, uniprotID, pathway_smpdb_id, drugID, name, enzyme_drugbankID)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{uniprotID}', '{pathway_smpdb_id}', '{drugID}', '{name}', '{enzyme_drugbankID}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, uniprotID, pathway_smpdb_id, drugID, name, enzyme_drugbankID)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `pathway_enzymes` SET `uniprotID`='{0}', `pathway_smpdb_id`='{1}', `drugID`='{2}', `name`='{3}', `enzyme_drugbankID`='{4}' WHERE `uniprotID`='{5}' and `pathway_smpdb_id`='{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uniprotID, pathway_smpdb_id, drugID, name, enzyme_drugbankID, uniprotID, pathway_smpdb_id)
    End Function
#End Region
End Class


End Namespace
