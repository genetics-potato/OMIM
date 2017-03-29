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

        Dim drugs As New List(Of mysql.drug)
        Dim drugATCCodes As New List(Of mysql.drug_atc_code)
        Dim drugCalculatedProperties As New List(Of mysql.drug_calculated_properties)
        Dim drugCatagory As New List(Of mysql.drug_category)
        Dim drugClassification As New List(Of mysql.drug_classification)
        Dim drugDosage As New List(Of mysql.drug_dosage)
        Dim drugExperimentalproperties As New List(Of mysql.drug_experimental_properties)
        Dim drugExternalID As New List(Of mysql.drug_external_identifiers)
        Dim drugExternalLinks As New List(Of mysql.drug_external_links)
        Dim drugInteractions As New List(Of mysql.drug_interactions)
        Dim drugManufactures As New List(Of mysql.drug_manufacturers)
        Dim drugMixtures As New List(Of mysql.drug_mixtures)
        Dim drugPackgers As New List(Of mysql.drug_packagers)
        Dim drugPatents As New List(Of mysql.drug_patents)
        Dim drugPathways As New List(Of mysql.drug_pathways)
        Dim drugprices As New List(Of mysql.drug_price)
        Dim drugProducts As New List(Of mysql.drug_products)
        Dim drugReactions As New List(Of mysql.drug_reactions)
        Dim drugSNPeffects As New List(Of mysql.drug_snp_effects)
        Dim drugSynonyms As New List(Of mysql.drug_synonym)
        Dim drugtargets As New List(Of mysql.drug_targets)
        Dim pathwayDrugs As New List(Of mysql.pathway_drugs)
        Dim pathwayEnzymes As New List(Of mysql.pathway_enzymes)
        Dim polypeptideExternalIDs As New List(Of mysql.polypeptide_external_ids)
        Dim polypeptideSequence As New List(Of mysql.polypeptide_sequences)
        Dim polypeptideSynonms As New List(Of mysql.polypeptide_synonyms)
        Dim references As New List(Of mysql.reference)
        Dim targetPolypeptides As New List(Of mysql.target_polypeptides)

        For Each d As XML.Drug In XML.Database.Load(fullXML)

            drugs += New mysql.drug With {
                .absorption = d.absorption.MySqlEscaping,
                .primaryID = d.PrimaryID,
                .other_IDs = d.OtherIDs.JoinBy("; ").MySqlEscaping,
                .average_mass = d.averageMass,
                .cas_number = d.CASNumber.MySqlEscaping,
                .clearance = d.clearance.MySqlEscaping,
                .created = d.created.MySqlEscaping,
                .description = d.description.MySqlEscaping,
                .fdaLabel = d.fdaLabel.MySqlEscaping,
                .halfLife = d.halfLife.MySqlEscaping,
                .indication = d.indication.MySqlEscaping,
                .mechanism_of_action = d.mechanism_of_action.MySqlEscaping,
                .metabolism = d.metabolism.MySqlEscaping,
                .monoisotopic_Mass = d.monoisotopicMass,
                .msds = d.msds.MySqlEscaping,
                .name = d.name.MySqlEscaping,
                .pharmacodynamics = d.pharmacodynamics.MySqlEscaping,
                .route_of_elimination = d.route_of_elimination.MySqlEscaping,
                .state = d.state.MySqlEscaping,
                .synthesisReferences = d.synthesisReferences.MySqlEscaping,
                .toxicity = d.toxicity.MySqlEscaping,
                .type = d.type.MySqlEscaping,
                .unii = d.unii.MySqlEscaping,
                .updated = d.updated.MySqlEscaping,
                .volume_of_distribution = d.volume_of_distribution.MySqlEscaping
            }
#Region ""
            With d.DrugTargets
                drugtargets += .Item1
                targetPolypeptides += .Item2
                polypeptideExternalIDs += .Item3
                polypeptideSequence += .Item4
                polypeptideSynonms += .Item5
            End With

            drugSNPeffects += d.DrugSNPEffects
            drugReactions += d.DrugReactions

            With d.Drugpathways
                drugPathways += .Item1
                pathwayDrugs += .Item2
                pathwayEnzymes += .Item3
            End With

            drugPatents += d.DrugPatents
            drugPackgers += d.DrugPackagers
            drugManufactures += d.DrugManufactures
            drugExternalLinks += d.DrugExternalLinks
            drugExternalID += d.DrugExternalIdentifier
            drugExperimentalproperties += d.DrugExperimentalProperty
            drugDosage += d.drugDosages
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
#End Region
            ' Call d.PrimaryID.__DEBUG_ECHO
        Next

