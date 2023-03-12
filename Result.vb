Public Class Result
    Private Sub Result_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Res.Text = Math.Round(Inputan.Berat / ((Inputan.Tinggi / 100) * (Inputan.Tinggi / 100)), 2)
        Label1.Text = Anu.Jeneng

    End Sub
    Private Sub Result_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            Me.Hide()
        End If
    End Sub

    Private Sub Res_Click(sender As Object, e As EventArgs) Handles Res.Click

    End Sub
End Class