Imports Microsoft.VisualBasic.Serialization.JSON

Namespace DataFiles

    Public Class mimTitles

        ''' <summary>
        ''' ###### MIM number prefix:
        ''' 
        ''' |Prefix              |                                                                  |
        ''' |--------------------|------------------------------------------------------------------|
        ''' |Asterisk (*)        |Gene 
        ''' |Plus (+)            |Gene And phenotype, combined 
        ''' |Number Sign (#)     |Phenotype, molecular basis known 
        ''' |Percent (%)         |Phenotype Or locus, molecular basis unknown 
        ''' |NULL (``&lt;null>``)|Other, mainly phenotypes With suspected mendelian basis
        ''' |Caret (^)           |Entry has been removed from the database Or moved To another entry
        '''
        ''' </summary>
        ''' <returns></returns>
        Public Property Prefix As String
        Public Property MimNumber As String
        ''' <summary>
        ''' Preferred Title; symbol	
        ''' </summary>
        ''' <returns></returns>
        Public Property Preferred As String
        ''' <summary>
        ''' Alternative Title(s); symbol(s)	
        ''' </summary>
        ''' <returns></returns>
        Public Property Alternative As String
        ''' <summary>  
        ''' Included Title(s); symbols
        ''' </summary>
        ''' <returns></returns>
        Public Property Included As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace