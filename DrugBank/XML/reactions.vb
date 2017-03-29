Imports System.Xml.Serialization

Namespace XML

    Public Class reaction
        Public Property sequence As String
        <XmlElement("left-element")>
        Public Property leftElements As element()
        <XmlElement("right-element")>
        Public Property rightElements As element()
        Public Property enzymes As reactionEnzyme()
    End Class

    <XmlType("enzyme")>
    Public Class reactionEnzyme : Inherits element
        <XmlElement("uniprot-id")>
        Public Property uniprotID As String
    End Class

    Public Class pathwayEnzyme
        <XmlElement("uniprot-id")>
        Public Property uniprotID As String()
    End Class

    Public Class element
        <XmlElement("drugbank-id")>
        Public Property drugbankID As String
        Public Property name As String
    End Class

    Public Class transporter : Inherits target
        <XmlAttribute>
        Public Property position As String
    End Class
End Namespace