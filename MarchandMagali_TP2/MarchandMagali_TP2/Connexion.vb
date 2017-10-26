Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Connexion

    Dim ds As New DataSet
    Private dt As New DataTable
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter()
    Dim connect As New OleDbConnection
    Shared _nom As String

    Shared Property nom()
        Get
            Return _nom
        End Get

        Set(ByVal value)
            _nom = value
        End Set
    End Property

    'CONNEXION DE L'UTILISATEUR
    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click

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

        'CRYPTAGE DU MOT DE PASSE
        Dim motPasse As String
        Dim md As MD5 = MD5.Create
        Dim crypto As Byte() = md.ComputeHash(Encoding.Default.GetBytes(tbMotPasse.Text))
        Dim sb As New StringBuilder()

        For i As Integer = 0 To crypto.Length - 1
            sb.Append(crypto(i).ToString("x2"))
        Next i
        motPasse = sb.ToString

        'OUVERTURE DE LA FENÊTRE SELON LE TYPE D'UTILISATEUR
        Try
            If tbNom.Text = "" Then
                MsgBox("Veuillez entrer un nom")
            Else

                Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
                Dim dt As DataTable = ds.Tables("tblUtilisateurs")
                Connexion.nom = tbNom.Text

                For Each dr As DataRow In dt.Rows

                    If (dr(0) = tbNom.Text And dr(1) = motPasse) Then

                        If (dr(2) = "admin") Then
                            'Ouverture de la fenêtre Administrateur
                            Dim admin As New Administrateur
                            admin.StartPosition = FormStartPosition.Manual
                            admin.DesktopLocation = Me.DesktopLocation
                            admin.Show()
                            tbNom.Text = ""
                            tbMotPasse.Text = ""
                            Exit Sub

                        ElseIf (dr(2) = "gerant") Then
                            'Ouverture de la fenêtre Gerant
                            Dim gerant As New GerantClients
                            gerant.StartPosition = FormStartPosition.Manual
                            gerant.DesktopLocation = Me.DesktopLocation
                            gerant.Show()
                            tbNom.Text = ""
                            tbMotPasse.Text = ""
                            Exit Sub

                        ElseIf (dr(2) = "commis") Then
                            'Ouverture de la fenêtre Commis
                            Dim commis As New Commis
                            commis.StartPosition = FormStartPosition.Manual
                            commis.DesktopLocation = Me.DesktopLocation
                            commis.Show()
                            tbNom.Text = ""
                            tbMotPasse.Text = ""
                            Exit Sub
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Vos informations ne sont pas correctes")
            Clipboard.SetText(ex.Message)
        End Try
        Exit Sub
    End Sub

    'MODIFICATION DU MOT DE PASSE
    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click

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

        'CRYPTAGE DU MOT DE PASSE
        Dim motPasse As String
        Dim md As MD5 = MD5.Create
        Dim crypto As Byte() = md.ComputeHash(Encoding.Default.GetBytes(tbNouveau.Text))
        Dim sb As New StringBuilder()

        For i As Integer = 0 To crypto.Length - 1
            sb.Append(crypto(i).ToString("x2"))
        Next i
        motPasse = sb.ToString

        'UPDATE DU MOT DE PASSE
        Try
            Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
            Me.dt = ds.Tables("tblUtilisateurs")
            Connexion.nom = tbNom.Text
            Dim nom = Connexion.nom
            Dim dt As DataTable = Me.dt
            For Each dr As DataRow In dt.Rows
                If dr(0) = nom Then
                    dr(1) = motPasse
                    adapter.Update(Me.dt)
                    MsgBox("Le mot de passe a été modifié")
                End If
            Next
        Catch ex As Exception
            MsgBox("Problème: le mot de passe n'a pas été modifié")
            Clipboard.SetText(ex.Message)
        End Try
    End Sub

    'FERMETURE DE L'APPLICATION
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class
