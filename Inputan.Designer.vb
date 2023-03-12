<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inputan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Tall = New TextBox()
        Weight = New TextBox()
        Res = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._2
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(30, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(597, 788)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Tall
        ' 
        Tall.Font = New Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tall.Location = New Point(216, 386)
        Tall.Name = "Tall"
        Tall.Size = New Size(215, 26)
        Tall.TabIndex = 3
        Tall.TextAlign = HorizontalAlignment.Center
        ' 
        ' Weight
        ' 
        Weight.Font = New Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Weight.Location = New Point(216, 528)
        Weight.Name = "Weight"
        Weight.Size = New Size(215, 26)
        Weight.TabIndex = 4
        Weight.TextAlign = HorizontalAlignment.Center
        ' 
        ' Res
        ' 
        Res.Location = New Point(419, 685)
        Res.Name = "Res"
        Res.Size = New Size(132, 32)
        Res.TabIndex = 5
        Res.Text = "Get Your Result!"
        Res.UseVisualStyleBackColor = True
        ' 
        ' Inputan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 842)
        Controls.Add(Res)
        Controls.Add(Weight)
        Controls.Add(Tall)
        Controls.Add(PictureBox1)
        Name = "Inputan"
        Text = "Inputan"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Tall As TextBox
    Private WithEvents Weight As TextBox
    Friend WithEvents Res As Button
End Class
