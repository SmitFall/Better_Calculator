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
        Dim message As String


        Do

            Console.WriteLine("Please enter two numbers. Enter ")
            userResponse = Console.ReadLine()
            Console.WriteLine($"You entered {userResponse} ")
            Console.WriteLine("Please enter two numbers. Enter ")
            secondResponse = Console.ReadLine
            Console.WriteLine($"you entered {secondResponse}")

        Loop
        Console.Read()

    End Sub

End Module
