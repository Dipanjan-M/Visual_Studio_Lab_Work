Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prime number checker"
        Label1.Text = "Enter Number"
        Label2.Text = "Output"
        Button1.Text = "Check"
        Button2.Text = "Reset"
        Button3.Text = "Exit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, i, flag As Integer
        num = Val(TextBox1.Text)
        For i = 1 To num
            If (num Mod i = 0) Then
                flag = flag + 1
            End If
        Next
        If num = 1 Then
            TextBox2.Text = "Neither Prime nor not prime"
        ElseIf flag = 2 Then
            TextBox2.Text = "Prime"
        Else
            TextBox2.Text = "Not Prime"
        End If
    End Sub
End Class
