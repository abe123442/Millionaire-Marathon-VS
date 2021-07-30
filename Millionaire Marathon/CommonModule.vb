Module CommonModule
    Public MillionEvent As New Threading.ManualResetEvent(False)
    Public AcceptMillion As Boolean = False
    Public MillionPlayerName As String
    Public Players As Hashtable
    Public Response As String

    Sub CustomiseButtons(btns As List(Of Button))
        For Each btn As Button In btns
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.AntiqueWhite
            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Century Gothic", 10)

            Dim Raduis As New Drawing2D.GraphicsPath

            Raduis.StartFigure()
            Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
            Raduis.AddLine(10, 0, btn.Width - 20, 0)
            Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
            Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
            Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
            Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
            Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
            Raduis.CloseFigure()
            btn.Region = New Region(Raduis)
        Next
    End Sub

    Sub SwitchPanel(frm As Form)
        MainForm.PanelMain.Controls.Clear()
        frm.TopLevel = False
        MainForm.PanelMain.Controls.Add(frm)
        frm.Show()
        MainForm.PanelMain.BringToFront()
    End Sub


    Sub PopulateButtons(btns As List(Of Button), info As Array)
        For Each btn As Button In btns
            Select Case btn.Name
                Case "btnOption1"
                    btn.Text = info(1)
                Case "btnOption2"
                    btn.Text = info(2)
                Case "btnOption3"
                    btn.Text = info(3)
                Case "btnOption4"
                    btn.Text = info(4)
            End Select
        Next
    End Sub

    Sub PopulateLabels(lbls As List(Of Label), vars As GameVariables)
        For Each lbl As Label In lbls
            Select Case lbl.Name
                Case "lblRound"
                    lbl.Text = $"Round: {vars.CurrentRound}"
                Case "lblCurrentPlayer"
                    lbl.Text = $"Current Player: {Players(vars.CurrentPlayerInfo.CurrentPlayerID).Name}"
                Case "lblMoney"
                    lbl.Text = $"Money: ${(Players(vars.CurrentPlayerInfo.CurrentPlayerID).Money)}"
                Case "lblQuestion"
                    lbl.Text = $"Question {vars.CurrentQuestionInfo.CurrentQuestionNo + 1}: {vars.CurrentQuestionInfo.CurrentQuestion}"
            End Select
        Next
    End Sub

    Function GetControlByName(ctrls As IEnumerable(Of Control), name As String)
        For Each ctrl As Control In ctrls
            If ctrl.Name = name Then
                Return ctrl
            End If
        Next
        Return False
    End Function

    Function GetPartialList(arr As ArrayList, startIndex As Integer, lastIndex As Integer) As ArrayList
        Dim partialArray As New ArrayList
        For i = startIndex To lastIndex
            partialArray.Add(arr(i))
        Next
        Return partialArray
    End Function

    Function GetRounds(questions As ArrayList) As List(Of ArrayList)
        Return New List(Of ArrayList) From {
            GetPartialList(arr:=questions, startIndex:=0, lastIndex:=19),
            GetPartialList(arr:=questions, startIndex:=20, lastIndex:=39),
            GetPartialList(arr:=questions, startIndex:=40, lastIndex:=59),
            GetPartialList(arr:=questions, startIndex:=60, lastIndex:=questions.Count - 1)}
    End Function

    Function RandomiseOptions(question As Array) As Array
        Dim options As New ArrayList()
        For j = 1 To 4
            options.Add(question(j))
        Next
        Call ShuffleArray(arr:=options)
        options.Add(question(5))
        For j = 1 To 4
            question(j) = options(j - 1)
        Next
        Return question
    End Function

    Function GetQuestions(path As String) As ArrayList
        Dim questions As New ArrayList()
        Using MyReader As New FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                questions.Add(MyReader.ReadFields())
            End While
        End Using
        'Call ShuffleArray(arr:=questions)
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

End Module
