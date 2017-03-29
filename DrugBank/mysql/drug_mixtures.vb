REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/29 14:14:01


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_mixtures`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_mixtures` (
'''   `drug` varchar(45) NOT NULL,
'''   `mixture_name` varchar(45) DEFAULT NULL,
'''   `ingredients` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_mixtures", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_mixtures` (
  `drug` varchar(45) NOT NULL,
  `mixture_name` varchar(45) DEFAULT NULL,
  `ingredients` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_mixtures: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45")> Public Property drug As String
    <DatabaseField("mixture_name"), DataType(MySqlDbType.VarChar, "45")> Public Property mixture_name As String
    <DatabaseField("ingredients"), DataType(MySqlDbType.VarChar, "45")> Public Property ingredients As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_mixtures` (`drug`, `mixture_name`, `ingredients`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_mixtures` (`drug`, `mixture_name`, `ingredients`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_mixtures` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_mixtures` SET `drug`='{0}', `mixture_name`='{1}', `ingredients`='{2}' WHERE `drug` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_mixtures` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_mixtures` (`drug`, `mixture_name`, `ingredients`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, mixture_name, ingredients)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{mixture_name}', '{ingredients}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_mixtures` (`drug`, `mixture_name`, `ingredients`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, mixture_name, ingredients)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_mixtures` SET `drug`='{0}', `mixture_name`='{1}', `ingredients`='{2}' WHERE `drug` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, mixture_name, ingredients, drug)
    End Function
#End Region
End Class


End Namespace
