Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.ComponentModel.Collection
Imports Microsoft.VisualBasic.ComponentModel.DataSourceModel
Imports Microsoft.VisualBasic.Scripting
Imports Microsoft.VisualBasic.Text
Imports Oracle.LinuxCompatibility.MySQL
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
    Public Sub Dump(Of T As SQLTable)(tsv$, Optional save$ = Nothing)
        If save.StringEmpty Then
            save = tsv.TrimSuffix & ".sql"
        End If

        Using reader As StreamReader = tsv.OpenReader(), sql As StreamWriter = save.OpenWriter
            Dim index As New IndexOf(Of String)(reader.ReadLine.ToLower.Split(ASCII.TAB))
            Dim type As Type = GetType(T)
            Dim schema As New Table(type)
            Dim propWrites As NamedValue(Of PropertyInfo)() =
                schema.Fields _
                .Select(Function(o) New NamedValue(Of PropertyInfo) With {
                    .Name = o.FieldName.ToLower,
                    .Value = o.PropertyInfo
                }).ToArray

            Do While Not reader.EndOfStream
                Dim o As Object = Activator.CreateInstance(type)
                Dim row As SQLTable = DirectCast(o, SQLTable)
                Dim data$() = reader.ReadLine.Split(ASCII.TAB)

                For Each field As NamedValue(Of PropertyInfo) In propWrites
                    Dim s$ = data(index(field.Name))
                    Dim v As Object = InputHandler.CTypeDynamic(s, field.Value.PropertyType)
                    Call field.Value.SetValue(o, value:=v)
                Next

                Call sql.WriteLine(row.GetInsertSQL)
            Loop
        End Using
    End Sub
End Module
