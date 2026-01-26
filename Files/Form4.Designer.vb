<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tempe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tempe))
        TxtF = New TextBox()
        TxtK = New TextBox()
        TxtR = New TextBox()
        TxtC = New TextBox()
        PictureBox1 = New PictureBox()
        LblD1 = New Label()
        LblD2 = New Label()
        BtnCompute = New Button()
        BtnClear = New Button()
        BtnEnd = New Button()
        BtnHome = New Button()
        BtnPrevious = New Button()
        BtnNext = New Button()
        LblF = New Label()
        LblC = New Label()
        LblR = New Label()
        LblK = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtF
        ' 
        TxtF.BackColor = Color.Sienna
        TxtF.ForeColor = Color.AliceBlue
        TxtF.Location = New Point(84, 57)
        TxtF.Name = "TxtF"
        TxtF.Size = New Size(193, 27)
        TxtF.TabIndex = 0
        TxtF.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtK
        ' 
        TxtK.BackColor = Color.Brown
        TxtK.ForeColor = Color.AliceBlue
        TxtK.Location = New Point(84, 204)
        TxtK.Name = "TxtK"
        TxtK.Size = New Size(193, 27)
        TxtK.TabIndex = 1
        TxtK.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtR
        ' 
        TxtR.BackColor = Color.DarkRed
        TxtR.ForeColor = Color.AliceBlue
        TxtR.Location = New Point(84, 156)
        TxtR.Name = "TxtR"
        TxtR.Size = New Size(193, 27)
        TxtR.TabIndex = 2
        TxtR.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtC
        ' 
        TxtC.BackColor = Color.IndianRed
        TxtC.ForeColor = Color.AliceBlue
        TxtC.Location = New Point(84, 108)
        TxtC.Name = "TxtC"
        TxtC.Size = New Size(193, 27)
        TxtC.TabIndex = 3
        TxtC.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.SeaShell
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-6, -70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(809, 620)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' LblD1
        ' 
        LblD1.AutoSize = True
        LblD1.BackColor = SystemColors.ScrollBar
        LblD1.Font = New Font("Pixelify Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblD1.ForeColor = Color.Cornsilk
        LblD1.Location = New Point(390, 79)
        LblD1.Name = "LblD1"
        LblD1.Size = New Size(240, 41)
        LblD1.TabIndex = 5
        LblD1.Text = "Temperature"
        ' 
        ' LblD2
        ' 
        LblD2.AutoSize = True
        LblD2.Font = New Font("Pixelify Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblD2.ForeColor = Color.Cornsilk
        LblD2.Location = New Point(535, 142)
        LblD2.Name = "LblD2"
        LblD2.Size = New Size(198, 41)
        LblD2.TabIndex = 6
        LblD2.Text = "Converter"
        ' 
        ' BtnCompute
        ' 
        BtnCompute.Location = New Point(129, 292)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(94, 29)
        BtnCompute.TabIndex = 7
        BtnCompute.Text = "Compute"
        BtnCompute.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(84, 327)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(94, 29)
        BtnClear.TabIndex = 8
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnEnd
        ' 
        BtnEnd.Location = New Point(184, 327)
        BtnEnd.Name = "BtnEnd"
        BtnEnd.Size = New Size(94, 29)
        BtnEnd.TabIndex = 9
        BtnEnd.Text = "Exit"
        BtnEnd.UseVisualStyleBackColor = True
        ' 
        ' BtnHome
        ' 
        BtnHome.Location = New Point(30, 409)
        BtnHome.Name = "BtnHome"
        BtnHome.Size = New Size(94, 29)
        BtnHome.TabIndex = 10
        BtnHome.Text = "Home"
        BtnHome.UseVisualStyleBackColor = True
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.Location = New Point(130, 409)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(94, 29)
        BtnPrevious.TabIndex = 11
        BtnPrevious.Text = "Previous"
        BtnPrevious.UseVisualStyleBackColor = True
        ' 
        ' BtnNext
        ' 
        BtnNext.Location = New Point(230, 409)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(94, 29)
        BtnNext.TabIndex = 12
        BtnNext.Text = "Next"
        BtnNext.UseVisualStyleBackColor = True
        ' 
        ' LblF
        ' 
        LblF.AutoSize = True
        LblF.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblF.ForeColor = Color.FloralWhite
        LblF.Location = New Point(16, 37)
        LblF.Name = "LblF"
        LblF.Size = New Size(68, 17)
        LblF.TabIndex = 13
        LblF.Text = "Fahrenheit"
        ' 
        ' LblC
        ' 
        LblC.AutoSize = True
        LblC.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblC.ForeColor = Color.Cornsilk
        LblC.Location = New Point(31, 95)
        LblC.Name = "LblC"
        LblC.Size = New Size(48, 17)
        LblC.TabIndex = 14
        LblC.Text = "Celcius"
        ' 
        ' LblR
        ' 
        LblR.AutoSize = True
        LblR.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblR.ForeColor = Color.Cornsilk
        LblR.Location = New Point(26, 142)
        LblR.Name = "LblR"
        LblR.Size = New Size(53, 17)
        LblR.TabIndex = 15
        LblR.Text = "Rankine"
        ' 
        ' LblK
        ' 
        LblK.AutoSize = True
        LblK.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblK.ForeColor = Color.Cornsilk
        LblK.Location = New Point(36, 191)
        LblK.Name = "LblK"
        LblK.Size = New Size(42, 17)
        LblK.TabIndex = 16
        LblK.Text = "Kelvin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Cornsilk
        Label1.Location = New Point(390, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 28)
        Label1.TabIndex = 17
        Label1.Text = "Label1"
        ' 
        ' Tempe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(LblK)
        Controls.Add(LblR)
        Controls.Add(LblC)
        Controls.Add(LblF)
        Controls.Add(BtnNext)
        Controls.Add(BtnPrevious)
        Controls.Add(BtnHome)
        Controls.Add(BtnEnd)
        Controls.Add(BtnClear)
        Controls.Add(BtnCompute)
        Controls.Add(LblD2)
        Controls.Add(LblD1)
        Controls.Add(TxtC)
        Controls.Add(TxtR)
        Controls.Add(TxtK)
        Controls.Add(TxtF)
        Controls.Add(PictureBox1)
        Name = "Tempe"
        Text = "Temperature Converter"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtF As TextBox
    Friend WithEvents TxtK As TextBox
    Friend WithEvents TxtR As TextBox
    Friend WithEvents TxtC As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblD1 As Label
    Friend WithEvents LblD2 As Label
    Friend WithEvents BtnCompute As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnEnd As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents LblF As Label
    Friend WithEvents LblC As Label
    Friend WithEvents LblR As Label
    Friend WithEvents LblK As Label
    Friend WithEvents Label1 As Label
End Class
