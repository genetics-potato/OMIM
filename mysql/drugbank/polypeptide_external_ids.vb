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
''' DROP TABLE IF EXISTS `polypeptide_external_ids`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `polypeptide_external_ids` (
'''   `polypeptide` varchar(45) NOT NULL,
'''   `resource` varchar(45) DEFAULT NULL,
'''   `id` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`polypeptide`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("polypeptide_external_ids", Database:="drugbank", SchemaSQL:="
CREATE TABLE `polypeptide_external_ids` (
  `polypeptide` varchar(45) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`polypeptide`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class polypeptide_external_ids: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("polypeptide"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45")> Public Property polypeptide As String
    <DatabaseField("resource"), DataType(MySqlDbType.VarChar, "45")> Public Property resource As String
    <DatabaseField("id"), DataType(MySqlDbType.VarChar, "45")> Public Property id As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `polypeptide_external_ids` WHERE `polypeptide` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `polypeptide_external_ids` SET `polypeptide`='{0}', `resource`='{1}', `id`='{2}' WHERE `polypeptide` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `polypeptide_external_ids` WHERE `polypeptide` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, polypeptide)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, polypeptide, resource, id)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{polypeptide}', '{resource}', '{id}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, polypeptide, resource, id)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `polypeptide_external_ids` SET `polypeptide`='{0}', `resource`='{1}', `id`='{2}' WHERE `polypeptide` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, polypeptide, resource, id, polypeptide)
    End Function
#End Region
End Class


End Namespace
