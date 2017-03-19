Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON
Imports Microsoft.VisualBasic.Text.Xml

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

        Public Shared Function Load(path$) As Database
            Return path.LoadXml(Of Database)
            '  Dim xml As New XmlDoc(path.ReadAllText)
            '   xml.xmlns.xmlns =
        End Function
    End Class
End Namespace