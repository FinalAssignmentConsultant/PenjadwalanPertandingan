<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogWasit
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
        Dim Vc_id_wasitLabel As System.Windows.Forms.Label
        Dim Vc_nama_wasitLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogWasit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.DataSet = New PenjadwalanPertandingan.DataSet
        Me.WasitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WasitTableAdapter = New PenjadwalanPertandingan.DataSetTableAdapters.WasitTableAdapter
        Me.TableAdapterManager = New PenjadwalanPertandingan.DataSetTableAdapters.TableAdapterManager
        Me.WasitBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WasitBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.WasitDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Bt_statusCheckBox = New System.Windows.Forms.CheckBox
        Me.Vc_nama_wasitTextBox = New System.Windows.Forms.TextBox
        Me.Vc_id_wasitTextBox = New System.Windows.Forms.TextBox
        Vc_id_wasitLabel = New System.Windows.Forms.Label
        Vc_nama_wasitLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WasitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WasitBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WasitBindingNavigator.SuspendLayout()
        CType(Me.WasitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vc_id_wasitLabel
        '
        Vc_id_wasitLabel.AutoSize = True
        Vc_id_wasitLabel.Location = New System.Drawing.Point(34, 23)
        Vc_id_wasitLabel.Name = "Vc_id_wasitLabel"
        Vc_id_wasitLabel.Size = New System.Drawing.Size(46, 13)
        Vc_id_wasitLabel.TabIndex = 0
        Vc_id_wasitLabel.Text = "Id Wasit"
        '
        'Vc_nama_wasitLabel
        '
        Vc_nama_wasitLabel.AutoSize = True
        Vc_nama_wasitLabel.Location = New System.Drawing.Point(16, 49)
        Vc_nama_wasitLabel.Name = "Vc_nama_wasitLabel"
        Vc_nama_wasitLabel.Size = New System.Drawing.Size(65, 13)
        Vc_nama_wasitLabel.TabIndex = 2
        Vc_nama_wasitLabel.Text = "Nama Wasit"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(294, 325)
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
        'WasitBindingSource
        '
        Me.WasitBindingSource.DataMember = "Wasit"
        Me.WasitBindingSource.DataSource = Me.DataSet
        '
        'WasitTableAdapter
        '
        Me.WasitTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TimTableAdapter = Nothing
        Me.TableAdapterManager.undi_timTableAdapter = Nothing
        Me.TableAdapterManager.undi_wasitTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PenjadwalanPertandingan.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WasitTableAdapter = Me.WasitTableAdapter
        '
        'WasitBindingNavigator
        '
        Me.WasitBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WasitBindingNavigator.BindingSource = Me.WasitBindingSource
        Me.WasitBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WasitBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WasitBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WasitBindingNavigatorSaveItem})
        Me.WasitBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WasitBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WasitBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WasitBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WasitBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WasitBindingNavigator.Name = "WasitBindingNavigator"
        Me.WasitBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WasitBindingNavigator.Size = New System.Drawing.Size(443, 25)
        Me.WasitBindingNavigator.TabIndex = 1
        Me.WasitBindingNavigator.Text = "BindingNavigator1"
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
        'WasitBindingNavigatorSaveItem
        '
        Me.WasitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WasitBindingNavigatorSaveItem.Image = CType(resources.GetObject("WasitBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WasitBindingNavigatorSaveItem.Name = "WasitBindingNavigatorSaveItem"
        Me.WasitBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WasitBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WasitDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WasitDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.WasitDataGridView.AutoGenerateColumns = False
        Me.WasitDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WasitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WasitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.WasitDataGridView.DataSource = Me.WasitBindingSource
        Me.WasitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WasitDataGridView.Location = New System.Drawing.Point(3, 143)
        Me.WasitDataGridView.Name = "WasitDataGridView"
        Me.WasitDataGridView.Size = New System.Drawing.Size(437, 170)
        Me.WasitDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "vc_id_wasit"
        Me.DataGridViewTextBoxColumn1.HeaderText = "vc_id_wasit"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "vc_nama_wasit"
        Me.DataGridViewTextBoxColumn2.HeaderText = "vc_nama_wasit"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "bt_status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "bt_status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.WasitDataGridView, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(443, 357)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Bt_statusCheckBox)
        Me.Panel1.Controls.Add(Vc_nama_wasitLabel)
        Me.Panel1.Controls.Add(Me.Vc_nama_wasitTextBox)
        Me.Panel1.Controls.Add(Vc_id_wasitLabel)
        Me.Panel1.Controls.Add(Me.Vc_id_wasitTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 134)
        Me.Panel1.TabIndex = 3
        '
        'Bt_statusCheckBox
        '
        Me.Bt_statusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WasitBindingSource, "bt_status", True))
        Me.Bt_statusCheckBox.Location = New System.Drawing.Point(100, 72)
        Me.Bt_statusCheckBox.Name = "Bt_statusCheckBox"
        Me.Bt_statusCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Bt_statusCheckBox.TabIndex = 5
        Me.Bt_statusCheckBox.Text = "Aktif"
        Me.Bt_statusCheckBox.UseVisualStyleBackColor = True
        '
        'Vc_nama_wasitTextBox
        '
        Me.Vc_nama_wasitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WasitBindingSource, "vc_nama_wasit", True))
        Me.Vc_nama_wasitTextBox.Location = New System.Drawing.Point(100, 46)
        Me.Vc_nama_wasitTextBox.Name = "Vc_nama_wasitTextBox"
        Me.Vc_nama_wasitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vc_nama_wasitTextBox.TabIndex = 3
        '
        'Vc_id_wasitTextBox
        '
        Me.Vc_id_wasitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WasitBindingSource, "vc_id_wasit", True))
        Me.Vc_id_wasitTextBox.Location = New System.Drawing.Point(100, 20)
        Me.Vc_id_wasitTextBox.Name = "Vc_id_wasitTextBox"
        Me.Vc_id_wasitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vc_id_wasitTextBox.TabIndex = 1
        '
        'DialogWasit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(443, 382)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.WasitBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogWasit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogWasit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WasitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WasitBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WasitBindingNavigator.ResumeLayout(False)
        Me.WasitBindingNavigator.PerformLayout()
        CType(Me.WasitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents WasitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WasitTableAdapter As PenjadwalanPertandingan.DataSetTableAdapters.WasitTableAdapter
    Friend WithEvents TableAdapterManager As PenjadwalanPertandingan.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents WasitBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents WasitBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WasitDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bt_statusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Vc_nama_wasitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vc_id_wasitTextBox As System.Windows.Forms.TextBox

End Class
