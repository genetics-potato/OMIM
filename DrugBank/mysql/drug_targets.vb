REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/22 16:27:31


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_targets`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_targets` (
'''   `drug` int(11) NOT NULL,
'''   `target_id` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `organism` varchar(45) DEFAULT NULL,
'''   `actions` varchar(45) DEFAULT NULL,
'''   `known_action` varchar(45) DEFAULT NULL,
'''   `polypeptide` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_targets", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_targets` (
  `drug` int(11) NOT NULL,
  `target_id` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `organism` varchar(45) DEFAULT NULL,
  `actions` varchar(45) DEFAULT NULL,
  `known_action` varchar(45) DEFAULT NULL,
  `polypeptide` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_targets: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("target_id"), DataType(MySqlDbType.VarChar, "45")> Public Property target_id As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45")> Public Property name As String
    <DatabaseField("organism"), DataType(MySqlDbType.VarChar, "45")> Public Property organism As String
    <DatabaseField("actions"), DataType(MySqlDbType.VarChar, "45")> Public Property actions As String
    <DatabaseField("known_action"), DataType(MySqlDbType.VarChar, "45")> Public Property known_action As String
    <DatabaseField("polypeptide"), DataType(MySqlDbType.VarChar, "45")> Public Property polypeptide As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_targets` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_targets` SET `drug`='{0}', `target_id`='{1}', `name`='{2}', `organism`='{3}', `actions`='{4}', `known_action`='{5}', `polypeptide`='{6}' WHERE `drug` = '{7}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_targets` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, target_id, name, organism, actions, known_action, polypeptide)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, target_id, name, organism, actions, known_action, polypeptide)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_targets` SET `drug`='{0}', `target_id`='{1}', `name`='{2}', `organism`='{3}', `actions`='{4}', `known_action`='{5}', `polypeptide`='{6}' WHERE `drug` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, target_id, name, organism, actions, known_action, polypeptide, drug)
    End Function
#End Region
End Class


End Namespace
