<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _351
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_351))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Chk_Tel = New System.Windows.Forms.CheckBox()
        Me._Opt_Order_1 = New System.Windows.Forms.RadioButton()
        Me._Opt_Order_0 = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Excel_Output = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersoncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoresectioncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet2 = New MyFirstVBWindowApp.customerDataSet2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerTableAdapter = New MyFirstVBWindowApp.customerDataSet2TableAdapters.customerTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblDownloadLink = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "センターメ確状況照会"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(642, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "絞込条件　 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "並び順　　　："
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(277, 91)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 21)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "未メ確残ありのみ"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Chk_Tel
        '
        Me.Chk_Tel.AutoSize = True
        Me.Chk_Tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Chk_Tel.Location = New System.Drawing.Point(473, 90)
        Me.Chk_Tel.Name = "Chk_Tel"
        Me.Chk_Tel.Size = New System.Drawing.Size(112, 21)
        Me.Chk_Tel.TabIndex = 5
        Me.Chk_Tel.Text = "ＴＥＬメ確のみ"
        Me.Chk_Tel.UseVisualStyleBackColor = True
        '
        '_Opt_Order_1
        '
        Me._Opt_Order_1.AutoSize = True
        Me._Opt_Order_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me._Opt_Order_1.Location = New System.Drawing.Point(277, 140)
        Me._Opt_Order_1.Name = "_Opt_Order_1"
        Me._Opt_Order_1.Size = New System.Drawing.Size(123, 21)
        Me._Opt_Order_1.TabIndex = 6
        Me._Opt_Order_1.TabStop = True
        Me._Opt_Order_1.Text = "担当者コード順"
        Me._Opt_Order_1.UseVisualStyleBackColor = True
        '
        '_Opt_Order_0
        '
        Me._Opt_Order_0.AutoSize = True
        Me._Opt_Order_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me._Opt_Order_0.Location = New System.Drawing.Point(473, 141)
        Me._Opt_Order_0.Name = "_Opt_Order_0"
        Me._Opt_Order_0.Size = New System.Drawing.Size(108, 21)
        Me._Opt_Order_0.TabIndex = 7
        Me._Opt_Order_0.TabStop = True
        Me._Opt_Order_0.Text = "店課コード順"
        Me._Opt_Order_0.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(111, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 31)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "f5=戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(209, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(74, 31)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "f6=再表示"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Excel_Output
        '
        Me.Excel_Output.Location = New System.Drawing.Point(305, 18)
        Me.Excel_Output.Name = "Excel_Output"
        Me.Excel_Output.Size = New System.Drawing.Size(103, 31)
        Me.Excel_Output.TabIndex = 10
        Me.Excel_Output.Text = "f7=EXCEL出力"
        Me.Excel_Output.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToOrderColumns = True
        Me.dataGrid.AutoGenerateColumns = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PersonnameDataGridViewTextBoxColumn, Me.PersoncodeDataGridViewTextBoxColumn, Me.StoresectioncodeDataGridViewTextBoxColumn})
        Me.dataGrid.DataSource = Me.CustomerBindingSource
        Me.dataGrid.Location = New System.Drawing.Point(59, 30)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 51
        Me.dataGrid.RowTemplate.Height = 24
        Me.dataGrid.Size = New System.Drawing.Size(679, 164)
        Me.dataGrid.TabIndex = 11
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Person ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'PersonnameDataGridViewTextBoxColumn
        '
        Me.PersonnameDataGridViewTextBoxColumn.DataPropertyName = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.HeaderText = "Person Name"
        Me.PersonnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PersonnameDataGridViewTextBoxColumn.Name = "PersonnameDataGridViewTextBoxColumn"
        Me.PersonnameDataGridViewTextBoxColumn.Width = 125
        '
        'PersoncodeDataGridViewTextBoxColumn
        '
        Me.PersoncodeDataGridViewTextBoxColumn.DataPropertyName = "person_code"
        Me.PersoncodeDataGridViewTextBoxColumn.HeaderText = "Person Code"
        Me.PersoncodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PersoncodeDataGridViewTextBoxColumn.Name = "PersoncodeDataGridViewTextBoxColumn"
        Me.PersoncodeDataGridViewTextBoxColumn.Width = 125
        '
        'StoresectioncodeDataGridViewTextBoxColumn
        '
        Me.StoresectioncodeDataGridViewTextBoxColumn.DataPropertyName = "store_section_code"
        Me.StoresectioncodeDataGridViewTextBoxColumn.HeaderText = "Store Section Code"
        Me.StoresectioncodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StoresectioncodeDataGridViewTextBoxColumn.Name = "StoresectioncodeDataGridViewTextBoxColumn"
        Me.StoresectioncodeDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet2
        '
        'CustomerDataSet2
        '
        Me.CustomerDataSet2.DataSetName = "customerDataSet2"
        Me.CustomerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk_Tel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me._Opt_Order_0)
        Me.GroupBox1.Controls.Add(Me._Opt_Order_1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 186)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dataGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 225)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(862, 25)
        Me.FillByToolStrip.TabIndex = 15
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(9, 18)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 31)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lblDownloadLink
        '
        Me.lblDownloadLink.AutoSize = True
        Me.lblDownloadLink.Location = New System.Drawing.Point(13, 452)
        Me.lblDownloadLink.Name = "lblDownloadLink"
        Me.lblDownloadLink.Size = New System.Drawing.Size(0, 17)
        Me.lblDownloadLink.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.Excel_Output)
        Me.GroupBox3.Location = New System.Drawing.Point(409, 428)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 64)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        '_351
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 496)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblDownloadLink)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "_351"
        Me.Text = "センターメ確状況照会(SMCF351I)"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Chk_Tel As CheckBox
    Friend WithEvents _Opt_Order_1 As RadioButton
    Friend WithEvents _Opt_Order_0 As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Excel_Output As Button
    Friend WithEvents CustomerDataSet As customerDataSet2
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerTableAdapter As MyFirstVBWindowApp.customerDataSet2TableAdapters.customerTableAdapter
    Friend WithEvents CustomerDataSet2 As customerDataSet2
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersoncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StoresectioncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lblDownloadLink As LinkLabel
    Friend WithEvents GroupBox3 As GroupBox
End Class
