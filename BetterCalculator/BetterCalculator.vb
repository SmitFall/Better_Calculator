'Fallon Smith
'RCET0265
'Spring 2022
'Better Calculator
'https://github.com/SmitFall/Better_Calculator

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()

        'Setting aside varibles 
        Dim userResponse As String
        Dim secondResponse As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim menu As String
        Dim killSwitch As Boolean = False
        Dim result As Integer
        Dim loopOne As Boolean = False
        Dim loopTwo As Boolean = False
        Dim loopthree As Boolean = False

        ' Loops repeats until Q is entered
        Do
            ' loops until a number is pressed or until Q is entered
            Do
                Try
                    Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & "to quit")
                    userResponse = Console.ReadLine()
                    firstNumber = CInt(userResponse)
                    Console.WriteLine($"You entered {userResponse} ")
                    loopOne = False
                Catch
                    If userResponse = "Q" Then
                        killSwitch = True
                    Else
                        Console.WriteLine($" you entered {userResponse} please enter a whole number")
                        Console.ReadLine()
                        loopOne = True
                    End If


                End Try

            Loop Until loopOne = False

            'If Q is pressed then it will skip this. if not runs normal
            If killSwitch <> True Then
                ' loops until a number is pressed or until Q is entered
                Do
                    Try
                        Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & "to quit")
                        secondResponse = Console.ReadLine()
                        secondNumber = CInt(secondResponse)
                        Console.WriteLine($"You entered {secondResponse} ")
                        loopTwo = False
                    Catch
                        If secondResponse = "Q" Then
                            killSwitch = True
                        Else
                            Console.WriteLine($" you entered {secondResponse} please enter a whole number")
                            Console.ReadLine()
                            loopTwo = True
                        End If


                    End Try

                Loop Until loopTwo = False

            End If
            'Loops until Q or menu number is pressed
            Do
                'Checks to see if Q was pressed before
                If killSwitch <> True Then

                    Console.WriteLine("Choose one of the following option:" & vbNewLine _
                                 & "1. Add" & vbNewLine _
                                 & "2. Subtract" & vbNewLine _
                                 & "3. Multiply" & vbNewLine _
                                 & "4. Divide")
                    menu = Console.ReadLine()
                    Console.WriteLine($" You entered {menu}")
                    ' Runs through to see if a proper menu number was pressed or Q
                    Try
                        Select Case menu
                            Case "1"
                                result = firstNumber + secondNumber
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}")
                                Console.ReadLine()
                                loopthree = False
                            Case "2"
                                result = firstNumber - secondNumber
                                Console.WriteLine($"{firstNumber} - {secondNumber} = {result}")
                                Console.ReadLine()
                                loopthree = False
                            Case "3"
                                result = firstNumber * secondNumber
                                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}")
                                Console.ReadLine()
                                loopthree = False
                            Case "4"
                                result = firstNumber \ secondNumber
                                Console.Write($"{firstNumber} \ {secondNumber} = {result} with a remainder of ")
                                Console.WriteLine(firstNumber Mod secondNumber)
                                loopthree = False
                            Case "Q"
                                killSwitch = True
                                loopthree = False
                            Case Else
                                Console.WriteLine($"you entered {menu}")
                                loopthree = True
                        End Select
                    Catch ex As Exception
                        Console.WriteLine($"you entered {menu}")
                    End Try

                End If

            Loop Until loopthree = False


        Loop Until killSwitch = True
        Console.WriteLine("you have entered " & Chr(34) & "Q" & Chr(34))
        Console.WriteLine("Have a nice day!")
        Console.WriteLine("Press enter to close this window")
        Console.Read()
    End Sub

End Module
