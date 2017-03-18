Imports Microsoft.VisualBasic.Serialization.JSON

Namespace DataFiles

    Public Class genemap2
        Public Property Chromosome As String
        Public Property GenomicPositionStart As String
        Public Property GenomicPositionEnd As String
        Public Property CytoLocation As String
        Public Property ComputedCytoLocation As String
        Public Property MimNumber As String
        Public Property GeneSymbols As String
        Public Property GeneName As String
        Public Property ApprovedSymbol As String
        Public Property EntrezGeneID As String
        Public Property EnsemblGeneID As String
        Public Property Comments As String
        Public Property Phenotypes As String
        Public Property MouseGeneSymbol_ID As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace