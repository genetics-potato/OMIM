Imports Microsoft.VisualBasic.Language
Imports Microsoft.VisualBasic.Linq

Namespace Handlers.entry

    Public Class EntryQuery : Inherits IQuery

        Public Property mimNumber As New List(Of String)
        Public Property includes As New List(Of entry.includes)
        Public Property textSection As textSections = textSections.null

        Public Overrides ReadOnly Property handler As API.Handlers
            Get
                Return API.Handlers.entry
            End Get
        End Property

        Public Overrides Function ToString() As String
            If includes.Count = 0 Then Return __mimValue(mimNumber)

            Dim inc As String() = includes _
                .Where(Function(x) x <> entry.includes.text) _
                .ToArray(Function(x) x.ToString)
            Dim params As String =
                __mimValue(mimNumber) & "&include=" & String.Join(",", inc)

            If includes.IndexOf(entry.includes.text) > -1 Then
                If includes.Count = 1 Then
                    params &= "text"
                Else
                    params &= ",text"
                End If

                If textSection <> textSections.null Then
                    params &= ":" & textSection.ToString
                End If
            End If

            Return params
        End Function

        Sub New()
        End Sub

        Sub New(minNumber As String, Optional includes As entry.includes = entry.includes.all)
            Me.mimNumber.Add(minNumber)
            Me.includes.Add(includes.ToArray)
        End Sub

        Sub New(minNumber As String(), Optional includes As entry.includes = entry.includes.all)
            Me.mimNumber.Add(minNumber)
            Me.includes.Add(includes.ToArray)
        End Sub
    End Class
End Namespace