<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SecondForm
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet2 = New MyFirstVBWindowApp.customerDataSet2()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Excel_Output = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblDownloadLink = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerTableAdapter = New MyFirstVBWindowApp.customerDataSet2TableAdapters.customerTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersoncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoresectioncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(625, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "支店メ確状況照会"
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
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(747, 69)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 323)
        Me.VScrollBar1.TabIndex = 5
        '
        'Excel_Output
        '
        Me.Excel_Output.Location = New System.Drawing.Point(642, 407)
        Me.Excel_Output.Name = "Excel_Output"
        Me.Excel_Output.Size = New System.Drawing.Size(103, 31)
        Me.Excel_Output.TabIndex = 12
        Me.Excel_Output.Text = "f7=EXCEL出力"
        Me.Excel_Output.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(448, 407)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 31)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "f5=戻る"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblDownloadLink
        '
        Me.lblDownloadLink.AutoSize = True
        Me.lblDownloadLink.Location = New System.Drawing.Point(13, 421)
        Me.lblDownloadLink.Name = "lblDownloadLink"
        Me.lblDownloadLink.Size = New System.Drawing.Size(0, 17)
        Me.lblDownloadLink.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(195, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 63)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PersonnameDataGridViewTextBoxColumn, Me.PersoncodeDataGridViewTextBoxColumn, Me.StoresectioncodeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(40, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(677, 310)
        Me.DataGridView1.TabIndex = 4
        '
        'CustomerDataSet2BindingSource
        '
        Me.CustomerDataSet2BindingSource.DataSource = Me.CustomerDataSet2
        Me.CustomerDataSet2BindingSource.Position = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'PersonnameDataGridViewTextBoxColumn
        '
        Me.PersonnameDataGridViewTextBoxColumn.DataPropertyName = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.HeaderText = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PersonnameDataGridViewTextBoxColumn.Name = "PersonnameDataGridViewTextBoxColumn"
        Me.PersonnameDataGridViewTextBoxColumn.Width = 125
        '
        'PersoncodeDataGridViewTextBoxColumn
        '
        Me.PersoncodeDataGridViewTextBoxColumn.DataPropertyName = "person_code"
        Me.PersoncodeDataGridViewTextBoxColumn.HeaderText = "person_code"
        Me.PersoncodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PersoncodeDataGridViewTextBoxColumn.Name = "PersoncodeDataGridViewTextBoxColumn"
        Me.PersoncodeDataGridViewTextBoxColumn.Width = 125
        '
        'StoresectioncodeDataGridViewTextBoxColumn
        '
        Me.StoresectioncodeDataGridViewTextBoxColumn.DataPropertyName = "store_section_code"
        Me.StoresectioncodeDataGridViewTextBoxColumn.HeaderText = "store_section_code"
        Me.StoresectioncodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StoresectioncodeDataGridViewTextBoxColumn.Name = "StoresectioncodeDataGridViewTextBoxColumn"
        Me.StoresectioncodeDataGridViewTextBoxColumn.Width = 125
        '
        'SecondForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDownloadLink)
        Me.Controls.Add(Me.Excel_Output)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "SecondForm"
        Me.Text = "支店メ確状況照会(SMCF352I)"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Excel_Output As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblDownloadLink As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CustomerDataSet2 As customerDataSet2
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As customerDataSet2TableAdapters.customerTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerDataSet2BindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersoncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StoresectioncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
