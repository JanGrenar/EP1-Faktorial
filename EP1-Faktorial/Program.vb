Imports System
Imports System.Net.Sockets

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer

        Console.WriteLine("Zadejte ��slo")
        cislo = Console.ReadLine

        For x = 0 To cislo
            soucet = soucet + x
        Next

        Console.WriteLine($"Sou�et ��sel od 0 do {cislo} je {soucet}")

    End Sub
End Module
