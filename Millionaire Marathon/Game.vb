Public Class FrmGame
    Dim MRE As New Threading.ManualResetEvent(False)

    ReadOnly FilePath As String = "Questions.csv"
    ReadOnly Rounds = GetRounds(GetQuestions(FilePath))

    Dim CurrentRound As Integer = 1
    Dim CurrentQuestionNo As Integer = 0
    Dim CurrentQuestionInfo As Array

    ReadOnly PlayerNames As Hashtable = FrmSetup.playerNames
    Dim Players As New Hashtable From {
        {PlayerNames("Player 1"), New Player},
        {PlayerNames("Player 2"), New Player},
        {PlayerNames("Player 3"), New Player},
        {PlayerNames("Player 4"), New Player}
    }

    Dim Response As String
    Dim currentPlayerInt As Integer = 1
    'Dim currentPlayerStr As String = PlayerNames("Player " + Str(currentPlayerInt))
    Dim currentPlayerStr As String = PlayerNames(String.Format("Player {0}", currentPlayerInt))

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MainGame()
    End Sub

    Sub BtnOptions_Click(sender As Button, e As EventArgs) _
        Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click

        Dim BtnOption As Button = sender
        Response = BtnOption.Text
        MRE.Set()
    End Sub

    Async Sub MainGame()
        For round = 0 To 3
            CurrentRound = round + 1
            For question = 0 To Rounds(round).Count - 1
                CurrentQuestionNo = question
                CurrentQuestionInfo = Rounds(round)(CurrentQuestionNo)
                Dim correctAnswer As String = CurrentQuestionInfo(5)

                PopulateButtons(CurrentQuestionInfo)
                PopulateLabels(CurrentQuestionInfo(0))

                Await Task.Run(Sub()
                                   MRE.WaitOne()
                               End Sub)

                Select Case Response
                    Case correctAnswer
                        Players(currentPlayerStr).Money = 2 ^ (Players(currentPlayerStr).Qansd)
                        Players(currentPlayerStr).Qansd += 1
                        lblReponse.Text = currentPlayerStr & " is correct!"
                    Case "pass"
                        lblReponse.Text = currentPlayerStr & " passes!"
                    Case Else
                        lblReponse.Text = currentPlayerStr & " is wrong!"
                End Select

                Call ChangePlayer()
                MRE.Reset()

            Next question
        Next round
    End Sub

    Sub PopulateButtons(info As Array)
        btnOption1.Text = info(1)
        btnOption2.Text = info(2)
        btnOption3.Text = info(3)
        btnOption4.Text = info(4)
    End Sub

    Sub PopulateLabels(question As String)
        lblRound.Text = "Round: " & CurrentRound
        lblCurrentPlayer.Text = "Current Player: " & currentPlayerStr
        lblMoney.Text = "Money: $" & Players(currentPlayerStr).Money
        lblQuestion.Text = String.Format("Question {0}: {1}", (CurrentQuestionNo + 1), question)
    End Sub


    Sub ChangePlayer()
        If currentPlayerInt = 4 Then
            currentPlayerInt = 1
        Else
            currentPlayerInt += 1
        End If
        currentPlayerStr = PlayerNames(String.Format("Player {0}", currentPlayerInt))
    End Sub

    Function GetRounds(questions As ArrayList) As List(Of ArrayList)
        Dim rounds As New List(Of ArrayList) From {
            GetPartialList(questions, 0, 19),
            GetPartialList(questions, 20, 39),
            GetPartialList(questions, 40, 59),
            GetPartialList(questions, 60, questions.Count - 1)
            }
        Return rounds
    End Function

    Function GetPartialList(arr As ArrayList, startIndex As Integer, lastIndex As Integer)
        Dim partialArray As New ArrayList
        For i = startIndex To lastIndex
            partialArray.Add(arr(i))
        Next
        Return partialArray
    End Function

    Function GetQuestions(path As String) As ArrayList
        Dim questions As ArrayList = New ArrayList()
        Using MyReader As New FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                questions.Add(MyReader.ReadFields())
            End While
        End Using

        For Each question In questions
            Dim options As New ArrayList()

            For j = 1 To 4
                options.Add(question(j))
            Next

            Call ShuffleArray(options)
            options.Add(question(5))

            For j = 1 To 4
                question(j) = options(j - 1)
            Next
        Next

        Call ShuffleArray(questions)
        Return questions
    End Function

    Sub ShuffleArray(arr As ArrayList)
        Dim lastIndex As Integer = arr.Count - 1
        Dim randIndex As Integer
        Dim randGen As Random = New Random

        While lastIndex > 0
            randIndex = randGen.Next(0, arr.Count)
            Dim temp = arr(lastIndex)
            arr(lastIndex) = arr(randIndex)
            arr(randIndex) = temp
            lastIndex -= 1
        End While
    End Sub
End Class
