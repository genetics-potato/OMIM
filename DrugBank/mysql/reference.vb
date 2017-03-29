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
''' DROP TABLE IF EXISTS `reference`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `reference` (
'''   `type` int(11) NOT NULL COMMENT '1. article\n2. textbook\n3. link',
'''   `id` varchar(45) DEFAULT NULL COMMENT 'article -> pubmedID\ntextbook -> isbn\nlink -> url',
'''   `title` varchar(45) DEFAULT NULL COMMENT 'article, textbook -> citation\nlink -> title',
'''   PRIMARY KEY (`type`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `reference`
''' --
''' 
''' LOCK TABLES `reference` WRITE;
''' /*!40000 ALTER TABLE `reference` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `reference` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("reference", Database:="drugbank", SchemaSQL:="
CREATE TABLE `reference` (
  `type` int(11) NOT NULL COMMENT '1. article\n2. textbook\n3. link',
  `id` varchar(45) DEFAULT NULL COMMENT 'article -> pubmedID\ntextbook -> isbn\nlink -> url',
  `title` varchar(45) DEFAULT NULL COMMENT 'article, textbook -> citation\nlink -> title',
  PRIMARY KEY (`type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class reference: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' 1. article\n2. textbook\n3. link
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("type"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property type As Long
''' <summary>
''' article -> pubmedID\ntextbook -> isbn\nlink -> url
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("id"), DataType(MySqlDbType.VarChar, "45")> Public Property id As String
''' <summary>
''' article, textbook -> citation\nlink -> title
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("title"), DataType(MySqlDbType.VarChar, "45")> Public Property title As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `reference` (`type`, `id`, `title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `reference` (`type`, `id`, `title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `reference` WHERE `type` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `reference` SET `type`='{0}', `id`='{1}', `title`='{2}' WHERE `type` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `reference` WHERE `type` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, type)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `reference` (`type`, `id`, `title`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, type, id, title)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `reference` (`type`, `id`, `title`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, type, id, title)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `reference` SET `type`='{0}', `id`='{1}', `title`='{2}' WHERE `type` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, type, id, title, type)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{type}', '{id}', '{title}')"
End Function

#End Region
End Class


End Namespace
