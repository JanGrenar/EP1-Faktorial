Imports System
Imports System.Net.Sockets
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

            Else For x = 0 To cislo
                    soucet = soucet + x
                Next
                Console.WriteLine($"Faktori�l ��sla od 0 do {cislo} je {soucet}")

            End If
        Loop
        'loop u� tu byl 
    End Sub

End Module
