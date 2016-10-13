Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers.search

    Public Class searchResponse(Of T)
        Public Property search As String
        Public Property expandedSearch As String
        Public Property parsedSearch As String
        Public Property searchSuggestion As String
        Public Property searchSpelling As String
        Public Property filter As String
        Public Property expandedFilter As String
        Public Property fields As String
        Public Property searchReport As String
        Public Property totalResults As String
        Public Property startIndex As String
        Public Property endIndex As String
        Public Property sort As String
        Public Property searchTime As String
        ''' <summary>
        ''' List of enty/clinicalSynopsis/geneMap/phenotypeMap
        ''' </summary>
        ''' <returns></returns>
        Public Property List As T

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace