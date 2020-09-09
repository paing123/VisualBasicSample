Imports System.Data.SqlClient
Imports System.Linq
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml


Public Class _351
    Private outputFilePath As String
    Dim dbConnect As New DBConnection

    Private Sub _351_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.CustomerDataSet2.customer)
        'TODO: This line of code loads data into the 'CustomerDataSet.customer' table. You can move, or remove it, as needed.
        Call PF_I_ShowGrid()
        _Opt_Order_1.Checked = True
    End Sub

    Private Sub OrderByPersonCodeToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomerTableAdapter.Fill(Me.CustomerDataSet2.customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PF_I_ShowGrid()
        Dim sql As String
        If _Opt_Order_1.Checked Then
            sql = "SELECT * FROM customer ORDER BY person_code"
        ElseIf _Opt_Order_0.Checked Then
            sql = "SELECT * FROM customer ORDER BY store_section_code"
        End If
        dbConnect.connect(sql, dataGrid)
    End Sub

    Private Sub _Opt_Order_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Order_1.CheckedChanged
        PF_I_ShowGrid()
        'dataGrid.DataSource = Me.CustomerTableAdapter.GetOrderByPersonCode()
    End Sub

    Private Sub _Opt_Order_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Order_0.CheckedChanged
        PF_I_ShowGrid()
        'dataGrid.DataSource = Me.CustomerTableAdapter.GetOrderByStoreSelection()
    End Sub

    Private Sub Excel_Output_Click(sender As Object, e As EventArgs) Handles Excel_Output.Click
        Try
            Excel_Output.Text = "Please wait..."
            Excel_Output.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            SaveFileDialog1.InitialDirectory = "C:\"
            If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For k As Integer = 1 To dataGrid.Columns.Count
                    xlWorkSheet.Cells(1, k) = dataGrid.Columns(k - 1).HeaderText
                Next

                For i = 0 To dataGrid.Rows.Count - 2 '0 - 2
                    For j = 0 To dataGrid.Columns.Count - 1 '0 - 1
                        xlWorkSheet.Cells(i + 2, j + 1) = dataGrid(j, i).Value.ToString
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                outputFilePath = xlWorkBook.Path
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
                Excel_Output.Text = "Export Output"
                Excel_Output.Enabled = True
                MsgBox("Sucessfully saved" & vbCrLf & "File are saved at :" & SaveFileDialog1.FileName,
                MsgBoxStyle.Information, "Information")
                lblDownloadLink.Text = SaveFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show("Fail to save file!")
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Return
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        'PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dataGrid.Width, Me.dataGrid.Height)
        dataGrid.DrawToBitmap(bm, New Rectangle(0, 0, Me.dataGrid.Width, Me.dataGrid.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me._351_Load(sender, e)
        'dataGrid.DataSource = Me.CustomerTableAdapter.GetData()
    End Sub

    Private Sub Chk_Tel_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Tel.CheckedChanged
        Call PF_I_ShowGrid()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblDownloadLink.LinkClicked
        Process.Start(outputFilePath)
    End Sub

End Class