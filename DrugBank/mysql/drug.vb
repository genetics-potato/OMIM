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
''' DROP TABLE IF EXISTS `drug`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug` (
'''   `primaryID` varchar(45) NOT NULL COMMENT 'drugbank-id primary',
'''   `other_IDs` varchar(45) DEFAULT NULL COMMENT 'drugbank-id',
'''   `type` char(45) DEFAULT NULL,
'''   `created` varchar(45) DEFAULT NULL,
'''   `updated` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `description` varchar(45) DEFAULT NULL,
'''   `cas_number` varchar(45) DEFAULT NULL,
'''   `unii` varchar(45) DEFAULT NULL,
'''   `average_mass` varchar(45) DEFAULT NULL,
'''   `monoisotopic_Mass` varchar(45) DEFAULT NULL,
'''   `state` varchar(45) DEFAULT NULL,
'''   `synthesisReferences` varchar(45) DEFAULT NULL,
'''   `indication` varchar(45) DEFAULT NULL,
'''   `pharmacodynamics` varchar(45) DEFAULT NULL,
'''   `mechanism_of_action` varchar(45) DEFAULT NULL,
'''   `toxicity` varchar(45) DEFAULT NULL,
'''   `metabolism` varchar(45) DEFAULT NULL,
'''   `absorption` varchar(45) DEFAULT NULL,
'''   `halfLife` varchar(45) DEFAULT NULL,
'''   `route_of_elimination` varchar(45) DEFAULT NULL,
'''   `volume_of_distribution` varchar(45) DEFAULT NULL,
'''   `clearance` varchar(45) DEFAULT NULL,
'''   `fdaLabel` varchar(45) DEFAULT NULL,
'''   `msds` varchar(45) DEFAULT NULL,
'''   `references` varchar(45) DEFAULT NULL,
'''   `pdb_entry` varchar(45) DEFAULT NULL COMMENT 'pdb database entry list, using ; character as delimiter'
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug` (
  `primaryID` varchar(45) NOT NULL COMMENT 'drugbank-id primary',
  `other_IDs` varchar(45) DEFAULT NULL COMMENT 'drugbank-id',
  `type` char(45) DEFAULT NULL,
  `created` varchar(45) DEFAULT NULL,
  `updated` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `cas_number` varchar(45) DEFAULT NULL,
  `unii` varchar(45) DEFAULT NULL,
  `average_mass` varchar(45) DEFAULT NULL,
  `monoisotopic_Mass` varchar(45) DEFAULT NULL,
  `state` varchar(45) DEFAULT NULL,
  `synthesisReferences` varchar(45) DEFAULT NULL,
  `indication` varchar(45) DEFAULT NULL,
  `pharmacodynamics` varchar(45) DEFAULT NULL,
  `mechanism_of_action` varchar(45) DEFAULT NULL,
  `toxicity` varchar(45) DEFAULT NULL,
  `metabolism` varchar(45) DEFAULT NULL,
  `absorption` varchar(45) DEFAULT NULL,
  `halfLife` varchar(45) DEFAULT NULL,
  `route_of_elimination` varchar(45) DEFAULT NULL,
  `volume_of_distribution` varchar(45) DEFAULT NULL,
  `clearance` varchar(45) DEFAULT NULL,
  `fdaLabel` varchar(45) DEFAULT NULL,
  `msds` varchar(45) DEFAULT NULL,
  `references` varchar(45) DEFAULT NULL,
  `pdb_entry` varchar(45) DEFAULT NULL COMMENT 'pdb database entry list, using ; character as delimiter'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' drugbank-id primary
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("primaryID"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="primaryID")> Public Property primaryID As String
''' <summary>
''' drugbank-id
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("other_IDs"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="other_IDs")> Public Property other_IDs As String
    <DatabaseField("type"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="type")> Public Property type As String
    <DatabaseField("created"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="created")> Public Property created As String
    <DatabaseField("updated"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="updated")> Public Property updated As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
    <DatabaseField("description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="description")> Public Property description As String
    <DatabaseField("cas_number"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="cas_number")> Public Property cas_number As String
    <DatabaseField("unii"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="unii")> Public Property unii As String
    <DatabaseField("average_mass"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="average_mass")> Public Property average_mass As String
    <DatabaseField("monoisotopic_Mass"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="monoisotopic_Mass")> Public Property monoisotopic_Mass As String
    <DatabaseField("state"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="state")> Public Property state As String
    <DatabaseField("synthesisReferences"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="synthesisReferences")> Public Property synthesisReferences As String
    <DatabaseField("indication"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="indication")> Public Property indication As String
    <DatabaseField("pharmacodynamics"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="pharmacodynamics")> Public Property pharmacodynamics As String
    <DatabaseField("mechanism_of_action"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="mechanism_of_action")> Public Property mechanism_of_action As String
    <DatabaseField("toxicity"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="toxicity")> Public Property toxicity As String
    <DatabaseField("metabolism"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="metabolism")> Public Property metabolism As String
    <DatabaseField("absorption"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="absorption")> Public Property absorption As String
    <DatabaseField("halfLife"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="halfLife")> Public Property halfLife As String
    <DatabaseField("route_of_elimination"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="route_of_elimination")> Public Property route_of_elimination As String
    <DatabaseField("volume_of_distribution"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="volume_of_distribution")> Public Property volume_of_distribution As String
    <DatabaseField("clearance"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="clearance")> Public Property clearance As String
    <DatabaseField("fdaLabel"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="fdaLabel")> Public Property fdaLabel As String
    <DatabaseField("msds"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="msds")> Public Property msds As String
    <DatabaseField("references"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="references")> Public Property references As String
    <DatabaseField("pdb_entry"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="pdb_entry")> Public Property pdb_entry As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug` (`primaryID`, `other_IDs`, `type`, `created`, `updated`, `name`, `description`, `cas_number`, `unii`, `average_mass`, `monoisotopic_Mass`, `state`, `synthesisReferences`, `indication`, `pharmacodynamics`, `mechanism_of_action`, `toxicity`, `metabolism`, `absorption`, `halfLife`, `route_of_elimination`, `volume_of_distribution`, `clearance`, `fdaLabel`, `msds`, `references`, `pdb_entry`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug` (`primaryID`, `other_IDs`, `type`, `created`, `updated`, `name`, `description`, `cas_number`, `unii`, `average_mass`, `monoisotopic_Mass`, `state`, `synthesisReferences`, `indication`, `pharmacodynamics`, `mechanism_of_action`, `toxicity`, `metabolism`, `absorption`, `halfLife`, `route_of_elimination`, `volume_of_distribution`, `clearance`, `fdaLabel`, `msds`, `references`, `pdb_entry`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug` SET `primaryID`='{0}', `other_IDs`='{1}', `type`='{2}', `created`='{3}', `updated`='{4}', `name`='{5}', `description`='{6}', `cas_number`='{7}', `unii`='{8}', `average_mass`='{9}', `monoisotopic_Mass`='{10}', `state`='{11}', `synthesisReferences`='{12}', `indication`='{13}', `pharmacodynamics`='{14}', `mechanism_of_action`='{15}', `toxicity`='{16}', `metabolism`='{17}', `absorption`='{18}', `halfLife`='{19}', `route_of_elimination`='{20}', `volume_of_distribution`='{21}', `clearance`='{22}', `fdaLabel`='{23}', `msds`='{24}', `references`='{25}', `pdb_entry`='{26}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug` (`primaryID`, `other_IDs`, `type`, `created`, `updated`, `name`, `description`, `cas_number`, `unii`, `average_mass`, `monoisotopic_Mass`, `state`, `synthesisReferences`, `indication`, `pharmacodynamics`, `mechanism_of_action`, `toxicity`, `metabolism`, `absorption`, `halfLife`, `route_of_elimination`, `volume_of_distribution`, `clearance`, `fdaLabel`, `msds`, `references`, `pdb_entry`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, primaryID, other_IDs, type, created, updated, name, description, cas_number, unii, average_mass, monoisotopic_Mass, state, synthesisReferences, indication, pharmacodynamics, mechanism_of_action, toxicity, metabolism, absorption, halfLife, route_of_elimination, volume_of_distribution, clearance, fdaLabel, msds, references, pdb_entry)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{primaryID}', '{other_IDs}', '{type}', '{created}', '{updated}', '{name}', '{description}', '{cas_number}', '{unii}', '{average_mass}', '{monoisotopic_Mass}', '{state}', '{synthesisReferences}', '{indication}', '{pharmacodynamics}', '{mechanism_of_action}', '{toxicity}', '{metabolism}', '{absorption}', '{halfLife}', '{route_of_elimination}', '{volume_of_distribution}', '{clearance}', '{fdaLabel}', '{msds}', '{references}', '{pdb_entry}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug` (`primaryID`, `other_IDs`, `type`, `created`, `updated`, `name`, `description`, `cas_number`, `unii`, `average_mass`, `monoisotopic_Mass`, `state`, `synthesisReferences`, `indication`, `pharmacodynamics`, `mechanism_of_action`, `toxicity`, `metabolism`, `absorption`, `halfLife`, `route_of_elimination`, `volume_of_distribution`, `clearance`, `fdaLabel`, `msds`, `references`, `pdb_entry`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, primaryID, other_IDs, type, created, updated, name, description, cas_number, unii, average_mass, monoisotopic_Mass, state, synthesisReferences, indication, pharmacodynamics, mechanism_of_action, toxicity, metabolism, absorption, halfLife, route_of_elimination, volume_of_distribution, clearance, fdaLabel, msds, references, pdb_entry)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug` SET `primaryID`='{0}', `other_IDs`='{1}', `type`='{2}', `created`='{3}', `updated`='{4}', `name`='{5}', `description`='{6}', `cas_number`='{7}', `unii`='{8}', `average_mass`='{9}', `monoisotopic_Mass`='{10}', `state`='{11}', `synthesisReferences`='{12}', `indication`='{13}', `pharmacodynamics`='{14}', `mechanism_of_action`='{15}', `toxicity`='{16}', `metabolism`='{17}', `absorption`='{18}', `halfLife`='{19}', `route_of_elimination`='{20}', `volume_of_distribution`='{21}', `clearance`='{22}', `fdaLabel`='{23}', `msds`='{24}', `references`='{25}', `pdb_entry`='{26}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug
                  Return DirectCast(MyClass.MemberwiseClone, drug)
              End Function
End Class


End Namespace
