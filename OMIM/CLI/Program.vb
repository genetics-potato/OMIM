Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel
Imports Microsoft.VisualBasic.Language

Module Program

    ''' <summary>
    ''' OMIM api key
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property APIKey As New Value(Of String)
    ''' <summary>
    ''' Generics parameter settings
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Settings As Settings
        Get
            Return __settings.value
        End Get
    End Property

    Dim __settings As New Value(Of Settings)

    ''' <summary>
    ''' Load settings and check for the api key license.
    ''' </summary>
    Sub New()
        Dim SetKey As String = GetType(CLI).API(NameOf(CLI.SetKey))

        ' Force the app debugging output redirect into the std_error device.
        VBDebugger.ForceSTDError = True

        If String.IsNullOrEmpty(APIKey = (__settings = OMIM_CLI.Settings.Load).key) Then
            If Not String.Equals(App.CommandLine.Name, SetKey, StringComparison.OrdinalIgnoreCase) AndAlso
                InStr(App.CommandLine.Name, "?") <= 0 Then

                Call $"No available licensed OMIM api key information was found!".Warning
                Call $"Please using ""{SetKey}"" command to setup your OMIM license first, and then run this command again.".__DEBUG_ECHO
                Call $"Using `??vars` command to view your currently installed licensed key.".__DEBUG_ECHO
                Call $"Please visit `https://omim.org/api/` for more details information.".__DEBUG_ECHO
                Call App.Exit(-10)
            End If
        End If

        ' Add API key into the App environment variables 
        Call App.JoinVariables(New NamedValue(Of String)("OMIM_APIKEY", APIKey))
    End Sub

    Public Function Main() As Integer
        Return GetType(CLI).RunCLI(App.CommandLine)
    End Function
End Module
