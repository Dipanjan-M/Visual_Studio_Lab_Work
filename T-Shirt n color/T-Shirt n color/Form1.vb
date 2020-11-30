Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "T-Shirt"
        GroupBox1.Text = "Size"
        GroupBox2.Text = "Color"
        RadioButton1.Text = "Small"
        RadioButton2.Text = "Medium"
        RadioButton3.Text = "Large"
        RadioButton4.Text = "Red"
        RadioButton5.Text = "Green"
        RadioButton6.Text = "Blue"
        Button1.Text = "Price"
        Button2.Text = "Exit"
        Button3.Text = "Submit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Not yet declared.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2 As String
        s1 = ""
        s2 = ""
        If RadioButton1.Checked Then
            s1 = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            s1 = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            s1 = RadioButton3.Text
        End If
        If RadioButton4.Checked Then
            s2 = RadioButton4.Text
        ElseIf RadioButton5.Checked Then
            s2 = RadioButton5.Text
        ElseIf RadioButton6.Checked Then
            s2 = RadioButton6.Text
        End If
        If s1 = "" Then
            MessageBox.Show("Selsect any size")
        ElseIf s2 = "" Then
            MessageBox.Show("Select any color")
        Else
            MsgBox("User selected a " & s2 & " color and " & s1 & " size T-shirt", , "User's choice")
        End If
    End Sub
End Class
