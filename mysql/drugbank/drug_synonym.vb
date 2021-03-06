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
''' DROP TABLE IF EXISTS `drug_synonym`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_synonym` (
'''   `drug` varchar(45) NOT NULL,
'''   `synonym` varchar(45) DEFAULT NULL,
'''   `language` varchar(45) DEFAULT NULL,
'''   `coder` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_synonym", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_synonym` (
  `drug` varchar(45) NOT NULL,
  `synonym` varchar(45) DEFAULT NULL,
  `language` varchar(45) DEFAULT NULL,
  `coder` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_synonym: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("synonym"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synonym")> Public Property synonym As String
    <DatabaseField("language"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="language")> Public Property language As String
    <DatabaseField("coder"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="coder")> Public Property coder As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_synonym` (`drug`, `synonym`, `language`, `coder`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_synonym` (`drug`, `synonym`, `language`, `coder`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_synonym` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_synonym` SET `drug`='{0}', `synonym`='{1}', `language`='{2}', `coder`='{3}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_synonym` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_synonym` (`drug`, `synonym`, `language`, `coder`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, synonym, language, coder)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{synonym}', '{language}', '{coder}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_synonym` (`drug`, `synonym`, `language`, `coder`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, synonym, language, coder)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_synonym` SET `drug`='{0}', `synonym`='{1}', `language`='{2}', `coder`='{3}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_synonym
                  Return DirectCast(MyClass.MemberwiseClone, drug_synonym)
              End Function
End Class


End Namespace
