Imports System.Text
Imports Microsoft.VisualBasic

Namespace Handlers.geneMap

    ''' <summary>
    ''' 通过编号来查询
    ''' </summary>
    Public Class geneMapEntryQuery : Inherits IQuery

        ''' <summary>
        ''' The mim number.
        ''' </summary>
        ''' <returns></returns>
        Public Property mimNumber As List(Of String)

        Public Overrides ReadOnly Property handler As API.Handlers
            Get
                Return API.Handlers.geneMap
            End Get
        End Property

        Sub New(ParamArray entry As String())
            mimNumber = New List(Of String)(entry)
        End Sub

        Public Overrides Function ToString() As String
            Return __mimValue(mimNumber)
        End Function
    End Class

    Public Class geneMapQuery : Inherits IQuery

        ''' <summary>
        ''' The sequence ID In the gene map (these are sequential Integer values With no breaks And are Not stable beyond the scope Of a day).
        ''' </summary>
        ''' <returns></returns>
        Public Property sequenceID As String
        ''' <summary>
        ''' The chromosome, 1-22, 23 (X), 24 (Y), 25 (M), X, Y, M (mitochondria), A (autosomal group), S (XY group)
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosome As String
        ''' <summary>
        ''' The chromosome sort In the chromosome (these are sequential Integer values With no breaks And are Not stable beyond the scope Of a day).
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosomeSort As String
        ''' <summary>
        ''' The start offset into the gene map, Default Is 0 (can be negative When getting a list from a sequence ID
        ''' </summary>
        ''' <returns></returns>
        Public Property start As Integer
        ''' <summary>
        ''' The number Of entries To Return, Default Is 10
        ''' </summary>
        ''' <returns></returns>
        Public Property limit As Integer
        ''' <summary>
        ''' 'true' will only return entries with phenotypes, 'false' will only return entries without phenotypes
        ''' </summary>
        ''' <returns></returns>
        Public Property phenotypeExists As Boolean

        Public Overrides ReadOnly Property handler As API.Handlers
            Get
                Return API.Handlers.geneMap
            End Get
        End Property

        Public Overrides Function ToString() As String
            Dim args As New List(Of String)

            If Not String.IsNullOrEmpty(sequenceID) Then args += $"sequenceID={sequenceID}"
            If Not String.IsNullOrEmpty(chromosome) Then args += $"chromosome={chromosome}"
            If Not String.IsNullOrEmpty(chromosomeSort) Then args += $"chromosomeSort={chromosomeSort}"
            If start <> 0 Then args += $"start={start}"
            If limit <> 0 Then args += $"limit={limit}"
            If phenotypeExists Then args += $"phenotypeExists=true"

            Return args.JoinBy("&")
        End Function
    End Class
End Namespace