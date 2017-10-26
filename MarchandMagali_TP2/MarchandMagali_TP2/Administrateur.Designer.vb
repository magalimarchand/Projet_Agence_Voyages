<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.lblNewUsername = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.tbMotPasse = New System.Windows.Forms.MaskedTextBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblTypeUtilisateur = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbClient = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.BackgroundColor = System.Drawing.Color.Thistle
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(6, 23)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(318, 155)
        Me.DataGridView.TabIndex = 2
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(465, 151)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(100, 27)
        Me.btnSupprimer.TabIndex = 11
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'lblNewUsername
        '
        Me.lblNewUsername.AutoSize = True
        Me.lblNewUsername.Location = New System.Drawing.Point(59, 22)
        Me.lblNewUsername.Name = "lblNewUsername"
        Me.lblNewUsername.Size = New System.Drawing.Size(29, 13)
        Me.lblNewUsername.TabIndex = 16
        Me.lblNewUsername.Text = "Nom"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(114, 19)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(224, 20)
        Me.tbNom.TabIndex = 17
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(17, 62)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(71, 13)
        Me.lblNewPassword.TabIndex = 18
        Me.lblNewPassword.Text = "Mot de passe"
        '
        'tbMotPasse
        '
        Me.tbMotPasse.Location = New System.Drawing.Point(114, 59)
        Me.tbMotPasse.Name = "tbMotPasse"
        Me.tbMotPasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMotPasse.Size = New System.Drawing.Size(224, 20)
        Me.tbMotPasse.TabIndex = 19
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(465, 99)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(100, 27)
        Me.btnAjouter.TabIndex = 22
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'lblTypeUtilisateur
        '
        Me.lblTypeUtilisateur.AutoSize = True
        Me.lblTypeUtilisateur.Location = New System.Drawing.Point(57, 99)
        Me.lblTypeUtilisateur.Name = "lblTypeUtilisateur"
        Me.lblTypeUtilisateur.Size = New System.Drawing.Size(31, 13)
        Me.lblTypeUtilisateur.TabIndex = 23
        Me.lblTypeUtilisateur.Text = "Type"
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"gerant", "commis"})
        Me.cbType.Location = New System.Drawing.Point(114, 96)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(224, 21)
        Me.cbType.TabIndex = 24
        '
        'btnFermer
        '
        Me.btnFermer.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnFermer.Location = New System.Drawing.Point(739, 490)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(93, 27)
        Me.btnFermer.TabIndex = 28
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(292, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Suppression d'un utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(326, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Ajout d'un utilisateur"
        '
        'gbClient
        '
        Me.gbClient.Controls.Add(Me.tbMotPasse)
        Me.gbClient.Controls.Add(Me.lblNewPassword)
        Me.gbClient.Controls.Add(Me.tbNom)
        Me.gbClient.Controls.Add(Me.lblNewUsername)
        Me.gbClient.Controls.Add(Me.lblTypeUtilisateur)
        Me.gbClient.Controls.Add(Me.cbType)
        Me.gbClient.Controls.Add(Me.btnAjouter)
        Me.gbClient.Location = New System.Drawing.Point(125, 73)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(585, 143)
        Me.gbClient.TabIndex = 32
        Me.gbClient.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSupprimer)
        Me.GroupBox1.Controls.Add(Me.DataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(125, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 191)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des utilisateurs"
        '
        'Administrateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(844, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbClient)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFermer)
        Me.Name = "Administrateur"
        Me.Text = "ADMINISTRATEUR"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClient.ResumeLayout(False)
        Me.gbClient.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents tbMotPasse As MaskedTextBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents lblTypeUtilisateur As Label
    Friend WithEvents cbType As ComboBox
    Friend WithEvents btnFermer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbClient As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
