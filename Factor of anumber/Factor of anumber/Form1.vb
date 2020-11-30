Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Factor finder"
        Label1.Text = "Enter number"
        Label2.Text = "Factors"
        Button1.Text = "Calculate"
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
        Dim num, i As Integer
        num = Val(TextBox1.Text)
        For i = 1 To num
            If num Mod i = 0 Then
                TextBox2.Text = TextBox2.Text & i.ToString & ","
            End If
        Next
    End Sub
End Class
