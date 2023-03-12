Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics.X86
Imports System.Security.Cryptography.Pkcs

Public Class Inti
    Private Sub cek_Click(sender As Object, e As EventArgs) Handles cek.Click
        Dim tinggi, berat, BMI As Double
        Dim ket1, ket2, ket3 As String
        Dim Miaw As String = nama.Text
        ket1 = " Anda Normal"
        ket2 = " Anda perlu menambah berat badan anda"
        ket3 = " Anda perlu menurunkan berat badan anda"
        tinggi = Val(tb.Text)
        berat = Val(bb.Text)
        If tinggi > 10 Then
            BMI = berat / ((tinggi / 100) * (tinggi / 100))
        Else
            BMI = berat / (tinggi * tinggi)
        End If


        If (BMI >= 18 And BMI <= 21) Then
            MsgBox("BMI ANDA " & Miaw & " " & BMI & ket1)
        ElseIf BMI < 18 Then
            MsgBox("BMI ANDA " & Miaw & " " & BMI & ket2)
        Else
            MsgBox("BMI ANDA " & Miaw & " " & BMI & ket3)
        End If

    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        nama.Text = ""
        usia.Text = ""
        tb.Text = ""
        bb.Text = ""
    End Sub
    Private Sub jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenis.SelectedIndexChanged

    End Sub
End Class
