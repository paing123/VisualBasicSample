Public Class FourthForm

    Dim m_swSetOrder_int As Integer
    Dim m_swSetWayMk_int As Integer
    Private outputFilePath As String
    Private dbConnect As New DBConnection

    Private Sub _Opt_Order_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Order_0.CheckedChanged
        m_swSetOrder_int = 0
    End Sub

    Private Sub _Opt_Order_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Order_1.CheckedChanged
        m_swSetOrder_int = 1
    End Sub

    Private Sub _OPT_SEL_0_CheckedChanged(sender As Object, e As EventArgs) Handles _OPT_SEL_0.CheckedChanged
        m_swSetWayMk_int = 0
    End Sub

    Private Sub _OPT_SEL_1_CheckedChanged(sender As Object, e As EventArgs) Handles _OPT_SEL_1.CheckedChanged
        m_swSetWayMk_int = 1
    End Sub

    Private Sub _OPT_SEL_2_CheckedChanged(sender As Object, e As EventArgs) Handles _OPT_SEL_2.CheckedChanged
        m_swSetWayMk_int = 2
    End Sub

    Private Sub _Opt_Ctrl_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Ctrl_0.CheckedChanged
        Frm_Tenka.Visible = True
    End Sub

    Private Sub _Opt_Ctrl_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Ctrl_1.CheckedChanged
        Frm_Tenka.Visible = False
    End Sub

    Private Sub Mnu_Exit_Click()
        'フォームのアンロード
        Me.Close()
    End Sub

    Private Sub Cmd_Print_Click()
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub



    Private Sub FourthForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F1 'F1
                '終了 'end
                Call Mnu_Exit_Click()
            Case System.Windows.Forms.Keys.F10 'F10
                Call Cmd_Print_Click() '印刷処理
            Case System.Windows.Forms.Keys.F7 'F7 
                Call Excel_Click()
        End Select
    End Sub

    Private Sub Excel_Click()
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
                Dim dispRowCnt As Integer = DataGrid.DisplayedRowCount(True)
                For i = 0 To DataGrid.DisplayedRowCount(True) - 2 '0 - 2
                    For j = 0 To DataGrid.DisplayedRowCount(True) - 1 '0 - 1
                        For k As Integer = 1 To DataGrid.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGrid.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGrid(j, i).Value.ToString
                        Next
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

    Private Sub Excel_Output_Click(sender As Object, e As EventArgs) Handles Excel_Output.Click
        Call Me.Excel_Click()
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


    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        Cmd_Print_Click()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Mnu_Exit_Click()
    End Sub

    Private Sub _Opt_Ctrl_1_Leave(sender As Object, e As EventArgs) Handles _Opt_Ctrl_1.Leave
        _Opt_Ctrl_1.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 0, 0))
    End Sub

    Private Sub _Opt_Ctrl_0_Leave(sender As Object, e As EventArgs) Handles _Opt_Ctrl_0.Leave
        _Opt_Ctrl_0.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(102, 204, 0))
    End Sub

    Private Sub FourthForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._Opt_Ctrl_0.Checked = True
        Me._OPT_SEL_0.Checked = True
        Dim sql As String = "Select sure_day,total_confirmed_cases, confirmed_centers,
                             confirmed_cases, confirmed_branches, unestablished_branches,status
                             from output_confirmation_ledger"
        dbConnect.connect2(sql, DataGrid)
    End Sub

    Private Sub _Opt_0_Enter(sender As Object, e As EventArgs) Handles _Opt_0.Enter
        _Opt_0.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(102, 204, 0))
    End Sub

    Private Sub _Opt_1_Enter(sender As Object, e As EventArgs) Handles _Opt_1.Enter
        _Opt_1.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(102, 204, 0))
    End Sub

    Private Sub _Opt_2_Enter(sender As Object, e As EventArgs) Handles _Opt_2.Enter
        _Opt_2.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 255, 255))
    End Sub

    Private Sub _Opt_3_Enter(sender As Object, e As EventArgs) Handles _Opt_3.Enter
        _Opt_3.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 0, 255))
    End Sub

    Private Sub _Opt_0_KeyDown(sender As Object, e As KeyEventArgs) Handles _Opt_0.KeyDown
        Me.Opt_KeyDown(e)
    End Sub

    Private Sub _Opt_1_KeyDown(sender As Object, e As KeyEventArgs) Handles _Opt_1.KeyDown
        Me.Opt_KeyDown(e)
    End Sub

    Private Sub _Opt_2_KeyDown(sender As Object, e As KeyEventArgs) Handles _Opt_2.KeyDown
        Me.Opt_KeyDown(e)
    End Sub

    Private Sub _Opt_3_KeyDown(sender As Object, e As KeyEventArgs) Handles _Opt_3.KeyDown
        Me.Opt_KeyDown(e)
    End Sub

    Private Sub Opt_KeyDown(ByVal keyEventArgs As KeyEventArgs)
        Dim KeyCode As Short = keyEventArgs.KeyCode
        Select Case KeyCode
            Case System.Windows.Forms.Keys.Return
                If _Opt_0.Checked Or _Opt_2.Checked Then
                    _Opt_Ctrl_0.Focus()
                End If

                If _Opt_1.Checked Or _Opt_3.Checked Then
                    _Opt_Ctrl_1.Focus()
                End If
        End Select
    End Sub

    Private Sub _Txt_inpTenkaCd_0_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_0.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_0.Text, _Lbl_TenkaMei_0.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_1_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_1.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_1.Text, _Lbl_TenkaMei_1.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_2_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_2.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_2.Text, _Lbl_TenkaMei_2.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_3_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_3.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_3.Text, _Lbl_TenkaMei_3.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_4_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_4.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_4.Text, _Lbl_TenkaMei_4.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_5_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_5.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_5.Text, _Lbl_TenkaMei_5.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_6_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_6.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_6.Text, _Lbl_TenkaMei_6.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_7_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_7.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_7.Text, _Lbl_TenkaMei_7.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_8_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_8.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_8.Text, _Lbl_TenkaMei_8.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_9_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_9.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_9.Text, _Lbl_TenkaMei_9.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_10_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_10.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_10.Text, _Lbl_TenkaMei_10.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_11_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_11.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_11.Text, _Lbl_TenkaMei_11.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_12_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_12.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_12.Text, _Lbl_TenkaMei_12.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_13_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_13.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_13.Text, _Lbl_TenkaMei_13.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_14_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_14.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_14.Text, _Lbl_TenkaMei_14.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_15_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_15.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_15.Text, _Lbl_TenkaMei_15.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_16_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_16.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_16.Text, _Lbl_TenkaMei_16.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_17_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_17.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_17.Text, _Lbl_TenkaMei_17.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_18_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_18.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_18.Text, _Lbl_TenkaMei_18.Text)
        End If
    End Sub

    Private Sub _Txt_inpTenkaCd_19_KeyDown(sender As Object, e As KeyEventArgs) Handles _Txt_inpTenkaCd_19.KeyDown
        If e.KeyCode = Keys.Enter Then
            dbConnect.checkStoreSectionCode(_Txt_inpTenkaCd_19.Text, _Lbl_TenkaMei_19.Text)
        End If
    End Sub

    Private Sub _Opt_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_0.CheckedChanged
        Me.DataGrid.Rows(0).Selected = True
        Me.DataGrid.Rows(1).Selected = False
        Me.DataGrid.Rows(2).Selected = False
        Me.DataGrid.Rows(3).Selected = False

    End Sub

    Private Sub _Opt_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_1.CheckedChanged
        Me.DataGrid.Rows(0).Selected = False
        Me.DataGrid.Rows(1).Selected = True
        Me.DataGrid.Rows(2).Selected = False
        Me.DataGrid.Rows(3).Selected = False
    End Sub

    Private Sub _Opt_2_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_2.CheckedChanged
        Me.DataGrid.Rows(0).Selected = False
        Me.DataGrid.Rows(1).Selected = False
        Me.DataGrid.Rows(2).Selected = True
        Me.DataGrid.Rows(3).Selected = False
    End Sub

    Private Sub _Opt_3_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_3.CheckedChanged
        Me.DataGrid.Rows(0).Selected = False
        Me.DataGrid.Rows(1).Selected = False
        Me.DataGrid.Rows(2).Selected = False
        Me.DataGrid.Rows(3).Selected = True
    End Sub
End Class