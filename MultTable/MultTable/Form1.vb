Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Multiplication Table"
        Label1.Text = "Select number"
        Label2.Text = "Multiplication Table"
        ComboBox1.SelectedText = "Select"
        Button1.Text = "Clear"
        Button2.Text = "Exit"
        For i As Integer = 1 To 20
            ComboBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ComboBox1.ResetText()
        ComboBox1.SelectedText = "Select"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        Dim k As Integer
        Dim i As Integer = ComboBox1.SelectedItem
        For j As Integer = 1 To 10
            k = i * j
            ListBox1.Items.Add(k)
        Next
    End Sub
End Class
