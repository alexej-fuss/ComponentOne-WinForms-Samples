Imports System.Windows.Forms

Partial Public Class DemoBase_settings
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property Title() As String
        Get
            Return Me.lblTitle.Text
        End Get
        Set(value As String)
            Me.lblTitle.Text = Value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Me.lblDescription.Text
        End Get
        Set(value As String)
            Me.lblDescription.Text = Value
        End Set
    End Property
End Class