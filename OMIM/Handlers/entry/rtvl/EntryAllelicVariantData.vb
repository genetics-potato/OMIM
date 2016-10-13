Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers.entry

    Public Class EntryAllelicVariantData
        Public Property prefix As String
        Public Property mimNumber As String
        Public Property preferredTitle As String
        Public Property number As String
        ''' <summary>
        ''' 'live', 'moved', 'removed'
        ''' </summary>
        ''' <returns></returns>
        Public Property status As String
        ''' <summary>
        ''' Will be Set To the target entry mim number If this was moved
        ''' </summary>
        ''' <returns></returns>
        Public Property movedTo As String
        Public Property name As String
        Public Property alternativeNames As String
        Public Property mutations As String
        Public Property text As String
        ''' <summary>
        ''' comma-delimited list Of dbSNPs
        ''' </summary>
        ''' <returns></returns>
        Public Property dbSNPs As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace