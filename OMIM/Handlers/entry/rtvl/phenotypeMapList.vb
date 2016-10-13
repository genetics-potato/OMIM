Namespace Handlers.entry

    Public Class phenotypeMapList

        Public Property phenotypeMap As phenotypeMap
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
        ''' <summary>
        ''' Gene map sequence ID
        ''' </summary>
        ''' <returns></returns>
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
        ''' <summary>
        ''' Comma delimited list Of symbols
        ''' </summary>
        ''' <returns></returns>
        Public Property geneSymbols As String
        Public Property geneInheritance As String
    End Class
End Namespace