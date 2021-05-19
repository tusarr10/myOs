Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub BtnExit_click(sender As Object, e As EventArgs) Handles BtnExit.ItemClick
        Application.Exit()

    End Sub

    Private Sub SettingMenuBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SettingMenuBar.ItemClick


    End Sub

    Private Sub barBtnStart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnStart.ItemClick

    End Sub
End Class