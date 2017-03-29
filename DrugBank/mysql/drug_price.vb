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
''' DROP TABLE IF EXISTS `drug_price`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_price` (
'''   `drug` int(11) NOT NULL,
'''   `description` varchar(45) DEFAULT NULL,
'''   `cost` varchar(45) DEFAULT NULL,
'''   `unit` varchar(45) DEFAULT NULL,
'''   `currency` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_price`
''' --
''' 
''' LOCK TABLES `drug_price` WRITE;
''' /*!40000 ALTER TABLE `drug_price` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_price` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_price", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_price` (
  `drug` int(11) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `cost` varchar(45) DEFAULT NULL,
  `unit` varchar(45) DEFAULT NULL,
  `currency` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_price: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("description"), DataType(MySqlDbType.VarChar, "45")> Public Property description As String
    <DatabaseField("cost"), DataType(MySqlDbType.VarChar, "45")> Public Property cost As String
    <DatabaseField("unit"), DataType(MySqlDbType.VarChar, "45")> Public Property unit As String
    <DatabaseField("currency"), DataType(MySqlDbType.VarChar, "45")> Public Property currency As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_price` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_price` SET `drug`='{0}', `description`='{1}', `cost`='{2}', `unit`='{3}', `currency`='{4}' WHERE `drug` = '{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_price` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, description, cost, unit, currency)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, description, cost, unit, currency)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_price` SET `drug`='{0}', `description`='{1}', `cost`='{2}', `unit`='{3}', `currency`='{4}' WHERE `drug` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, description, cost, unit, currency, drug)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{drug}', '{description}', '{cost}', '{unit}', '{currency}')"
End Function

#End Region
End Class


End Namespace
