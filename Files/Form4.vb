Public Class Tempe

    Dim celcius, fahrenheit, kelvin, rankine As Double

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        fahrenheit = Val(InputBox("Enter the temperature in Fahrenheit: ", "Input Temperature"))
        celcius = (fahrenheit - 32) * 5 / 9
        rankine = fahrenheit + 459.67
        kelvin = celcius + 273.15

        MsgBox("The temperature in Celcius is " & celcius.ToString("N2") & vbCrLf &
                "The temperature in Rankine is " & rankine.ToString("N2") & vbCrLf &
                "The temperature in Kelvin is " & kelvin.ToString("N2"), MsgBoxStyle.Information, "Result")
        TxtF.Text = fahrenheit.ToString("N2")
        TxtC.Text = celcius.ToString("N2")
        TxtR.Text = rankine.ToString("N2")
        TxtK.Text = kelvin.ToString("N2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtF.Clear()
        TxtC.Clear()
        TxtK.Clear()
        TxtR.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Length.Show()
        Me.Hide()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Form1.Show()
        Me.Hide()


    End Sub
    Private Sub TxtC_TextChanged(sender As Object, e As EventArgs) Handles TxtC.TextChanged

    End Sub

    Private Sub LblF_Click(sender As Object, e As EventArgs) Handles LblF.Click

    End Sub

    Private Sub Tempe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Label1.Text = "Hi, " & UserName
    End Sub
End Class