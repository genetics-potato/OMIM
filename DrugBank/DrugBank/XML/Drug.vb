﻿Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace XML

    Public Class Drug

        <XmlAttribute> Public Property type As String
        <XmlAttribute> Public Property created As String
        <XmlAttribute> Public Property updated As String
        <XmlElement("drugbank-id")> Public Property drugbankIDs As DrugBankID()
        Public Property name As String
        Public Property description As String
        <XmlElement("cas-number")> Public Property CASNumber As String
        Public Property unii As String
        Public Property state As String
        Public Property groups As Group()
        <XmlElement("general-references")>
        Public Property generalReferences As references
        <XmlElement("synthesis-references")>
        Public Property synthesisReferences As references
        Public Property indication As String
        Public Property pharmacodynamics As String
        <XmlElement("mechanism-of-action")>
        Public Property mechanism_of_action As String
        Public Property toxicity As String
        Public Property metabolism As String
        Public Property absorption As String
        <XmlElement("half-life")> Public Property halfLife As String
        <XmlElement("route-of-elimination")>
        Public Property route_of_elimination As String
        <XmlElement("volume-of-distribution")>
        Public Property volume_of_distribution As String
        Public Property clearance As String
        Public Property classification As classification
        Public Property synonyms As synonym()
        Public Property products As product()
        Public Property mixtures As mixture()
        Public Property packagers As packager()
        Public Property manufacturers As manufacturer()
        Public Property prices As price()
        Public Property categories As category()
        <XmlArray("affected-organisms")>
        Public Property affected_organisms As affected_organism()
        Public Property dosages As dosage()
        <XmlArray("atc-codes")>
        Public Property atcCodes As atcCode()
        <XmlArray("ahfs-codes")>
        Public Property ahfsCodes As ahfsCode()
        <XmlArray("pdb-entries")>
        Public Property pdbEntries As pdbEntry()
        <XmlElement("fda-label")>
        Public Property fdaLabel As String
        Public Property msds As String
        <XmlArray("drug-interactions")>
        Public Property drug_interactions As DrugInteraction()
        Public Property patents As patent()
        Public Property sequences As sequence()
        <XmlArray("experimental-properties")>
        Public Property experimentalProperties As [property]()
        <XmlArray("external-identifiers")>
        Public Property externalIdentifiers As externalIdentifier()
        Public Property pathways As pathway()
        Public Property targets As target()
        <XmlArray("external-links")>
        Public Property externalLinks As externalLink()

    End Class

    <XmlType("external-link")>
    Public Class externalLink
        Public Property resource As String
        Public Property url As String
    End Class

    <XmlType("pdn-entry")>
    Public Class pdbEntry
        <XmlText>
        Public Property entryID As String
    End Class

    <XmlType("ahfs-code")>
    Public Class ahfsCode
        <XmlText>
        Public Property code As String
    End Class

    <XmlType("atc-code")>
    Public Class atcCode

        <XmlAttribute>
        Public Property code As String
        <XmlElement("level")>
        Public Property levels As level()

    End Class

    Public Class level

        <XmlAttribute>
        Public Property code As String
        Public Property value As String
    End Class

    Public Class dosage
        Public Property form As String
        Public Property route As String
        Public Property strength As String
    End Class

    Public Class patent
        Public Property number As String
        Public Property country As String
        Public Property approved As String
        Public Property expires As String
        <XmlElement("pediatric-extension")> Public Property pediatric_extension As Boolean
    End Class
End Namespace