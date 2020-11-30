Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Fibonacci series"
        Label1.Text = "Enter number"
        Label2.Text = "Output"
        Button1.Text = "Print"
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
        Dim first, second, temp, n As Integer
        first = 0
        second = 1
        n = Val(TextBox1.Text)
        For i = 1 To n
            TextBox2.Text = TextBox2.Text & first.ToString & vbNewLine
            temp = first + second
            first = second
            second = temp
        Next
    End Sub
End Class
