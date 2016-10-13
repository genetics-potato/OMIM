Imports System.Text
Imports Microsoft.VisualBasic.CommandLine
Imports Microsoft.VisualBasic.CommandLine.Reflection
Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel
Imports Microsoft.VisualBasic.ComponentModel.Settings
Imports Microsoft.VisualBasic.Scripting.MetaData
Imports Microsoft.VisualBasic.Serialization.JSON
Imports SMRUCC.Clinic.OMIM.Handlers

<PackageNamespace("OMIM_CLI", Category:=APICategories.CLI_MAN,
                  Description:="
### OMIM® - Online Mendelian Inheritance in Man®

Welcome to OMIM®, Online Mendelian Inheritance in Man®. OMIM is a comprehensive, authoritative compendium of human genes and genetic phenotypes that is freely available and updated daily. 
The full-text, referenced overviews in OMIM contain information on all known mendelian disorders and over 15,000 genes. OMIM focuses on the relationship between phenotype and genotype. 
It is updated daily, and the entries contain copious links to other genetics resources.		

This database was initiated in the early 1960s by Dr. Victor A. McKusick as a catalog of mendelian traits and disorders, entitled Mendelian Inheritance in Man (MIM). 
Twelve book editions of MIM were published between 1966 and 1998. The online version, OMIM, was created in 1985 by a collaboration between the National Library of Medicine and the William H. Welch Medical Library at Johns Hopkins. 
It was made generally available on the internet starting in 1987. In 1995, OMIM was developed for the World Wide Web by NCBI, the National Center for Biotechnology Information.

OMIM is authored and edited at the McKusick-Nathans Institute of Genetic Medicine, Johns Hopkins University School of Medicine, under the direction of Dr. Ada Hamosh.
                                    
Copyright® 1966-2016 Johns Hopkins University.

The OMIM® database including the collective data contained therein is the property of the Johns Hopkins University, which holds the copyright thereto.             
The OMIM database is made available to the general public subject to certain restrictions. You may use the OMIM database and data obtained from this site for your personal use, for educational or scholarly use, or for research purposes only. 
The OMIM database may not be copied, distributed, transmitted, duplicated, reduced or altered in any way for commercial purposes, or for the purpose of redistribution, without a license from the Johns Hopkins University.
Requests for information regarding a license for commercial use or redistribution of the OMIM database may be sent via e-mail to JHTT-Communications@jhmi.edu.")>
Module CLI

    <ExportAPI("/Set.Key", Usage:="/Set.Key <key>",
               Info:="Setup the OMIM API key for query the database.",
               Example:="/Set.Key ""039583F9182AE1F7C343746B9B54C1F1BF1678A9""")>
    <ParameterInfo("key", False,
                   AcceptTypes:={GetType(String)},
                   Description:="The api key of this OMIM query client.",
                   Example:="039583F9182AE1F7C343746B9B54C1F1BF1678A9")>
    Public Function SetKey(args As CommandLine) As Integer
        Dim key As String = args.SingleValueOrStdIn
        Return New Settings With {
            .key = key
        }.GetJson.SaveTo(Settings.DefaultFile).CLICode
    End Function

    <ExportAPI("/Set", Usage:="/Set <var> <value>",
               Info:="Setup the OMIM API tools variables.",
               Example:="/Set ""format"" ""json""")>
    Public Function SetVar(args As CommandLine) As Integer
        Using settings = ComponentModel.Settings _
            .Settings(Of Settings) _
            .Load(OMIM_CLI.Settings.Load)

            Dim var As NamedValue(Of String) = args.ParameterList.First
            Return settings.Set(var).CLICode
        End Using
    End Function

    <ExportAPI("/vars", Info:="Listing all of the variables for using the `/Set` command.",
               Usage:="/vars",
               Example:="/vars")>
    Public Function ListSettings(args As CommandLine) As Integer
        Dim settings = ComponentModel.Settings _
            .Settings(Of Settings) _
            .Load(OMIM_CLI.Settings.Load)
        Call Console.WriteLine(settings.View)
        Return 0
    End Function

    <ExportAPI("/debug", Info:="Displays the debugging information from the OMIM API server.",
               Usage:="/debug",
               Example:="/debug")>
    Public Function Debug() As Integer
        Dim dump As New dump
        Call Console.WriteLine(dump.GetJson(True))
        Return 0
    End Function
End Module
