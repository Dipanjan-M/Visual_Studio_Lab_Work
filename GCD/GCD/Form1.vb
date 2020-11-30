Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "GCD finder"
        Label1.Text = "Enter number 1"
        Label2.Text = "Enter number 2"
        Button1.Text = "Find"
        Button2.Text = "Reset"
        Button3.Text = "Exit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, gcd As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        While num2 > 0
            gcd = num1 Mod num2
            num1 = num2
            num2 = gcd
        End While
        TextBox3.Text = num1.ToString
    End Sub
End Class
