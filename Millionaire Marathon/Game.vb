Public Class FrmGame
    Dim gameOver = False
    Dim currentPlayer = 1
    Dim currentPlayerStr As String



    ReadOnly file_path = "Questions.txt"
    Dim question_bank = GetQuestions(file_path)
    Dim options As ArrayList = New ArrayList()

    Dim currentRound = 1
    ReadOnly noQuestions = 82
    Dim currentQuestion = 1

    Function GetQuestions(path As String)
        Dim questions As ArrayList = New ArrayList()
        Using MyReader As New FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                questions.Add(MyReader.ReadFields())
            End While
        End Using
        Return questions
    End Function

    Function CheckNewRound(players, money, qAnsd, qNo)
        Return (qNo Mod 20 = 0) And (qNo <> 0)
    End Function

    Sub ShuffleArray(arr As ArrayList)
        Dim last_index = arr.Count - 1
        While last_index > 0
            Randomize()
            Dim rand_index = New Random().Next(0, arr.Count)
            Dim temp = arr(last_index)
            arr(last_index) = arr(rand_index)
            arr(rand_index) = temp
            last_index -= 1
        End While
    End Sub

    Function UpdateQuestions()
        For j = 1 To 4
            options.Add(question_bank(currentQuestion)(j))
        Next

        Call ShuffleArray(options)

        For j = 1 To 4
            question_bank(currentQuestion)(j) = options(j - 1)
        Next

        currentQuestion += 1
        Return question_bank(currentQuestion)
    End Function


    Sub ChangePlayer()
        If currentPlayer = 4 Then
            currentPlayer = 1
        Else
            currentPlayer += 1
            currentPlayerStr = String.Format("Player {0}", currentPlayer)
        End If
    End Sub

    Sub CheckPlayerStreak()
        If (players(currentPlayerStr).Qansd Mod 5 = 0) And (players(currentPlayerStr).Qansd <> 0) Then
            MsgBox(currentPlayerStr & " exits the hotseat!")
            Call ChangePlayer()
        End If
    End Sub



    'Variable Declarations

    Dim players As New Hashtable From {
            {"Player 1", New Player With {.Money = 0, .Qansd = 0}},
            {"Player 2", New Player With {.Money = 0, .Qansd = 0}},
            {"Player 3", New Player With {.Money = 0, .Qansd = 0}},
            {"Player 4", New Player With {.Money = 0, .Qansd = 0}}
        }

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 1 To 4
        '    Dim playerStr = String.Format("Player {0}", i)
        '    MsgBox(playerStr & "'s Money: " & players(playerStr).Money)
        'Next
    End Sub

    Private Sub MainGame(user_input As String, correct_answer As String)
        If user_input = correct_answer Then
            ' the money of the current player
            players(currentPlayerStr).Money = 2 ^ (players(currentPlayerStr).Qansd)
            ' the number of questions the currentt player has correctly answered
            players(currentPlayerStr).Qansd += 1

            'Checks if the current player is on a 5 answer streak
            Call CheckPlayerStreak()
        Else
            If user_input = "pass" Then
                MsgBox(currentPlayerStr & " passes the question and exits the hotseat!")
            Else
                MsgBox(currentPlayerStr & " is incorrect and exits the hotseat!")
            End If
            Call ChangePlayer()
            MsgBox(currentPlayerStr & " enters the hotseat")
        End If
    End Sub

End Class

Public Class Player
    Property Money As Integer
    Property Qansd As Integer
End Class