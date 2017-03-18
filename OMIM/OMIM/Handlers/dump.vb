Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel
Imports Microsoft.VisualBasic.Language
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace Handlers

    ''' <summary>
    ''' The ``dump`` handle is used to return dump/debug data from the API.
    ''' 
    ''' For example
    ''' 
    ''' http://api.omim.org/api/dump
    ''' </summary>
    Public Class dump : Inherits ClassObject

        ''' <summary>
        ''' Servlet Request Values
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Request As Dictionary(Of String, String)
        ''' <summary>
        ''' HTTP Headers
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HTTPheaders As Dictionary(Of String, String)
        Public ReadOnly URL As String
        Public ReadOnly HTTP As String

        Const API_URL As String = "http://api.omim.org/api/dump"

        Sub New()
            Dim html As String = API_URL.GET ' http GET request
            Dim i As New Int
            Dim parts As String()() =
                LinqAPI.Exec(Of String()) <= From part As String()
                                             In html.lTokens.Split("")
                                             Where part.Length > 0
                                             Select part

            Request = __buildHash(parts(++i).Skip(1))
            HTTPheaders = __buildHash(parts(++i).Skip(1))
        End Sub

        Private Shared Function __buildHash(array As IEnumerable(Of String)) As Dictionary(Of String, String)
            Dim LQuery As IEnumerable(Of NamedValue(Of String)) =
                From line As String
                In array
                Select line.GetTagValue(":", trim:=True)
            Return LQuery.ToDictionary(
                Function(x) x.Name.Trim,
                Function(x) x.x)
        End Function

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function
    End Class
End Namespace