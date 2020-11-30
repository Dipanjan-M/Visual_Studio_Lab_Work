Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Random"
        Label1.Text = "Enter number"
        Label2.Text = "Secret number"
        Label3.Text = "Output"
        Button1.Text = "Generate"
        Button2.Text = "Reset"
        Button3.Text = "Exit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As New Random
        Dim a As Integer
        a = r.Next(1, 10)
        If a = Val(TextBox1.Text) Then
            TextBox2.Text = a.ToString
            TextBox3.Text = "Matched"
        Else
            TextBox2.Text = a.ToString
            TextBox3.Text = "Not Matched"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
