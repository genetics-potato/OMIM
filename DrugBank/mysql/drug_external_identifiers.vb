REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/29 11:18:52


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_external_identifiers`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_external_identifiers` (
'''   `drug` int(11) NOT NULL,
'''   `resource` varchar(45) DEFAULT NULL,
'''   `ID` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_external_identifiers`
''' --
''' 
''' LOCK TABLES `drug_external_identifiers` WRITE;
''' /*!40000 ALTER TABLE `drug_external_identifiers` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_external_identifiers` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_external_identifiers", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_external_identifiers` (
  `drug` int(11) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `ID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_external_identifiers: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("resource"), DataType(MySqlDbType.VarChar, "45")> Public Property resource As String
    <DatabaseField("ID"), DataType(MySqlDbType.VarChar, "45")> Public Property ID As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_external_identifiers` (`drug`, `resource`, `ID`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_external_identifiers` (`drug`, `resource`, `ID`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_external_identifiers` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_external_identifiers` SET `drug`='{0}', `resource`='{1}', `ID`='{2}' WHERE `drug` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_external_identifiers` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_external_identifiers` (`drug`, `resource`, `ID`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, resource, ID)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_external_identifiers` (`drug`, `resource`, `ID`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, resource, ID)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_external_identifiers` SET `drug`='{0}', `resource`='{1}', `ID`='{2}' WHERE `drug` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, resource, ID, drug)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{drug}', '{resource}', '{ID}')"
End Function

#End Region
End Class


End Namespace
