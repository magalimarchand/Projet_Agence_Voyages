Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class GerantClients

    Dim ds As New DataSet
    Private dtU As New DataTable
    Private dtC As New DataTable
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter()
    Dim connect As New OleDbConnection

    Private Sub TblClientsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblClientsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblClientsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Voyages2010DataSet)
            MsgBox("Les informations ont été enregistrées")
        Catch ex As Exception
            MessageBox.Show("Les informations entrées sont incorrectes")
            Clipboard.SetText(ex.Message)
        End Try

    End Sub

    'CHARGEMENT DES INFORMATIONS
    Private Sub GerantClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblClientsTableAdapter.Fill(Me.Voyages2010DataSet.tblClients)
        TblClientsDataGridView.Columns(0).ReadOnly = True
        TblClientsDataGridView.Columns(2).ReadOnly = True

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

        Try
            Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
            dtU = ds.Tables("tblUtilisateurs")
            Dim nomUtilisateur = Connexion.nom
            Dim dt As DataTable = dtU
            For Each dr As DataRow In dt.Rows
                If dr(0) = nomUtilisateur And dr(3) = True Then
                    cbAffichage.Checked = True
                    gbClient.Visible = False
                    TblClientsDataGridView.Visible = True
                End If
                If dr(0) = nomUtilisateur And dr(3) = False Then
                    cbAffichage.Checked = False
                    gbClient.Visible = True
                    TblClientsDataGridView.Visible = False
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Clipboard.SetText(ex.Message)
        End Try
    End Sub

    'AJOUT D'UN CLIENT
    Private Sub TblClientsBindingNavigator_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TblClientsBindingNavigator.ItemClicked

        Try
            If e.ClickedItem Is Me.BindingNavigatorAddNewItem Then

                TblClientsDataGridView.Columns(0).ReadOnly = False
                TblClientsDataGridView.Columns(2).ReadOnly = False

            End If

            If e.ClickedItem Is Me.TblClientsBindingNavigatorSaveItem Then
                TblClientsDataGridView.Columns(0).ReadOnly = True
                TblClientsDataGridView.Columns(2).ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Les informations entrées sont incorrectes")
            Clipboard.SetText(ex.Message)
        End Try

    End Sub

    'MODIFICATION DES INFORMATIONS D'UN CLIENT DANS LE TABLEAU
    Private Sub TblClientsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblClientsDataGridView.CellValueChanged

        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then Exit Sub

        Try
            Dim cellule As DataGridViewCell = Me.TblClientsDataGridView.Item(e.ColumnIndex, e.RowIndex)
            Dim strCol As String = cellule.OwningColumn.DataPropertyName

            If strCol = "TitreAbrege" Then
                Dim strVal As String = cellule.Value.ToString
                If strVal.Length > 0 Then
                    strVal = strVal.Substring(0, 1).ToUpper & strVal.Substring(1).ToLower
                    If strVal <> "Mme" And strVal <> "Mlle" And strVal <> "M" Then
                        cellule.ErrorText = "Veuillez entrer un titre valide"
                    Else
                        cellule.ErrorText = String.Empty
                        cellule.Value = strVal
                    End If
                End If

            ElseIf strCol = "CodePostal" Then
                Dim strVal As String = cellule.Value.ToString
                If strVal.Length > 0 Then
                    If Regex.IsMatch(strVal, "^\d{5}$") Then
                        cellule.ErrorText = String.Empty
                        cellule.Value = strVal
                    Else
                        cellule.ErrorText = "Veuillez entrer un code postal valide"
                    End If
                End If

            ElseIf strCol = "Telephone" Then
                Dim strVal As String = cellule.Value.ToString
                If strVal.Length > 0 Then
                    If Regex.IsMatch(strVal, "^(\d{2}\.){4}\d{2}$") Then
                        cellule.ErrorText = String.Empty
                        cellule.Value = strVal
                    Else
                        cellule.ErrorText = "Veuillez entrer un numéro de téléphone valide"
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Les informations entrées sont incorrectes")
            Clipboard.SetText(ex.Message)
        End Try
    End Sub

    'MODIFICATION DE L'AFFICHAGE
    Private Sub cbAffichage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAffichage.CheckedChanged

        Try
            connect.ConnectionString = My.Settings.Voyages2010ConnectionString
            connect.Open()
            Dim requete As String = "SELECT * FROM tblUtilisateurs"
            Dim cmd As New OleDb.OleDbCommand(requete, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(ds, "tblUtilisateurs")
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Clipboard.SetText(ex.Message)
        End Try

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        dtU = ds.Tables("tblUtilisateurs")
        Dim nomUtilisateur = Connexion.nom
        Dim dt As DataTable = dtU
        If Me.cbAffichage.Checked Then
            gbClient.Visible = False
            TblClientsDataGridView.Visible = True
            For Each dr As DataRow In dt.Rows
                If dr(0) = nomUtilisateur Then
                    dr(3) = True
                End If
            Next
        Else
            gbClient.Visible = True
            TblClientsDataGridView.Visible = False
            For Each dr As DataRow In dt.Rows
                If dr(0) = nomUtilisateur Then
                    dr(3) = False
                End If
            Next
        End If
    End Sub

    'ALLER À LA PAGE DE MODIFICATION DES VOYAGES
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gerant As New GerantVoyages
        gerant.StartPosition = FormStartPosition.Manual
        gerant.DesktopLocation = Me.DesktopLocation
        gerant.Show()
        Me.Close()
    End Sub

    'FERMETURE DE L'APPLICATION
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class