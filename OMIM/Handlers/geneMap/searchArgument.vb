Imports System.ComponentModel
Imports Microsoft.VisualBasic.Net.Http

Namespace Handlers.geneMap

    Public Class searchArgument

        ''' <summary>
        ''' The search (required)
        ''' </summary>
        ''' <returns></returns>
        Public Property search As String
        ''' <summary>
        ''' The filter (Optional)
        ''' </summary>
        ''' <returns></returns>
        Public Property filter As String
        ''' <summary>
        ''' The fields, defaults To 'default'
        ''' </summary>
        ''' <returns></returns>
        Public Property fields As String = "default"
        ''' <summary>
        ''' The sort order To use, defaults To 'score desc'
        ''' </summary>
        ''' <returns></returns>
        Public Property sort As sorts = sorts.score_desc
        ''' <summary>
        ''' The start offset into the results, Default Is 0
        ''' </summary>
        ''' <returns></returns>
        Public Property start As Integer = 0
        ''' <summary>
        ''' The number Of results To Return, Default Is 10
        ''' </summary>
        ''' <returns></returns>
        Public Property limit As Integer = 10

        ''' <summary>
        ''' The 'sort' parameter takes the any of the search fields available in the gene map index, some useful sort orders include:
        ''' </summary>
        Public Enum sorts

            ''' <summary>
            ''' For descending score order
            ''' </summary>
            <Description("score desc")>
            score_desc

            ''' <summary>
            ''' For ascending chromosome number order
            ''' </summary>
            <Description("chromosome_number asc")>
            chromosome_number_asc

            ''' <summary>
            ''' For ascending chromosome number order, And chromosome location start order
            ''' </summary>
            <Description("chromosome_number asc, chromosome_location_start asc")>
            chromosome_number_asc_chromosome_location_start_asc
        End Enum

        Public Overrides Function ToString() As String
            Return Me.BuildParameters
        End Function
    End Class
End Namespace