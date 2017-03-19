Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace XML

    Public Class references

        ''' <summary>
        ''' Articles are typically PubMed references, although there are some references which do not have a PubMed ID.
        ''' </summary>
        ''' <returns></returns>
        Public Property articles As article()
        Public Property links As link()
        Public Property textbooks As textbook()

    End Class

    Public Class article

        <XmlElement("pubmed-id")>
        Public Property pubmedID As String
        Public Property citation As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class textbook
        Public Property isbn As String
        Public Property citation As String
    End Class

    Public Class link
        Public Property title As String
        Public Property url As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace