Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace XML

    Public Class target
        Public Property id As String
        Public Property name As String
        Public Property organism As String
        Public Property actions As action()
        Public Property references As references
        <XmlElement("known-action")>
        Public Property knownAction As String
        Public Property polypeptide As polypeptide

    End Class

    Public Class polypeptide
        <XmlAttribute> Public Property id As String
        <XmlAttribute> Public Property source As String
        Public Property name As String
        <XmlElement("general-function")> Public Property generalFunction As String
        <XmlElement("specific-function")> Public Property specificFunction As String
        <XmlElement("gene-name")> Public Property geneName As String
        Public Property locus As String
        <XmlElement("cellular-location")> Public Property cellularLocation As String
        <XmlElement("transmembrane-regions")> Public Property transmembraneRegions As String
        <XmlElement("signal-regions")> Public Property signalRegions As String
        <XmlArray("external-identifiers")> Public Property externalIdentifiers As externalIdentifier()
        Public Property synonyms As synonym()
        <XmlElement("amino-acid-sequence")> Public Property AA As sequence
        <XmlElement("gene-sequence")> Public Property NT As sequence
        Public Property pfams As pfam()
        <XmlArray("go-classifiers")>
        Public Property goClassifiers As goClassifier()

    End Class

    <XmlType("go-classifier")>
    Public Class goClassifier
        Public Property category As String
        Public Property description As String
    End Class

    Public Class pfam
        Public Property identifier As String
        Public Property name As String
    End Class

    Public Class references
        Public Property articles As article()
    End Class

    Public Class article

        <XmlElement("pubmed-id")>
        Public Property pubmedID As String
        Public Property citation As String
    End Class

    Public Class action
        Public Property action As String
    End Class
End Namespace