<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alluserfrm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alluserfrm))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.N_AME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ACNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D_ATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.aDDRESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.aDHAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMINI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GENDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ACTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOTES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rEFF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.mobile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.recno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolTipController2 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1341, 193)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "View"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Update"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Delete"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Operation"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 714)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1341, 30)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Button1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(1333, 79)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "GroupControl1"
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = ""
        Me.TextEdit2.Location = New System.Drawing.Point(215, 19)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Size = New System.Drawing.Size(164, 24)
        Me.TextEdit2.TabIndex = 14
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(19, 20)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Size = New System.Drawing.Size(164, 24)
        Me.TextEdit1.TabIndex = 13
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "All"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(719, 28)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"All", "Saving", "Requiring Deposit", "SS Account", "Time deposit", "RPLI"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(117, 22)
        Me.ComboBoxEdit1.TabIndex = 12
        Me.ComboBoxEdit1.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton2.Location = New System.Drawing.Point(493, 11)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(48, 47)
        Me.SimpleButton2.TabIndex = 11
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Aqua
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(421, 10)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(48, 47)
        Me.SimpleButton1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(873, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print All"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSize = True
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1333, 430)
        Me.GroupControl2.TabIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(2, 28)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1329, 400)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.N_AME, Me.CIF, Me.ACNO, Me.FNAME, Me.D_ATE, Me.aDDRESS, Me.dob, Me.aDHAR, Me.PAN, Me.NOMINI, Me.GENDER, Me.ACTYPE, Me.NOTES, Me.AMOUNT, Me.rEFF_NO, Me.mobile, Me.recno})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        '
        'id
        '
        Me.id.AppearanceCell.BackColor = System.Drawing.Color.Blue
        Me.id.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.id.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.id.AppearanceCell.Options.UseBackColor = True
        Me.id.AppearanceCell.Options.UseBorderColor = True
        Me.id.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.id.AppearanceHeader.BackColor2 = System.Drawing.Color.Red
        Me.id.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.id.AppearanceHeader.Options.UseBackColor = True
        Me.id.AppearanceHeader.Options.UseBorderColor = True
        Me.id.Caption = "ID"
        Me.id.FieldName = "id"
        Me.id.Name = "id"
        Me.id.Visible = True
        Me.id.VisibleIndex = 0
        '
        'N_AME
        '
        Me.N_AME.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.N_AME.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.N_AME.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.N_AME.AppearanceCell.Options.UseBackColor = True
        Me.N_AME.AppearanceCell.Options.UseBorderColor = True
        Me.N_AME.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.N_AME.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.N_AME.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.N_AME.AppearanceHeader.Options.UseBackColor = True
        Me.N_AME.AppearanceHeader.Options.UseBorderColor = True
        Me.N_AME.Caption = "CustmorName"
        Me.N_AME.FieldName = "N_AME"
        Me.N_AME.Name = "N_AME"
        Me.N_AME.Visible = True
        Me.N_AME.VisibleIndex = 2
        '
        'CIF
        '
        Me.CIF.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.CIF.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.CIF.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.CIF.AppearanceCell.Options.UseBackColor = True
        Me.CIF.AppearanceCell.Options.UseBorderColor = True
        Me.CIF.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.CIF.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.CIF.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CIF.AppearanceHeader.Options.UseBackColor = True
        Me.CIF.AppearanceHeader.Options.UseBorderColor = True
        Me.CIF.Caption = "CIF"
        Me.CIF.FieldName = "CIF"
        Me.CIF.Name = "CIF"
        Me.CIF.Visible = True
        Me.CIF.VisibleIndex = 3
        '
        'ACNO
        '
        Me.ACNO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ACNO.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.ACNO.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.ACNO.AppearanceCell.Options.UseBackColor = True
        Me.ACNO.AppearanceCell.Options.UseBorderColor = True
        Me.ACNO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ACNO.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ACNO.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ACNO.AppearanceHeader.Options.UseBackColor = True
        Me.ACNO.AppearanceHeader.Options.UseBorderColor = True
        Me.ACNO.Caption = "AcNo"
        Me.ACNO.FieldName = "ACNO"
        Me.ACNO.Name = "ACNO"
        Me.ACNO.Visible = True
        Me.ACNO.VisibleIndex = 1
        '
        'FNAME
        '
        Me.FNAME.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FNAME.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.FNAME.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.FNAME.AppearanceCell.Options.UseBackColor = True
        Me.FNAME.AppearanceCell.Options.UseBorderColor = True
        Me.FNAME.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FNAME.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FNAME.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FNAME.AppearanceHeader.Options.UseBackColor = True
        Me.FNAME.AppearanceHeader.Options.UseBorderColor = True
        Me.FNAME.Caption = "GUARDIAN"
        Me.FNAME.FieldName = "FNAME"
        Me.FNAME.Name = "FNAME"
        Me.FNAME.Visible = True
        Me.FNAME.VisibleIndex = 5
        '
        'D_ATE
        '
        Me.D_ATE.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.D_ATE.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.D_ATE.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.D_ATE.AppearanceCell.Options.UseBackColor = True
        Me.D_ATE.AppearanceCell.Options.UseBorderColor = True
        Me.D_ATE.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.D_ATE.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.D_ATE.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_ATE.AppearanceHeader.Options.UseBackColor = True
        Me.D_ATE.AppearanceHeader.Options.UseBorderColor = True
        Me.D_ATE.Caption = "DATE"
        Me.D_ATE.FieldName = "D_ATE"
        Me.D_ATE.Name = "D_ATE"
        Me.D_ATE.Visible = True
        Me.D_ATE.VisibleIndex = 6
        '
        'aDDRESS
        '
        Me.aDDRESS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDDRESS.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.aDDRESS.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.aDDRESS.AppearanceCell.Options.UseBackColor = True
        Me.aDDRESS.AppearanceCell.Options.UseBorderColor = True
        Me.aDDRESS.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDDRESS.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aDDRESS.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.aDDRESS.AppearanceHeader.Options.UseBackColor = True
        Me.aDDRESS.AppearanceHeader.Options.UseBorderColor = True
        Me.aDDRESS.Caption = "Address"
        Me.aDDRESS.FieldName = "aDDRESS"
        Me.aDDRESS.Name = "aDDRESS"
        Me.aDDRESS.Visible = True
        Me.aDDRESS.VisibleIndex = 8
        '
        'dob
        '
        Me.dob.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dob.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.dob.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.dob.AppearanceCell.Options.UseBackColor = True
        Me.dob.AppearanceCell.Options.UseBorderColor = True
        Me.dob.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dob.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dob.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dob.AppearanceHeader.Options.UseBackColor = True
        Me.dob.AppearanceHeader.Options.UseBorderColor = True
        Me.dob.Caption = "DOB"
        Me.dob.FieldName = "dob"
        Me.dob.Name = "dob"
        Me.dob.Visible = True
        Me.dob.VisibleIndex = 13
        '
        'aDHAR
        '
        Me.aDHAR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDHAR.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.aDHAR.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.aDHAR.AppearanceCell.Options.UseBackColor = True
        Me.aDHAR.AppearanceCell.Options.UseBorderColor = True
        Me.aDHAR.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDHAR.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aDHAR.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.aDHAR.AppearanceHeader.Options.UseBackColor = True
        Me.aDHAR.AppearanceHeader.Options.UseBorderColor = True
        Me.aDHAR.Caption = "Adhar"
        Me.aDHAR.FieldName = "aDHAR"
        Me.aDHAR.Name = "aDHAR"
        Me.aDHAR.Visible = True
        Me.aDHAR.VisibleIndex = 9
        '
        'PAN
        '
        Me.PAN.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.PAN.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.PAN.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.PAN.AppearanceCell.Options.UseBackColor = True
        Me.PAN.AppearanceCell.Options.UseBorderColor = True
        Me.PAN.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.PAN.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.PAN.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PAN.AppearanceHeader.Options.UseBackColor = True
        Me.PAN.AppearanceHeader.Options.UseBorderColor = True
        Me.PAN.Caption = "PAN"
        Me.PAN.FieldName = "PAN"
        Me.PAN.Name = "PAN"
        Me.PAN.Visible = True
        Me.PAN.VisibleIndex = 10
        '
        'NOMINI
        '
        Me.NOMINI.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NOMINI.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.NOMINI.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.NOMINI.AppearanceCell.Options.UseBackColor = True
        Me.NOMINI.AppearanceCell.Options.UseBorderColor = True
        Me.NOMINI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NOMINI.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NOMINI.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NOMINI.AppearanceHeader.Options.UseBackColor = True
        Me.NOMINI.AppearanceHeader.Options.UseBorderColor = True
        Me.NOMINI.Caption = "NominiName"
        Me.NOMINI.FieldName = "NOMINI"
        Me.NOMINI.Name = "NOMINI"
        Me.NOMINI.Visible = True
        Me.NOMINI.VisibleIndex = 11
        '
        'GENDER
        '
        Me.GENDER.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GENDER.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.GENDER.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.GENDER.AppearanceCell.Options.UseBackColor = True
        Me.GENDER.AppearanceCell.Options.UseBorderColor = True
        Me.GENDER.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GENDER.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GENDER.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GENDER.AppearanceHeader.Options.UseBackColor = True
        Me.GENDER.AppearanceHeader.Options.UseBorderColor = True
        Me.GENDER.Caption = "Gender"
        Me.GENDER.FieldName = "GENDER"
        Me.GENDER.Name = "GENDER"
        Me.GENDER.Visible = True
        Me.GENDER.VisibleIndex = 4
        '
        'ACTYPE
        '
        Me.ACTYPE.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.ACTYPE.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.ACTYPE.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.ACTYPE.AppearanceCell.Options.UseBackColor = True
        Me.ACTYPE.AppearanceCell.Options.UseBorderColor = True
        Me.ACTYPE.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.ACTYPE.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.ACTYPE.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ACTYPE.AppearanceHeader.Options.UseBackColor = True
        Me.ACTYPE.AppearanceHeader.Options.UseBorderColor = True
        Me.ACTYPE.Caption = "AcType"
        Me.ACTYPE.FieldName = "ACTYPE"
        Me.ACTYPE.Name = "ACTYPE"
        Me.ACTYPE.Visible = True
        Me.ACTYPE.VisibleIndex = 7
        '
        'NOTES
        '
        Me.NOTES.AppearanceCell.BackColor = System.Drawing.Color.Aqua
        Me.NOTES.AppearanceCell.BackColor2 = System.Drawing.Color.Blue
        Me.NOTES.AppearanceCell.BorderColor = System.Drawing.Color.Fuchsia
        Me.NOTES.AppearanceCell.Options.UseBackColor = True
        Me.NOTES.AppearanceCell.Options.UseBorderColor = True
        Me.NOTES.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NOTES.AppearanceHeader.BackColor2 = System.Drawing.Color.Fuchsia
        Me.NOTES.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NOTES.AppearanceHeader.Options.UseBackColor = True
        Me.NOTES.AppearanceHeader.Options.UseBorderColor = True
        Me.NOTES.Caption = "Notes"
        Me.NOTES.FieldName = "NOTES"
        Me.NOTES.Name = "NOTES"
        Me.NOTES.Visible = True
        Me.NOTES.VisibleIndex = 17
        '
        'AMOUNT
        '
        Me.AMOUNT.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.AMOUNT.AppearanceCell.BackColor2 = System.Drawing.Color.Red
        Me.AMOUNT.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.AMOUNT.AppearanceCell.Options.UseBackColor = True
        Me.AMOUNT.AppearanceCell.Options.UseBorderColor = True
        Me.AMOUNT.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.AMOUNT.AppearanceHeader.BackColor2 = System.Drawing.Color.Red
        Me.AMOUNT.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AMOUNT.AppearanceHeader.Options.UseBackColor = True
        Me.AMOUNT.AppearanceHeader.Options.UseBorderColor = True
        Me.AMOUNT.Caption = "AcBal"
        Me.AMOUNT.FieldName = "AMOUNT"
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.Visible = True
        Me.AMOUNT.VisibleIndex = 16
        '
        'rEFF_NO
        '
        Me.rEFF_NO.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.rEFF_NO.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.rEFF_NO.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.rEFF_NO.AppearanceCell.Options.UseBackColor = True
        Me.rEFF_NO.AppearanceCell.Options.UseBorderColor = True
        Me.rEFF_NO.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.rEFF_NO.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.rEFF_NO.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rEFF_NO.AppearanceHeader.Options.UseBackColor = True
        Me.rEFF_NO.AppearanceHeader.Options.UseBorderColor = True
        Me.rEFF_NO.Caption = "Refference No"
        Me.rEFF_NO.FieldName = "rEFF_NO"
        Me.rEFF_NO.Name = "rEFF_NO"
        Me.rEFF_NO.Visible = True
        Me.rEFF_NO.VisibleIndex = 12
        '
        'mobile
        '
        Me.mobile.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mobile.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.mobile.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.mobile.AppearanceCell.Options.UseBackColor = True
        Me.mobile.AppearanceCell.Options.UseBorderColor = True
        Me.mobile.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mobile.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mobile.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mobile.AppearanceHeader.Options.UseBackColor = True
        Me.mobile.AppearanceHeader.Options.UseBorderColor = True
        Me.mobile.Caption = "MobileNo"
        Me.mobile.FieldName = "mobile"
        Me.mobile.Name = "mobile"
        Me.mobile.Visible = True
        Me.mobile.VisibleIndex = 15
        '
        'recno
        '
        Me.recno.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.recno.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.recno.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.recno.AppearanceCell.Options.UseBackColor = True
        Me.recno.AppearanceCell.Options.UseBorderColor = True
        Me.recno.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.recno.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.recno.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.recno.AppearanceHeader.Options.UseBackColor = True
        Me.recno.AppearanceHeader.Options.UseBorderColor = True
        Me.recno.Caption = "PR No"
        Me.recno.FieldName = "recno"
        Me.recno.Name = "recno"
        Me.recno.Visible = True
        Me.recno.VisibleIndex = 14
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 193)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1341, 521)
        Me.PanelControl1.TabIndex = 6
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(2, 85)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1337, 434)
        Me.PanelControl3.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1337, 83)
        Me.PanelControl2.TabIndex = 0
        '
        'Alluserfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 744)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Alluserfrm"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Alluserfrm"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents N_AME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ACNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_ATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents aDDRESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents aDHAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMINI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ACTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rEFF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mobile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents recno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTipController2 As DevExpress.Utils.ToolTipController
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
