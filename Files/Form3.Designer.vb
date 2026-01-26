<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Length
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Length))
        TxtInch = New TextBox()
        TxtMeter = New TextBox()
        TxtFeet = New TextBox()
        TxtCm = New TextBox()
        TxtYard = New TextBox()
        BtnCompute = New Button()
        BtnClear = New Button()
        BtnExit = New Button()
        BtnHome = New Button()
        BtnPrevious = New Button()
        BtnNext = New Button()
        PictureBox1 = New PictureBox()
        LblInch = New Label()
        LblMeter = New Label()
        LblFeet = New Label()
        LblCm = New Label()
        Label4 = New Label()
        LblYard = New Label()
        LblD1 = New Label()
        LblD2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtInch
        ' 
        TxtInch.BackColor = Color.RosyBrown
        TxtInch.Location = New Point(39, 50)
        TxtInch.Name = "TxtInch"
        TxtInch.Size = New Size(281, 27)
        TxtInch.TabIndex = 0
        TxtInch.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtMeter
        ' 
        TxtMeter.BackColor = Color.RosyBrown
        TxtMeter.Location = New Point(39, 83)
        TxtMeter.Name = "TxtMeter"
        TxtMeter.Size = New Size(281, 27)
        TxtMeter.TabIndex = 1
        TxtMeter.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtFeet
        ' 
        TxtFeet.BackColor = Color.RosyBrown
        TxtFeet.Location = New Point(39, 116)
        TxtFeet.Name = "TxtFeet"
        TxtFeet.Size = New Size(281, 27)
        TxtFeet.TabIndex = 2
        TxtFeet.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtCm
        ' 
        TxtCm.BackColor = Color.RosyBrown
        TxtCm.Location = New Point(39, 149)
        TxtCm.Name = "TxtCm"
        TxtCm.Size = New Size(281, 27)
        TxtCm.TabIndex = 3
        TxtCm.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtYard
        ' 
        TxtYard.BackColor = Color.RosyBrown
        TxtYard.Location = New Point(39, 182)
        TxtYard.Name = "TxtYard"
        TxtYard.Size = New Size(281, 27)
        TxtYard.TabIndex = 4
        TxtYard.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnCompute
        ' 
        BtnCompute.ForeColor = SystemColors.ControlText
        BtnCompute.Location = New Point(39, 238)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(81, 29)
        BtnCompute.TabIndex = 5
        BtnCompute.Text = "Compute"
        BtnCompute.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(126, 238)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(94, 29)
        BtnClear.TabIndex = 6
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(226, 238)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(94, 29)
        BtnExit.TabIndex = 7
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnHome
        ' 
        BtnHome.Location = New Point(39, 357)
        BtnHome.Name = "BtnHome"
        BtnHome.Size = New Size(81, 29)
        BtnHome.TabIndex = 8
        BtnHome.Text = "Home"
        BtnHome.UseVisualStyleBackColor = True
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.Location = New Point(126, 357)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(94, 29)
        BtnPrevious.TabIndex = 9
        BtnPrevious.Text = "Previous"
        BtnPrevious.UseVisualStyleBackColor = True
        ' 
        ' BtnNext
        ' 
        BtnNext.Location = New Point(226, 357)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(94, 29)
        BtnNext.TabIndex = 10
        BtnNext.Text = "Next"
        BtnNext.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(424, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(344, 336)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' LblInch
        ' 
        LblInch.AutoSize = True
        LblInch.ForeColor = SystemColors.ActiveCaptionText
        LblInch.Location = New Point(324, 30)
        LblInch.Name = "LblInch"
        LblInch.Size = New Size(36, 20)
        LblInch.TabIndex = 12
        LblInch.Text = "Inch"
        ' 
        ' LblMeter
        ' 
        LblMeter.AutoSize = True
        LblMeter.ForeColor = SystemColors.ActiveCaptionText
        LblMeter.Location = New Point(326, 67)
        LblMeter.Name = "LblMeter"
        LblMeter.Size = New Size(48, 20)
        LblMeter.TabIndex = 13
        LblMeter.Text = "Meter"
        ' 
        ' LblFeet
        ' 
        LblFeet.AutoSize = True
        LblFeet.ForeColor = SystemColors.WindowText
        LblFeet.Location = New Point(324, 105)
        LblFeet.Name = "LblFeet"
        LblFeet.Size = New Size(37, 20)
        LblFeet.TabIndex = 14
        LblFeet.Text = "Feet"
        ' 
        ' LblCm
        ' 
        LblCm.AutoSize = True
        LblCm.ForeColor = SystemColors.WindowText
        LblCm.Location = New Point(324, 137)
        LblCm.Name = "LblCm"
        LblCm.Size = New Size(31, 20)
        LblCm.TabIndex = 15
        LblCm.Text = "Cm"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(324, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 16
        ' 
        ' LblYard
        ' 
        LblYard.AutoSize = True
        LblYard.ForeColor = SystemColors.WindowText
        LblYard.Location = New Point(322, 173)
        LblYard.Name = "LblYard"
        LblYard.Size = New Size(38, 20)
        LblYard.TabIndex = 17
        LblYard.Text = "Yard"
        ' 
        ' LblD1
        ' 
        LblD1.AutoSize = True
        LblD1.BackColor = Color.White
        LblD1.Font = New Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblD1.ForeColor = Color.DarkTurquoise
        LblD1.Location = New Point(664, 329)
        LblD1.Name = "LblD1"
        LblD1.Size = New Size(91, 28)
        LblD1.TabIndex = 18
        LblD1.Text = "Length"
        ' 
        ' LblD2
        ' 
        LblD2.AutoSize = True
        LblD2.BackColor = Color.White
        LblD2.Font = New Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblD2.ForeColor = Color.DarkTurquoise
        LblD2.Location = New Point(667, 357)
        LblD2.Name = "LblD2"
        LblD2.Size = New Size(88, 18)
        LblD2.TabIndex = 19
        LblD2.Text = "Converter"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pixelify Sans", 14F)
        Label1.Location = New Point(441, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 29)
        Label1.TabIndex = 20
        Label1.Text = "."
        ' 
        ' Length
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(LblD2)
        Controls.Add(LblD1)
        Controls.Add(LblYard)
        Controls.Add(Label4)
        Controls.Add(LblCm)
        Controls.Add(LblFeet)
        Controls.Add(LblMeter)
        Controls.Add(LblInch)
        Controls.Add(PictureBox1)
        Controls.Add(BtnNext)
        Controls.Add(BtnPrevious)
        Controls.Add(BtnHome)
        Controls.Add(BtnExit)
        Controls.Add(BtnClear)
        Controls.Add(BtnCompute)
        Controls.Add(TxtYard)
        Controls.Add(TxtCm)
        Controls.Add(TxtFeet)
        Controls.Add(TxtMeter)
        Controls.Add(TxtInch)
        Name = "Length"
        Text = "Length Converter"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtInch As TextBox
    Friend WithEvents TxtMeter As TextBox
    Friend WithEvents TxtFeet As TextBox
    Friend WithEvents TxtCm As TextBox
    Friend WithEvents TxtYard As TextBox
    Friend WithEvents BtnCompute As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblInch As Label
    Friend WithEvents LblMeter As Label
    Friend WithEvents LblFeet As Label
    Friend WithEvents LblCm As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblYard As Label
    Friend WithEvents LblD1 As Label
    Friend WithEvents LblD2 As Label
    Friend WithEvents Label1 As Label
End Class
