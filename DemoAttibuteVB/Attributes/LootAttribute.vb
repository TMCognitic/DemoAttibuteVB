Class LootAttribute
    Inherits Attribute
    Private Shared sharedRandom As New Random
    Private random As Random

    Private _maxValue As Integer
    Private _name As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Private Set(value As String)
            _name = value
        End Set
    End Property

    Public Sub New(maxValue As Integer, name As String)
        _maxValue = maxValue
        Me.Name = name
        random = New Random(sharedRandom.Next())
    End Sub

    Public ReadOnly Property Quantity() As Integer
        Get
            Return random.Next(_maxValue) + 1
        End Get
    End Property

End Class
