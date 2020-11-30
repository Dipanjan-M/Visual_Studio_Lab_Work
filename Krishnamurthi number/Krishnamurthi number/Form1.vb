Public Class Form1
    Public Function fact(ByVal n As Integer)
        Dim i, facto As Integer
        facto = 1
        If n = 0 Then
            Return 1
        Else
            For i = 1 To n
                facto = facto * i
            Next
            Return facto
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Krishnamurthi number"
        Label1.Text = "Enter number"
        Label2.Text = "Is it Krishnaurthi number?"
        Button1.Text = "check"
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
        Dim num, no, i, sum, n As Integer
        num = Val(TextBox1.Text)
        no = num
        sum = 0
        While num > 0
            n = num Mod 10
            num = num \ 10
            sum = sum + fact(n)
        End While
        If sum = no Then
            TextBox2.Text = "Yes"
        Else
            TextBox2.Text = "No"
        End If
    End Sub
End Class
