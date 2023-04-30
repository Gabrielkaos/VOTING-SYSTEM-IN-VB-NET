Public Class AuthorityForm
    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Me.Hide()
        AdminComelecForm.Show()
    End Sub

    Private Sub GuestButton_Click(sender As Object, e As EventArgs) Handles GuestButton.Click
        Me.Hide()
        GuestForm.Show()
    End Sub
End Class