Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers.geneMap

    Public Class rtvl

        Public Property listResponse As GeneMapData()

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    ''' <summary>
    ''' Gene Map Data
    ''' </summary>
    Public Class GeneMapData

        ''' <summary>
        ''' 1-24
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosome As String
        ''' <summary>
        ''' 1-22, X, Y
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosomeSymbol As String
        Public Property totalResults As String
        Public Property startIndex As String
        Public Property endIndex As String
        Public Property geneMapList As geneMap()
    End Class

    Public Class geneMap

        Public Property sequenceID As String
        ''' <summary>
        ''' 1-24
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosome As String
        ''' <summary>
        ''' 1-22, X, Y
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosomeSymbol As String
        Public Property chromosomeSort As String
        ''' <summary>
        ''' (if available)
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosomeLocationStart As String
        ''' <summary>
        ''' (if available)
        ''' </summary>
        ''' <returns></returns>
        Public Property chromosomeLocationEnd As String
        ''' <summary>
        ''' (if available)
        ''' </summary>
        ''' <returns></returns>
        Public Property transcript As String
        Public Property cytoLocation As String
        ''' <summary>
        ''' (if available)
        ''' </summary>
        ''' <returns></returns>
        Public Property computedCytoLocation As String
        Public Property mimNumber As String
        ''' <summary>
        ''' Comma delimited list Of symbols
        ''' </summary>
        ''' <returns></returns>
        Public Property geneSymbols As String
        Public Property geneName As String
        Public Property mappingMethod As String
        Public Property confidence As String
        Public Property references As String
        Public Property comments As String
        Public Property mouseGeneSymbol As String
        Public Property mouseMgiID As String
        Public Property geneInheritance As String
        Public Property phenotypeMapList As phenotypeMap()
    End Class

    Public Class phenotypeMap
        Public Property mimNumber As String
        Public Property phenotype As String
        Public Property phenotypeMimNumber As String
        ''' <summary>
        ''' Comma delimited list Of phenotypic series numbers
        ''' </summary>
        ''' <returns></returns>
        Public Property phenotypicSeriesNumber As String
        Public Property phenotypeMappingKey As String
        Public Property phenotypeInheritance As String
    End Class
End Namespace