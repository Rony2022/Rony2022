Imports System

Module Program
	Sub Main()
		Console.Title = "Rony Rodriguez"

		Dim valor, x, y, z As Decimal
		x = 0.05
		y = 0.01
		y = 0.015
		Console.Write("Ingrese el valor total de la compra: ")
		valor = Console.ReadLine()
		If (valor > 49 And valor < 101) Then
			Console.WriteLine("Total de compra :" & valor)
			Dim d1 As Decimal
			d1 = valor * x
			Console.WriteLine("Total de Descuento :" & d1)
			Console.WriteLine("Total a pagar :" & valor - d1)

		ElseIf (valor > 100 And valor < 151) Then
			Console.WriteLine("Total de compra :" & valor)
			Dim d2 As Decimal
			d2 = valor * y
			Console.WriteLine("Total de Descuento :" & d2)
			Console.WriteLine("Total a pagar :" & valor - d2)

		ElseIf (valor > 151) Then
			Dim d3 As Decimal
			d3 = valor * z
			Console.WriteLine("Total de Descuento :" & d3)
			Console.WriteLine("Total a pagar :" & valor - d3)
		Else
			Console.WriteLine("No aplica descuento")

		End If
		Console.ReadKey()

	End Sub
End Module
