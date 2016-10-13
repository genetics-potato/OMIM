Imports Microsoft.VisualBasic.Serialization.JSON

Namespace DataFiles

    Public Class genemap
        Public Property Sort As String
        Public Property Month As String
        Public Property Day As String
        Public Property Year As String
        Public Property CytoLocation As String
        Public Property GeneSymbols As String
        Public Property Confidence As String
        Public Property GeneName As String
        Public Property MIMNumber As String
        Public Property MappingMethod As String
        Public Property Comments As String
        Public Property Phenotypes As String
        Public Property MouseGeneSymbol As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace