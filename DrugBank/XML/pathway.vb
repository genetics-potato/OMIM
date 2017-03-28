﻿
Imports System.Xml.Serialization

Namespace XML

    Public Class pathway

        <XmlElement("smpdb-id")>
        Public Property smpdb_id As String
        Public Property name As String
        Public Property category As String
        Public Property drugs As drug()
        Public Property enzymes As enzyme()

        Public Class drug
            <XmlElement("drugbank-id")>
            Public Property drugbankID As String
            Public Property name As String
        End Class
    End Class

    <XmlType("external-identifier")>
    Public Class externalIdentifier
        Public Property resource As String
        Public Property identifier As String
    End Class

    Public Class [property]
        Public Property kind As String
        Public Property value As String
        Public Property source As String
    End Class

    Public Class sequence
        <XmlAttribute>
        Public Property format As String
        <XmlText>
        Public Property sequence As String

        Public Overrides Function ToString() As String
            Return sequence.lTokens.FirstOrDefault
        End Function
    End Class
End Namespace