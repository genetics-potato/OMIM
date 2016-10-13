Namespace Handlers.entry

    ''' <summary>
    ''' By default the ``text`` include will return the entire text which can be quite long. You can specify which text 
    ''' section(s) is returned by appending a colon followed by the text section name to 'text', for example:
    '''
    ''' ```
    ''' http://api.omim.org/api/entry?mimNumber=100100&amp;include=text:clinicalFeatures
    ''' ```
    ''' </summary>
    Public Enum textSections As Integer

        null

        ''' <summary>
        ''' Animal Model
        ''' </summary>
        animalModel
        ''' <summary>
        ''' Biochemical Features
        ''' </summary>
        biochemicalFeatures
        ''' <summary>
        ''' Clinical Features
        ''' </summary>
        clinicalFeatures
        ''' <summary>
        ''' Clinical Management
        ''' </summary>
        clinicalManagement
        ''' <summary>
        ''' Cloning
        ''' </summary>
        cloning
        ''' <summary>
        ''' Cytogenetics
        ''' </summary>
        cytogenetics
        ''' <summary>
        ''' Description
        ''' </summary>
        description
        ''' <summary>
        ''' Diagnosis
        ''' </summary>
        diagnosis
        ''' <summary>
        ''' Evolution
        ''' </summary>
        evolution
        ''' <summary>
        ''' Gene Family
        ''' </summary>
        geneFamily
        ''' <summary>
        ''' Gene Function
        ''' </summary>
        geneFunction
        ''' <summary>
        ''' Gene Structure
        ''' </summary>
        geneStructure
        ''' <summary>
        ''' Gene Therapy
        ''' </summary>
        geneTherapy
        ''' <summary>
        ''' Genetic Variability
        ''' </summary>
        geneticVariability
        ''' <summary>
        ''' Genotype
        ''' </summary>
        genotype
        ''' <summary>
        ''' Genotype/Phenotype Correlations
        ''' </summary>
        genotypePhenotypeCorrelations
        ''' <summary>
        ''' Heterogeneity
        ''' </summary>
        heterogeneity
        ''' <summary>
        ''' History
        ''' </summary>
        history
        ''' <summary>
        ''' Inheritance
        ''' </summary>
        inheritance
        ''' <summary>
        ''' Mapping
        ''' </summary>
        mapping
        ''' <summary>
        ''' Genetics Molecular Genetics
        ''' </summary>
        molecular
        ''' <summary>
        ''' Nomenclature
        ''' </summary>
        nomenclature
        ''' <summary>
        ''' Other Features
        ''' </summary>
        otherFeatures
        ''' <summary>
        ''' Pathogenesis
        ''' </summary>
        pathogenesis
        ''' <summary>
        ''' Phenotype
        ''' </summary>
        phenotype
        ''' <summary>
        ''' Population Genetics
        ''' </summary>
        populationGenetics
        ''' <summary>
        ''' Text (unfielded text section at the start Of the entry)
        ''' </summary>
        text
    End Enum
End Namespace