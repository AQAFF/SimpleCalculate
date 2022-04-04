Public Class Form3
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As Double = input1.Text
        Dim str2 As Double = input2.Text

        Dim str_add As String = str1 + str2

        result.Text = str_add
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str1 As Double = input1.Text
        Dim str2 As Double = input2.Text

        Dim str_minus As String = str1 - str2

        result.Text = str_minus

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str1 As Double = input1.Text
        Dim str2 As Double = input2.Text

        Dim str_mult As String = str1 * str2

        result.Text = str_mult

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str1 As Double = input1.Text
        Dim str2 As Double = input2.Text

        Dim str_Divide As String = str1 / str2

        result.Text = str_Divide

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
        Form1.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub result_TextChanged(sender As Object, e As EventArgs) Handles result.TextChanged

    End Sub
End Class