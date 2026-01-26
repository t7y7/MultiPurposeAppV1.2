Imports System.Reflection.Emit
Imports System.Windows.Forms.MonthCalendar

Public Class Tri


    Dim base, area, h, hypotenuse As Double


    Private Sub Tri_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Label1.Text = "Hi, " & UserName

    End Sub




    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click

        base = Val(InputBox("Enter the base: ", "Input Base"))
        hypotenuse = Val(InputBox("Enter the hypotenuse: ", "Input Hypotenuse"))

        h = Math.Sqrt((hypotenuse ^ 2) - (base ^ 2))
        area = 0.5 * base * h


        MessageBox.Show("The area of the triangle is " & area.ToString("N2") & vbCrLf &
                "The height of the triangle is " & h.ToString("N2"), "Result")
        TxtBase.Text = base.ToString("N2")
        Txth.Text = h.ToString("N2")
        TxtArea.Text = area.ToString("N2")
        TxtHypo.Text = hypotenuse.ToString("N2")




    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtBase.Clear()
        Txth.Clear()
        TxtArea.Clear()
        TxtHypo.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Length.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LblD1_Click(sender As Object, e As EventArgs) Handles LblD1.Click

    End Sub
End Class