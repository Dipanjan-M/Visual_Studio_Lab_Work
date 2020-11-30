Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Avarage n total"
        Label1.Text = "Total n Avarage"
        Label2.Text = "Physics"
        Label3.Text = "Chemistry"
        Label4.Text = "Mathematics"
        Label5.Text = "Total"
        Label6.Text = "Avarage"
        Button1.Text = "Calculate"
        Button2.Text = "Reset"
        Button3.Text = "Exit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)
        TextBox5.Text = Val(TextBox4.Text) / 3
    End Sub
End Class
