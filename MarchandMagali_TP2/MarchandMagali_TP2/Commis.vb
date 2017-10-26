Public Class Commis

    Private Sub Commis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblReservationsTableAdapter.Fill(Me.Voyages2010DataSet.tblReservations)
        Me.TblClientsTableAdapter.Fill(Me.Voyages2010DataSet.tblClients)

    End Sub

    'AJOUT D'UNE RÉSERVATION
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click

        If MessageBox.Show("Enregistrer la reservation ?",
                           "Confirmation Enregistrement",
                           MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Me.Validate()
            Me.TblClientsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Voyages2010DataSet)

        End If

    End Sub

    'SUPPRESSION D'UNE RÉSERVATION
    Private Sub BindingNavigator1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles BindingNavigator1.ItemClicked
        If e.ClickedItem Is Me.ToolStripButton2 Then
            If MessageBox.Show("Supprimer la reservation ?",
                               "Confirmation Suppression",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                Me.BindingNavigator1.DeleteItem = Me.ToolStripButton2
            Else
                Me.BindingNavigator1.DeleteItem = Nothing
            End If
        End If
    End Sub

    'FERMETURE DE L'APPLICATION
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

End Class