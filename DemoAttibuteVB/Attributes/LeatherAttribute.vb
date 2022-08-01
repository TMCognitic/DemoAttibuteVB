Class LeatherAttribute
    Inherits LootAttribute

    Public Sub New(maxValue As Integer)
        MyBase.New(maxValue, "peaux")
    End Sub

    Public Sub New(maxValue As Integer, name As String)
        MyBase.New(maxValue, name)
    End Sub
End Class
