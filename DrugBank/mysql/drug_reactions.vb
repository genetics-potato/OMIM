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
''' DROP TABLE IF EXISTS `drug_reactions`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_reactions` (
'''   `drug` int(11) NOT NULL,
'''   `sequence` varchar(45) DEFAULT NULL,
'''   `left1` varchar(45) DEFAULT NULL,
'''   `left2` varchar(45) DEFAULT NULL,
'''   `left3` varchar(45) DEFAULT NULL,
'''   `left4` varchar(45) DEFAULT NULL,
'''   `left5` varchar(45) DEFAULT NULL,
'''   `right1` varchar(45) DEFAULT NULL,
'''   `right2` varchar(45) DEFAULT NULL,
'''   `right3` varchar(45) DEFAULT NULL,
'''   `right4` varchar(45) DEFAULT NULL,
'''   `right5` varchar(45) DEFAULT NULL,
'''   `enzymes` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_reactions`
''' --
''' 
''' LOCK TABLES `drug_reactions` WRITE;
''' /*!40000 ALTER TABLE `drug_reactions` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_reactions` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_reactions", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_reactions` (
  `drug` int(11) NOT NULL,
  `sequence` varchar(45) DEFAULT NULL,
  `left1` varchar(45) DEFAULT NULL,
  `left2` varchar(45) DEFAULT NULL,
  `left3` varchar(45) DEFAULT NULL,
  `left4` varchar(45) DEFAULT NULL,
  `left5` varchar(45) DEFAULT NULL,
  `right1` varchar(45) DEFAULT NULL,
  `right2` varchar(45) DEFAULT NULL,
  `right3` varchar(45) DEFAULT NULL,
  `right4` varchar(45) DEFAULT NULL,
  `right5` varchar(45) DEFAULT NULL,
  `enzymes` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_reactions: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("sequence"), DataType(MySqlDbType.VarChar, "45")> Public Property sequence As String
    <DatabaseField("left1"), DataType(MySqlDbType.VarChar, "45")> Public Property left1 As String
    <DatabaseField("left2"), DataType(MySqlDbType.VarChar, "45")> Public Property left2 As String
    <DatabaseField("left3"), DataType(MySqlDbType.VarChar, "45")> Public Property left3 As String
    <DatabaseField("left4"), DataType(MySqlDbType.VarChar, "45")> Public Property left4 As String
    <DatabaseField("left5"), DataType(MySqlDbType.VarChar, "45")> Public Property left5 As String
    <DatabaseField("right1"), DataType(MySqlDbType.VarChar, "45")> Public Property right1 As String
    <DatabaseField("right2"), DataType(MySqlDbType.VarChar, "45")> Public Property right2 As String
    <DatabaseField("right3"), DataType(MySqlDbType.VarChar, "45")> Public Property right3 As String
    <DatabaseField("right4"), DataType(MySqlDbType.VarChar, "45")> Public Property right4 As String
    <DatabaseField("right5"), DataType(MySqlDbType.VarChar, "45")> Public Property right5 As String
    <DatabaseField("enzymes"), DataType(MySqlDbType.VarChar, "45")> Public Property enzymes As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_reactions` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_reactions` SET `drug`='{0}', `sequence`='{1}', `left1`='{2}', `left2`='{3}', `left3`='{4}', `left4`='{5}', `left5`='{6}', `right1`='{7}', `right2`='{8}', `right3`='{9}', `right4`='{10}', `right5`='{11}', `enzymes`='{12}' WHERE `drug` = '{13}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_reactions` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, sequence, left1, left2, left3, left4, left5, right1, right2, right3, right4, right5, enzymes)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, sequence, left1, left2, left3, left4, left5, right1, right2, right3, right4, right5, enzymes)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_reactions` SET `drug`='{0}', `sequence`='{1}', `left1`='{2}', `left2`='{3}', `left3`='{4}', `left4`='{5}', `left5`='{6}', `right1`='{7}', `right2`='{8}', `right3`='{9}', `right4`='{10}', `right5`='{11}', `enzymes`='{12}' WHERE `drug` = '{13}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, sequence, left1, left2, left3, left4, left5, right1, right2, right3, right4, right5, enzymes, drug)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{drug}', '{sequence}', '{left1}', '{left2}', '{left3}', '{left4}', '{left5}', '{right1}', '{right2}', '{right3}', '{right4}', '{right5}', '{enzymes}')"
End Function

#End Region
End Class


End Namespace
