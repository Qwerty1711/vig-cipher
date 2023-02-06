Module Module1

    Sub Main()

        Console.WriteLine("input alphabet")
        Dim alphabet As String = Console.ReadLine()
        Console.WriteLine("input input")
        Dim input As String = Console.ReadLine()
        Console.WriteLine("input key")
        Dim key As String = Console.ReadLine()

        Dim func As String = "harshithWasHere"
        Do Until func = "e" Or func = "d"
            Console.WriteLine("input function (encode-'e'/decode-'d')")
            func = Console.ReadLine()
            If Not (func = "e" Or func = "d") Then
                Console.WriteLine("invalid input")
            End If
        Loop



        Dim keyI As Integer
        Dim outputI As Integer
        For i = 0 To input.Length - 1
            keyI = i
            While keyI > key.Length - 1
                keyI -= key.Length
            End While

            If InStr(alphabet, key(keyI)) = 0 Then
                Console.Write("{undefined character in key}")
            Else
                If InStr(alphabet, input(i)) = 0 Then
                    Console.Write(input(i))
                Else
                    If func = "e" Then
                        outputI = InStr(alphabet, input(i)) + (InStr(alphabet, key(keyI)) - 1) - 1
                    Else
                        outputI = InStr(alphabet, input(i)) -
                        (
                            InStr(alphabet, key(keyI)) - 1
                        ) - 1
                    End If


                    If outputI > alphabet.Length - 1 Then
                        outputI -= alphabet.Length
                    End If

                    If outputI < 0 Then
                        outputI += alphabet.Length
                    End If

                    Console.Write(alphabet(outputI))
                End If
            End If

        Next
        Console.ReadLine()

    End Sub

End Module
