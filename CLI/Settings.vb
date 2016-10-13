Imports System.Text
Imports Microsoft.VisualBasic.ComponentModel.Settings
Imports Microsoft.VisualBasic.Serialization.JSON

Public Class Settings : Implements IProfile

    <ProfileItem> Public Property key As String

#Region "Generic Parameters: There are a number of generic parameters which are supported by all handler"

    ''' <summary>
    ''' This specifies the format Of the data returned, these include 'html', 'xml', 'json', 'jsonp', 'python' and 'ruby' (for example 'format=xml'). 
    ''' The html format is just the xml with a stylesheet applied to it, this application is done in the API itself. This allows a developer to 
    ''' get responses from the API marked up in html suitable for a web browser. Note that 'text' is only useful in very specific cases.
    ''' </summary>
    ''' <returns></returns>
    <ProfileItem(Description:="This specifies the format Of the data returned, these include 'html', 'xml', 'json', 'jsonp', 'python' and 'ruby' (for example 'format=xml'). The html format is just the xml with a stylesheet applied to it, this application is done in the API itself. This allows a developer to get responses from the API marked up in html suitable for a web browser. Note that 'text' is only useful in very specific cases.")> Public Property format As String
    ''' <summary>
    ''' This specifies the callback Function name For 'jsonp'. If omitted or invalid, the callback function defaults to 'omimWrapper'.
    ''' </summary>
    ''' <returns></returns>
    <ProfileItem(Description:="This specifies the callback Function name For 'jsonp'. If omitted or invalid, the callback function defaults to 'omimWrapper'.")>
    Public Property jsonp As String
    ''' <summary>
    ''' This returns debug output Of what the API received from the client (For example 'debug=true'). No data will be returned.
    ''' </summary>
    ''' <returns></returns>
    <ProfileItem(Description:="This returns debug output Of what the API received from the client (For example 'debug=true'). No data will be returned.")>
    Public Property debug As Boolean
    ''' <summary>
    ''' This causes the API To include stylesheet URL For rendering by a browser (For example 'style=true'). This is only 
    ''' useful for the 'xml' format, and allows the client to render the XML into HTML locally as opposed to having the 
    ''' API do it for them.
    ''' </summary>
    ''' <returns></returns>
    <ProfileItem(Description:="This causes the API To include stylesheet URL For rendering by a browser (For example 'style=true'). This is only useful for the 'xml' format, and allows the client to render the XML into HTML locally as opposed to having the API do it for them.")>
    Public Property style As Boolean
#End Region

    Public Shared ReadOnly Property DefaultFile As String = App.HOME & "/.settings.json"

    Private Property FilePath As String Implements IProfile.FilePath

    Public Overrides Function ToString() As String
        Return Me.GetJson
    End Function

    Public Shared Function Load() As Settings
        If DefaultFile.FileExists Then
            Return DefaultFile.ReadAllText.LoadObject(Of Settings)
        Else
            Return New Settings
        End If
    End Function

    Public Function Save(Optional FilePath As String = "", Optional Encoding As Encoding = Nothing) As Boolean Implements IProfile.Save
        Return Me.GetJson.SaveTo(If(String.IsNullOrEmpty(FilePath), DefaultFile, FilePath), Encoding)
    End Function
End Class