Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace XML

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

        End Function
    End Class
End Namespace