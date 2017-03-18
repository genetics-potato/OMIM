Namespace Handlers.clinicalSynopsis

    ''' <summary>
    ''' For example:
    ''' 
    ''' http://api.omim.org/api/clinicalSynopsis?mimNumber=100100&amp;include=clinicalSynopsis&amp;include=externalLinks
    ''' 
    ''' Or
    ''' 
    ''' http://api.omim.org/api/clinicalSynopsis?mimNumber=100100&amp;include=clinicalSynopsis,externalLinks
    ''' </summary>
    Public Enum includes As Integer

        ''' <summary>
        ''' Include the clinical synopsis With the entry.
        ''' </summary>
        clinicalSynopsis = 2
        ''' <summary>
        ''' Include the 'exists' flags with the entry (clinical synopsis, allelic variant, gene map &amp; phenotype map).
        ''' </summary>
        existflags = 4
        ''' <summary>
        ''' Include the external links With the entry.
        ''' </summary>
        externalLinks = 8
        ''' <summary>
        ''' Include the contributors With the entry.
        ''' </summary>
        contributors = 16
        ''' <summary>
        ''' Include the creation Date With the entry.
        ''' </summary>
        creationDate = 32
        ''' <summary>
        ''' Include the edit history With the entry.
        ''' </summary>
        editHistory = 64
        ''' <summary>
        ''' Include the dates With the entry.
        ''' </summary>
        dates = 128
        ''' <summary>
        ''' Include the above data With the entry.
        ''' </summary>
        all = 256
    End Enum
End Namespace