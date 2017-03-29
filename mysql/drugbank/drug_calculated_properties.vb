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
''' DROP TABLE IF EXISTS `drug_calculated_properties`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_calculated_properties` (
'''   `drug` int(11) NOT NULL,
'''   `kind` varchar(45) DEFAULT NULL,
'''   `value` varchar(45) DEFAULT NULL,
'''   `source` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_calculated_properties`
''' --
''' 
''' LOCK TABLES `drug_calculated_properties` WRITE;
''' /*!40000 ALTER TABLE `drug_calculated_properties` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_calculated_properties` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_calculated_properties", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_calculated_properties` (
  `drug` int(11) NOT NULL,
  `kind` varchar(45) DEFAULT NULL,
  `value` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_calculated_properties: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("kind"), DataType(MySqlDbType.VarChar, "45")> Public Property kind As String
    <DatabaseField("value"), DataType(MySqlDbType.VarChar, "45")> Public Property value As String
    <DatabaseField("source"), DataType(MySqlDbType.VarChar, "45")> Public Property source As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_calculated_properties` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_calculated_properties` SET `drug`='{0}', `kind`='{1}', `value`='{2}', `source`='{3}' WHERE `drug` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_calculated_properties` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, kind, value, source)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, kind, value, source)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_calculated_properties` SET `drug`='{0}', `kind`='{1}', `value`='{2}', `source`='{3}' WHERE `drug` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, kind, value, source, drug)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{drug}', '{kind}', '{value}', '{source}')"
End Function

#End Region
End Class


End Namespace
