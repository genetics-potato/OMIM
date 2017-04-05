Imports System.IO
Imports System.Reflection
Imports System.Text
Imports Microsoft.VisualBasic.ComponentModel.Collection
Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel
Imports Microsoft.VisualBasic.Language
Imports Microsoft.VisualBasic.Scripting
Imports Microsoft.VisualBasic.Serialization.JSON
Imports Microsoft.VisualBasic.Text
Imports Oracle.LinuxCompatibility.MySQL
Imports Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic
Imports Oracle.LinuxCompatibility.MySQL.Reflection.Schema

''' <summary>
''' The large cosmic tsv database imports tools
''' </summary>
Public Module TSV

    ''' <summary>
    ''' 将tsv文件导入为mysql INSERT INTO脚本，以方便进行数据的导入操作
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="tsv$"></param>
    ''' <param name="save$"></param>
    Public Sub Dump(Of T As SQLTable)(tsv$, Optional save$ = Nothing, Optional block_size% = 1024)
        Dim type As Type = GetType(T)
        Dim schema As New Table(type)
        Dim propWrites As NamedValue(Of PropertyInfo)() =
            schema.Fields _
            .Select(Function(o) New NamedValue(Of PropertyInfo) With {
                .Name = CodeGenerator.FixInvalids(o.FieldName).ToLower,
                .Value = o.PropertyInfo
            }).ToArray

        If save.StringEmpty Then
            save = tsv.TrimSuffix & ".sql"
        End If
        If Not save.Split("."c).Last.TextEquals("sql") Then
            save = save & "/" & GetType(T).Name & ".sql"
        End If

        Call $"Open cosmic tsv table: {tsv.ToFileURL}, length={tsv.FileLength}bytes".__INFO_ECHO

        Using reader As StreamReader = tsv.OpenReader(Encoding.ASCII), sql As StreamWriter = save.OpenWriter
            Dim tmp As New List(Of T)
            Dim index As IndexOf(Of String) = reader.GetTsvHeader(
                lower:=True,
                process:=AddressOf CodeGenerator.FixInvalids)

            ' check for schema
            For Each field As NamedValue(Of PropertyInfo) In propWrites
                If index(field.Name) = -1 Then
                    Throw New Exception($"{schema.TableName}({tsv.FileName}): Not {field.Name} In {index.ToString}")
                End If
            Next

            Call $"{tsv} --> {save}".__DEBUG_ECHO

            Do While Not reader.EndOfStream
                Dim o As Object = Activator.CreateInstance(type)
                Dim row As T = DirectCast(o, T)
                Dim data$() = reader.ReadLine.Split(ASCII.TAB)
                Dim s$ = Nothing
                Dim v As Object

                For Each field As NamedValue(Of PropertyInfo) In propWrites
                    Try
                        s = data(index(field.Name))

                        If field.Value.PropertyType Is GetType(String) Then
                            s = MySqlEscaping(s)
                            v = s
                        Else
                            v = InputHandler.CTypeDynamic(s, field.Value.PropertyType)
                        End If

                        Call field.Value.SetValue(o, value:=v)
                    Catch ex As Exception
                        ex = New Exception(data.GetJson, ex)
                        ex = New Exception("fieldName is " & field.Name & ", and value is " & s, ex)
                        Call App.LogException(ex)
                        Call ex.PrintException

                        Continue Do
                    End Try
                Next

                If tmp.Count <= block_size Then
                    tmp += row
                Else
                    Call sql.WriteLine(tmp.DumpTransaction)
                    Call sql.Flush()
                    Call tmp.Clear()
                End If
            Loop

            If tmp.Count > 0 Then
                Call sql.WriteLine(tmp.DumpTransaction)
                Call tmp.Clear()
            End If
        End Using
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="DIR$"></param>
    ''' <param name="save$">The export directory</param>
    Public Sub DumpFromDirectory(DIR$, save$)
        Call TSV.Dump(Of mysql.cosmic_genome_screens_mutant_export)(DIR & "\CosmicGenomeScreensMutantExport.tsv", save)
        Call TSV.Dump(Of mysql.hgnc)(DIR & "\CosmicHGNC.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_mutant_export)(DIR & "\CosmicMutantExport.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_mutant_export_census)(DIR & "\CosmicMutantExportCensus.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_ncv)(DIR & "\CosmicNCV.tsv", save)
        Call TSV.Dump(Of mysql.resistance_mutations)(DIR & "\CosmicResistanceMutations.tsv", save)
        Call TSV.Dump(Of mysql.sample_features)(DIR & "\CosmicSample.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_struct_export)(DIR & "\CosmicStructExport.tsv", save)
        Call TSV.Dump(Of mysql.transcripts)(DIR & "\CosmicTranscripts.tsv", save)
        Call TSV.Dump(Of mysql.ascat_acf_ploidy)(DIR & "\ascat_acf_ploidy.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_breakpoints_export)(DIR & "\CosmicBreakpointsExport.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_complete_cna)(DIR & "\CosmicCompleteCNA.tsv", save)
        Call TSV.Dump(Of mysql.complete_differential_methylation)(DIR & "\CosmicCompleteDifferentialMethylation.tsv", save)
        Call TSV.Dump(Of mysql.gene_expression)(DIR & "\CosmicCompleteGeneExpression.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_complete_targeted_screens_mutant_export)(DIR & "\CosmicCompleteTargetedScreensMutantExport.tsv", save)
        Call TSV.Dump(Of mysql.cosmic_fusion_export)(DIR & "\CosmicFusionExport.tsv", save)
    End Sub
End Module
