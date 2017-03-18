Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers.entry

    Public Class value

        <XmlAttribute> Public Property version As String
        Public Property entryList As entryList()

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class entryList
        Public Property entry As EntryData
    End Class
End Namespace