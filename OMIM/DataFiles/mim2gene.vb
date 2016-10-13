Imports Microsoft.VisualBasic.Serialization.JSON

Namespace DataFiles

    Public Class mim2gene

        Public Property MIMNumber
        ''' <summary>
        ''' (see FAQ 1.3 at http://omim.org/help/faq)
        ''' </summary>
        ''' <returns></returns>
        Public Property MIMEntryType
        ''' <summary>
        ''' (NCBI)
        ''' </summary>
        ''' <returns></returns>
        Public Property EntrezGeneID
        ''' <summary>
        ''' (HGNC)
        ''' </summary>
        ''' <returns></returns>
        Public Property ApprovedGeneSymbol
        ''' <summary>
        ''' (Ensembl)
        ''' </summary>
        ''' <returns></returns>
        Public Property EnsemblGeneID

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace