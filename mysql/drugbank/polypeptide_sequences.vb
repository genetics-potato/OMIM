REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/29 11:18:52


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' polypeptide sequence data and function annotations
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `polypeptide_sequences`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `polypeptide_sequences` (
'''   `polypeptide` int(11) NOT NULL,
'''   `aa` varchar(45) DEFAULT NULL,
'''   `nt` varchar(45) DEFAULT NULL,
'''   `pfam` varchar(45) DEFAULT NULL COMMENT 'pfam ID list, using ; character as the delimiter',
'''   `go_bp` varchar(45) DEFAULT NULL,
'''   `go_cc` varchar(45) DEFAULT NULL,
'''   `go_mf` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`polypeptide`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='polypeptide sequence data and function annotations';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `polypeptide_sequences`
''' --
''' 
''' LOCK TABLES `polypeptide_sequences` WRITE;
''' /*!40000 ALTER TABLE `polypeptide_sequences` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `polypeptide_sequences` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("polypeptide_sequences", Database:="drugbank", SchemaSQL:="
CREATE TABLE `polypeptide_sequences` (
  `polypeptide` int(11) NOT NULL,
  `aa` varchar(45) DEFAULT NULL,
  `nt` varchar(45) DEFAULT NULL,
  `pfam` varchar(45) DEFAULT NULL COMMENT 'pfam ID list, using ; character as the delimiter',
  `go_bp` varchar(45) DEFAULT NULL,
  `go_cc` varchar(45) DEFAULT NULL,
  `go_mf` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`polypeptide`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='polypeptide sequence data and function annotations';")>
Public Class polypeptide_sequences: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("polypeptide"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property polypeptide As Long
    <DatabaseField("aa"), DataType(MySqlDbType.VarChar, "45")> Public Property aa As String
    <DatabaseField("nt"), DataType(MySqlDbType.VarChar, "45")> Public Property nt As String
''' <summary>
''' pfam ID list, using ; character as the delimiter
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("pfam"), DataType(MySqlDbType.VarChar, "45")> Public Property pfam As String
    <DatabaseField("go_bp"), DataType(MySqlDbType.VarChar, "45")> Public Property go_bp As String
    <DatabaseField("go_cc"), DataType(MySqlDbType.VarChar, "45")> Public Property go_cc As String
    <DatabaseField("go_mf"), DataType(MySqlDbType.VarChar, "45")> Public Property go_mf As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `polypeptide_sequences` WHERE `polypeptide` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `polypeptide_sequences` SET `polypeptide`='{0}', `aa`='{1}', `nt`='{2}', `pfam`='{3}', `go_bp`='{4}', `go_cc`='{5}', `go_mf`='{6}' WHERE `polypeptide` = '{7}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `polypeptide_sequences` WHERE `polypeptide` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, polypeptide)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, polypeptide, aa, nt, pfam, go_bp, go_cc, go_mf)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, polypeptide, aa, nt, pfam, go_bp, go_cc, go_mf)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `polypeptide_sequences` SET `polypeptide`='{0}', `aa`='{1}', `nt`='{2}', `pfam`='{3}', `go_bp`='{4}', `go_cc`='{5}', `go_mf`='{6}' WHERE `polypeptide` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, polypeptide, aa, nt, pfam, go_bp, go_cc, go_mf, polypeptide)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{polypeptide}', '{aa}', '{nt}', '{pfam}', '{go_bp}', '{go_cc}', '{go_mf}')"
End Function

#End Region
End Class


End Namespace
