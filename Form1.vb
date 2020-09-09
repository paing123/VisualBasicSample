Public Class frmCrystalReportView
    Private Sub frmCrystalReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.PrintDocument1.Print()
    End Sub
End Class