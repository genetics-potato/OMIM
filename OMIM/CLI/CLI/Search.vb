Imports System.IO
Imports Microsoft.VisualBasic.CommandLine
Imports Microsoft.VisualBasic.CommandLine.Reflection
Imports SMRUCC.Clinic.OMIM
Imports SMRUCC.Clinic.OMIM.Handlers.search

Partial Module CLI

    <ExportAPI("/Search.entry",
               Info:="Search for OMIM entries by a specific term input.",
               Usage:="/Search.entry /term <search_term> [/filter <term> /fields <null> /sort <sort_options> /out <out_file|std_out> /start 0 /limit 10 /retrieve <geneMap|clinicalSynopsis,default:null>]")>
    <ParameterInfo("/term", False,
                   AcceptTypes:={GetType(String)},
                   Description:="The keyword for the searches.")>
    Public Function EntrySearch(args As CommandLine) As Integer
        Dim term As String = args.ReadInput("/term")
        Dim filter As String = args("/filter")
        Dim fields As String = args("/fields")
        Dim sort As String = args("/sort")
        Dim start As Integer = args.GetValue("/start", 0)
        Dim limit As Integer = args.GetValue("/limit", 10)
        Dim retrieve As String = args.GetValue("/retrieve", "null")
        Dim api As New API(Program.APIKey)

        Using out As StreamWriter = args.OpenStreamOutput("/out")
            Dim query As New searchQuery(API.Handlers.entry) With {
                .fields = fields,
                .filter = filter,
                .limit = limit,
                .search = term,
                .start = start,
                .retrieve = retrieve.GetEntryRetrieves,
                .sort = sort.GetSearchSorts
            }
            Call out.Write(api.Search(query))
        End Using

        Return 0
    End Function

    <ExportAPI("/Search.clinicalSynopsis",
               Info:="OMIM searches for clinical Synopsis by using keyword.",
               Usage:="/Search.clinicalSynopsis /term <search_term> [/filter <term> /fields <null> /sort <sort_options> /out <out_file|std_out> /start 0 /limit 10]")>
    Public Function clinicalSynopsisSearch(args As CommandLine) As Integer
        Dim term As String = args.ReadInput("/term")
        Dim filter As String = args("/filter")
        Dim fields As String = args("/fields")
        Dim sort As String = args("/sort")
        Dim start As Integer = args.GetValue("/start", 0)
        Dim limit As Integer = args.GetValue("/limit", 10)
        Dim api As New API(Program.APIKey)

        Using out As StreamWriter = args.OpenStreamOutput("/out")
            Dim query As New searchQuery(API.Handlers.clinicalSynopsis) With {
                .fields = fields,
                .filter = filter,
                .limit = limit,
                .search = term,
                .start = start,
                .sort = sort.GetSearchSorts
            }
            Call out.Write(api.Search(query))
        End Using

        Return 0
    End Function

    <ExportAPI("/Search.geneMap",
               Usage:="/Search.geneMap /term <search_term> [/filter <term> /fields <null> /sort <sort_options> /out <out_file|std_out> /start 0 /limit 10]")>
    Public Function geneMapSearch(args As CommandLine) As Integer
        Dim term As String = args.ReadInput("/term")
        Dim filter As String = args("/filter")
        Dim fields As String = args("/fields")
        Dim sort As String = args("/sort")
        Dim start As Integer = args.GetValue("/start", 0)
        Dim limit As Integer = args.GetValue("/limit", 10)
        Dim api As New API(Program.APIKey)

        Using out As StreamWriter = args.OpenStreamOutput("/out")
            Dim query As New searchQuery(API.Handlers.geneMap) With {
                .fields = fields,
                .filter = filter,
                .limit = limit,
                .search = term,
                .start = start,
                .sort = sort.GetSearchSorts
            }
            Call out.Write(api.Search(query))
        End Using

        Return 0
    End Function
End Module