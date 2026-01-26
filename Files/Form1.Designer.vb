<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnTri = New Button()
        BtnLength = New Button()
        BtnTemp = New Button()
        BtnExit = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnTri
        ' 
        BtnTri.BackColor = Color.RosyBrown
        BtnTri.Location = New Point(40, 157)
        BtnTri.Name = "BtnTri"
        BtnTri.Size = New Size(241, 50)
        BtnTri.TabIndex = 0
        BtnTri.Text = "Right Triangle"
        BtnTri.UseVisualStyleBackColor = False
        ' 
        ' BtnLength
        ' 
        BtnLength.BackColor = Color.IndianRed
        BtnLength.Location = New Point(40, 201)
        BtnLength.Name = "BtnLength"
        BtnLength.Size = New Size(241, 56)
        BtnLength.TabIndex = 1
        BtnLength.Text = "Length Convertion"
        BtnLength.UseVisualStyleBackColor = False
        ' 
        ' BtnTemp
        ' 
        BtnTemp.BackColor = Color.Brown
        BtnTemp.Location = New Point(40, 254)
        BtnTemp.Name = "BtnTemp"
        BtnTemp.Size = New Size(241, 52)
        BtnTemp.TabIndex = 2
        BtnTemp.Text = "Temperature Convertion"
        BtnTemp.UseVisualStyleBackColor = False
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.LightCoral
        BtnExit.Location = New Point(68, 374)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(182, 37)
        BtnExit.TabIndex = 3
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-49, -48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(864, 581)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AntiqueWhite
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Pixelify Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(40, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 41)
        Label1.TabIndex = 5
        Label1.Text = "HELLO, USER"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtnExit)
        Controls.Add(BtnTemp)
        Controls.Add(BtnLength)
        Controls.Add(BtnTri)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "MultiApp"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnTri As Button
    Friend WithEvents BtnLength As Button
    Friend WithEvents BtnTemp As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label

End Class
