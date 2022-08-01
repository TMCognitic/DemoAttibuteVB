Imports System.Reflection

Class Hero
    Public Sub Loot(monster As Monstre)
        Dim monsterType As Type = monster.GetType()

        Dim attributes As IEnumerable(Of LootAttribute) = monsterType.GetCustomAttributes(Of LootAttribute)()
        For Each attribute As LootAttribute In attributes
            Console.WriteLine($"Je ramasse {attribute.Quantity} {attribute.Name}!")
        Next
    End Sub
End Class