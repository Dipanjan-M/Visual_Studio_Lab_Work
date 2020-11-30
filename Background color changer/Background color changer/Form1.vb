Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Background Change"
        Label1.Text = "Background color changer"
        Label2.Text = "Red"
        Label3.Text = "Green"
        Label4.Text = "Blue"
        Button1.Text = "Change"
        Button2.Text = "Reset"
        Button3.Text = "Exit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Me.BackColor = Color.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.FromArgb(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
