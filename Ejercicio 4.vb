Module Module1
    Sub Main()
        Dim cantidad, inicial, secuencial, i As Integer
        inicial = 1
        cantidad = 20
        secuencial = 2
        For i = 1 To cantidad
            Console.Write(inicial & ",")
            inicial = inicial + secuencial
            secuencial = secuencial + 1
        Next
        Console.ReadKey()
    End Sub
End Module
