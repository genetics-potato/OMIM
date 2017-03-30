Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace XML

    <XmlType("drug-interaction")>
    Public Class DrugInteraction

        <XmlElement("drugbank-id")>
        Public Property drugbankID As String
        Public Property name As String
        Public Property description As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    <XmlType("affected-organism")>
    Public Class affected_organism
        <XmlText>
        Public Property value As String
    End Class

    Public Class category
        Public Property category As String
        <XmlElement("mesh-id")> Public Property mesh_id As String
    End Class

    ''' <summary>
    ''' The price for the given drug in US or Canadian currency.
    ''' </summary>
    Public Class price
        Public Property description As String
        Public Property cost As cost
        Public Property unit As String
    End Class

    Public Class cost
        <XmlAttribute> Public Property currency As String
        <XmlText> Public Property value As String
    End Class

    Public Class manufacturer
        <XmlAttribute> Public Property generic As Boolean
        <XmlAttribute> Public Property url As String
        <XmlText> Public Property value As String
    End Class

    Public Class packager
        Public Property name As String
        Public Property url As String
    End Class

    Public Class mixture
        Public Property name As String
        Public Property ingredients As String
    End Class

    Public Class product
        Public Property name As String
        Public Property labeller As String
        <XmlElement("ndc-id")> Public Property ndc_id As String
        <XmlElement("ndc-product-code")> Public Property ndc_product_code As String
        ''' <summary>
        ''' DPD ID from the Canadian Drug Product Database. Only present for drugs that are marketed in Canada.
        ''' </summary>
        ''' <returns></returns>
        <XmlElement("dpd-id")> Public Property dpd_id As String
        <XmlElement("started-marketing-on")> Public Property started_marketing_on As String
        <XmlElement("ended-marketing-on")> Public Property ended_marketing_on As String
        <XmlElement("dosage-form")> Public Property dosage_form As String
        Public Property strength As String
        Public Property route As String
        <XmlElement("fda-application-number")> Public Property fda_application_number As String
        Public Property generic As Boolean
        <XmlElement("over-the-counter")> Public Property over_the_counter As Boolean
        Public Property approved As Boolean
        Public Property country As String
        Public Property source As String
    End Class

    Public Class synonym
        <XmlAttribute> Public Property language As String
        <XmlAttribute> Public Property coder As String
        <XmlText> Public Property value As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    Public Class classification
        Public Property description As String
        <XmlElement("direct-parent")> Public Property directParent As String
        Public Property kingdom As String
        Public Property superclass As String
        Public Property [class] As String
        Public Property subclass As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    <XmlType("group")> Public Class Group
        <XmlText>
        Public Property value As String
    End Class

    Public Class DrugBankID

        <XmlAttribute> Public Property primary As Boolean
        <XmlText> Public Property ID As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class

    <XmlType("effect")> Public Class snpEffect
        <XmlElement("protein-name")>
        Public Property proteinName As String
        <XmlElement("gene-symbol")>
        Public Property geneSymbol As String
        <XmlElement("uniprot-id")>
        Public Property uniprotID As String
        <XmlElement("rs-id")>
        Public Property rsID As String
        Public Property allele As String
        <XmlElement("defining-change")>
        Public Property definingChange As String
        Public Property description As String
        <XmlElement("pubmed-id")>
        Public Property pubmedID As String
    End Class
End Namespace