#Region "Dumps"

        Call pathwayDrugs.DumpTransaction(save)
        Call polypeptideExternalIDs.DumpTransaction(save)
        Call polypeptideSequence.DumpTransaction(save)
        Call polypeptideSynonms.DumpTransaction(save)
        Call targetPolypeptides.DumpTransaction(save)
        Call pathwayEnzymes.DumpTransaction(save)
        Call drugtargets.DumpTransaction(save)
        Call drugSNPeffects.DumpTransaction(save)
        Call drugReactions.DumpTransaction(save)
        Call drugPathways.DumpTransaction(save)
        Call drugPatents.DumpTransaction(save)
        Call drugPackgers.DumpTransaction(save)
        Call drugManufactures.DumpTransaction(save)
        Call drugExternalLinks.DumpTransaction(save)
        Call drugExternalID.DumpTransaction(save)
        Call drugExperimentalproperties.DumpTransaction(save)
        Call drugDosage.DumpTransaction(save)
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
#End Region
    End Sub

    <Extension>
    Private Function DrugTargets(drug As XML.Drug) As (mysql.drug_targets(), mysql.target_polypeptides(), mysql.polypeptide_external_ids(), mysql.polypeptide_sequences(), mysql.polypeptide_synonyms())
        Dim targets = drug.targets.SafeQuery.Select(
            Function(t)
                Return New mysql.drug_targets With {
                    .actions = t.actions.SafeQuery.Select(Function(a) a.action).JoinBy("; ").MySqlEscaping,
                    .drug = drug.PrimaryID,
                    .known_action = t.knownAction.MySqlEscaping,
                    .name = MySqlEscaping(t.name),
                    .organism = t.organism.MySqlEscaping,
                    .polypeptide = t.polypeptide?.id.MySqlEscaping,
                    .target_id = t.id.MySqlEscaping
                }
            End Function).ToArray
        Dim targetPolypeptides = drug.targets.SafeQuery.Select(
            Function(t)
                Dim pl = t.polypeptide
                If pl Is Nothing Then
                    Return Nothing
                End If
                Return New mysql.target_polypeptides With {
                    .cellular_location = pl.cellularLocation.MySqlEscaping,
                    .chromosome_location = MySqlEscaping(pl.chromosomeLocation),
                    .drug_id = drug.PrimaryID,
                    .general_function = MySqlEscaping(pl.generalFunction),
                    .gene_name = MySqlEscaping(pl.geneName),
                    .locus = pl.locus.MySqlEscaping,
                    .molecular_weight = pl.molecularWeight,
                    .name = pl.name.MySqlEscaping,
                    .organism = MySqlEscaping(pl.organism?.name),
                    .organism_ncbi_taxonomy_id = pl.organism?.NCBItaxonomyID.MySqlEscaping,
                    .polypeptide_id = pl.id.MySqlEscaping,
                    .signal_regions = MySqlEscaping(pl.signalRegions),
                    .source = pl.source.MySqlEscaping,
                    .specific_function = pl.specificFunction.MySqlEscaping,
                    .target_id = t.id.MySqlEscaping,
                    .theoretical_PI = pl.theoreticalPI,
                    .transmembrane_regions = MySqlEscaping(pl.transmembraneRegions)
                }
            End Function).ToArray
        Dim plexternalIDs = drug.targets.SafeQuery.Select(
            Function(t)
                Return t.polypeptide?.externalIdentifiers.SafeQuery.Select(
                    Function(id)
                        Return New mysql.polypeptide_external_ids With {
                            .id = id.identifier,
                            .polypeptide = t.polypeptide.id,
                            .resource = id.resource
                        }
                    End Function)
            End Function).IteratesALL.ToArray
        Dim plSequence = drug.targets.SafeQuery.Select(
            Function(t)
                If t.polypeptide Is Nothing Then
                    Return Nothing
                End If
                Return New mysql.polypeptide_sequences With {
                    .aa = MySqlEscaping(t.polypeptide.AA.sequence),
                    .nt = MySqlEscaping(t.polypeptide.NT.sequence),
                    .go_bp = t.polypeptide.goClassifiers.Where(Function(go) go.category = "process").Select(Function(go) go.description).JoinBy("; ").MySqlEscaping,
                    .go_cc = t.polypeptide.goClassifiers.Where(Function(go) go.category = "component").Select(Function(go) go.description).JoinBy("; ").MySqlEscaping,
                    .go_mf = t.polypeptide.goClassifiers.Where(Function(go) go.category = "function").Select(Function(go) go.description).JoinBy("; ").MySqlEscaping,
                    .pfam = t.polypeptide.pfams.Select(Function(pf) pf.identifier).JoinBy("; ").MySqlEscaping,
                    .polypeptide = t.polypeptide.id
                }
            End Function).ToArray
        Dim plSynonms = drug.targets.SafeQuery.Select(
            Function(t)
                Dim i As int = 0

                If t.polypeptide Is Nothing Then
                    Return Nothing
                End If

                Return New mysql.polypeptide_synonyms With {
                    .polypeptide = t.polypeptide.id,
                    .synonym1 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym2 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym3 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym4 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym5 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym6 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym7 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym8 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym9 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping,
                    .synonym10 = t.polypeptide.synonyms.Get(++i)?.value.MySqlEscaping
                }

            End Function).ToArray

        Return (targets, targetPolypeptides, plexternalIDs, plSequence, plSynonms)
    End Function

    <Extension>
    Private Function DrugSNPEffects(drug As XML.Drug) As mysql.drug_snp_effects()
        Return drug.snpEffects.SafeQuery.Select(
            Function(snp)
                Return New mysql.drug_snp_effects With {
                    .allele = snp.allele.MySqlEscaping,
                    .defining_change = snp.definingChange.MySqlEscaping,
                    .description = snp.description.MySqlEscaping,
                    .drug = drug.PrimaryID,
                    .gene_symbol = snp.geneSymbol.MySqlEscaping,
                    .protein_name = snp.proteinName.MySqlEscaping,
                    .pubmed_id = snp.pubmedID,
                    .rs_ID = snp.rsID,
                    .uniprot = snp.uniprotID
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function DrugReactions(drug As XML.Drug) As mysql.drug_reactions()
        Return drug.reactions.SafeQuery.Select(
            Function(r)
                Dim i As int = 0, j As int = 0

                Return New mysql.drug_reactions With {
                    .drug = drug.PrimaryID,
                    .enzymes = r.enzymes.Select(Function(x) x.uniprotID).JoinBy("; "),
                    .sequence = r.sequence,
                    .left1 = r.leftElements.Get(++i)?.drugbankID,
                    .left2 = r.leftElements.Get(++i)?.drugbankID,
                    .left3 = r.leftElements.Get(++i)?.drugbankID,
                    .left4 = r.leftElements.Get(++i)?.drugbankID,
                    .left5 = r.leftElements.Get(++i)?.drugbankID,
                    .right1 = r.rightElements.Get(++j)?.drugbankID,
                    .right2 = r.rightElements.Get(++j)?.drugbankID,
                    .right3 = r.rightElements.Get(++j)?.drugbankID,
                    .right4 = r.rightElements.Get(++j)?.drugbankID,
                    .right5 = r.rightElements.Get(++j)?.drugbankID
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function Drugpathways(drug As XML.Drug) As (mysql.drug_pathways(), mysql.pathway_drugs(), mysql.pathway_enzymes())
        Dim plist = drug.pathways.SafeQuery.Select(
            Function(pwy)
                Return New mysql.drug_pathways With {
                    .category = pwy.category,
                    .drug = drug.PrimaryID,
                    .enzymes = pwy.enzymes?.uniprotID.JoinBy("; "),
                    .name = MySqlEscaping(pwy.name),
                    .smpdb_id = pwy.smpdb_id
                }
            End Function).ToArray
        Dim pdrugs = drug.pathways.SafeQuery.Select(
            Function(pwy)
                Return pwy.drugs?.drugs.SafeQuery.Select(
                    Function(dr)
                        Return New mysql.pathway_drugs With {
                            .drug = dr.drugbankID,
                            .name = MySqlEscaping(dr.name),
                            .pathway_smpdb_id = pwy.smpdb_id
                        }
                    End Function).ToArray
            End Function).IteratesALL.ToArray
        Dim penzymes = drug.pathways.SafeQuery.Select(
            Function(pwy)
                Return pwy.enzymes.uniprotID.SafeQuery.Select(
                    Function(x)
                        Return New mysql.pathway_enzymes With {
                            .drugID = drug.PrimaryID,
                            .pathway_smpdb_id = pwy.smpdb_id,
                            .uniprotID = x,
                            .name = MySqlEscaping(x),
                            .enzyme_drugbankID = x
                        }
                    End Function).ToArray
            End Function).IteratesALL.ToArray

        Return (plist, pdrugs, penzymes)
    End Function

    <Extension>
    Private Function DrugPatents(drug As XML.Drug) As mysql.drug_patents()
        Return drug.patents.SafeQuery.Select(
            Function(pt)
                Return New mysql.drug_patents With {
                    .approved = pt.approved,
                    .country = pt.country,
                    .drug = drug.PrimaryID,
                    .expires = pt.expires,
                    .number = pt.number,
                    .pediatric_extension = pt.pediatric_extension
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function DrugPackagers(drug As XML.Drug) As mysql.drug_packagers()
        Return drug.packagers.SafeQuery.Select(
            Function(pk)
                Return New mysql.drug_packagers With {
                    .drug = drug.PrimaryID,
                    .packager_name = MySqlEscaping(pk.name),
                    .url = MySqlEscaping(pk.url)
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function DrugManufactures(drug As XML.Drug) As mysql.drug_manufacturers()
        Return drug.manufacturers.SafeQuery.Select(
            Function(m)
                Return New mysql.drug_manufacturers With {
                    .drug = drug.PrimaryID,
                    .generic = m.generic,
                    .manufacturer = m.value,
                    .url = m.url
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function DrugExternalLinks(drug As XML.Drug) As mysql.drug_external_links()
        Return drug.externalLinks.SafeQuery.Select(
            Function(l)
                Return New mysql.drug_external_links With {
                    .drug = drug.PrimaryID,
                    .resource = l.resource,
                    .url = l.url
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function DrugExternalIdentifier(drug As XML.Drug) As mysql.drug_external_identifiers()
        Return drug.externalIdentifiers.SafeQuery.Select(
            Function(ID)
                Return New mysql.drug_external_identifiers With {
                    .drug = drug.PrimaryID,
                    .ID = ID.identifier,
                    .resource = ID.resource
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function DrugExperimentalProperty(drug As XML.Drug) As mysql.drug_experimental_properties()
        Return drug.experimentalProperties.SafeQuery.Select(
            Function(prop)
                Return New mysql.drug_experimental_properties With {
                    .drug = drug.PrimaryID,
                    .kind = prop.kind,
                    .source = MySqlEscaping(prop.source),
                    .value = MySqlEscaping(prop.value)
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function drugDosages(drug As XML.Drug) As mysql.drug_dosage()
        Return drug.dosages.SafeQuery.Select(
            Function(d)
                Return New mysql.drug_dosage With {
                    .drug = drug.PrimaryID,
                    .form = MySqlEscaping(d.form),
                    .route = MySqlEscaping(d.route),
                    .strength = MySqlEscaping(d.strength)
                }
            End Function).ToArray
    End Function

    <Extension>
    Public Function DrugPrices(drug As XML.Drug) As mysql.drug_price()
        Return drug.prices _
            .SafeQuery _
            .Select(Function(pr)
                        Return New mysql.drug_price With {
                            .drug = drug.PrimaryID,
                            .cost = pr.cost.value,
                            .description = MySqlEscaping(pr.description),
                            .unit = pr.unit,
                            .currency = pr.cost.currency
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugCategory(drug As XML.Drug) As mysql.drug_category()
        Return drug.categories _
            .SafeQuery _
            .Select(Function(c)
                        Return New mysql.drug_category With {
                            .drug = drug.PrimaryID,
                            .category = c.category.MySqlEscaping,
                            .mesh_id = c.mesh_id.MySqlEscaping
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugMixtures(drug As XML.Drug) As mysql.drug_mixtures()
        Return drug.mixtures _
            .SafeQuery _
            .Select(Function(m)
                        Return New mysql.drug_mixtures With {
                            .drug = drug.PrimaryID,
                            .ingredients = m.ingredients.MySqlEscaping,
                            .mixture_name = m.name.MySqlEscaping
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugSynonyms(drug As XML.Drug) As mysql.drug_synonym()
        Return drug.synonyms _
            .SafeQuery _
            .Select(Function(s)
                        Return New mysql.drug_synonym With {
                            .coder = s.coder,
                            .drug = drug.PrimaryID,
                            .language = s.language,
                            .synonym = s.value.MySqlEscaping
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugProducts(drug As XML.Drug) As mysql.drug_products()
        Return drug.products _
            .SafeQuery _
            .Select(Function(p)
                        Return New mysql.drug_products With {
                            .drug = drug.PrimaryID,
                            .approved = p.approved,
                            .country = p.country.MySqlEscaping,
                            .dosage_form = p.dosage_form.MySqlEscaping,
                            .dpd_id = p.dpd_id.MySqlEscaping,
                            .ended_marketting_on = p.ended_marketing_on.MySqlEscaping,
                            .fda_application_number = p.fda_application_number.MySqlEscaping,
                            .generic = p.generic,
                            .labeller = p.labeller.MySqlEscaping,
                            .name = MySqlEscaping(p.name),
                            .ndc_id = p.ndc_id.MySqlEscaping,
                            .ndc_product_code = p.ndc_product_code.MySqlEscaping,
                            .over_the_counter = p.over_the_counter,
                            .route = p.route.MySqlEscaping,
                            .source = p.source.MySqlEscaping,
                            .start_marketing_on = p.started_marketing_on.MySqlEscaping,
                            .strength = p.strength.MySqlEscaping
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugClassification(drug As XML.Drug) As mysql.drug_classification
        Dim c = drug.classification

        If c Is Nothing Then
            Return Nothing
        End If
        Return New mysql.drug_classification With {
            .drug = drug.PrimaryID,
            .class = c.class.MySqlEscaping,
            .description = MySqlEscaping(c.description),
            .direct_parent = c.directParent.MySqlEscaping,
            .kingdom = c.kingdom.MySqlEscaping,
            .subclass = c.subclass.MySqlEscaping,
            .superclass = c.superclass.MySqlEscaping
        }
    End Function

    <Extension>
    Public Function DrugInteractions(drug As XML.Drug) As mysql.drug_interactions()
        Return drug.drug_interactions _
            .SafeQuery _
            .Select(Function(i)
                        Return New mysql.drug_interactions With {
                            .drug = drug.PrimaryID,
                            .partner = i.drugbankID.MySqlEscaping,
                            .partner_description = MySqlEscaping(i.description),
                            .partner_name = i.name.MySqlEscaping
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugCalculatedProperties(drug As XML.Drug) As mysql.drug_calculated_properties()
        Return drug.calculated_properties _
            .SafeQuery _
            .Select(Function(c)
                        Return New mysql.drug_calculated_properties With {
                            .drug = drug.PrimaryID.MySqlEscaping,
                            .kind = c.kind.MySqlEscaping,
                            .source = c.source.MySqlEscaping,
                            .value = c.value.MySqlEscaping
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugATCCodes(drug As XML.Drug) As mysql.drug_atc_code()
        Return drug.atcCodes _
            .SafeQuery _
            .Select(Function(code)
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
                .title = MySqlEscaping(book.citation),
                .type = 2
            }
        Next

        For Each link In ref.links.SafeQuery
            out += New mysql.reference With {
                .id = MySqlEscaping(link.url),
                .title = MySqlEscaping(link.title),
                .type = 3
            }
        Next

        For Each article In ref.articles.SafeQuery
            out += New mysql.reference With {
                .id = article.pubmedID,
                .title = MySqlEscaping(article.citation),
                .type = 1
            }
        Next

        Return out
    End Function
End Module
