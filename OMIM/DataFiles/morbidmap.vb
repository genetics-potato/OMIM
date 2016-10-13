Imports Microsoft.VisualBasic.Serialization.JSON

Namespace DataFiles

    ''' <summary>
    ''' Phenotype Mapping key - Appears in parentheses after a disorder :
    ''' -----------------------------------------------------------------
    '''
    ''' 1 - the disorder Is placed On the map based On its association With
    '''     a gene, but the underlying defect Is Not known.
    ''' 2 - the disorder has been placed On the map by linkage Or other
    '''     statistical method; no mutation has been found.
    ''' 3 - the molecular basis For the disorder Is known; a mutation has been
    '''     found In the gene.
    ''' 4 - a contiguous gene deletion Or duplication syndrome, multiple genes
    '''     are deleted Or duplicated causing the phenotype.
    '''     
    ''' </summary>
    Public Class morbidmap

        ''' <summary>
        ''' Each Phenotype is followed by its MIM number, if different from that 
        ''' Of the locus/gene, And Then followed by its phenotype mapping 
        ''' key In parentheses (explanation below). 
        ''' </summary>
        ''' <returns></returns>
        Public Property Phenotype As String
        Public Property GeneSymbols As String
        Public Property MIMNumber As String
        Public Property CytoLocation As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace