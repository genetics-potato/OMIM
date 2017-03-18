Imports System.Text
Imports Microsoft.VisualBasic.Serialization.JSON

''' <summary>
''' Handlers' query base.
''' </summary>
Public MustInherit Class IQuery

    ''' <summary>
    ''' A mim number is required to get a entry!
    ''' </summary>
    Public Const NoValidEntry As String = "A mim number is required to get a entry!"

#Region "Generic Parameters: There are a number of generic parameters which are supported by all handler"

    ''' <summary>
    ''' This specifies the format Of the data returned, these include 'html', 'xml', 'json', 'jsonp', 'python' and 'ruby' (for example 'format=xml'). 
    ''' The html format is just the xml with a stylesheet applied to it, this application is done in the API itself. This allows a developer to 
    ''' get responses from the API marked up in html suitable for a web browser. Note that 'text' is only useful in very specific cases.
    ''' </summary>
    ''' <returns></returns>
    Public Property format As Formats = Formats.json
    ''' <summary>
    ''' This specifies the callback Function name For 'jsonp'. If omitted or invalid, the callback function defaults to 'omimWrapper'.
    ''' </summary>
    ''' <returns></returns>
    Public Property jsonp As String
    ''' <summary>
    ''' This returns debug output Of what the API received from the client (For example 'debug=true'). No data will be returned.
    ''' </summary>
    ''' <returns></returns>
    Public Property debug As Boolean
    ''' <summary>
    ''' This causes the API To include stylesheet URL For rendering by a browser (For example 'style=true'). This is only 
    ''' useful for the 'xml' format, and allows the client to render the XML into HTML locally as opposed to having the 
    ''' API do it for them.
    ''' </summary>
    ''' <returns></returns>
    Public Property style As Boolean
#End Region

    ''' <summary>
    ''' The handler refers to the data object, such as an entry or a clinical synopsis.
    ''' </summary>
    ''' <returns></returns>
    Public MustOverride ReadOnly Property handler As API.Handlers

    Public Function GetGenericSettings() As String
        Dim sb As String = ""

        sb &= $"{NameOf(format)}={format}"

        If Not String.IsNullOrEmpty(jsonp) Then
            sb &= $"&{NameOf(jsonp)}={jsonp}"
        End If
        If debug Then
            sb &= "&debug=true"
        End If
        If style Then
            sb &= "&style=true"
        End If

        Return sb
    End Function

    ''' <summary>
    ''' 请重写这个方法来构建URL参数
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return Me.GetJson
    End Function

    Protected Shared Function __mimValue(mimNumber As IEnumerable(Of String)) As String
        Dim mn As String

        If mimNumber.Count = 0 Then
            Throw New ArgumentException(NoValidEntry)
        Else
            mn = String.Join(",", mimNumber.ToArray)
        End If

        mn = "mimNumber=" & mn

        Return mn
    End Function
End Class

Public Structure rtvl(Of T As Class)

    Public Property omim As T

    Public Overrides Function ToString() As String
        Return MyClass.GetJson
    End Function
End Structure

''' <summary>
''' This specifies the format Of the data returned, these include 'html', 'xml', 'json', 'jsonp', 'python' and 'ruby' (for example 'format=xml'). 
''' The html format is just the xml with a stylesheet applied to it, this application is done in the API itself. This allows a developer to 
''' get responses from the API marked up in html suitable for a web browser. Note that 'text' is only useful in very specific cases.
''' </summary>
Public Enum Formats
    html
    xml
    json
    jsonp
    python
    ruby
    text
End Enum