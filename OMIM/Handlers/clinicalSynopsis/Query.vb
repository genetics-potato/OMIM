Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Linq

Namespace Handlers.clinicalSynopsis

    Public Class clinicalSynopsisQuery : Inherits IQuery

        Public Property mimNumber As New List(Of String)
        Public Property includes As New List(Of includes)

        Public Overrides ReadOnly Property handler As API.Handlers
            Get
                Return API.Handlers.clinicalSynopsis
            End Get
        End Property

        Public Overrides Function ToString() As String
            If includes.Count = 0 Then Return __mimValue(mimNumber)

            Dim inc As String = includes.ToArray(Function(x) x.ToString).JoinBy(",")
            Dim params As String = __mimValue(mimNumber) & "&includes=" & inc
            Return params
        End Function

        Sub New()
        End Sub

        Sub New(minNumber As String, Optional includes As includes = clinicalSynopsis.includes.all)
            Me.mimNumber.Add(minNumber)
            Me.includes.Add(includes.ToArray)
        End Sub

        Sub New(minNumber As String(), Optional includes As includes = clinicalSynopsis.includes.all)
            Me.mimNumber.Add(minNumber)
            Me.includes.Add(includes.ToArray)
        End Sub
    End Class
End Namespace