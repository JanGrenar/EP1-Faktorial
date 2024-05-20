Imports System
Imports System.Net.Sockets
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())

        Dim cislo As Integer
        Dim soucet As Integer
        Do
            Console.WriteLine("Zadej celé èíslo:")
            cislo = Console.ReadLine

            If cislo < 0 Then
                Console.WriteLine("Faktoriál není možný")

            ElseIf cislo = 0 Or cislo = 1 Then
                Console.WriteLine("Faktoriál je 1")
            ElseIf cislo > 10 Then
                Console.WriteLine("Èíslo je pøíliš velké")

            Else Program.výpoèet(cislo)

            End If
        Loop

        End Sub

    Function výpoèet(ByVal cislo As Integer)

        Dim soucet As Integer
        For x = 0 To cislo
            soucet = soucet + x
        Next
        Console.WriteLine($"Faktoriál èísla od 0 do {cislo} je {soucet}")

    End Function
End Module
