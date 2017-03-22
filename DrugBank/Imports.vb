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
        Dim drugATCCodes As New List(Of mysql.drug_atc_code)
        Dim drugCalculatedProperties As New List(Of mysql.drug_calculated_properties)
        Dim drugInteractions As New List(Of mysql.drug_interactions)
        Dim drugClassification As New List(Of mysql.drug_classification)
        Dim drugProducts As New List(Of mysql.drug_products)
        Dim drugSynonyms As New List(Of mysql.drug_synonym)
        Dim drugMixtures As New List(Of mysql.drug_mixtures)
        Dim drugCatagory As New List(Of mysql.drug_category)
        Dim drugprices As New List(Of mysql.drug_price)

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

            drugCatagory += d.DrugCategory
            drugprices += d.DrugPrices
            drugMixtures += d.DrugMixtures
            drugSynonyms += d.DrugSynonyms
            drugProducts += d.DrugProducts
            drugClassification += d.DrugClassification
            drugInteractions += d.DrugInteractions
            drugCalculatedProperties += d.DrugCalculatedProperties
            drugATCCodes += d.DrugATCCodes
            references += d.generalReferences.ToReferenceList
        Next

        Call references.DumpTransaction(save)
        Call drugs.DumpTransaction(save)
        Call drugATCCodes.DumpTransaction(save)
        Call drugCalculatedProperties.DumpTransaction(save)
        Call drugInteractions.DumpTransaction(save)
        Call drugClassification.DumpTransaction(save)
        Call drugProducts.DumpTransaction(save)
        Call drugSynonyms.DumpTransaction(save)
        Call drugMixtures.DumpTransaction(save)
        Call drugCatagory.DumpTransaction(save)
        Call drugprices.DumpTransaction(save)
    End Sub

    <Extension>
    Public Function DrugPrices(drug As XML.Drug) As mysql.drug_price()
        Return drug.prices.Select(Function(pr)
                                      Return New mysql.drug_price With {
                                          .drug = drug.PrimaryID,
                                          .cost = pr.cost.value,
                                          .description = pr.description,
                                          .unit = pr.unit,
                                          .currency = pr.cost.currency
                                      }
                                  End Function).ToArray
    End Function

    <Extension>
    Public Function DrugCategory(drug As XML.Drug) As mysql.drug_category()
        Return drug.categories _
            .Select(Function(c)
                        Return New mysql.drug_category With {
                            .drug = drug.PrimaryID,
                            .category = c.category,
                            .mesh_id = c.mesh_id
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugMixtures(drug As XML.Drug) As mysql.drug_mixtures()
        Return drug.mixtures _
            .Select(Function(m)
                        Return New mysql.drug_mixtures With {
                            .drug = drug.PrimaryID,
                            .ingredients = m.ingredients,
                            .mixture_name = m.name
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugSynonyms(drug As XML.Drug) As mysql.drug_synonym()
        Return drug.synonyms _
            .Select(Function(s)
                        Return New mysql.drug_synonym With {
                            .coder = s.coder,
                            .drug = drug.PrimaryID,
                            .language = s.language,
                            .synonym = s.value
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugProducts(drug As XML.Drug) As mysql.drug_products()
        Return drug.products _
            .Select(Function(p)
                        Return New mysql.drug_products With {
                            .drug = drug.PrimaryID,
                            .approved = p.approved,
                            .country = p.country,
                            .dosage_form = p.dosage_form,
                            .dpd_id = p.dpd_id,
                            .ended_marketting_on = p.ended_marketing_on,
                            .fda_application_number = p.fda_application_number,
                            .generic = p.generic,
                            .labeller = p.labeller,
                            .name = p.name,
                            .ndc_id = p.ndc_id,
                            .ndc_product_code = p.ndc_product_code,
                            .over_the_counter = p.over_the_counter,
                            .route = p.route,
                            .source = p.source,
                            .start_marketing_on = p.started_marketing_on,
                            .strength = p.strength
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugClassification(drug As XML.Drug) As mysql.drug_classification
        Dim c = drug.classification
        Return New mysql.drug_classification With {
            .drug = drug.PrimaryID,
            .class = c.class,
            .description = c.description,
            .direct_parent = c.directParent,
            .kingdom = c.kingdom,
            .subclass = c.subclass,
            .superclass = c.superclass
        }
    End Function

    <Extension>
    Public Function DrugInteractions(drug As XML.Drug) As mysql.drug_interactions()
        Return drug.drug_interactions.SafeQuery _
            .Select(Function(i)
                        Return New mysql.drug_interactions With {
                            .drug = drug.PrimaryID,
                            .partner = i.drugbankID,
                            .partner_description = i.description,
                            .partner_name = i.name
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugCalculatedProperties(drug As XML.Drug) As mysql.drug_calculated_properties()
        Return drug.calculated_properties.Select(Function(c)
                                                     Return New mysql.drug_calculated_properties With {
                                                        .drug = drug.PrimaryID,
                                                        .kind = c.kind,
                                                        .source = c.source,
                                                        .value = c.value
                                                     }
                                                 End Function).ToArray
    End Function

    <Extension>
    Public Function DrugATCCodes(drug As XML.Drug) As mysql.drug_atc_code()
        Return drug.atcCodes.SafeQuery.Select(
            Function(code)
                Dim levels = code.levels.OrderBy(Function(l) l.code.Length).ToArray

                Return New mysql.drug_atc_code With {
                    .code = code.code,
                    .drug = drug.PrimaryID,
                    .level1_code = levels(0).code,
                    .level1_description = levels(0).value,
                    .level2_code = levels(1).code,
                    .level2_description = levels(1).value,
                    .level3_code = levels(2).code,
                    .level3_description = levels(2).value,
                    .level4_code = levels(3).code,
                    .level4_description = levels(3).value,
                    .level5_code = levels.Get(4)?.code,
                    .level5_description = levels.Get(4)?.value
                }
            End Function).ToArray
    End Function

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
