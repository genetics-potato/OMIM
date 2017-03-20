Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Language
Imports Microsoft.VisualBasic.Linq
Imports Oracle.LinuxCompatibility.MySQL

Public Module [Imports]

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fullXML$">``drugbank_all_full_database.xml``</param>
    ''' <param name="save$">所导出来的SQL文件的保存的文件夹</param>
    Public Sub Dump(fullXML$, Optional save$ = Nothing)
        If save.StringEmpty Then
            save = fullXML.TrimSuffix & ".Dumps/"
        End If

        Dim fullData As XML.Database = XML.Database.Load(fullXML)
        Dim drugs As New List(Of mysql.drug)
        Dim references As New List(Of mysql.reference)

        For Each d As XML.Drug In fullData.drugs
            drugs += New mysql.drug With {
                .absorption = d.absorption,
                .primaryID = d.PrimaryID,
                .other_IDs = d.OtherIDs.JoinBy("; "),
                .average_mass = d.averageMass,
                .cas_number = d.CASNumber,
                .clearance = d.clearance,
                .created = d.created,
                .description = d.description,
                .fdaLabel = d.fdaLabel,
                .halfLife = d.halfLife,
                .indication = d.indication,
                .mechanism_of_action = d.mechanism_of_action,
                .metabolism = d.metabolism,
                .monoisotopic_Mass = d.monoisotopicMass,
                .msds = d.msds,
                .name = d.name,
                .pharmacodynamics = d.pharmacodynamics,
                .route_of_elimination = d.route_of_elimination,
                .state = d.state,
                .synthesisReferences = d.synthesisReferences,
                .toxicity = d.toxicity,
                .type = d.type,
                .unii = d.unii,
                .updated = d.updated,
                .volume_of_distribution = d.volume_of_distribution
            }

            references += d.generalReferences.ToReferenceList
        Next

        Call references.DumpTransaction(save)
        Call drugs.DumpTransaction(save)
    End Sub

    <Extension>
    Public Function ToReferenceList(ref As XML.references) As mysql.reference()
        Dim out As New List(Of mysql.reference)

        If ref Is Nothing Then
            Return {}
        End If

        For Each book In ref.textbooks.SafeQuery
            out += New mysql.reference With {
                .id = book.isbn,
                .title = book.citation,
                .type = 2
            }
        Next

        For Each link In ref.links.SafeQuery
            out += New mysql.reference With {
                .id = link.url,
                .title = link.title,
                .type = 3
            }
        Next

        For Each article In ref.articles.SafeQuery
            out += New mysql.reference With {
                .id = article.pubmedID,
                .title = article.citation,
                .type = 1
            }
        Next

        Return out
    End Function
End Module
