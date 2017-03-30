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

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
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
        <XmlElement("theoretical-pi")>
        Public Property theoreticalPI As String
        <XmlElement("molecular-weight")>
        Public Property molecularWeight As String
        <XmlElement("chromosome-location")>
        Public Property chromosomeLocation As String
        Public Property organism As organism
        <XmlArray("external-identifiers")>
        Public Property externalIdentifiers As externalIdentifier()
        Public Property synonyms As synonym()
        <XmlElement("amino-acid-sequence")> Public Property AA As sequence
        <XmlElement("gene-sequence")> Public Property NT As sequence
        Public Property pfams As pfam()
        <XmlArray("go-classifiers")>
        Public Property goClassifiers As goClassifier()

    End Class

    Public Class organism

        <XmlAttribute("ncbi-taxonomy-id")>
        Public Property NCBItaxonomyID As String
        <XmlText>
        Public Property name As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    <XmlType("go-classifier")>
    Public Class goClassifier

        ''' <summary>
        ''' 这里是用的是命名空间的简写
        ''' </summary>
        ''' <returns></returns>
        Public Property category As String
        Public Property description As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class pfam

        Public Property identifier As String
        Public Property name As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class action
        Public Property action As String

        Public Overrides Function ToString() As String
            Return action
        End Function
    End Class
End Namespace