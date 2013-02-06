<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogTim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Vc_id_timLabel As System.Windows.Forms.Label
        Dim Vc_nama_timLabel As System.Windows.Forms.Label
        Dim Vc_nama_stadionLabel As System.Windows.Forms.Label
        Dim Nu_kap_stadionLabel As System.Windows.Forms.Label
        Dim Vc_alamat_stadionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogTim))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.DataSet = New PenjadwalanPertandingan.DataSet
        Me.TimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimTableAdapter = New PenjadwalanPertandingan.DataSetTableAdapters.TimTableAdapter
        Me.TableAdapterManager = New PenjadwalanPertandingan.DataSetTableAdapters.TableAdapterManager
        Me.TimBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TimBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TimDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Vc_alamat_stadionTextBox = New System.Windows.Forms.TextBox
        Me.Nu_kap_stadionTextBox = New System.Windows.Forms.TextBox
        Me.Vc_nama_stadionTextBox = New System.Windows.Forms.TextBox
        Me.Vc_nama_timTextBox = New System.Windows.Forms.TextBox
        Me.Vc_id_timTextBox = New System.Windows.Forms.TextBox
        Vc_id_timLabel = New System.Windows.Forms.Label
        Vc_nama_timLabel = New System.Windows.Forms.Label
        Vc_nama_stadionLabel = New System.Windows.Forms.Label
        Nu_kap_stadionLabel = New System.Windows.Forms.Label
        Vc_alamat_stadionLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimBindingNavigator.SuspendLayout()
        CType(Me.TimDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vc_id_timLabel
        '
        Vc_id_timLabel.AutoSize = True
        Vc_id_timLabel.Location = New System.Drawing.Point(62, 18)
        Vc_id_timLabel.Name = "Vc_id_timLabel"
        Vc_id_timLabel.Size = New System.Drawing.Size(38, 13)
        Vc_id_timLabel.TabIndex = 0
        Vc_id_timLabel.Text = "Id TIM"
        '
        'Vc_nama_timLabel
        '
        Vc_nama_timLabel.AutoSize = True
        Vc_nama_timLabel.Location = New System.Drawing.Point(44, 44)
        Vc_nama_timLabel.Name = "Vc_nama_timLabel"
        Vc_nama_timLabel.Size = New System.Drawing.Size(55, 13)
        Vc_nama_timLabel.TabIndex = 2
        Vc_nama_timLabel.Text = "Nama Tim"
        '
        'Vc_nama_stadionLabel
        '
        Vc_nama_stadionLabel.AutoSize = True
        Vc_nama_stadionLabel.Location = New System.Drawing.Point(23, 70)
        Vc_nama_stadionLabel.Name = "Vc_nama_stadionLabel"
        Vc_nama_stadionLabel.Size = New System.Drawing.Size(74, 13)
        Vc_nama_stadionLabel.TabIndex = 4
        Vc_nama_stadionLabel.Text = "Nama Stadion"
        '
        'Nu_kap_stadionLabel
        '
        Nu_kap_stadionLabel.AutoSize = True
        Nu_kap_stadionLabel.Location = New System.Drawing.Point(261, 21)
        Nu_kap_stadionLabel.Name = "Nu_kap_stadionLabel"
        Nu_kap_stadionLabel.Size = New System.Drawing.Size(92, 13)
        Nu_kap_stadionLabel.TabIndex = 6
        Nu_kap_stadionLabel.Text = "Kapasitas Stadion"
        '
        'Vc_alamat_stadionLabel
        '
        Vc_alamat_stadionLabel.AutoSize = True
        Vc_alamat_stadionLabel.Location = New System.Drawing.Point(261, 47)
        Vc_alamat_stadionLabel.Name = "Vc_alamat_stadionLabel"
        Vc_alamat_stadionLabel.Size = New System.Drawing.Size(78, 13)
        Vc_alamat_stadionLabel.TabIndex = 8
        Vc_alamat_stadionLabel.Text = "Alamat Stadion"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(816, 406)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimBindingSource
        '
        Me.TimBindingSource.DataMember = "Tim"
        Me.TimBindingSource.DataSource = Me.DataSet
        '
        'TimTableAdapter
        '
        Me.TimTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CounterTableAdapter = Nothing
        Me.TableAdapterManager.hindari_tanggalTableAdapter = Nothing
        Me.TableAdapterManager.LigaTableAdapter = Nothing
        Me.TableAdapterManager.pertandinganTableAdapter = Nothing
        Me.TableAdapterManager.ta_tgl_lastnoTableAdapter = Nothing
        Me.TableAdapterManager.TandingTableAdapter = Nothing
        Me.TableAdapterManager.tgl_mainTableAdapter = Nothing
        Me.TableAdapterManager.TimTableAdapter = Me.TimTableAdapter
        Me.TableAdapterManager.undi_timTableAdapter = Nothing
        Me.TableAdapterManager.undi_wasitTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PenjadwalanPertandingan.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WasitTableAdapter = Nothing
        '
        'TimBindingNavigator
        '
        Me.TimBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TimBindingNavigator.BindingSource = Me.TimBindingSource
        Me.TimBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TimBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TimBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TimBindingNavigatorSaveItem})
        Me.TimBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TimBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TimBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TimBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TimBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TimBindingNavigator.Name = "TimBindingNavigator"
        Me.TimBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TimBindingNavigator.Size = New System.Drawing.Size(965, 25)
        Me.TimBindingNavigator.TabIndex = 1
        Me.TimBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TimBindingNavigatorSaveItem
        '
        Me.TimBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TimBindingNavigatorSaveItem.Image = CType(resources.GetObject("TimBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TimBindingNavigatorSaveItem.Name = "TimBindingNavigatorSaveItem"
        Me.TimBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TimBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TimDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TimDataGridView.AutoGenerateColumns = False
        Me.TimDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TimDataGridView.DataSource = Me.TimBindingSource
        Me.TimDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimDataGridView.Location = New System.Drawing.Point(3, 131)
        Me.TimDataGridView.Name = "TimDataGridView"
        Me.TimDataGridView.Size = New System.Drawing.Size(959, 262)
        Me.TimDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "vc_id_tim"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id TIM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "vc_nama_tim"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Tim"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "vc_nama_stadion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama Stadion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nu_kap_stadion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kapasitas Stadion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "vc_alamat_stadion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Alamat Stadion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TimDataGridView, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(965, 438)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Vc_alamat_stadionLabel)
        Me.Panel1.Controls.Add(Me.Vc_alamat_stadionTextBox)
        Me.Panel1.Controls.Add(Nu_kap_stadionLabel)
        Me.Panel1.Controls.Add(Me.Nu_kap_stadionTextBox)
        Me.Panel1.Controls.Add(Vc_nama_stadionLabel)
        Me.Panel1.Controls.Add(Me.Vc_nama_stadionTextBox)
        Me.Panel1.Controls.Add(Vc_nama_timLabel)
        Me.Panel1.Controls.Add(Me.Vc_nama_timTextBox)
        Me.Panel1.Controls.Add(Vc_id_timLabel)
        Me.Panel1.Controls.Add(Me.Vc_id_timTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 122)
        Me.Panel1.TabIndex = 3
        '
        'Vc_alamat_stadionTextBox
        '
        Me.Vc_alamat_stadionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimBindingSource, "vc_alamat_stadion", True))
        Me.Vc_alamat_stadionTextBox.Location = New System.Drawing.Point(360, 44)
        Me.Vc_alamat_stadionTextBox.Name = "Vc_alamat_stadionTextBox"
        Me.Vc_alamat_stadionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vc_alamat_stadionTextBox.TabIndex = 9
        '
        'Nu_kap_stadionTextBox
        '
        Me.Nu_kap_stadionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimBindingSource, "nu_kap_stadion", True))
        Me.Nu_kap_stadionTextBox.Location = New System.Drawing.Point(360, 18)
        Me.Nu_kap_stadionTextBox.Name = "Nu_kap_stadionTextBox"
        Me.Nu_kap_stadionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nu_kap_stadionTextBox.TabIndex = 7
        '
        'Vc_nama_stadionTextBox
        '
        Me.Vc_nama_stadionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimBindingSource, "vc_nama_stadion", True))
        Me.Vc_nama_stadionTextBox.Location = New System.Drawing.Point(117, 67)
        Me.Vc_nama_stadionTextBox.Name = "Vc_nama_stadionTextBox"
        Me.Vc_nama_stadionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vc_nama_stadionTextBox.TabIndex = 5
        '
        'Vc_nama_timTextBox
        '
        Me.Vc_nama_timTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimBindingSource, "vc_nama_tim", True))
        Me.Vc_nama_timTextBox.Location = New System.Drawing.Point(117, 41)
        Me.Vc_nama_timTextBox.Name = "Vc_nama_timTextBox"
        Me.Vc_nama_timTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vc_nama_timTextBox.TabIndex = 3
        '
        'Vc_id_timTextBox
        '
        Me.Vc_id_timTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimBindingSource, "vc_id_tim", True))
        Me.Vc_id_timTextBox.Location = New System.Drawing.Point(117, 15)
        Me.Vc_id_timTextBox.Name = "Vc_id_timTextBox"
        Me.Vc_id_timTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vc_id_timTextBox.TabIndex = 1
        '
        'DialogTim
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(965, 463)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TimBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogTim"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogTim"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimBindingNavigator.ResumeLayout(False)
        Me.TimBindingNavigator.PerformLayout()
        CType(Me.TimDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataSet As PenjadwalanPertandingan.DataSet
    Friend WithEvents TimBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimTableAdapter As PenjadwalanPertandingan.DataSetTableAdapters.TimTableAdapter
    Friend WithEvents TableAdapterManager As PenjadwalanPertandingan.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TimBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TimBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TimDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Vc_alamat_stadionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nu_kap_stadionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vc_nama_stadionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vc_nama_timTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vc_id_timTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
