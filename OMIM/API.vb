Imports Microsoft.VisualBasic.Language
Imports Microsoft.VisualBasic.Serialization.JSON
Imports SMRUCC.Clinic.OMIM.Handlers
Imports SMRUCC.Clinic.OMIM.Handlers.entry

''' <summary>
''' Online Mendelian Inheritance in Man (OMIM), a know ledgebase of human genes and genetic disorders
''' 
''' ##### OMIM API
''' 
''' The OMIM API URLs are organized In a very simple fashion:
'''
''' + ``/api/[handler]?[parameters]``
''' + ``/api/[handler]/[component]?[parameters]``
''' + ``/api/[handler]/[action]?[parameters]``
'''
''' The handler refers To the data Object, such As an entry Or a clinical synopsis.
''' The component Is Optional And refers To a specific data component within a data Object 
''' For example references within an entry.
''' The action Is Optional And refers To an action To be performed On a data Object, such 
''' As a search For entries.
''' For basic 'GET's, the component or action are usually optional.
''' The parameters would include things such As MIM numbers, data retrieval options And data 
''' formatting options.
''' Since this Is a read-only database, ``GET`` is the only HTTP method for public access, all 
''' other HTTP methods will return an error (except for the apiKey handle which supports 
''' ``POST`` and ``DELETE``).
''' </summary>
Public Class API : Inherits ClassObject

    Public Enum Handlers
        entry
        clinicalSynopsis
        geneMap
        search
        html
        apiKey
        dump
    End Enum

    ''' <summary>
    ''' The API host name is:
    ''' 
    ''' > api.omim.org
    ''' </summary>
    Public Const OMIM_API As String = "http://api.omim.org"

    ''' <summary>
    ''' API Key
    ''' </summary>
    Protected ReadOnly __key As Dictionary(Of String, String)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="key">
    ''' The API key is a key (SHA1 hash) that is unique to every developer wanting to access the API. 
    ''' It is allocated by OMIM and should not be shared. This has to be included with every request 
    ''' and is validated before the request is processed.
    ''' </param>
    ''' <remarks>
    ''' ##### API Key
    '''
    ''' The API key Is a key (SHA1 hash) that Is unique To every developer wanting To access the API. 
    ''' It Is allocated by OMIM And should Not be Shared. This has To be included With every request 
    ''' And Is validated before the request Is processed. There are three ways In which it can be 
    ''' included With a request.
    '''
    ''' + Added as an HTTP Header as follows
    '''    ```
    ''' ApiKey: 039583F9182AE1F7C343746B9B54C1F1BF1678A9
    '''    ```
    '''    
    ''' + Added as a cookie as follows
    '''    ```
    ''' Cookie: ApiKey=039583F9182AE1F7C343746B9B54C1F1BF1678A9
    '''    ```
    '''    
    ''' + Added as a parameter to the url request as follows
    '''    ```
    ''' http://api.omim.org/....?...&amp;apiKey=039583F9182AE1F7C343746B9B54C1F1BF1678A9
    '''    ```
    '''    
    ''' Note that the API key parameter name Is Case-sensitive.
    ''' </remarks>
    Sub New(key As String)
        __key = New Dictionary(Of String, String) From {
            {"ApiKey", key}
        }
    End Sub

#Region "Generic"

    ''' <summary>
    ''' API query of the OMIM database
    ''' </summary>
    ''' <param name="args"></param>
    ''' <returns></returns>
    Public Function APIQuery(args As IQuery) As String
        Dim url As String = BuildURL(args.handler, args)
        Dim text As String = url.GET(headers:=__key)
        Return text
    End Function

    Public Function BuildURL(handler As Handlers, Optional args As IQuery = Nothing) As String
        If args Is Nothing Then Return $"{OMIM_API}/api/{handler}"

        Dim param As String = args.ToString
        Dim generic As String = args.GetGenericSettings
        Dim url As String = $"{OMIM_API}/api/{handler}?{param}"

        If Not String.IsNullOrEmpty(generic) Then
            url &= "&" & generic
        End If

        Return url
    End Function

    Public Function Search(args As search.searchQuery) As String
        Dim url As String = $"{OMIM_API}/api/{args.handler.ToString}/search?" & args.ToString
        Dim generic As String = args.GetGenericSettings
        If Not String.IsNullOrEmpty(generic) Then
            url &= "&" & generic
        End If
        Dim text As String = url.GET(headers:=__key)
        Return text
    End Function
#End Region

    Public Function entry(query As EntryQuery) As String
        Return APIQuery(query)
    End Function

    ''' <summary>
    ''' The clinical synopsis handler supports the following actions/components:
    '''
    ''' [none]
    ''' 
    ''' This Is the default case And requires one parameter 'mimNumber' specifying the MIM entry to be retrieved, for example:
    ''' 
    ''' http://api.omim.org/api/clinicalSynopsis?mimNumber=100100
    ''' 
    ''' Multiple MIM numbers can be specified As follows
    ''' 
    ''' http://api.omim.org/api/clinicalSynopsis?mimNumber=100100&amp;mimNumber=100200
    ''' 
    ''' Or as follows
    ''' 
    ''' http://api.omim.org/api/clinicalSynopsis?mimNumber=100100,100200
    ''' 
    ''' This will Return the mim number, the prefix, the status And the titles.
    ''' </summary>
    Public Function clinicalSynopsis(query As clinicalSynopsis.clinicalSynopsisQuery) As String
        Return APIQuery(query)
    End Function

    Public Overrides Function ToString() As String
        Return OMIM_API
    End Function
End Class