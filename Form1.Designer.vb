<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrystalReportView
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
        Me.frmCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New MyFirstVBWindowApp.CrystalReport1()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'frmCrystalReportViewer
        '
        Me.frmCrystalReportViewer.ActiveViewIndex = 0
        Me.frmCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frmCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.frmCrystalReportViewer.Name = "frmCrystalReportViewer"
        Me.frmCrystalReportViewer.ReportSource = Me.CrystalReport11
        Me.frmCrystalReportViewer.Size = New System.Drawing.Size(1151, 478)
        Me.frmCrystalReportViewer.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(646, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmCrystalReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 478)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.frmCrystalReportViewer)
        Me.Name = "frmCrystalReportView"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frmCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As CrystalReport1
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
