<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Metro.MetroAppForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PagePanel = New DevComponents.DotNetBar.PanelEx
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.cmdPage1 = New DevComponents.DotNetBar.Command(Me.components)
        Me.cmdPage2 = New DevComponents.DotNetBar.Command(Me.components)
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.cmdPage3 = New DevComponents.DotNetBar.Command(Me.components)
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel
        Me.CalendarView1 = New DevComponents.DotNetBar.Schedule.CalendarView
        Me.MetroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel
        Me.MetroAppButton1 = New DevComponents.DotNetBar.Metro.MetroAppButton
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem
        Me.MetroTabItem2 = New DevComponents.DotNetBar.Metro.MetroTabItem
        Me.biExit = New DevComponents.DotNetBar.ButtonItem
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PagePanel.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroShell1.SuspendLayout()
        Me.MetroTabPanel1.SuspendLayout()
        Me.MetroTabPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PagePanel
        '
        Me.PagePanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.PagePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PagePanel.Controls.Add(Me.DataGridViewX1)
        Me.PagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagePanel.Location = New System.Drawing.Point(3, 0)
        Me.PagePanel.Name = "PagePanel"
        Me.PagePanel.Size = New System.Drawing.Size(754, 479)
        Me.PagePanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PagePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PagePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PagePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PagePanel.Style.GradientAngle = 90
        Me.PagePanel.TabIndex = 0
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(497, 235)
        Me.DataGridViewX1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Command = Me.cmdPage1
        Me.ButtonX1.Location = New System.Drawing.Point(12, 540)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Menu 1"
        '
        'cmdPage1
        '
        Me.cmdPage1.Name = "cmdPage1"
        '
        'cmdPage2
        '
        Me.cmdPage2.Name = "cmdPage2"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Command = Me.cmdPage2
        Me.ButtonX2.Location = New System.Drawing.Point(93, 540)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "Menu 2"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Command = Me.cmdPage3
        Me.ButtonX3.Location = New System.Drawing.Point(174, 541)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 1
        Me.ButtonX3.Text = "Menu 3"
        '
        'cmdPage3
        '
        Me.cmdPage3.Name = "cmdPage3"
        '
        'MetroShell1
        '
        Me.MetroShell1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroShell1.BackgroundStyle.Class = ""
        Me.MetroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroShell1.CaptionVisible = True
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel2)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel1)
        Me.MetroShell1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroShell1.ForeColor = System.Drawing.Color.Black
        Me.MetroShell1.HelpButtonText = Nothing
        Me.MetroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroAppButton1, Me.MetroTabItem1, Me.MetroTabItem2})
        Me.MetroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MetroShell1.Location = New System.Drawing.Point(1, 1)
        Me.MetroShell1.Name = "MetroShell1"
        Me.MetroShell1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biExit})
        Me.MetroShell1.Size = New System.Drawing.Size(760, 533)
        Me.MetroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.MetroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.MetroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.MetroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.MetroShell1.SystemText.QatDialogAddButton = "&Add >>"
        Me.MetroShell1.SystemText.QatDialogCancelButton = "Cancel"
        Me.MetroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.MetroShell1.SystemText.QatDialogOkButton = "OK"
        Me.MetroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.MetroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.MetroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.MetroShell1.TabIndex = 3
        Me.MetroShell1.TabStripFont = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroShell1.Text = "MetroShell1"
        '
        'MetroTabPanel1
        '
        Me.MetroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel1.Controls.Add(Me.CalendarView1)
        Me.MetroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel1.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel1.Name = "MetroTabPanel1"
        Me.MetroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel1.Size = New System.Drawing.Size(760, 482)
        '
        '
        '
        Me.MetroTabPanel1.Style.Class = ""
        Me.MetroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseDown.Class = ""
        Me.MetroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseOver.Class = ""
        Me.MetroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel1.TabIndex = 1
        Me.MetroTabPanel1.Visible = False
        '
        'CalendarView1
        '
        Me.CalendarView1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.CalendarView1.BackgroundStyle.Class = ""
        Me.CalendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CalendarView1.ContainerControlProcessDialogKey = True
        Me.CalendarView1.ForeColor = System.Drawing.Color.Black
        Me.CalendarView1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.CalendarView1.Location = New System.Drawing.Point(3, 0)
        Me.CalendarView1.Name = "CalendarView1"
        Me.CalendarView1.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month
        Me.CalendarView1.Size = New System.Drawing.Size(404, 295)
        Me.CalendarView1.TabIndex = 0
        Me.CalendarView1.Text = "CalendarView1"
        Me.CalendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty
        Me.CalendarView1.TimeIndicator.Tag = Nothing
        Me.CalendarView1.TimeSlotDuration = 30
        '
        'MetroTabPanel2
        '
        Me.MetroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel2.Controls.Add(Me.PagePanel)
        Me.MetroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel2.Location = New System.Drawing.Point(0, 51)
        Me.MetroTabPanel2.Name = "MetroTabPanel2"
        Me.MetroTabPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel2.Size = New System.Drawing.Size(760, 482)
        '
        '
        '
        Me.MetroTabPanel2.Style.Class = ""
        Me.MetroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseDown.Class = ""
        Me.MetroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseOver.Class = ""
        Me.MetroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel2.TabIndex = 2
        '
        'MetroAppButton1
        '
        Me.MetroAppButton1.AutoExpandOnClick = True
        Me.MetroAppButton1.CanCustomize = False
        Me.MetroAppButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.MetroAppButton1.ImagePaddingHorizontal = 0
        Me.MetroAppButton1.ImagePaddingVertical = 0
        Me.MetroAppButton1.Name = "MetroAppButton1"
        Me.MetroAppButton1.ShowSubItems = False
        Me.MetroAppButton1.Text = "&File"
        '
        'MetroTabItem1
        '
        Me.MetroTabItem1.Name = "MetroTabItem1"
        Me.MetroTabItem1.Panel = Me.MetroTabPanel1
        Me.MetroTabItem1.Text = "&HOME"
        '
        'MetroTabItem2
        '
        Me.MetroTabItem2.Checked = True
        Me.MetroTabItem2.Name = "MetroTabItem2"
        Me.MetroTabItem2.Panel = Me.MetroTabPanel2
        Me.MetroTabItem2.Text = "&VIEW"
        '
        'biExit
        '
        Me.biExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biExit.Name = "biExit"
        Me.biExit.Text = "Exit"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 575)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.MetroShell1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MetroForm"
        Me.PagePanel.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        Me.MetroTabPanel1.ResumeLayout(False)
        Me.MetroTabPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PagePanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdPage1 As DevComponents.DotNetBar.Command
    Friend WithEvents cmdPage2 As DevComponents.DotNetBar.Command
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdPage3 As DevComponents.DotNetBar.Command
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroAppButton1 As DevComponents.DotNetBar.Metro.MetroAppButton
    Friend WithEvents MetroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents MetroTabItem2 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents biExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarView1 As DevComponents.DotNetBar.Schedule.CalendarView
End Class
