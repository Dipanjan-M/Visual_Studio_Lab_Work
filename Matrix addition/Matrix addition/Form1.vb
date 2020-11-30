Public Class Form1
    Dim m1(10, 10), m2(10, 10), op(10, 10), n, m As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Matrix addition"
        Label1.Text = "Addition"
        Label2.Text = "Matrix 1"
        Label3.Text = "Matrix 2"
        Label4.Text = "Output"
        Button1.Text = "Input 1"
        Button2.Text = "Input 2"
        Button3.Text = "Add"
        Button4.Text = "Reset"
        Button5.Text = "Exit"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j As Integer
        m = Val(InputBox("Enter the order of matrix(m x n)", "Input m", 0))
        n = Val(InputBox("Enter the order of matrix(m x n)", "Input n", 0))
        For i = 0 To n - 1
            For j = 0 To m - 1
                m1(i, j) = Val(InputBox("Enter value", "", 0))
                TextBox1.Text = TextBox1.Text & m1(i, j).ToString & vbTab
                If j = m - 1 Then
                    TextBox1.Text = TextBox1.Text & vbNewLine
                End If
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j As Integer
        For i = 0 To n - 1
            For j = 0 To m - 1
                m2(i, j) = Val(InputBox("Enter value", "", 0))
                TextBox2.Text = TextBox2.Text & m2(i, j).ToString & vbTab
                If j = m - 1 Then
                    TextBox2.Text = TextBox2.Text & vbNewLine
                End If
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        Dim s As String
        s = vbNull
        For i = 0 To n - 1
            For j = 0 To m - 1
                op(i, j) = m1(i, j) + m2(i, j)
                TextBox3.Text = TextBox3.Text & op(i, j).ToString & vbTab
                If j = m - 1 Then
                    TextBox3.Text = TextBox3.Text & vbNewLine
                End If
            Next
        Next
        s = TextBox3.Text
        MsgBox(s, 0, "Result")
    End Sub
End Class

