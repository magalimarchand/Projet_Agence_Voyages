Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class Administrateur

    Dim ds As New DataSet
    Private dt As New DataTable
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter()
    Dim connect As New OleDbConnection

    Private Sub Utilisateurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'REQUETE À LA BD
        Try
            connect.ConnectionString = My.Settings.Voyages2010ConnectionString
            connect.Open()
            Dim requete As String = "SELECT * FROM tblUtilisateurs"
            Dim cmd As New OleDb.OleDbCommand(requete, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(ds, "tblUtilisateurs")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Clipboard.SetText(ex.Message)
        End Try

        'CRÉATION DE LA VUE
        dt = ds.Tables("tblUtilisateurs")
        DataGridView.DataSource = dt
        'DataGridView.Columns(1).Visible = False

    End Sub

    'CREATION D'UN UTILISATEUR
    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click

        'REQUETE À LA BD
        Try
            ds.Clear()
            connect.ConnectionString = My.Settings.Voyages2010ConnectionString
            connect.Open()
            Dim requete As String = "SELECT * FROM tblUtilisateurs"
            Dim cmd As New OleDb.OleDbCommand(requete, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(ds, "tblUtilisateurs")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Clipboard.SetText(ex.Message)
        End Try

        'AJOUT DU NOUVEL UTILISATEUR DANS LA BD
        Try
            If tbNom.Text = "" Then
                MsgBox("Veuillez entrer un nom")
            ElseIf cbType.SelectedItem Is Nothing Then
                MsgBox("Veuillez choisir un type")
            Else

                'CRYPTAGE DU MOT DE PASSE
                Dim motPasse As String
                Dim md As MD5 = MD5.Create
                Dim crypto As Byte() = md.ComputeHash(Encoding.Default.GetBytes(tbMotPasse.Text))
                Dim sb As New StringBuilder()

                For i As Integer = 0 To crypto.Length - 1
                    sb.Append(crypto(i).ToString("x2"))
                Next i
                motPasse = sb.ToString

                Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
                dt = ds.Tables("tblUtilisateurs")
                Dim ligne As DataRow = dt.NewRow()

                ligne(0) = tbNom.Text
                ligne(1) = motPasse
                ligne(2) = cbType.SelectedItem

                dt.Rows.Add(ligne)
                adapter.Update(dt)

                tbNom.Text = ""
                tbMotPasse.Text = ""

            End If
        Catch ex As Exception
            MsgBox("Veuillez entrer un mot de passe")
            Clipboard.SetText(ex.Message)
        End Try
    End Sub

    'SUPPRESSION D'UN UTILISATEUR
    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        dt = ds.Tables("tblUtilisateurs")
        Dim index = DataGridView.CurrentRow.Index

        If dt.Rows(index)(2) <> "admin" Then
            Dim result As Integer = MessageBox.Show("Supprimer l'utilisateur ?", "caption", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                dt.Rows(index).Delete()
                adapter.Update(dt)
            End If
        Else
            MsgBox("L'administrateur ne peut pas être supprimé")
        End If
    End Sub

    'FERMETURE DE LA FENÊTRE
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class