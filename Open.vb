Imports System.Drawing.Text

Public Class Anu

    Private Sub Jeneng_TextChanged(sender As Object, e As EventArgs) Handles Jeneng.TextChanged

    End Sub

    Private Sub Jeneng_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Jeneng.KeyPress

    End Sub

    Private Sub Jeneng_KeyDown(sender As Object, e As KeyEventArgs) Handles Jeneng.KeyDown
        If e.KeyCode = Keys.Enter Then
            Inputan.Show()
            Me.Hide()
        End If
    End Sub
End Class


