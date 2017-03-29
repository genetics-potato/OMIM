Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace XML

    <XmlType("drug")> Public Class Drug

        <XmlAttribute> Public Property type As String
        <XmlAttribute> Public Property created As String
        <XmlAttribute> Public Property updated As String
        <XmlElement("drugbank-id")> Public Property drugbankIDs As DrugBankID()
        Public Property name As String
        Public Property description As String
        <XmlElement("cas-number")> Public Property CASNumber As String
        Public Property unii As String
        <XmlElement("average-mass")>
        Public Property averageMass As Double
        <XmlElement("monoisotopic-mass")>
        Public Property monoisotopicMass As Double
        Public Property state As String
        Public Property groups As Group()
        <XmlElement("general-references")>
        Public Property generalReferences As references
        <XmlElement("synthesis-references")>
        Public Property synthesisReferences As String
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
        Public Property salts As salt()
        Public Property synonyms As synonym()
        Public Property products As product()
        <XmlArray("international-brands")>
        Public Property internationalBrands As internationalBrand()
        Public Property mixtures As mixture()
        Public Property packagers As packager()
        Public Property manufacturers As manufacturer()
        ''' <summary>
        ''' The price for the given drug in US or Canadian currency.
        ''' </summary>
        ''' <returns></returns>
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
        <XmlArray("calculated-properties")>
        Public Property calculated_properties As [property]()
        <XmlArray("experimental-properties")>
        Public Property experimentalProperties As [property]()
        <XmlArray("external-identifiers")>
        Public Property externalIdentifiers As externalIdentifier()
        Public Property pathways As pathway()
        Public Property targets As target()
        <XmlArray("external-links")>
        Public Property externalLinks As externalLink()
        <XmlArray("snp-effects")>
        Public Property snpEffects As snpEffect()
        Public Property reactions As reaction()

        ''' <summary>
        ''' 获取得到当前的这个药物对象的主编号，主编号在编号对象之中具有一个Primary的属性标记
        ''' 当在编号列表之中找不到这个属性的时候，会默认使用第一个编号作为主编号 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PrimaryID As String
            Get
                Dim primary As DrugBankID = drugbankIDs _
                    .Where(Function(id) id.primary = True) _
                    .FirstOrDefault
                If primary Is Nothing Then
                    ' 有些是还没有primaryID的，则默认使用id列表之中的第一个编号为主编号
                    primary = drugbankIDs.FirstOrDefault
                End If
                Return primary?.ID
            End Get
        End Property

        Public ReadOnly Property OtherIDs As String()
            Get
                Return drugbankIDs _
                    .Where(Function(id) Not id.primary) _
                    .Select(Function(id) id.ID) _
                    .ToArray
            End Get
        End Property
    End Class

    <XmlType("international-brand")>
    Public Class internationalBrand

    End Class

    Public Class salt

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