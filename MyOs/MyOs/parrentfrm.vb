
Imports DevExpress.Compatibility.System.Windows
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

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

    Private Sub parrentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        '  mainform.MdiParent = Me
        mainform.WindowState = FormWindowState.Maximized
        mainform.Show()
        mainform.BringToFront()


    End Sub


End Class
