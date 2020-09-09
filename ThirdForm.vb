Public Class ThirdForm
    Private Sub _Chk_SEL_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Chk_SEL_0.CheckedChanged
        checkSelect()
    End Sub

    Private Sub checkSelect()
        If _Chk_SEL_0.Checked = True Then
            _Opt_Ctrl_1.Enabled = True
        Else
            If _Opt_Ctrl_1.Checked = True Then
                _Opt_Ctrl_3.Checked = True
            End If
            _Opt_Ctrl_1.Enabled = False
        End If
    End Sub

    Private Sub _Chk_SEL_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Chk_SEL_1.CheckedChanged
        checkSelect()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim frmTitle As String = Me.Text
        'メ確方法選択チェックボックス
        If _Chk_SEL_0.CheckState = False And _Chk_SEL_1.CheckState = False And _Chk_SEL_2.CheckState = False And _Chk_SEL_3.CheckState = False And _Chk_SEL_4.CheckState = False And _Chk_SEL_5.CheckState = False And _Chk_SEL_6.CheckState = False And _Chk_SEL_7.CheckState = False Then
            MsgBox("メ確方法を選択して下さい", MsgBoxStyle.OkOnly, frmTitle)
            _Chk_SEL_0.Checked = True
            Return
        End If

        If _Opt_Taishou_4.Checked Then
            If Trim(Txt_inpKigyoCd.Text) = "" Then
                MsgBox("出力対象選択・指定なしの場合は対象企業は入力必須です", MsgBoxStyle.OkOnly, frmTitle)
                Txt_inpKigyoCd.Focus()
                Exit Sub
            End If
            Return
        End If
        Me.Refresh()
    End Sub

    Private Sub _Opt_Ctrl_0_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Ctrl_0.CheckedChanged
        If _Opt_Ctrl_0.Checked Then
            Frm_Tantou.Visible = False
            Frm_Tenka.Visible = True
            Frm_Eigyoubu.Visible = False
        End If
    End Sub

    Private Sub _Opt_Ctrl_1_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Ctrl_1.CheckedChanged
        If _Opt_Ctrl_1.Checked Then
            Frm_Tantou.Visible = True
            Frm_Tenka.Visible = False
            Frm_Eigyoubu.Visible = False
        End If
    End Sub

    Private Sub _Opt_Ctrl_3_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Ctrl_3.CheckedChanged
        If _Opt_Ctrl_3.Checked Then
            Frm_Tantou.Visible = False
            Frm_Tenka.Visible = False
            Frm_Eigyoubu.Visible = True
        End If
    End Sub

    Private Sub _Opt_Ctrl_2_CheckedChanged(sender As Object, e As EventArgs) Handles _Opt_Ctrl_2.CheckedChanged
        If _Opt_Ctrl_2.Checked Then
            Frm_Tantou.Visible = False
            Frm_Tenka.Visible = False
            Frm_Eigyoubu.Visible = False
        End If
    End Sub

    Private Sub ThirdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._Opt_Ctrl_0.Checked = True
        Me._Opt_Ctrl_0_CheckedChanged(sender, e)
    End Sub
End Class