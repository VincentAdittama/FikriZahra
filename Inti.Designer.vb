<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        nama = New TextBox()
        usia = New TextBox()
        tb = New TextBox()
        bb = New TextBox()
        jenis = New ComboBox()
        cek = New Button()
        exi = New Button()
        reset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(350, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 15)
        Label2.TabIndex = 1
        Label2.Text = " BMI BODY MASSA INDEKS" ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(130, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "NAMA" ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(130, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 3
        Label4.Text = "USIA" ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(130, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 4
        Label5.Text = "JENIS KELAMIN" ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(490, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 15)
        Label6.TabIndex = 5
        Label6.Text = "TINGGI BADAN" ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(490, 211)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 15)
        Label7.TabIndex = 6
        Label7.Text = "BERAT BADAN" ' nama
        ' 
        nama.Location = New Point(220, 140)
        nama.Name = "nama"
        nama.Size = New Size(222, 23)
        nama.TabIndex = 7
        ' 
        ' usia
        ' 
        usia.Location = New Point(220, 180)
        usia.Name = "usia"
        usia.Size = New Size(222, 23)
        usia.TabIndex = 8
        ' 
        ' tb
        ' 
        tb.Location = New Point(583, 137)
        tb.Name = "tb"
        tb.Size = New Size(130, 23)
        tb.TabIndex = 10
        ' 
        ' bb
        ' 
        bb.Location = New Point(583, 203)
        bb.Name = "bb"
        bb.Size = New Size(109, 23)
        bb.TabIndex = 11
        ' 
        ' jenis
        ' 
        jenis.FormattingEnabled = True
        jenis.Items.AddRange(New Object() {"Wanita", "Pria"})
        jenis.Location = New Point(252, 317)
        jenis.Name = "jenis"
        jenis.Size = New Size(121, 23)
        jenis.TabIndex = 12
        jenis.Text = "--Pilih--" ' cek
        ' 
        cek.Location = New Point(583, 281)
        cek.Name = "cek"
        cek.Size = New Size(122, 52)
        cek.TabIndex = 13
        cek.Text = "cek"
        cek.UseVisualStyleBackColor = True
        ' 
        ' exi
        ' 
        exi.Location = New Point(416, 281)
        exi.Name = "exi"
        exi.Size = New Size(122, 52)
        exi.TabIndex = 14
        exi.Text = "exit"
        exi.UseVisualStyleBackColor = True
        ' 
        ' reset
        ' 
        reset.Location = New Point(513, 360)
        reset.Name = "reset"
        reset.Size = New Size(122, 52)
        reset.TabIndex = 15
        reset.Text = "reset"
        reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 785)
        Controls.Add(reset)
        Controls.Add(exi)
        Controls.Add(cek)
        Controls.Add(jenis)
        Controls.Add(bb)
        Controls.Add(tb)
        Controls.Add(usia)
        Controls.Add(nama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents usia As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents bb As TextBox
    Friend WithEvents jenis As ComboBox
    Friend WithEvents cek As Button
    Friend WithEvents exi As Button
    Friend WithEvents reset As Button
End Class
