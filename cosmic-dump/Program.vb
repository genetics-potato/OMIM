Imports Microsoft.VisualBasic.CommandLine
Imports Microsoft.VisualBasic.CommandLine.Reflection
Imports SMRUCC.Clinic.Data

Module Program

    Public Function Main() As Integer
        Return GetType(Program).RunCLI(App.CommandLine)
    End Function

    <ExportAPI("/Imports.Cosmic.Tsv",
               Usage:="/Imports.Cosmic.Tsv /in <tsv.DIR> [/out <mysql.DIR>]")>
    Public Function ImportsCosmic(args As CommandLine) As Integer
        Dim in$ = args <= "/in"
        Dim out As String = args.GetValue("/out", [in].TrimDIR & ".mysql_Dumps/")
        Call Cosmic.DumpFromDirectory([in], save:=out)
        Return 0
    End Function

    <ExportAPI("/Imports.Cosmic.Csv",
               Usage:="/Imports.Cosmic.Csv /in <cosmic.DIR> /out <mysql.DIR>")>
    Public Function ImportsCosmicCsv(args As CommandLine) As Integer
        Dim in$ = args <= "/in"
        Dim out As String = args.GetValue("/out", [in].TrimDIR & ".mysql_Dumps/")
        Call Cosmic.DumpCsvFiles([in], out)
        Return 0
    End Function
End Module
