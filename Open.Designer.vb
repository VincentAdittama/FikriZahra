<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Anu
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
        PictureBox1 = New PictureBox()
        Jeneng = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._1
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(30, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(597, 788)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Jeneng
        ' 
        Jeneng.Font = New Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Jeneng.Location = New Point(221, 339)
        Jeneng.Name = "Jeneng"
        Jeneng.Size = New Size(215, 26)
        Jeneng.TabIndex = 2
        Jeneng.Text = "Your Name?"
        Jeneng.TextAlign = HorizontalAlignment.Center
        ' 
        ' Anu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 842)
        Controls.Add(Jeneng)
        Controls.Add(PictureBox1)
        Name = "Anu"
        Text = "Opening"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Jeneng As TextBox
End Class
