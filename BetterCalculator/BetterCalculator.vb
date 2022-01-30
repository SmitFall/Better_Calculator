'Fallon Smith
'RCET0265
'Spring 2022
'Better Calculator
'

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim userResponse As String
        Dim secondResponse As String
        Dim menu As String
        Dim booleanSwitch As Boolean
        Dim result As Integer

        Do

            Console.WriteLine("Please enter two numbers. Enter ")
                userResponse = Console.ReadLine()
                Console.WriteLine($"You entered {userResponse} ")
                Console.WriteLine("Please enter two numbers. Enter ")
                secondResponse = Console.ReadLine
                Console.WriteLine($"you entered {secondResponse}")

                Console.WriteLine("1. Add" & vbNewLine _
                                 & "2. Subtract" & vbNewLine _
                                 & "3. Multiply" & vbNewLine _
                                 & "4. Divide")
                menu = Console.ReadLine()
                Console.WriteLine($" You entered {menu}")

                Select Case menu
                Case "1"
                    result = CInt(userResponse) + CInt(secondResponse)
                    Console.WriteLine($"{userResponse} + {secondResponse} = {result}")
                    Console.ReadLine()
                Case "2"
                    result = CInt(userResponse) - CInt(secondResponse)
                    Console.WriteLine($"{userResponse} - {secondResponse} = {result}")
                    Console.ReadLine()
                Case "3"
                    result = CInt(userResponse) * CInt(secondResponse)
                    Console.WriteLine($"{userResponse} * {secondResponse} = {result}")
                    Console.ReadLine()
                Case "4"
                    result = CInt(userResponse) \ CInt(secondResponse)
                    Console.Write($"{userResponse} \ {secondResponse} = {result} with a remainder of ")
                    Console.WriteLine(CInt(userResponse) Mod CInt(secondResponse))
                Case "Q"
                    booleanSwitch = False
                Case Else
                    Console.WriteLine($"you entered {menu}")
            End Select



        Loop Until booleanSwitch = False
        Console.Read()

    End Sub

End Module
