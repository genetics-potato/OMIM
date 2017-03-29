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
''' DROP TABLE IF EXISTS `drug_products`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_products` (
'''   `drug` int(11) NOT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `labeller` varchar(45) DEFAULT NULL,
'''   `ndc_id` varchar(45) DEFAULT NULL,
'''   `ndc_product_code` varchar(45) DEFAULT NULL,
'''   `dpd_id` varchar(45) DEFAULT NULL,
'''   `start_marketing_on` varchar(45) DEFAULT NULL,
'''   `ended_marketting_on` varchar(45) DEFAULT NULL,
'''   `dosage_form` varchar(45) DEFAULT NULL,
'''   `strength` varchar(45) DEFAULT NULL,
'''   `route` varchar(45) DEFAULT NULL,
'''   `fda_application_number` varchar(45) DEFAULT NULL,
'''   `generic` varchar(45) DEFAULT NULL,
'''   `over_the_counter` varchar(45) DEFAULT NULL,
'''   `approved` varchar(45) DEFAULT NULL,
'''   `country` varchar(45) DEFAULT NULL,
'''   `source` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_products`
''' --
''' 
''' LOCK TABLES `drug_products` WRITE;
''' /*!40000 ALTER TABLE `drug_products` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_products` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_products", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_products` (
  `drug` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `labeller` varchar(45) DEFAULT NULL,
  `ndc_id` varchar(45) DEFAULT NULL,
  `ndc_product_code` varchar(45) DEFAULT NULL,
  `dpd_id` varchar(45) DEFAULT NULL,
  `start_marketing_on` varchar(45) DEFAULT NULL,
  `ended_marketting_on` varchar(45) DEFAULT NULL,
  `dosage_form` varchar(45) DEFAULT NULL,
  `strength` varchar(45) DEFAULT NULL,
  `route` varchar(45) DEFAULT NULL,
  `fda_application_number` varchar(45) DEFAULT NULL,
  `generic` varchar(45) DEFAULT NULL,
  `over_the_counter` varchar(45) DEFAULT NULL,
  `approved` varchar(45) DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_products: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45")> Public Property name As String
    <DatabaseField("labeller"), DataType(MySqlDbType.VarChar, "45")> Public Property labeller As String
    <DatabaseField("ndc_id"), DataType(MySqlDbType.VarChar, "45")> Public Property ndc_id As String
    <DatabaseField("ndc_product_code"), DataType(MySqlDbType.VarChar, "45")> Public Property ndc_product_code As String
    <DatabaseField("dpd_id"), DataType(MySqlDbType.VarChar, "45")> Public Property dpd_id As String
    <DatabaseField("start_marketing_on"), DataType(MySqlDbType.VarChar, "45")> Public Property start_marketing_on As String
    <DatabaseField("ended_marketting_on"), DataType(MySqlDbType.VarChar, "45")> Public Property ended_marketting_on As String
    <DatabaseField("dosage_form"), DataType(MySqlDbType.VarChar, "45")> Public Property dosage_form As String
    <DatabaseField("strength"), DataType(MySqlDbType.VarChar, "45")> Public Property strength As String
    <DatabaseField("route"), DataType(MySqlDbType.VarChar, "45")> Public Property route As String
    <DatabaseField("fda_application_number"), DataType(MySqlDbType.VarChar, "45")> Public Property fda_application_number As String
    <DatabaseField("generic"), DataType(MySqlDbType.VarChar, "45")> Public Property generic As String
    <DatabaseField("over_the_counter"), DataType(MySqlDbType.VarChar, "45")> Public Property over_the_counter As String
    <DatabaseField("approved"), DataType(MySqlDbType.VarChar, "45")> Public Property approved As String
    <DatabaseField("country"), DataType(MySqlDbType.VarChar, "45")> Public Property country As String
    <DatabaseField("source"), DataType(MySqlDbType.VarChar, "45")> Public Property source As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_products` (`drug`, `name`, `labeller`, `ndc_id`, `ndc_product_code`, `dpd_id`, `start_marketing_on`, `ended_marketting_on`, `dosage_form`, `strength`, `route`, `fda_application_number`, `generic`, `over_the_counter`, `approved`, `country`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_products` (`drug`, `name`, `labeller`, `ndc_id`, `ndc_product_code`, `dpd_id`, `start_marketing_on`, `ended_marketting_on`, `dosage_form`, `strength`, `route`, `fda_application_number`, `generic`, `over_the_counter`, `approved`, `country`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_products` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_products` SET `drug`='{0}', `name`='{1}', `labeller`='{2}', `ndc_id`='{3}', `ndc_product_code`='{4}', `dpd_id`='{5}', `start_marketing_on`='{6}', `ended_marketting_on`='{7}', `dosage_form`='{8}', `strength`='{9}', `route`='{10}', `fda_application_number`='{11}', `generic`='{12}', `over_the_counter`='{13}', `approved`='{14}', `country`='{15}', `source`='{16}' WHERE `drug` = '{17}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_products` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_products` (`drug`, `name`, `labeller`, `ndc_id`, `ndc_product_code`, `dpd_id`, `start_marketing_on`, `ended_marketting_on`, `dosage_form`, `strength`, `route`, `fda_application_number`, `generic`, `over_the_counter`, `approved`, `country`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, name, labeller, ndc_id, ndc_product_code, dpd_id, start_marketing_on, ended_marketting_on, dosage_form, strength, route, fda_application_number, generic, over_the_counter, approved, country, source)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_products` (`drug`, `name`, `labeller`, `ndc_id`, `ndc_product_code`, `dpd_id`, `start_marketing_on`, `ended_marketting_on`, `dosage_form`, `strength`, `route`, `fda_application_number`, `generic`, `over_the_counter`, `approved`, `country`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, name, labeller, ndc_id, ndc_product_code, dpd_id, start_marketing_on, ended_marketting_on, dosage_form, strength, route, fda_application_number, generic, over_the_counter, approved, country, source)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_products` SET `drug`='{0}', `name`='{1}', `labeller`='{2}', `ndc_id`='{3}', `ndc_product_code`='{4}', `dpd_id`='{5}', `start_marketing_on`='{6}', `ended_marketting_on`='{7}', `dosage_form`='{8}', `strength`='{9}', `route`='{10}', `fda_application_number`='{11}', `generic`='{12}', `over_the_counter`='{13}', `approved`='{14}', `country`='{15}', `source`='{16}' WHERE `drug` = '{17}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, name, labeller, ndc_id, ndc_product_code, dpd_id, start_marketing_on, ended_marketting_on, dosage_form, strength, route, fda_application_number, generic, over_the_counter, approved, country, source, drug)
    End Function
Public Overrides Function GetDumpInsertValue() As String
Return $"('{drug}', '{name}', '{labeller}', '{ndc_id}', '{ndc_product_code}', '{dpd_id}', '{start_marketing_on}', '{ended_marketting_on}', '{dosage_form}', '{strength}', '{route}', '{fda_application_number}', '{generic}', '{over_the_counter}', '{approved}', '{country}', '{source}')"
End Function

#End Region
End Class


End Namespace
