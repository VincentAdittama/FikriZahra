Public Class Inputan
    Public BMI, Tinggi, Berat As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Res.Click, Res.Click
        Tinggi = Val(Tall.Text)
        Berat = Val(Weight.Text)
        Result.Show()
    End Sub
End Class