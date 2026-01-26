Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Length

    Dim inch, meter, feet, cm, yard As Double



    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        inch = Val(InputBox("Enter the length in inches: ", "Input Length"))

        meter = inch * 0.0254
        feet = inch / 12
        cm = inch * 2.54
        yard = inch / 36


        MsgBox("The length in meters is " & meter.ToString("N2") & vbCrLf &
                   "The length in feet is " & feet.ToString("N2") & vbCrLf &
                   "The length in centimeters is " & cm.ToString("N2") & vbCrLf &
                   "The length in yards is " & yard.ToString("N2"), MsgBoxStyle.Information, "Result")
        TxtInch.Text = inch.ToString("N2")
        TxtMeter.Text = meter.ToString("N2")
        TxtFeet.Text = feet.ToString("N2")
        TxtCm.Text = cm.ToString("N2")
        TxtYard.Text = yard.ToString("N2")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtInch.Clear()
        TxtMeter.Clear()
        TxtFeet.Clear()
        TxtCm.Clear()
        TxtYard.Clear()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

        Me.Hide()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Tri.Show()
        Me.Hide()

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Tempe.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Length_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Hi, " & UserName
    End Sub
End Class