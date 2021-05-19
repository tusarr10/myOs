<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.MenuBar = New DevExpress.XtraBars.BarSubItem()
        Me.SettingMenuBar = New DevExpress.XtraBars.BarButtonItem()
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.bar3 = New DevExpress.XtraBars.Bar()
        Me.barBtnStart = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BtnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barBtnStart, Me.BtnExit, Me.MenuBar, Me.SettingMenuBar})
        Me.barManager1.MainMenu = Me.bar2
        Me.barManager1.MaxItemId = 4
        Me.barManager1.StatusBar = Me.bar3
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 1
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBar)})
        Me.bar1.Text = "Tools"
        '
        'MenuBar
        '
        Me.MenuBar.Caption = "Menu"
        Me.MenuBar.Hint = "Get Control"
        Me.MenuBar.Id = 2
        Me.MenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SettingMenuBar)})
        Me.MenuBar.Name = "MenuBar"
        '
        'SettingMenuBar
        '
        Me.SettingMenuBar.Caption = "Setting"
        Me.SettingMenuBar.Id = 3
        Me.SettingMenuBar.Name = "SettingMenuBar"
        '
        'bar2
        '
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.OptionsBar.MultiLine = True
        Me.bar2.OptionsBar.UseWholeRow = True
        Me.bar2.Text = "Main menu"
        '
        'bar3
        '
        Me.bar3.BarName = "Status bar"
        Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3.DockCol = 0
        Me.bar3.DockRow = 0
        Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barBtnStart)})
        Me.bar3.OptionsBar.AllowQuickCustomization = False
        Me.bar3.OptionsBar.DrawDragBorder = False
        Me.bar3.OptionsBar.UseWholeRow = True
        Me.bar3.Text = "Status bar"
        '
        'barBtnStart
        '
        Me.barBtnStart.ActAsDropDown = True
        Me.barBtnStart.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.barBtnStart.Caption = "Start"
        Me.barBtnStart.DropDownControl = Me.PopupMenu1
        Me.barBtnStart.Hint = "Start"
        Me.barBtnStart.Id = 0
        Me.barBtnStart.ImageOptions.Image = CType(resources.GetObject("barBtnStart.ImageOptions.Image"), System.Drawing.Image)
        Me.barBtnStart.ImageOptions.LargeImage = CType(resources.GetObject("barBtnStart.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barBtnStart.Name = "barBtnStart"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnExit)})
        Me.PopupMenu1.Manager = Me.barManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BtnExit
        '
        Me.BtnExit.Caption = "Exit"
        Me.BtnExit.Id = 1
        Me.BtnExit.Name = "BtnExit"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1160, 46)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 617)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1160, 32)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 571)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1160, 46)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 571)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 649)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend barManager1 As DevExpress.XtraBars.BarManager
    Friend bar1 As DevExpress.XtraBars.Bar
    Friend bar2 As DevExpress.XtraBars.Bar
    Friend bar3 As DevExpress.XtraBars.Bar
    Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barBtnStart As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BtnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuBar As DevExpress.XtraBars.BarSubItem
    Friend WithEvents SettingMenuBar As DevExpress.XtraBars.BarButtonItem
End Class
