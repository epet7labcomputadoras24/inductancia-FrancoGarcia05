Imports System

Module Program
    Sub Main(args As String())
        Dim L As Single
        Dim f As Single
        Dim Xl As Single
        Console.WriteLine("Ingrese el valor de la inductancia")
        L = Console.ReadLine()
        Console.WriteLine("Ingrese el valor de la frecuencia")
        f = Console.ReadLine()
        Xl = 2 * 3.14 * f * L
        Console.WriteLine("XL= " & Xl)
    End Sub
End Module
