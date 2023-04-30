Public Class IntroductoryForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Me.Hide()
        AuthorityForm.Show()
    End Sub

    Private Sub IntroductoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        DevelopersForm.Show()
    End Sub
End Class
