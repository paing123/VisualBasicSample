Public Class SecondForm

    Private dbConnect As New DBConnection
    Private outputFilePath As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub SecondForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet2.customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.CustomerDataSet2.customer)
        'Me.CenterToScreen()
        Me.PF_I_ShowGrid()
    End Sub

    Private Sub PF_I_ShowGrid()
        Dim sql As String = "Select * from customer"
        dbConnect.connect(sql, DataGridView1)
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

                Dim varData(0, 0) As Object
                ReDim varData(DataGridView1.Rows.Count - 1, 4)

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                Next

                For i = 0 To DataGridView1.Rows.Count - 2 '0 - 2
                    For j = 0 To DataGridView1.Columns.Count - 1 '0 - 1
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
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

    Private Sub lblDownloadLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblDownloadLink.LinkClicked
        Process.Start(outputFilePath)
    End Sub
End Class