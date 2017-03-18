Imports Microsoft.VisualBasic.Serialization.JSON
Imports SMRUCC.Clinic.OMIM.Handlers.clinicalSynopsis
Imports SMRUCC.Clinic.OMIM.Handlers.geneMap

Namespace Handlers.entry

    Public Class EntryData

        Public Property prefix As String
        Public Property mimNumber As String
        Public Property titles As titles
        ''' <summary>
        ''' 'live', 'moved', 'removed'
        ''' </summary>
        ''' <returns></returns>
        Public Property status As String
        ''' <summary>
        ''' Will be Set To the target entry mim number If this was moved
        ''' </summary>
        ''' <returns></returns>
        Public Property movedTo As String
        ''' <summary>
        ''' True|False - depending On whether a clinical synopsis exists, Set If the 'exists' include was set
        ''' </summary>
        ''' <returns></returns>
        Public Property clinicalSynopsisExists As Boolean
        Public Property clinicalSynopsis As clinicalSynopsisData
        ''' <summary>
        ''' True|False - depending On whether an allelic Variant exists, Set If the 'exists' include was set
        ''' </summary>
        ''' <returns></returns>
        Public Property allelicVariantExists As Boolean
        ''' <summary>
        ''' True|False - depending On whether a gene map exists, Set If the 'exists' include was set
        ''' </summary>
        ''' <returns></returns>
        Public Property geneMapExists As Boolean
        ''' <summary>
        ''' True|False - depending On whether a phenotype map exists, Set If the 'exists' include was set
        ''' </summary>
        ''' <returns></returns>
        Public Property phenotypeMapExists As Boolean
        ''' <summary>
        ''' True|False - depending On whether a phenotypic series exists, Set If the 'exists' include was set
        ''' </summary>
        ''' <returns></returns>
        Public Property phenotypicSeriesExists As Boolean
        ''' <summary>
        ''' text section list In order
        ''' </summary>
        ''' <returns></returns>
        Public Property textSectionList As textSectionList()
        Public Property allelicVariantList As allelicVariant()
        ''' <summary>
        ''' see-also list, delimited with ';'
        ''' </summary>
        ''' <returns></returns>
        Public Property seeAlso As String
        Public Property referenceList As referenceList()
        Public Property geneMapList As geneMap.geneMap()
        Public Property phenotypeMapList As phenotypeMapList()
        Public Property externalLinks As externalLinks
        Public Property contributors As String
        Public Property creationDate As String
        Public Property editHistory As String
        ''' <summary>
        ''' Web Date
        ''' </summary>
        ''' <returns></returns>
        Public Property dateCreated As String
        ''' <summary>
        ''' Unix epoch
        ''' </summary>
        ''' <returns></returns>
        Public Property epochCreated As String
        ''' <summary>
        ''' Web Date
        ''' </summary>
        ''' <returns></returns>
        Public Property dateUpdated As String
        ''' <summary>
        ''' Unix epoch
        ''' </summary>
        ''' <returns></returns>
        Public Property epochUpdated As String
    End Class

    Public Class externalLinks

        ''' <summary>
        ''' comma delimited list Of approved gene symbols
        ''' </summary>
        ''' <returns></returns>
        Public Property approvedGeneSymbols As String
        ''' <summary>
        ''' comma delimited list Of entrez gene IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property geneIDs As String
        ''' <summary>
        ''' comma delimited list Of NCBI reference sequences
        ''' </summary>
        ''' <returns></returns>
        Public Property ncbiReferenceSequences As String
        ''' <summary>
        ''' comma delimited list Of genbank nucleotide sequences
        ''' </summary>
        ''' <returns></returns>
        Public Property genbankNucleotideSequences As String
        ''' <summary>
        ''' comma delimited list Of protein sequences
        ''' </summary>
        ''' <returns></returns>
        Public Property proteinSequences As String
        ''' <summary>
        ''' comma delimited list Of uni genes
        ''' </summary>
        ''' <returns></returns>
        Public Property uniGenes As String
        ''' <summary>
        ''' triple-colon delimited list Of coma-delimited ensembl ID pairs
        ''' </summary>
        ''' <returns></returns>
        Public Property ensemblIDs As String
        ''' <summary>
        ''' comma delimited list Of swiss prot IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property swissProtIDs As String
        ''' <summary>
        ''' triple semi-colon delimited database name/url tuples, Each tuple Is Double semi-colon delimited
        ''' </summary>
        ''' <returns></returns>
        Public Property locusSpecificDBs As String
        ''' <summary>
        ''' comma delimited list Of MGI IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property mgiIDs As String
        ''' <summary>
        ''' MGI human disease flag (True|False)
        ''' </summary>
        ''' <returns></returns>
        Public Property mgiHumanDisease As Boolean
        ''' <summary>
        ''' comma delimited list Of wormbase IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property wormbaseIDs As String
        ''' <summary>
        ''' wormbase Do
        ''' </summary>
        ''' <returns></returns>
        Public Property wormbaseDO As Boolean
        ''' <summary>
        ''' triple semi-colon delimited list Of Double semi-colon delimited NBK ID/clinical disease name pairs
        ''' </summary>
        ''' <returns></returns>
        Public Property nbkIDs As String
        ''' <summary>
        ''' triple semi-colon delimited list Of Double semi-colon delimited possum ID/possum syndrome name pairs
        ''' </summary>
        ''' <returns></returns>
        Public Property possumSyndromes As String
        ''' <summary>
        ''' comma delimited list Of flybase IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property flybaseIDs As String
        ''' <summary>
        ''' comma delimited list Of zfin IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property zfinIDs As String
        ''' <summary>
        ''' triple semi-colon delimited list Of newborn screening urls
        ''' </summary>
        ''' <returns></returns>
        Public Property newbornScreeningUrls As String
        ''' <summary>
        ''' comma delimited list Of hprd IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property hprdIDs As String
        ''' <summary>
        ''' triple semi-colon delimited list Of coriell diseases
        ''' </summary>
        ''' <returns></returns>
        Public Property coriellDiseases As String
        ''' <summary>
        ''' DermAtlas entry flag (True|False)
        ''' </summary>
        ''' <returns></returns>
        Public Property dermAtlas As String
        ''' <summary>
        ''' triple semi-colon delimited list Of Double semi-colon delimited orphanet ID/disease pairs
        ''' </summary>
        ''' <returns></returns>
        Public Property orphanetDiseases As String
        ''' <summary>
        ''' !RefSeq accession IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property refSeqAccessionIDs As String
        ''' <summary>
        ''' GARD/ORDR diseases
        ''' </summary>
        ''' <returns></returns>
        Public Property ordrDiseases As String
        ''' <summary>
        ''' DECIPHER urls
        ''' </summary>
        ''' <returns></returns>
        Public Property decipherUrls As String
        ''' <summary>
        ''' Genetics Home Reference IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property geneticsHomeReferenceIDs As String
        ''' <summary>
        ''' OMIA IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property omiaIDs As String
        ''' <summary>
        ''' SNOMEDCT IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property snomedctIDs As String
        ''' <summary>
        ''' ICD10CM IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property icd10cmIDs As String
        ''' <summary>
        ''' ICD9CM IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property icd9cmIDs As String
        ''' <summary>
        ''' UMLS IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property umlsIDs As String
        ''' <summary>
        ''' NextGxDx
        ''' </summary>
        ''' <returns></returns>
        Public Property nextGxDx As String
        ''' <summary>
        ''' GTR
        ''' </summary>
        ''' <returns></returns>
        Public Property gtr As String
        ''' <summary>
        ''' Disease Ontology IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property diseaseOntologyIDs As String
        ''' <summary>
        ''' Gene Tests
        ''' </summary>
        ''' <returns></returns>
        Public Property geneTests As String
        ''' <summary>
        ''' Genetic Alliance IDs
        ''' </summary>
        ''' <returns></returns>
        Public Property geneticAllianceIDs As String
        ''' <summary>
        ''' CMG Gene
        ''' </summary>
        ''' <returns></returns>
        Public Property cmgGene As String
        ''' <summary>
        ''' KEGG Pathways
        ''' </summary>
        ''' <returns></returns>
        Public Property keggPathways As String
        ''' <summary>
        ''' GWAS Catalog
        ''' </summary>
        ''' <returns></returns>
        Public Property gwasCatalog As String
        ''' <summary>
        ''' ClinGen
        ''' </summary>
        ''' <returns></returns>
        Public Property clinGen As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class allelicVariant
        Public Property number As String
        ''' <summary>
        ''' 'live', 'moved', 'removed'
        ''' </summary>
        ''' <returns></returns>
        Public Property status As String
        ''' <summary>
        ''' Will be Set To the target entry mim number If this was moved
        ''' </summary>
        ''' <returns></returns>
        Public Property movedTo As String
        Public Property name As String
        Public Property alternativeNames As String
        Public Property mutations As String
        Public Property text As String
        ''' <summary>
        ''' comma delimited list Of dbSNPs
        ''' </summary>
        ''' <returns></returns>
        Public Property dbSNPs As String
        ''' <summary>
        ''' triple semi-colon list Of Clinvar accession
        ''' </summary>
        ''' <returns></returns>
        Public Property clinvarAccessions As String
    End Class

    Public Class textSection
        Public Property textSectionName As String
        Public Property textSectionTitle As String
        Public Property textSectionContent As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class textSectionList
        Public Property textSection As textSection
    End Class

    Public Class titles

        ''' <summary>
        ''' title And symbol, delimited With ';'
        ''' </summary>
        ''' <returns></returns>
        Public Property preferredTitle As String
        ''' <summary>
        ''' titles are delimited With ';;', and title/symbols are delimited with ';'
        ''' </summary>
        ''' <returns></returns>
        Public Property includedTitles As String
        Public Property alternativeTitles As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace