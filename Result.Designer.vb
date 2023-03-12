<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Res = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._3
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(30, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(597, 788)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Res
        ' 
        Res.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Res.AutoSize = True
        Res.Font = New Font("Segoe UI", 67F, FontStyle.Regular, GraphicsUnit.Point)
        Res.Location = New Point(293, 361)
        Res.Name = "Res"
        Res.Size = New Size(70, 120)
        Res.TabIndex = 4
        Res.Text = "."
        Res.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(310, 285)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 5
        Label1.Text = "Label1"' 
        ' Result
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 842)
        Controls.Add(Label1)
        Controls.Add(Res)
        Controls.Add(PictureBox1)
        Name = "Result"
        Text = "Result"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Res As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Result_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Friend WithEvents Label1 As Label
End Class
