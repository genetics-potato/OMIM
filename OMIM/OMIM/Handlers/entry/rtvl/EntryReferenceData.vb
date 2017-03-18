Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers.entry

    Public Class EntryReferenceData

    End Class

    Public Class reference
        Public Property mimNumber As String
        Public Property referenceNumber As String
        Public Property authors As String
        Public Property title As String
        Public Property source As String
        Public Property pubmedID As String
        Public Property pubmedCentralID As String
        Public Property articleUrl As String
        Public Property publisherAbbreviation As String
        Public Property publisherName As String
        Public Property publisherUrl As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class referenceList
        Public Property reference As reference
    End Class
End Namespace