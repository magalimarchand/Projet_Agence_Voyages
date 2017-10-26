Public Class GerantVoyages

    Dim celVal As String

    Private Sub TblVoyagesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblVoyagesBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.TblVoyagesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voyages2010DataSet)

    End Sub

    Private Sub FormGerantVoyages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblVoyagesTableAdapter.Fill(Me.Voyages2010DataSet.tblVoyages)
        TblVoyagesDataGridView.Columns(0).ReadOnly = True
        TblVoyagesDataGridView.Columns(1).ReadOnly = True
        TblVoyagesDataGridView.Columns(3).ReadOnly = True
        TblVoyagesDataGridView.Columns(4).ReadOnly = True
        TblVoyagesDataGridView.Columns(6).ReadOnly = True
        TblVoyagesDataGridView.Columns(7).ReadOnly = True
        TblVoyagesDataGridView.Columns(8).ReadOnly = True

    End Sub

    Private Sub TblVoyagesDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TblVoyagesDataGridView.CellMouseClick

        Dim cellule As DataGridViewCell = Me.TblVoyagesDataGridView.Item(e.ColumnIndex, e.RowIndex)
        celVal = cellule.Value.ToString

    End Sub

    'MODIFICATION DES CELLULES DE PRIX ET DE DURÉE
    Private Sub TblVoyagesDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblVoyagesDataGridView.CellValueChanged

        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then Exit Sub

        Try
            Dim c As DataGridViewCell = Me.TblVoyagesDataGridView.Item(e.ColumnIndex, e.RowIndex)
            Dim t As Boolean = False
            Dim r As DialogResult
            Dim v As String = c.Value.ToString
            If v <> celVal Then

                r = MessageBox.Show("Modifier la donnée ?",
                    "Confirmation Modification",
                    MessageBoxButtons.YesNo)
            End If
            If r = Windows.Forms.DialogResult.OK Then
                c.Value = v
            End If
            If r = Windows.Forms.DialogResult.No Then
                c.Value = celVal
            End If

            MsgBox("La modification a été enregistrée")

        Catch ex As Exception
            MsgBox("L'information entrée n'est pas correcte")
            Clipboard.SetText(ex.Message)
        End Try
    End Sub

    'ALLER À LA PAGE DE MODIFICATION DES CLIENTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gerant As New GerantClients
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