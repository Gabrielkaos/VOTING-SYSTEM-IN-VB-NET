Imports System.Data.OleDb

Public Class AdminComelecForm

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PartyNameBox.Text = ""
        PresidentBox.Text = ""
        VicePresidentBox.Text = ""
        SecretaryBox.Text = ""
        TreasurerBox.Text = ""
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If PartyNameBox.Text = "" Or PresidentBox.Text = "" Or VicePresidentBox.Text = "" Or SecretaryBox.Text = "" Or TreasurerBox.Text = "" Then
            MessageBox.Show("Failed Saving, some field are empty", "Save Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim conn As New OleDbConnection
        Dim cmd As OleDbCommand

        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LENOVO\Documents\PartiesDatabase.mdb"
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Table1(PartyName,President,VIcePresident,Secretary,Treasurer)values('" + PartyNameBox.Text + "','" + PresidentBox.Text + "','" + VicePresidentBox.Text + "','" + SecretaryBox.Text + "','" + TreasurerBox.Text +
                "')"

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Party saved", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PartyNameBox.Text = ""
            PresidentBox.Text = ""
            VicePresidentBox.Text = ""
            SecretaryBox.Text = ""
            TreasurerBox.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub AdminComelecForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection
        Dim cmd As OleDbCommand

        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LENOVO\Documents\PartiesDatabase.mdb"

        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE * FROM Table1"

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Me.Hide()
        AuthorityForm.Show()
    End Sub
End Class