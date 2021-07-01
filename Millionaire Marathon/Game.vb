Public Class FrmGame
    ReadOnly filePath As String = "Questions.csv"
    Dim questionBank As ArrayList = GetQuestions(filePath)
    Dim currentQuestionInfo As Array

    Dim currentRound As Integer = 1
    Dim currentQuestion As Integer = 0

    ReadOnly PlayerNames As Hashtable = FrmSetup.playerNames
    Dim Players As New Hashtable From {
        {PlayerNames("Player 1"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}},
        {PlayerNames("Player 2"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}},
        {PlayerNames("Player 3"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}},
        {PlayerNames("Player 4"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}}
    }
    Dim currentPlayerInt = 1
    Dim currentPlayerStr = PlayerNames(String.Format("Player {0}", currentPlayerInt))

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call UpdateQuestions()
        Call FeedInformation(currentQuestionInfo)
    End Sub

    Private Sub BtnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        Call MainGame(btnOption1.Text, currentQuestionInfo(5))
    End Sub

    Private Sub BtnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        Call MainGame(btnOption2.Text, currentQuestionInfo(5))
    End Sub

    Private Sub BtnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        Call MainGame(btnOption3.Text, currentQuestionInfo(5))
    End Sub

    Private Sub BtnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        Call MainGame(btnOption4.Text, currentQuestionInfo(5))
    End Sub

    Private Sub MainGame(userInput As String, correctAnswer As String)
        If currentQuestion + 1 <= 81 Then

            If (userInput = correctAnswer) Then
                Players(currentPlayerStr).Money = 2 ^ (Players(currentPlayerStr).Qansd)
                Players(currentPlayerStr).Qansd += 1
                Players(currentPlayerStr).Streak += 1

                lblFeedback.Text = String.Format("{0} is correct!", currentPlayerStr)
                Call CheckPlayerStreak()
            Else
                If userInput = "pass" Then
                    lblFeedback.Text = currentPlayerStr & " passes the question and exits the hotseat!"
                Else
                    lblFeedback.Text = currentPlayerStr & " is incorrect and exits the hotseat!"
                End If
                Call ChangePlayer()
                lblFeedback.Text = currentPlayerStr & " enters the hotseat"
            End If

            currentQuestion += 1
            If currentQuestion <> 81 Then
                Call UpdateQuestions()
                Call FeedInformation(currentQuestionInfo)
            End If

        Else
            For i = 1 To 4
                Players(String.Format("Player {0}", i)).Money = Players(String.Format("Player {0}", i)).Qansd
            Next
        End If
    End Sub


    Sub FeedInformation(info As Array)
        If CheckNewRound() Then
            currentRound += 1
        End If
        lblRound.Text = "Round: " & currentRound
        lblCurrentPlayer.Text = "Current Player: " & PlayerNames(String.Format("Player {0}", currentPlayerInt))
        lblQuestion.Text = String.Format("Question {0}: {1}", (currentQuestion + 1), info(0))

        btnOption1.Text = info(1)
        btnOption2.Text = info(2)
        btnOption3.Text = info(3)
        btnOption4.Text = info(4)
    End Sub

    Sub ChangePlayer()
        If currentPlayerInt = 4 Then
            currentPlayerInt = 1
        Else
            currentPlayerInt += 1
        End If
        currentPlayerStr = PlayerNames(String.Format("Player {0}", currentPlayerInt))
    End Sub

    Function CheckNewRound() As Boolean
        Return (currentQuestion Mod 20 = 0) And (currentQuestion <> 0)
    End Function

    Sub CheckPlayerStreak()
        If Players(currentPlayerStr).Streak = 5 Then
            lblFeedback.Text = currentPlayerStr & " exits the hotseat!"
            Call ChangePlayer()
            lblFeedback.Text = currentPlayerStr & " enters the hotseat!"
            Players(currentPlayerStr).Streak = 0
        End If
    End Sub

    Sub UpdateQuestions()
        If currentQuestion < 81 Then
            Dim options As ArrayList = New ArrayList()
            For j = 1 To 4
                options.Add(questionBank(currentQuestion)(j))
            Next

            Call ShuffleArray(options)
            options.Add(questionBank(currentQuestion)(5))

            For j = 1 To 4
                questionBank(currentQuestion)(j) = options(j - 1)
            Next

            currentQuestionInfo = questionBank(currentQuestion)
        End If
    End Sub

    Function GetQuestions(path As String) As ArrayList
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

    Sub ShuffleArray(arr As ArrayList)
        Dim last_index As Integer = arr.Count - 1
        Dim rand_index As Integer
        Dim rand_gen As Random = New Random

        While last_index > 0
            rand_index = rand_gen.Next(0, arr.Count)
            Dim temp = arr(last_index)
            arr(last_index) = arr(rand_index)
            arr(rand_index) = temp
            last_index -= 1
        End While
    End Sub
End Class

Public Class Player
    Property Money As Integer
    Property Qansd As Integer
    Property Streak As Integer
End Class