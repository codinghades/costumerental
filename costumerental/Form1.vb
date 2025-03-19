Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rdbMale.Checked Then
            Me.Hide()
            male.Show()
        ElseIf rdbFemale.Checked Then
            Me.Hide()
            female.Show()
        End If
    End Sub
End Class
