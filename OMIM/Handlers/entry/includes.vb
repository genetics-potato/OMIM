Namespace Handlers.entry

    Public Enum includes As Integer

        ''' <summary>
        ''' Includes the text field sections With the entry.
        ''' </summary>
        text = 2
        ''' <summary>
        ''' Include the 'exists' flags with the entry (clinical synopsis, allelic variant, gene map &amp; phenotype map).
        ''' </summary>
        existflags = 4
        ''' <summary>
        ''' Includes the allelic Variant list With the entry.
        ''' </summary>
        allelicVariantList = 8
        ''' <summary>
        ''' Include the clinical synopsis With the entry.
        ''' </summary>
        clinicalSynopsis = 16
        ''' <summary>
        ''' Includes the 'see also' field with the entry.
        ''' </summary>
        seeAlso = 32
        ''' <summary>
        ''' Include the reference list With the entry.
        ''' </summary>
        referenceList = 64
        ''' <summary>
        ''' Include the gene map/phenotype map data With the entry.
        ''' </summary>
        geneMap = 128
        ''' <summary>
        ''' Include the external links With the entry.
        ''' </summary>
        externalLinks = 256
        ''' <summary>
        ''' Includes the 'contributors' field with the entry.
        ''' </summary>
        contributors = 512
        ''' <summary>
        ''' Includes the 'creation date' field with the entry.
        ''' </summary>
        creationDate = 1024
        ''' <summary>
        ''' Includes the 'edit history' field with the entry.
        ''' </summary>
        editHistory = 2048
        ''' <summary>
        ''' Include the dates data With the entry.
        ''' </summary>
        dates = 4096
        ''' <summary>
        ''' Include the above data With the entry.
        ''' </summary>
        all = 8192
    End Enum
End Namespace