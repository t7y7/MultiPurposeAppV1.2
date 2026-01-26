<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tri))
        PictureBox1 = New PictureBox()
        TxtBase = New TextBox()
        TxtHypo = New TextBox()
        Txth = New TextBox()
        TxtArea = New TextBox()
        BtnCompute = New Button()
        BtnClear = New Button()
        BtnExit = New Button()
        BtnHome = New Button()
        BtnNext = New Button()
        BtnPrevious = New Button()
        LblBase = New Label()
        LblHypo = New Label()
        LblHeight = New Label()
        LblArea = New Label()
        LblD1 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(404, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(554, 616)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TxtBase
        ' 
        TxtBase.Location = New Point(52, 46)
        TxtBase.Name = "TxtBase"
        TxtBase.Size = New Size(310, 27)
        TxtBase.TabIndex = 1
        TxtBase.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtHypo
        ' 
        TxtHypo.Location = New Point(52, 93)
        TxtHypo.Name = "TxtHypo"
        TxtHypo.Size = New Size(310, 27)
        TxtHypo.TabIndex = 2
        TxtHypo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txth
        ' 
        Txth.Location = New Point(52, 138)
        Txth.Name = "Txth"
        Txth.Size = New Size(310, 27)
        Txth.TabIndex = 3
        Txth.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtArea
        ' 
        TxtArea.Location = New Point(52, 183)
        TxtArea.Name = "TxtArea"
        TxtArea.Size = New Size(310, 27)
        TxtArea.TabIndex = 4
        TxtArea.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnCompute
        ' 
        BtnCompute.Location = New Point(52, 231)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(94, 29)
        BtnCompute.TabIndex = 5
        BtnCompute.Text = "Compute"
        BtnCompute.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(152, 231)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(110, 29)
        BtnClear.TabIndex = 6
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(268, 231)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(94, 29)
        BtnExit.TabIndex = 7
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnHome
        ' 
        BtnHome.Location = New Point(52, 399)
        BtnHome.Name = "BtnHome"
        BtnHome.Size = New Size(94, 29)
        BtnHome.TabIndex = 8
        BtnHome.Text = "Home"
        BtnHome.UseVisualStyleBackColor = True
        ' 
        ' BtnNext
        ' 
        BtnNext.Location = New Point(268, 399)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(94, 29)
        BtnNext.TabIndex = 9
        BtnNext.Text = "Next"
        BtnNext.UseVisualStyleBackColor = True
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.Location = New Point(152, 399)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(110, 29)
        BtnPrevious.TabIndex = 10
        BtnPrevious.Text = "Previous"
        BtnPrevious.UseVisualStyleBackColor = True
        ' 
        ' LblBase
        ' 
        LblBase.AutoSize = True
        LblBase.ForeColor = Color.Cornsilk
        LblBase.Location = New Point(357, 34)
        LblBase.Name = "LblBase"
        LblBase.Size = New Size(40, 20)
        LblBase.TabIndex = 11
        LblBase.Text = "Base"
        ' 
        ' LblHypo
        ' 
        LblHypo.AutoSize = True
        LblHypo.ForeColor = Color.Cornsilk
        LblHypo.Location = New Point(358, 70)
        LblHypo.Name = "LblHypo"
        LblHypo.Size = New Size(88, 20)
        LblHypo.TabIndex = 12
        LblHypo.Text = "Hypotenuse"
        ' 
        ' LblHeight
        ' 
        LblHeight.AutoSize = True
        LblHeight.ForeColor = Color.Cornsilk
        LblHeight.Location = New Point(358, 123)
        LblHeight.Name = "LblHeight"
        LblHeight.Size = New Size(54, 20)
        LblHeight.TabIndex = 13
        LblHeight.Text = "Height"
        ' 
        ' LblArea
        ' 
        LblArea.AutoSize = True
        LblArea.ForeColor = Color.Cornsilk
        LblArea.Location = New Point(358, 168)
        LblArea.Name = "LblArea"
        LblArea.Size = New Size(40, 20)
        LblArea.TabIndex = 14
        LblArea.Text = "Area"
        ' 
        ' LblD1
        ' 
        LblD1.AutoSize = True
        LblD1.Font = New Font("Pixelify Sans", 14F)
        LblD1.ForeColor = Color.FloralWhite
        LblD1.Location = New Point(538, 46)
        LblD1.Name = "LblD1"
        LblD1.Size = New Size(250, 29)
        LblD1.TabIndex = 15
        LblD1.Text = "Right Triangle Solver"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pixelify Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(538, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(14, 21)
        Label1.TabIndex = 16
        Label1.Text = "."
        ' 
        ' Tri
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(LblD1)
        Controls.Add(LblArea)
        Controls.Add(LblHeight)
        Controls.Add(LblHypo)
        Controls.Add(LblBase)
        Controls.Add(BtnPrevious)
        Controls.Add(BtnNext)
        Controls.Add(BtnHome)
        Controls.Add(BtnExit)
        Controls.Add(BtnClear)
        Controls.Add(BtnCompute)
        Controls.Add(TxtArea)
        Controls.Add(Txth)
        Controls.Add(TxtHypo)
        Controls.Add(TxtBase)
        Controls.Add(PictureBox1)
        Name = "Tri"
        Text = "Right Triangle"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBase As TextBox
    Friend WithEvents TxtHypo As TextBox
    Friend WithEvents Txth As TextBox
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents BtnCompute As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents LblBase As Label
    Friend WithEvents LblHypo As Label
    Friend WithEvents LblHeight As Label
    Friend WithEvents LblArea As Label
    Friend WithEvents LblD1 As Label
    Friend WithEvents Label1 As Label
End Class

