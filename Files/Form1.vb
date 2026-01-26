Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Module GlobalData
    Public UserName As String
End Module

Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserName = InputBox("What is your name?", "LET'S START!")

        Label1.Text = "Hi, " & UserName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTri.Click
        Tri.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLength.Click
        Length.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnTemp.Click
        Tempe.Show()
    End Sub

    Private Sub LblUser_Click(sender As Object, e As EventArgs)

    End Sub
End Class
