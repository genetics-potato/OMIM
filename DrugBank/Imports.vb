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
                    .actions = t.actions.Select(Function(a) a.action).JoinBy("; "),
                    .drug = drug.PrimaryID,
                    .known_action = t.knownAction,
                    .name = t.name,
                    .organism = t.organism,
                    .polypeptide = t.polypeptide.id,
                    .target_id = t.id
                }
            End Function).ToArray
        Dim targetPolypeptides = drug.targets.SafeQuery.Select(
            Function(t)
                Dim pl = t.polypeptide
                Return New mysql.target_polypeptides With {
                    .cellular_location = pl.cellularLocation,
                    .chromosome_location = pl.chromosomeLocation,
                    .drug_id = drug.PrimaryID,
                    .general_function = pl.generalFunction,
                    .gene_name = pl.geneName,
                    .locus = pl.locus,
                    .molecular_weight = pl.molecularWeight,
                    .name = pl.name,
                    .organism = pl.organism.name,
                    .organism_ncbi_taxonomy_id = pl.organism.NCBItaxonomyID,
                    .polypeptide_id = pl.id,
                    .signal_regions = pl.signalRegions,
                    .source = pl.source,
                    .specific_function = pl.specificFunction,
                    .target_id = t.id,
                    .theoretical_PI = pl.theoreticalPI,
                    .transmembrane_regions = pl.transmembraneRegions
                }
            End Function).ToArray
        Dim plexternalIDs = drug.targets.SafeQuery.Select(
            Function(t)
                Return t.polypeptide.externalIdentifiers.Select(
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
                Return New mysql.polypeptide_sequences With {
                    .aa = t.polypeptide.AA.sequence,
                    .nt = t.polypeptide.NT.sequence,
                    .go_bp = t.polypeptide.goClassifiers.Where(Function(go) go.category = "").Select(Function(go) go.description).JoinBy("; "),
                    .go_cc = t.polypeptide.goClassifiers.Where(Function(go) go.category = "").Select(Function(go) go.description).JoinBy("; "),
                    .go_mf = t.polypeptide.goClassifiers.Where(Function(go) go.category = "").Select(Function(go) go.description).JoinBy("; "),
                    .pfam = t.polypeptide.pfams.Select(Function(pf) pf.identifier).JoinBy("; "),
                    .polypeptide = t.polypeptide.id
                }
            End Function).ToArray
        Dim plSynonms = drug.targets.SafeQuery.Select(
            Function(t)
                Return t.polypeptide.synonyms.Select(
                    Function(sy)
                        Dim i As int = 0

                        Return New mysql.polypeptide_synonyms With {
                            .polypeptide = t.polypeptide.id,
                            .synonym1 = t.polypeptide.synonyms(++i).value,
                            .synonym2 = t.polypeptide.synonyms(++i).value,
                            .synonym3 = t.polypeptide.synonyms(++i).value,
                            .synonym4 = t.polypeptide.synonyms(++i).value,
                            .synonym5 = t.polypeptide.synonyms(++i).value,
                            .synonym6 = t.polypeptide.synonyms(++i).value,
                            .synonym7 = t.polypeptide.synonyms(++i).value,
                            .synonym8 = t.polypeptide.synonyms(++i).value,
                            .synonym9 = t.polypeptide.synonyms(++i).value,
                            .synonym10 = t.polypeptide.synonyms(++i).value
                        }
                    End Function)
            End Function).IteratesALL.ToArray

        Return (targets, targetPolypeptides, plexternalIDs, plSequence, plSynonms)
    End Function

    <Extension>
    Private Function DrugSNPEffects(drug As XML.Drug) As mysql.drug_snp_effects()
        Return drug.snpEffects.SafeQuery.Select(
            Function(snp)
                Return New mysql.drug_snp_effects With {
                    .allele = snp.allele,
                    .defining_change = snp.definingChange,
                    .description = snp.description,
                    .drug = drug.PrimaryID,
                    .gene_symbol = snp.geneSymbol,
                    .protein_name = snp.proteinName,
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
                    .enzymes = r.enzymes.Select(Function(x) x.drugbankID).JoinBy("; "),
                    .sequence = r.sequence,
                    .left1 = r.leftElements(++i).drugbankID,
                    .left2 = r.leftElements(++i).drugbankID,
                    .left3 = r.leftElements(++i).drugbankID,
                    .left4 = r.leftElements(++i).drugbankID,
                    .left5 = r.leftElements(++i).drugbankID,
                    .right1 = r.rightElements(++j).drugbankID,
                    .right2 = r.rightElements(++j).drugbankID,
                    .right3 = r.rightElements(++j).drugbankID,
                    .right4 = r.rightElements(++j).drugbankID,
                    .right5 = r.rightElements(++j).drugbankID
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
                    .enzymes = pwy.enzymes.SafeQuery.Select(Function(o) o.drugbankID).JoinBy("; "),
                    .name = pwy.name,
                    .smpdb_id = pwy.smpdb_id
                }
            End Function).ToArray
        Dim pdrugs = drug.pathways.SafeQuery.Select(
            Function(pwy)
                Return pwy.drugs?.drugs.SafeQuery.Select(
                    Function(dr)
                        Return New mysql.pathway_drugs With {
                            .drug = dr.drugbankID,
                            .name = dr.name,
                            .pathway_smpdb_id = pwy.smpdb_id
                        }
                    End Function).ToArray
            End Function).IteratesALL.ToArray
        Dim penzymes = drug.pathways.SafeQuery.Select(
            Function(pwy)
                Return pwy.enzymes.SafeQuery.Select(
                    Function(x)
                        Return New mysql.pathway_enzymes With {
                            .drugID = drug.PrimaryID,
                            .pathway_smpdb_id = pwy.smpdb_id,
                            .uniprotID = x.uniprotID,
                            .name = x.name,
                            .enzyme_drugbankID = x.drugbankID
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
                    .packager_name = pk.name,
                    .url = pk.url
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
                    .source = prop.source,
                    .value = prop.value
                }
            End Function).ToArray
    End Function

    <Extension>
    Private Function drugDosages(drug As XML.Drug) As mysql.drug_dosage()
        Return drug.dosages.SafeQuery.Select(
            Function(d)
                Return New mysql.drug_dosage With {
                    .drug = drug.PrimaryID,
                    .form = d.form,
                    .route = d.route,
                    .strength = d.strength
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
                            .category = c.category,
                            .mesh_id = c.mesh_id
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
                            .ingredients = m.ingredients,
                            .mixture_name = m.name
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
                            .synonym = s.value
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
                            .country = p.country,
                            .dosage_form = p.dosage_form,
                            .dpd_id = p.dpd_id,
                            .ended_marketting_on = p.ended_marketing_on,
                            .fda_application_number = p.fda_application_number,
                            .generic = p.generic,
                            .labeller = p.labeller,
                            .name = MySqlEscaping(p.name),
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

        If c Is Nothing Then
            Return Nothing
        End If
        Return New mysql.drug_classification With {
            .drug = drug.PrimaryID,
            .class = c.class,
            .description = MySqlEscaping(c.description),
            .direct_parent = c.directParent,
            .kingdom = c.kingdom,
            .subclass = c.subclass,
            .superclass = c.superclass
        }
    End Function

    <Extension>
    Public Function DrugInteractions(drug As XML.Drug) As mysql.drug_interactions()
        Return drug.drug_interactions _
            .SafeQuery _
            .Select(Function(i)
                        Return New mysql.drug_interactions With {
                            .drug = drug.PrimaryID,
                            .partner = i.drugbankID,
                            .partner_description = MySqlEscaping(i.description),
                            .partner_name = i.name
                        }
                    End Function).ToArray
    End Function

    <Extension>
    Public Function DrugCalculatedProperties(drug As XML.Drug) As mysql.drug_calculated_properties()
        Return drug.calculated_properties _
            .SafeQuery _
            .Select(Function(c)
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
