Public Class GuestForm
    Private Sub GuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Me.Hide()
        AuthorityForm.Show()
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        Me.Hide()
        VotingForm.Show()
    End Sub
End Class