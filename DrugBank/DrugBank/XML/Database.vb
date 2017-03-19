Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON
Imports Microsoft.VisualBasic.Text.Xml

Namespace XML

    <XmlRoot("drugbank", [Namespace]:="http://www.drugbank.ca")>
    Public Class Database

        <XmlAttribute>
        Public Property version As String
        <XmlAttribute("exported-on")>
        Public Property exportedOn As String
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