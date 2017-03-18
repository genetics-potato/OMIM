Imports System.ComponentModel
Imports Microsoft.VisualBasic.Language

Namespace Handlers.search

    ''' <summary>
    ''' Model for builds the search url parameters
    ''' </summary>
    Public Class searchQuery : Inherits IQuery

#Region "Generics parameter"

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
        ''' The fields, defaults To 'number^5 title^3 default'
        ''' </summary>
        ''' <returns></returns>
        Public Property fields As String
        ''' <summary>
        ''' The sort order To use, defaults To 'score desc'
        ''' </summary>
        ''' <returns></returns>
        Public Property sort As sorts
        ''' <summary>
        ''' The start offset into the results, Default Is 0
        ''' </summary>
        ''' <returns></returns>
        Public Property start As Integer
        ''' <summary>
        ''' The number Of results To Return, Default Is 10
        ''' </summary>
        ''' <returns></returns>
        Public Property limit As Integer = 10
#End Region

        ''' <summary>
        ''' To retrieve the gene map Or clinical synopses corresponding to the entries instead of the entries themselves
        ''' </summary>
        ''' <returns></returns>
        Public Property retrieve As retrieves = retrieves.null

        ''' <summary>
        ''' Only allowed ``<see cref="API.Handlers.entry"/>``, ``<see cref="API.Handlers.geneMap"/>``, and ``<see cref="API.Handlers.clinicalSynopsis"/>``
        ''' </summary>
        ''' <returns></returns>
        Public Overrides ReadOnly Property handler As API.Handlers

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="handler">
        ''' Only allowed ``<see cref="API.Handlers.entry"/>``, 
        ''' ``<see cref="API.Handlers.geneMap"/>``, and 
        ''' ``<see cref="API.Handlers.clinicalSynopsis"/>``
        ''' </param>
        Sub New(handler As API.Handlers)
            _handler = handler
        End Sub

        ''' <summary>
        ''' Generates the url parameter
        ''' </summary>
        ''' <returns></returns>
        Public Overrides Function ToString() As String
            Dim args As New List(Of String)

            If Not String.IsNullOrEmpty(search) Then args += $"search={UrlEncode(search)}"
            If Not String.IsNullOrEmpty(filter) Then args += $"filter={UrlEncode(filter)}"
            If Not String.IsNullOrEmpty(fields) Then args += $"fields={UrlEncode(fields)}"
            If sort <> sorts.null Then args += $"sort={sort.ToString}"
            If start <> 0 Then args += $"start={start}"
            If limit <> 0 AndAlso limit <> 10 Then args += $"limit={limit}"

            If Handler = API.Handlers.entry AndAlso retrieve <> retrieves.null Then args += $"retrieve={retrieve.ToString}"

            Return args.JoinBy("&")
        End Function
    End Class

    Public Enum retrieves
        null
        ''' <summary>
        ''' To retrieve the corresponding gene map
        ''' </summary>
        geneMap
        ''' <summary>
        ''' To retrieve the corresponding clinical synopses
        ''' </summary>
        clinicalSynopsis
    End Enum

    ''' <summary>
    ''' The 'sort' parameter takes the any of the search fields available in the entry index
    ''' </summary>
    Public Enum sorts

        ''' <summary>
        ''' No sort action
        ''' </summary>
        null

        ''' <summary>
        ''' [*] For descending score order
        ''' </summary>
        <Description("score+desc")> score_desc
        ''' <summary>
        ''' For descending score order, And descending prefix sort order
        ''' </summary>
        <Description("score+desc,prefix_sort+desc")> prefix_sort_desc
        ''' <summary>
        ''' For descending Date created order
        ''' </summary>
        <Description("date_created+desc")> date_created_desc
        ''' <summary>
        ''' For ascending Date created order
        ''' </summary>
        <Description("date_created+asc")> date_created_asc
        ''' <summary>
        ''' For descending Date updated order
        ''' </summary>
        <Description("date_updated+desc")> date_updated_desc
        ''' <summary>
        ''' For ascending Date updated order
        ''' </summary>
        <Description("date_updated+asc")> date_updated_asc

#Region "geneMap options"
        ''' <summary>
        ''' (geneMap options) For ascending chromosome number order
        ''' </summary>
        <Description("chromosome_number+asc")> chromosome_number_asc
        ''' <summary>
        ''' (geneMap options) For ascending chromosome number order, And chromosome location start order
        ''' </summary>
        <Description("chromosome_location_start+asc")> chromosome_location_start_asc
#End Region
    End Enum
End Namespace