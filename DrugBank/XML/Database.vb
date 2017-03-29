Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON
Imports Microsoft.VisualBasic.Text.Xml.Linq

Namespace XML

    ''' <summary>
    ''' This is the root element for the DrugBank database schema. DrugBank is a database on drug and drug-targets.
    ''' </summary>
    <XmlRoot("drugbank", [Namespace]:="http://www.drugbank.ca")>
    Public Class Database

        ''' <summary>
        ''' The DrugBank version for the exported XML file.
        ''' </summary>
        ''' <returns></returns>
        <XmlAttribute>
        Public Property version As String
        ''' <summary>
        ''' The date the XML file was exported.
        ''' </summary>
        ''' <returns></returns>
        <XmlAttribute("exported-on")>
        Public Property exportedOn As Date
        <XmlElement("drug")>
        Public Property drugs As Drug()

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function

        ''' <summary>
        ''' 采用迭代器的方式加载drugbank_all_full_database.xml
        ''' </summary>
        ''' <param name="path$"></param>
        ''' <returns></returns>
        Public Shared Function Load(path$) As IEnumerable(Of Drug)
            Return path.LoadXmlDataSet(Of Drug)("drug", xmlns:="http://www.drugbank.ca")
        End Function
    End Class
End Namespace