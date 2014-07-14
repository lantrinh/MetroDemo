Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class MetroCommands
    Private _SlideStartControl As Command
    ''' <summary>
    ''' Toggles start control visibility.
    ''' </summary>
    Public Property ToggleStartControl() As Command
        Get
            Return _SlideStartControl
        End Get
        Set(ByVal value As Command)
            _SlideStartControl = value
        End Set
    End Property
End Class


