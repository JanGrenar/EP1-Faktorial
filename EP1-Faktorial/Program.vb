Imports System
Imports System.Net.Sockets
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())

        Dim cislo As Integer
        Dim soucet As Integer
        Do
            Console.WriteLine("Zadej cel� ��slo:")
            cislo = Console.ReadLine

            If cislo < 0 Then
                Console.WriteLine("Faktori�l nen� mo�n�")

            ElseIf cislo = 0 Or cislo = 1 Then
                Console.WriteLine("Faktori�l je 1")
            ElseIf cislo > 10 Then
                Console.WriteLine("��slo je p��li� velk�")

            Else Program.v�po�et(cislo)

            End If
        Loop

        End Sub

    Function v�po�et(ByVal cislo As Integer)

        Dim soucet As Integer
        For x = 0 To cislo
            soucet = soucet + x
        Next
        Console.WriteLine($"Faktori�l ��sla od 0 do {cislo} je {soucet}")

    End Function
End Module
