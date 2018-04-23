Imports System
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Navigation


Partial Public NotInheritable Class MainPage
    Inherits Page

    Public Sub New()
        Me.InitializeComponent()
        DataContext = New ViewModel() With {.Start = 10000, .Count = 50000, .Increment = TimeSpan.FromHours(3)}
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As NavigationEventArgs)
    End Sub
End Class

