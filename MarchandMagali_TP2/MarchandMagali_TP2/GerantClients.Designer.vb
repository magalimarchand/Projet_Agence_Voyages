<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GerantClients
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
        Me.components = New System.ComponentModel.Container()
        Dim NumClientLabel As System.Windows.Forms.Label
        Dim TitreAbregeLabel As System.Windows.Forms.Label
        Dim NomClientLabel As System.Windows.Forms.Label
        Dim PrenomLabel As System.Windows.Forms.Label
        Dim AdresseLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim CodePostalLabel As System.Windows.Forms.Label
        Dim VilleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GerantClients))
        Me.Voyages2010DataSet = New MarchandMagali_TP2.Voyages2010DataSet()
        Me.TblClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientsTableAdapter = New MarchandMagali_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter()
        Me.TableAdapterManager = New MarchandMagali_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager()
        Me.TblClientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblClientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblClientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumClientTextBox = New System.Windows.Forms.TextBox()
        Me.TitreAbregeTextBox = New System.Windows.Forms.TextBox()
        Me.NomClientTextBox = New System.Windows.Forms.TextBox()
        Me.PrenomTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.CodePostalTextBox = New System.Windows.Forms.TextBox()
        Me.VilleTextBox = New System.Windows.Forms.TextBox()
        Me.cbAffichage = New System.Windows.Forms.CheckBox()
        Me.gbClient = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        NumClientLabel = New System.Windows.Forms.Label()
        TitreAbregeLabel = New System.Windows.Forms.Label()
        NomClientLabel = New System.Windows.Forms.Label()
        PrenomLabel = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        CodePostalLabel = New System.Windows.Forms.Label()
        VilleLabel = New System.Windows.Forms.Label()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblClientsBindingNavigator.SuspendLayout()
        CType(Me.TblClientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumClientLabel
        '
        NumClientLabel.AutoSize = True
        NumClientLabel.Location = New System.Drawing.Point(12, 19)
        NumClientLabel.Name = "NumClientLabel"
        NumClientLabel.Size = New System.Drawing.Size(61, 13)
        NumClientLabel.TabIndex = 2
        NumClientLabel.Text = "Num Client:"
        '
        'TitreAbregeLabel
        '
        TitreAbregeLabel.AutoSize = True
        TitreAbregeLabel.Location = New System.Drawing.Point(12, 45)
        TitreAbregeLabel.Name = "TitreAbregeLabel"
        TitreAbregeLabel.Size = New System.Drawing.Size(68, 13)
        TitreAbregeLabel.TabIndex = 4
        TitreAbregeLabel.Text = "Titre Abrege:"
        '
        'NomClientLabel
        '
        NomClientLabel.AutoSize = True
        NomClientLabel.Location = New System.Drawing.Point(12, 71)
        NomClientLabel.Name = "NomClientLabel"
        NomClientLabel.Size = New System.Drawing.Size(61, 13)
        NomClientLabel.TabIndex = 6
        NomClientLabel.Text = "Nom Client:"
        '
        'PrenomLabel
        '
        PrenomLabel.AutoSize = True
        PrenomLabel.Location = New System.Drawing.Point(12, 97)
        PrenomLabel.Name = "PrenomLabel"
        PrenomLabel.Size = New System.Drawing.Size(46, 13)
        PrenomLabel.TabIndex = 8
        PrenomLabel.Text = "Prenom:"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Location = New System.Drawing.Point(236, 19)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(48, 13)
        AdresseLabel.TabIndex = 10
        AdresseLabel.Text = "Adresse:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(236, 45)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 12
        TelephoneLabel.Text = "Telephone:"
        '
        'CodePostalLabel
        '
        CodePostalLabel.AutoSize = True
        CodePostalLabel.Location = New System.Drawing.Point(236, 71)
        CodePostalLabel.Name = "CodePostalLabel"
        CodePostalLabel.Size = New System.Drawing.Size(67, 13)
        CodePostalLabel.TabIndex = 14
        CodePostalLabel.Text = "Code Postal:"
        '
        'VilleLabel
        '
        VilleLabel.AutoSize = True
        VilleLabel.Location = New System.Drawing.Point(236, 97)
        VilleLabel.Name = "VilleLabel"
        VilleLabel.Size = New System.Drawing.Size(29, 13)
        VilleLabel.TabIndex = 16
        VilleLabel.Text = "Ville:"
        '
        'Voyages2010DataSet
        '
        Me.Voyages2010DataSet.DataSetName = "Voyages2010DataSet"
        Me.Voyages2010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientsBindingSource
        '
        Me.TblClientsBindingSource.DataMember = "tblClients"
        Me.TblClientsBindingSource.DataSource = Me.Voyages2010DataSet
        '
        'TblClientsTableAdapter
        '
        Me.TblClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCategoriesTableAdapter = Nothing
        Me.TableAdapterManager.tblClientsParisiensTableAdapter = Nothing
        Me.TableAdapterManager.tblClientsParVilleTableAdapter = Nothing
        Me.TableAdapterManager.tblClientsTableAdapter = Me.TblClientsTableAdapter
        Me.TableAdapterManager.tblReservationsTableAdapter = Nothing
        Me.TableAdapterManager.tblTitresTableAdapter = Nothing
        Me.TableAdapterManager.tblUtilisateurTableAdapter = Nothing
        Me.TableAdapterManager.tblVoyagesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MarchandMagali_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblClientsBindingNavigator
        '
        Me.TblClientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblClientsBindingNavigator.BindingSource = Me.TblClientsBindingSource
        Me.TblClientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblClientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblClientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblClientsBindingNavigatorSaveItem})
        Me.TblClientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblClientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblClientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblClientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblClientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblClientsBindingNavigator.Name = "TblClientsBindingNavigator"
        Me.TblClientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblClientsBindingNavigator.Size = New System.Drawing.Size(844, 25)
        Me.TblClientsBindingNavigator.TabIndex = 0
        Me.TblClientsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblClientsBindingNavigatorSaveItem
        '
        Me.TblClientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblClientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblClientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblClientsBindingNavigatorSaveItem.Name = "TblClientsBindingNavigatorSaveItem"
        Me.TblClientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblClientsBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'TblClientsDataGridView
        '
        Me.TblClientsDataGridView.AutoGenerateColumns = False
        Me.TblClientsDataGridView.BackgroundColor = System.Drawing.Color.Thistle
        Me.TblClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblClientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblClientsDataGridView.DataSource = Me.TblClientsBindingSource
        Me.TblClientsDataGridView.Location = New System.Drawing.Point(0, 228)
        Me.TblClientsDataGridView.Name = "TblClientsDataGridView"
        Me.TblClientsDataGridView.Size = New System.Drawing.Size(846, 242)
        Me.TblClientsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumClient"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NumClient"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TitreAbrege"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TitreAbrege"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomClient"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NomClient"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Prenom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prenom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Adresse"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Adresse"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CodePostal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CodePostal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ville"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ville"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'NumClientTextBox
        '
        Me.NumClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "NumClient", True))
        Me.NumClientTextBox.Location = New System.Drawing.Point(86, 16)
        Me.NumClientTextBox.Name = "NumClientTextBox"
        Me.NumClientTextBox.ReadOnly = True
        Me.NumClientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumClientTextBox.TabIndex = 3
        '
        'TitreAbregeTextBox
        '
        Me.TitreAbregeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "TitreAbrege", True))
        Me.TitreAbregeTextBox.Location = New System.Drawing.Point(86, 42)
        Me.TitreAbregeTextBox.Name = "TitreAbregeTextBox"
        Me.TitreAbregeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitreAbregeTextBox.TabIndex = 5
        '
        'NomClientTextBox
        '
        Me.NomClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "NomClient", True))
        Me.NomClientTextBox.Location = New System.Drawing.Point(86, 68)
        Me.NomClientTextBox.Name = "NomClientTextBox"
        Me.NomClientTextBox.ReadOnly = True
        Me.NomClientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomClientTextBox.TabIndex = 7
        '
        'PrenomTextBox
        '
        Me.PrenomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Prenom", True))
        Me.PrenomTextBox.Location = New System.Drawing.Point(86, 94)
        Me.PrenomTextBox.Name = "PrenomTextBox"
        Me.PrenomTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrenomTextBox.TabIndex = 9
        '
        'AdresseTextBox
        '
        Me.AdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Adresse", True))
        Me.AdresseTextBox.Location = New System.Drawing.Point(310, 16)
        Me.AdresseTextBox.Name = "AdresseTextBox"
        Me.AdresseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdresseTextBox.TabIndex = 11
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(310, 42)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelephoneTextBox.TabIndex = 13
        '
        'CodePostalTextBox
        '
        Me.CodePostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "CodePostal", True))
        Me.CodePostalTextBox.Location = New System.Drawing.Point(310, 68)
        Me.CodePostalTextBox.Name = "CodePostalTextBox"
        Me.CodePostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodePostalTextBox.TabIndex = 15
        '
        'VilleTextBox
        '
        Me.VilleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Ville", True))
        Me.VilleTextBox.Location = New System.Drawing.Point(310, 94)
        Me.VilleTextBox.Name = "VilleTextBox"
        Me.VilleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VilleTextBox.TabIndex = 17
        '
        'cbAffichage
        '
        Me.cbAffichage.AutoSize = True
        Me.cbAffichage.Location = New System.Drawing.Point(12, 205)
        Me.cbAffichage.Name = "cbAffichage"
        Me.cbAffichage.Size = New System.Drawing.Size(107, 17)
        Me.cbAffichage.TabIndex = 18
        Me.cbAffichage.Text = "Choix d'affichage"
        Me.cbAffichage.UseVisualStyleBackColor = True
        '
        'gbClient
        '
        Me.gbClient.Controls.Add(NumClientLabel)
        Me.gbClient.Controls.Add(Me.NumClientTextBox)
        Me.gbClient.Controls.Add(TitreAbregeLabel)
        Me.gbClient.Controls.Add(Me.TitreAbregeTextBox)
        Me.gbClient.Controls.Add(NomClientLabel)
        Me.gbClient.Controls.Add(Me.NomClientTextBox)
        Me.gbClient.Controls.Add(PrenomLabel)
        Me.gbClient.Controls.Add(Me.PrenomTextBox)
        Me.gbClient.Controls.Add(AdresseLabel)
        Me.gbClient.Controls.Add(Me.AdresseTextBox)
        Me.gbClient.Controls.Add(TelephoneLabel)
        Me.gbClient.Controls.Add(Me.TelephoneTextBox)
        Me.gbClient.Controls.Add(CodePostalLabel)
        Me.gbClient.Controls.Add(Me.CodePostalTextBox)
        Me.gbClient.Controls.Add(VilleLabel)
        Me.gbClient.Controls.Add(Me.VilleTextBox)
        Me.gbClient.Location = New System.Drawing.Point(213, 84)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(423, 129)
        Me.gbClient.TabIndex = 19
        Me.gbClient.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(348, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Modifications Client"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 29)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Modifications Voyage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(735, 493)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(97, 27)
        Me.btnFermer.TabIndex = 44
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'GerantClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(844, 532)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbClient)
        Me.Controls.Add(Me.cbAffichage)
        Me.Controls.Add(Me.TblClientsDataGridView)
        Me.Controls.Add(Me.TblClientsBindingNavigator)
        Me.Name = "GerantClients"
        Me.Text = "GÉRANT - CLIENTS"
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblClientsBindingNavigator.ResumeLayout(False)
        Me.TblClientsBindingNavigator.PerformLayout()
        CType(Me.TblClientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClient.ResumeLayout(False)
        Me.gbClient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Voyages2010DataSet As MarchandMagali_TP2.Voyages2010DataSet
    Friend WithEvents TblClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientsTableAdapter As MarchandMagali_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter
    Friend WithEvents TableAdapterManager As MarchandMagali_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblClientsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblClientsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblClientsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitreAbregeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodePostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VilleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cbAffichage As System.Windows.Forms.CheckBox
    Friend WithEvents gbClient As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFermer As Button
End Class
