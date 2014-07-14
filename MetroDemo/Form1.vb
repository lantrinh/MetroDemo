Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro
Imports System.ComponentModel

Public Class Form1
    'Private _Commands As Command() = New Command(2) {}
    Private _CurrentPage As Integer = 0
    Private _MainMenu1 As New MainMenu1
    Private _Commands As New MetroCommands


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        '_Commands.ToggleStartControl = New Command(components)
        'AddHandler _Commands.ToggleStartControl.Executed, AddressOf ToggleStartControlExecuted

        '_Commands(0) = cmdPage1
        '_Commands(1) = cmdPage2
        '_Commands(2) = cmdPage3

        _MainMenu1.mti1.Command = cmdPage1 '_Commands(2)
        _MainMenu1.mti2.Command = cmdPage2
        _MainMenu1.mti2.Command = cmdPage3

        AddHandler cmdPage1.Executed, AddressOf cmdPage1_Executed
        AddHandler cmdPage2.Executed, AddressOf cmdPage2_Executed
        AddHandler cmdPage2.Executed, AddressOf cmdPage3_Executed

        AddHandler _MainMenu1.Click, AddressOf _MainMenu1_Click


        'cmdPage1.Execute()
        Me.SuspendLayout()
        Me.Controls.Add(_MainMenu1)
        _MainMenu1.BringToFront()
        _MainMenu1.SlideSide = eSlideSide.Right
        Me.ResumeLayout()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim page As New MainMenu

        'PagePanel.Controls.Add(page)
        ''page.Bounds = New Rectangle(PagePanel.Width, 0, page.Width, page.Height)
        'page.BringToFront()
        'page.SlideSide = eSlideSide.Right
        'page.IsOpen = True
        Console.WriteLine("test")
    End Sub

#Region "Change Page"
    Private Sub ChangePage(ByVal page As SlidePanel, ByVal pageNumber As Integer)

        Try
            Me.SuspendLayout()
            Me.Controls.Add(page)
            Me.ResumeLayout()
            'If TypeOf page Is IRunSample Then
            '    DirectCast(page, IRunSample).RunSampleCommand = runCommand
            'End If

            If _CurrentPage = 0 Then
                ' Just show the page no need to slide it into the view
                PagePanel.Controls.Add(page)
            Else
                page.Visible = False
                page.IsOpen = False

                ' SlidePanel is opening from closed position so we need to set its open bounds
                page.OpenBounds = New Rectangle(0, 0, page.Width, page.Height)

                ' Now we will set its closed bounds so it is out of the view and it slides into
                ' view from the desired side based on page number
                If _CurrentPage < pageNumber Then
                    page.Bounds = New Rectangle(PagePanel.Width, 0, page.Width, page.Height)
                    ' Slide from right side
                    page.SlideSide = eSlideSide.Right

                Else
                    page.Bounds = New Rectangle(-page.Width, 0, page.Width, page.Height)
                    ' Slide from left side
                    page.SlideSide = eSlideSide.Left
                End If

                PagePanel.Controls.Add(page)
                page.BringToFront()

                ' Make sure panel is top-most
                page.IsOpen = True

                ' Remove old page
                'Dim oldPage As Control = PagePanel.Controls(1)
                'If TypeOf oldPage Is IRunSample Then
                '    DirectCast(oldPage, IRunSample).RunSampleCommand = Nothing
                'End If

                'pagePanel.Controls.Remove(oldPage)
                'oldPage.Dispose()
            End If

            'pageTitleLabel.Text = page.Text
            _CurrentPage = pageNumber

            ' Update command checked state
            'For i As Integer = 0 To _Commands.Length - 1
            '    'is currentPage = i + 1 => True or False
            '    _Commands(i).Checked = (i + 1 = _CurrentPage)

            'Next

            page.Dock = DockStyle.Fill

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "Command Page Executed"
    Private Sub cmdPage1_Executed(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles cmdPage1.Executed
        ChangePage(New MainMenu1(), 1)
        ToggleMainMenuExecuted()
    End Sub


    Private Sub cmdPage2_Executed(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles cmdPage2.Executed
        ChangePage(New MainMenu2(), 2)
        'ToggleMainMenuExecuted()

    End Sub

    Private Sub cmdPage3_Executed(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles cmdPage3.Executed

    End Sub

#End Region

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        UpdateControlsSizeAndLocation()
        MyBase.OnLoad(e)
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        UpdateControlsSizeAndLocation()
        MyBase.OnResize(e)
    End Sub

    Private Sub UpdateControlsSizeAndLocation()
        If _MainMenu1 IsNot Nothing Then
            If Not _MainMenu1.IsOpen Then
                _MainMenu1.OpenBounds = GetStartControlBounds()
            Else
                _MainMenu1.Bounds = GetStartControlBounds()
            End If
            If Not Me.IsModalPanelDisplayed Then _MainMenu1.BringToFront()
        End If
        'metroToolbar1.Location = New Point((Me.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1)
        'metroToolbar2.Location = New Point((Me.Width - metroToolbar2.Width) / 2, metroToolbar2.Parent.Height - metroToolbar2.Height - 1)
    End Sub

    Private Function GetStartControlBounds() As Rectangle
        Dim captionHeight As Integer = MetroShell1.MetroTabStrip.GetCaptionHeight() + 2
        Dim borderThickness As Thickness = GetBorderThickness()
        Return New Rectangle(borderThickness.Left, captionHeight, Me.Width - borderThickness.Horizontal, Me.Height - captionHeight - 1)
    End Function

    Private Sub _MainMenu1_Click(ByVal sender As Object, ByVal e As EventArgs)
        _MainMenu1.IsOpen = False
    End Sub

    Private Sub ToggleMainMenuExecuted() '(ByVal sender As Object, ByVal e As EventArgs)
        _MainMenu1.IsOpen = Not _MainMenu1.IsOpen
    End Sub

End Class