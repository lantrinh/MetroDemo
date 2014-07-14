<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu1
    Inherits DevComponents.DotNetBar.Controls.SlidePanel 'System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu1))
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.mti1 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.mti2 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.mti3 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.MetroTileItem8 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.MetroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.MetroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.MetroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.MetroTileItem9 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.MetroTileItem7 = New DevComponents.DotNetBar.Metro.MetroTileItem
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.SuspendLayout()
        '
        'ItemPanel1
        '
        Me.ItemPanel1.AutoScroll = True
        Me.ItemPanel1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ItemPanel1.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel1.ContainerControlProcessDialogKey = True
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.ItemPanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ItemPanel1.Location = New System.Drawing.Point(3, 73)
        Me.ItemPanel1.MultiLine = True
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(572, 305)
        Me.ItemPanel1.TabIndex = 0
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = ""
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.ItemSpacing = 6
        Me.ItemContainer1.MinimumSize = New System.Drawing.Size(560, 290)
        Me.ItemContainer1.MultiLine = True
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.ResizeItemsToFit = False
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mti1, Me.mti2, Me.mti3, Me.MetroTileItem8, Me.MetroTileItem6, Me.MetroTileItem5, Me.MetroTileItem4, Me.MetroTileItem9, Me.MetroTileItem7})
        '
        'mti1
        '
        Me.mti1.Image = CType(resources.GetObject("mti1.Image"), System.Drawing.Image)
        Me.mti1.Name = "mti1"
        Me.mti1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
        '
        '
        '
        Me.mti1.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mti1.TileStyle.BackColor2 = System.Drawing.SystemColors.ButtonFace
        Me.mti1.TileStyle.BackColorGradientAngle = 45
        Me.mti1.TileStyle.Class = ""
        Me.mti1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mti1.TileStyle.PaddingBottom = 4
        Me.mti1.TileStyle.PaddingLeft = 4
        Me.mti1.TileStyle.PaddingRight = 4
        Me.mti1.TileStyle.PaddingTop = 4
        Me.mti1.TileStyle.TextColor = System.Drawing.Color.White
        '
        'mti2
        '
        Me.mti2.Image = CType(resources.GetObject("mti2.Image"), System.Drawing.Image)
        Me.mti2.Name = "mti2"
        Me.mti2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal
        '
        '
        '
        Me.mti2.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.mti2.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.mti2.TileStyle.BackColorGradientAngle = 45
        Me.mti2.TileStyle.Class = ""
        Me.mti2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mti2.TileStyle.PaddingBottom = 4
        Me.mti2.TileStyle.PaddingLeft = 4
        Me.mti2.TileStyle.PaddingRight = 4
        Me.mti2.TileStyle.PaddingTop = 4
        Me.mti2.TileStyle.TextColor = System.Drawing.Color.White
        '
        'mti3
        '
        Me.mti3.Image = CType(resources.GetObject("mti3.Image"), System.Drawing.Image)
        Me.mti3.Name = "mti3"
        Me.mti3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee
        '
        '
        '
        Me.mti3.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.mti3.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.mti3.TileStyle.BackColorGradientAngle = 45
        Me.mti3.TileStyle.Class = ""
        Me.mti3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mti3.TileStyle.PaddingBottom = 4
        Me.mti3.TileStyle.PaddingLeft = 4
        Me.mti3.TileStyle.PaddingRight = 4
        Me.mti3.TileStyle.PaddingTop = 4
        Me.mti3.TileStyle.TextColor = System.Drawing.Color.White
        '
        'MetroTileItem8
        '
        Me.MetroTileItem8.Name = "MetroTileItem8"
        Me.MetroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue
        '
        '
        '
        Me.MetroTileItem8.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroTileItem8.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MetroTileItem8.TileStyle.BackColorGradientAngle = 45
        Me.MetroTileItem8.TileStyle.Class = ""
        Me.MetroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem8.TileStyle.PaddingBottom = 4
        Me.MetroTileItem8.TileStyle.PaddingLeft = 4
        Me.MetroTileItem8.TileStyle.PaddingRight = 4
        Me.MetroTileItem8.TileStyle.PaddingTop = 4
        Me.MetroTileItem8.TileStyle.TextColor = System.Drawing.Color.White
        '
        'MetroTileItem6
        '
        Me.MetroTileItem6.Name = "MetroTileItem6"
        Me.MetroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange
        '
        '
        '
        Me.MetroTileItem6.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroTileItem6.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroTileItem6.TileStyle.BackColorGradientAngle = 45
        Me.MetroTileItem6.TileStyle.Class = ""
        Me.MetroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem6.TileStyle.PaddingBottom = 4
        Me.MetroTileItem6.TileStyle.PaddingLeft = 4
        Me.MetroTileItem6.TileStyle.PaddingRight = 4
        Me.MetroTileItem6.TileStyle.PaddingTop = 4
        Me.MetroTileItem6.TileStyle.TextColor = System.Drawing.Color.White
        '
        'MetroTileItem5
        '
        Me.MetroTileItem5.Name = "MetroTileItem5"
        Me.MetroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow
        '
        '
        '
        Me.MetroTileItem5.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroTileItem5.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroTileItem5.TileStyle.BackColorGradientAngle = 45
        Me.MetroTileItem5.TileStyle.Class = ""
        Me.MetroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem5.TileStyle.PaddingBottom = 4
        Me.MetroTileItem5.TileStyle.PaddingLeft = 4
        Me.MetroTileItem5.TileStyle.PaddingRight = 4
        Me.MetroTileItem5.TileStyle.PaddingTop = 4
        Me.MetroTileItem5.TileStyle.TextColor = System.Drawing.Color.White
        Me.MetroTileItem5.TitleText = "Test"
        '
        'MetroTileItem4
        '
        Me.MetroTileItem4.Name = "MetroTileItem4"
        Me.MetroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray
        '
        '
        '
        Me.MetroTileItem4.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTileItem4.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.MetroTileItem4.TileStyle.BackColorGradientAngle = 45
        Me.MetroTileItem4.TileStyle.Class = ""
        Me.MetroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem4.TileStyle.PaddingBottom = 4
        Me.MetroTileItem4.TileStyle.PaddingLeft = 4
        Me.MetroTileItem4.TileStyle.PaddingRight = 4
        Me.MetroTileItem4.TileStyle.PaddingTop = 4
        Me.MetroTileItem4.TileStyle.TextColor = System.Drawing.Color.White
        '
        'MetroTileItem9
        '
        Me.MetroTileItem9.Name = "MetroTileItem9"
        Me.MetroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.MaroonWashed
        '
        '
        '
        Me.MetroTileItem9.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MetroTileItem9.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.MetroTileItem9.TileStyle.BackColorGradientAngle = 45
        Me.MetroTileItem9.TileStyle.Class = ""
        Me.MetroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem9.TileStyle.PaddingBottom = 4
        Me.MetroTileItem9.TileStyle.PaddingLeft = 4
        Me.MetroTileItem9.TileStyle.PaddingRight = 4
        Me.MetroTileItem9.TileStyle.PaddingTop = 4
        Me.MetroTileItem9.TileStyle.TextColor = System.Drawing.Color.White
        '
        'MetroTileItem7
        '
        Me.MetroTileItem7.Name = "MetroTileItem7"
        Me.MetroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem7.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.MetroTileItem7.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.MetroTileItem7.TileStyle.BackColorGradientAngle = 45
        Me.MetroTileItem7.TileStyle.Class = ""
        Me.MetroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem7.TileStyle.PaddingBottom = 4
        Me.MetroTileItem7.TileStyle.PaddingLeft = 4
        Me.MetroTileItem7.TileStyle.PaddingRight = 4
        Me.MetroTileItem7.TileStyle.PaddingTop = 4
        Me.MetroTileItem7.TileStyle.TextColor = System.Drawing.Color.White
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(3, 3)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(155, 55)
        Me.ReflectionLabel1.TabIndex = 1
        Me.ReflectionLabel1.Text = "<b><font size=""+10""><i>Main </i><font color=""#B02B2C"">Menu</font></font></b>"
        '
        'MainMenu1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Name = "MainMenu1"
        Me.Size = New System.Drawing.Size(588, 388)
        Me.Text = "Main Menu 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mti1 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents mti2 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents mti3 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem7 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents MetroTileItem8 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem9 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents MetroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel

End Class
