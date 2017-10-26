<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.tbMotPasse = New System.Windows.Forms.MaskedTextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.tbNouveau = New System.Windows.Forms.MaskedTextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbClient = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbClient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnexion
        '
        Me.btnConnexion.Location = New System.Drawing.Point(469, 86)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(100, 27)
        Me.btnConnexion.TabIndex = 22
        Me.btnConnexion.Text = "Se connecter"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'tbMotPasse
        '
        Me.tbMotPasse.Location = New System.Drawing.Point(174, 74)
        Me.tbMotPasse.Name = "tbMotPasse"
        Me.tbMotPasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMotPasse.Size = New System.Drawing.Size(224, 20)
        Me.tbMotPasse.TabIndex = 21
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(78, 77)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 13)
        Me.lblPassword.TabIndex = 20
        Me.lblPassword.Text = "Mot de passe"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(174, 29)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(224, 20)
        Me.tbNom.TabIndex = 19
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(120, 32)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(29, 13)
        Me.lblUsername.TabIndex = 18
        Me.lblUsername.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(363, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Connexion"
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(735, 493)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(97, 27)
        Me.btnFermer.TabIndex = 35
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(298, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Modification du mot de passe"
        '
        'btnModifier
        '
        Me.btnModifier.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnModifier.Location = New System.Drawing.Point(469, 85)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(100, 27)
        Me.btnModifier.TabIndex = 38
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'tbNouveau
        '
        Me.tbNouveau.Location = New System.Drawing.Point(174, 50)
        Me.tbNouveau.Name = "tbNouveau"
        Me.tbNouveau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNouveau.Size = New System.Drawing.Size(224, 20)
        Me.tbNouveau.TabIndex = 37
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(32, 53)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(117, 13)
        Me.lblNewPassword.TabIndex = 36
        Me.lblNewPassword.Text = "Nouveau mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(332, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "VOYAGES 2010"
        '
        'gbClient
        '
        Me.gbClient.Controls.Add(Me.tbNom)
        Me.gbClient.Controls.Add(Me.lblPassword)
        Me.gbClient.Controls.Add(Me.lblUsername)
        Me.gbClient.Controls.Add(Me.btnConnexion)
        Me.gbClient.Controls.Add(Me.tbMotPasse)
        Me.gbClient.Location = New System.Drawing.Point(112, 130)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(591, 129)
        Me.gbClient.TabIndex = 42
        Me.gbClient.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbNouveau)
        Me.GroupBox1.Controls.Add(Me.lblNewPassword)
        Me.GroupBox1.Controls.Add(Me.btnModifier)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 340)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 129)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(844, 532)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Connexion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.gbClient.ResumeLayout(False)
        Me.gbClient.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnexion As System.Windows.Forms.Button
    Friend WithEvents tbMotPasse As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents tbNom As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFermer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModifier As Button
    Friend WithEvents tbNouveau As MaskedTextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbClient As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
