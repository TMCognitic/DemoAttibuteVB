Module Program

    Sub Main()
        Dim h As New Hero()
        Dim m As Monstre = New Dragon()

        h.Loot(m)
        'Dim r As New Random()
        'Dim r1 As New Random(r.Next())
        'Dim r2 As New Random(r.Next())

        'For index = 1 To 10
        '    Console.WriteLine($"{r1.Next()} - {r2.Next()}")
        'Next

        Console.ReadLine()
    End Sub

End Module
