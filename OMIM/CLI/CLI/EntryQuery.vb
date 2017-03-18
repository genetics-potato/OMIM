Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CommandLine
Imports Microsoft.VisualBasic.CommandLine.Reflection
Imports SMRUCC.Clinic.OMIM
Imports SMRUCC.Clinic.OMIM.Handlers

Partial Module CLI

    Const CLI_output As String = "The output stream pointer value of your query result. 

+ If this parameter value is not specific, then output will be the standard output pointer(CLI Pipeline mode)
+ Otherwise the output will be redirect to your specific file."

    Const CLI_inputs As String = "The OMIM database entry id or list of these id value. 

+ If the id list source is a text file, then this text file format required of each line is a mim id number. This makes more easy on large amount data query.
+ If this parameter is a id list, then each id value should seperated by comma character.
+ If this parameter is not represented, then the program will open the standard input as data source.(CLI pipeline mode)"

    <ExportAPI("/Query.entry", Info:="Gets OMIM data by mim entry number.",
               Usage:="/Query.entry /id <id|id_list|id_list.txt> [/includes <all,...> /text <all> /out <out_file|std_out>]",
               Example:="/Query.entry /id 100100,100200 /includes referenceList,clinicalSynopsis /text all /out ~/example.json")>
    <Argument("/id", False, AcceptTypes:={GetType(String), GetType(String())},
                   Description:=CLI_inputs,
                   Example:="/id ""~/entries.txt""")>
    <Argument("/includes", True, AcceptTypes:={GetType(String())},
                   Description:="Additional content can be retrieved using the 'include' parameter, the includes are as follows:
                   
|Parameter         |Description|
|------------------|---------------------------------------------------------------------------------------------------------|
|text              |Includes the text field sections with the entry.|
|existflags        |Include the 'exists' flags with the entry (clinical synopsis, allelic variant, gene map & phenotype map).|
|allelicVariantList|Includes the allelic variant list with the entry.|
|clinicalSynopsis  |Include the clinical synopsis with the entry.|
|seeAlso           |Includes the 'see also' field with the entry.|
|referenceList     |Include the reference list with the entry.|
|geneMap           |Include the gene map/phenotype map data with the entry.|
|externalLinks     |Include the external links with the entry.|
|contributors      |Includes the 'contributors' field with the entry.|
|creationDate      |Includes the 'creation date' field with the entry.|
|editHistory       |Includes the 'edit history' field with the entry.|
|dates             |Include the dates data with the entry.|
|all               |Include the above data with the entry.|",
                   Example:="/includes referenceList,clinicalSynopsis")>
    <Argument("/out", True, AcceptTypes:={GetType(String)},
                   Description:=CLI_output,
                   Example:="/out ""/home/xieguigang/query_result.json""")>
    Public Function QueryEntry(args As CommandLine) As Integer
        Dim ids As String() = args.__getIds
        Dim api As New API(Program.APIKey)
        Dim includes As String() = args.GetValue("/includes", "all").Split(","c)
        Dim text As String = args.GetValue("/text", "all")
        Dim query As New entry.EntryQuery(ids,) With {
            .debug = Program.Settings.debug,
            .format = Program.Settings.format.GetFormats,
            .jsonp = Program.Settings.jsonp,
            .style = Program.Settings.style,
            .textSection = text.GetTextSections,
            .includes = New List(Of entry.includes)(includes.Select(AddressOf GetEntryIncludes))
        }

        Using out = args.OpenStreamOutput("/out")
            Call out.Write(api.APIQuery(query))
        End Using

        Return 0
    End Function

    Public Sub ApplyGenericSettings(ByRef query As IQuery)
        query.debug = Program.Settings.debug
        query.format = Program.Settings.format.GetFormats
        query.jsonp = Program.Settings.jsonp
        query.style = Program.Settings.style
    End Sub

    <Extension>
    Private Function __getIds(args As CommandLine) As String()
        Dim id As String = Nothing
        Dim file = args.OpenStreamInput("/id", id)
        Dim ids As String() = If(file Is Nothing, id.Split(","c), file.ReadToEnd.lTokens)
        Return ids
    End Function

    <ExportAPI("/Query.clinicalSynopsis", Usage:="/Query.clinicalSynopsis /id <id|id_list|id_list.txt> [/includes <all,...> /out <out_file|std_out>]",
               Example:="/Query.clinicalSynopsis /id 100100 /includes externalLinks,clinicalSynopsis /out ./100100-clinicalSynopsis.json")>
    <Argument("/id", False, AcceptTypes:={GetType(String), GetType(String())},
                   Description:=CLI_inputs,
                   Example:="/id ""~/entries.txt""")>
    <Argument("/out", True, AcceptTypes:={GetType(String)},
                   Description:=CLI_output,
                   Example:="/out ""/home/xieguigang/query_result.json""")>
    <Argument("/includes", True, AcceptTypes:={GetType(String())},
                   Description:="Additional content can be retrieved using the 'include' parameter, the includes are as follows:

|Parameter       |Description                                                                                             |
|----------------|--------------------------------------------------------------------------------------------------------|
|clinicalSynopsis|Include the clinical synopsis with the entry.
|existflags      |Include the 'exists' flags with the entry (clinical synopsis, allelic variant, gene map & phenotype map).
|externalLinks   |Include the external links with the entry.
|contributors    |Include the contributors with the entry.
|creationDate    |Include the creation date with the entry.
|editHistory     |Include the edit history with the entry.
|dates           |Include the dates with the entry.
|all             |Include the above data with the entry.")>
    Public Function QueryclinicalSynopsis(args As CommandLine) As Integer
        Dim ids As String() = args.__getIds
        Dim api As New API(Program.APIKey)
        Dim query As New clinicalSynopsis.clinicalSynopsisQuery(ids)

        Using out = args.OpenStreamOutput("/out")
            Call ApplyGenericSettings(query)
            Call out.Write(api.clinicalSynopsis(query))
        End Using

        Return 0
    End Function

    <ExportAPI("/Query.geneMap.entry", Usage:="/Query.geneMap.entry /id <id|id_list|id_list.txt> [/out <out_file|std_out>]")>
    <Argument("/id", False, AcceptTypes:={GetType(String), GetType(String())},
                   Description:=CLI_inputs,
                   Example:="/id ""~/entries.txt""")>
    <Argument("/out", True, AcceptTypes:={GetType(String)},
                   Description:=CLI_output,
                   Example:="/out ""/home/xieguigang/query_result.json""")>
    Public Function QueryGeneMaps_entry(args As CommandLine) As Integer
        Dim ids As String() = args.__getIds
        Dim api As New API(Program.APIKey)
        Dim query As New geneMap.geneMapEntryQuery(ids)

        Using out = args.OpenStreamOutput("/out")
            Call ApplyGenericSettings(query)
            Call out.Write(api.APIQuery(query))
        End Using

        Return 0
    End Function

    Const geneMap_phenotypeExists As String = "Additionally the ``phenotypeExists`` flag can be used to restrict the entries returned to those with or without phenotypes, the default is to return all entries:

|Parameter      |Description                                                                                             |
|---------------|--------------------------------------------------------------------------------------------------------|
|phenotypeExists|``true`` will only return entries with phenotypes, ``false`` will only return entries without phenotypes|"

    <ExportAPI("/Query.geneMap.loci", Usage:="/Query.geneMap.loci /chr <chr_id> /chr.Sort <int> [/phenotypeExists /start <default:0> /limit <default:0> /out <out_file|std_out>]")>
    <Argument("/out", True, AcceptTypes:={GetType(String)},
                   Description:=CLI_output,
                   Example:="/out ""/home/xieguigang/query_result.json""")>
    <Argument("/phenotypeExists", True, AcceptTypes:={GetType(Boolean)},
                   Description:=geneMap_phenotypeExists)>
    Public Function QueryGeneMaps_loci(args As CommandLine) As Integer
        Dim chr As String = args("/chr")
        Dim sort As String = args("/chr.Sort")
        Dim start As Integer = args.GetInt32("/start")
        Dim limit As Integer = args.GetInt32("/limit")
        Dim query As New geneMap.geneMapQuery With {
            .chromosome = chr,
            .chromosomeSort = sort,
            .debug = Program.Settings.debug,
            .format = Program.Settings.format.GetFormats,
            .jsonp = Program.Settings.jsonp,
            .limit = limit,
            .phenotypeExists = args.GetBoolean("/phenotypeExists"),
            .start = start,
            .style = Program.Settings.style
        }
        Dim api As New API(Program.APIKey)

        Using out = args.OpenStreamOutput("/out")
            Call out.Write(api.APIQuery(query))
        End Using

        Return 0
    End Function

    <ExportAPI("/Query.geneMap.seqID", Usage:="/Query.geneMap.seqID /seqid <id> [/phenotypeExists /start <default:0> /limit <default:0> /out <out_file|std_out>]")>
    <Argument("/id", False, AcceptTypes:={GetType(String), GetType(String())},
                   Description:="The OMIM database entry id value. If this parameter is not represented, then the program will open the standard input as data source.(CLI pipeline mode), ortherwise program will accept this parameter value as ``seqID`` value.",
                   Example:="/id ""~/entries.txt""")>
    <Argument("/out", True, AcceptTypes:={GetType(String)},
                   Description:=CLI_output,
                   Example:="/out ""/home/xieguigang/query_result.json""")>
    <Argument("/phenotypeExists", True, AcceptTypes:={GetType(Boolean)},
                   Description:=geneMap_phenotypeExists)>
    Public Function QueryGeneMaps_seqID(args As CommandLine) As Integer
        Dim seqid As String = args.ReadInput("/seqid")
        Dim start As Integer = args.GetInt32("/start")
        Dim limit As Integer = args.GetInt32("/limit")
        Dim query As New geneMap.geneMapQuery With {
            .sequenceID = seqid,
            .debug = Program.Settings.debug,
            .format = Program.Settings.format.GetFormats,
            .jsonp = Program.Settings.jsonp,
            .limit = limit,
            .phenotypeExists = args.GetBoolean("/phenotypeExists"),
            .start = start,
            .style = Program.Settings.style
        }
        Dim api As New API(Program.APIKey)

        Using out = args.OpenStreamOutput("/out")
            Call out.Write(api.APIQuery(query))
        End Using

        Return 0
    End Function
End Module