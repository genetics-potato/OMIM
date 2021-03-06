REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/10/24 11:04:04


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `polypeptide_synonyms`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `polypeptide_synonyms` (
'''   `polypeptide` varchar(45) NOT NULL,
'''   `synonym1` varchar(45) DEFAULT NULL,
'''   `synonym2` varchar(45) DEFAULT NULL,
'''   `synonym3` varchar(45) DEFAULT NULL,
'''   `synonym4` varchar(45) DEFAULT NULL,
'''   `synonym5` varchar(45) DEFAULT NULL,
'''   `synonym6` varchar(45) DEFAULT NULL,
'''   `synonym7` varchar(45) DEFAULT NULL,
'''   `synonym8` varchar(45) DEFAULT NULL,
'''   `synonym9` varchar(45) DEFAULT NULL,
'''   `synonym10` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("polypeptide_synonyms", Database:="drugbank", SchemaSQL:="
CREATE TABLE `polypeptide_synonyms` (
  `polypeptide` varchar(45) NOT NULL,
  `synonym1` varchar(45) DEFAULT NULL,
  `synonym2` varchar(45) DEFAULT NULL,
  `synonym3` varchar(45) DEFAULT NULL,
  `synonym4` varchar(45) DEFAULT NULL,
  `synonym5` varchar(45) DEFAULT NULL,
  `synonym6` varchar(45) DEFAULT NULL,
  `synonym7` varchar(45) DEFAULT NULL,
  `synonym8` varchar(45) DEFAULT NULL,
  `synonym9` varchar(45) DEFAULT NULL,
  `synonym10` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class polypeptide_synonyms: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("polypeptide"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="polypeptide")> Public Property polypeptide As String
    <DatabaseField("synonym1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym1")> Public Property synonym1 As String
    <DatabaseField("synonym2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym2")> Public Property synonym2 As String
    <DatabaseField("synonym3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym3")> Public Property synonym3 As String
    <DatabaseField("synonym4"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym4")> Public Property synonym4 As String
    <DatabaseField("synonym5"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym5")> Public Property synonym5 As String
    <DatabaseField("synonym6"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym6")> Public Property synonym6 As String
    <DatabaseField("synonym7"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym7")> Public Property synonym7 As String
    <DatabaseField("synonym8"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym8")> Public Property synonym8 As String
    <DatabaseField("synonym9"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym9")> Public Property synonym9 As String
    <DatabaseField("synonym10"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym10")> Public Property synonym10 As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `polypeptide_synonyms` (`polypeptide`, `synonym1`, `synonym2`, `synonym3`, `synonym4`, `synonym5`, `synonym6`, `synonym7`, `synonym8`, `synonym9`, `synonym10`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `polypeptide_synonyms` (`polypeptide`, `synonym1`, `synonym2`, `synonym3`, `synonym4`, `synonym5`, `synonym6`, `synonym7`, `synonym8`, `synonym9`, `synonym10`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `polypeptide_synonyms` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `polypeptide_synonyms` SET `polypeptide`='{0}', `synonym1`='{1}', `synonym2`='{2}', `synonym3`='{3}', `synonym4`='{4}', `synonym5`='{5}', `synonym6`='{6}', `synonym7`='{7}', `synonym8`='{8}', `synonym9`='{9}', `synonym10`='{10}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `polypeptide_synonyms` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `polypeptide_synonyms` (`polypeptide`, `synonym1`, `synonym2`, `synonym3`, `synonym4`, `synonym5`, `synonym6`, `synonym7`, `synonym8`, `synonym9`, `synonym10`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, polypeptide, synonym1, synonym2, synonym3, synonym4, synonym5, synonym6, synonym7, synonym8, synonym9, synonym10)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{polypeptide}', '{synonym1}', '{synonym2}', '{synonym3}', '{synonym4}', '{synonym5}', '{synonym6}', '{synonym7}', '{synonym8}', '{synonym9}', '{synonym10}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `polypeptide_synonyms` (`polypeptide`, `synonym1`, `synonym2`, `synonym3`, `synonym4`, `synonym5`, `synonym6`, `synonym7`, `synonym8`, `synonym9`, `synonym10`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, polypeptide, synonym1, synonym2, synonym3, synonym4, synonym5, synonym6, synonym7, synonym8, synonym9, synonym10)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `polypeptide_synonyms` SET `polypeptide`='{0}', `synonym1`='{1}', `synonym2`='{2}', `synonym3`='{3}', `synonym4`='{4}', `synonym5`='{5}', `synonym6`='{6}', `synonym7`='{7}', `synonym8`='{8}', `synonym9`='{9}', `synonym10`='{10}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As polypeptide_synonyms
                  Return DirectCast(MyClass.MemberwiseClone, polypeptide_synonyms)
              End Function
End Class


End Namespace
