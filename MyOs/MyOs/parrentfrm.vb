Imports System.Windows.Forms

Public Class parrentfrm

    Private m_ChildFormNumber As Integer

    Private Sub barBtnStart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnStart.ItemClick

    End Sub

    Private Sub BtnExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExit.ItemClick
        Application.Exit()

    End Sub

    Private Sub SettingMenuBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SettingMenuBar.ItemClick
        Settingsetup.MdiParent = Me
        Settingsetup.Show()
    End Sub
End Class
