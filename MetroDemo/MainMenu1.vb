Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class MainMenu1
    Private _Commands As Command
    ''' <summary>
    ''' Gets or sets the commands associated with the control.
    ''' </summary>
    Public Property Commands() As Command
        Get
            Return _Commands
        End Get
        Set(ByVal value As Command)
            _Commands = value
            
        End Set
    End Property
End Class
