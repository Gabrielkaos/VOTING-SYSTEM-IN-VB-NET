Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VotingForm
    Private Sub VotingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LENOVO\Documents\PartiesDatabase.mdb")
        Dim command As New OleDbCommand
        command.Connection = connection
        command.CommandText = "SELECT * FROM Table1"
        connection.Open()

        Dim sdr As OleDbDataReader = command.ExecuteReader()

        While sdr.Read()
            PresidentComboBox.Items.Add(sdr("President") & "-" & sdr("PartyName"))
            VicePresidentComboBox.Items.Add(sdr("VicePresident") & "-" & sdr("PartyName"))
            SecretaryComboBox.Items.Add(sdr("Secretary") & "-" & sdr("PartyName"))
            TreasurerComboBox.Items.Add(sdr("Treasurer") & "-" & sdr("PartyName"))
        End While

    End Sub
End Class