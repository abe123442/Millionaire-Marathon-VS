Module GameDataModule

    Function GetPartialList(arr As ArrayList, startIndex As Integer, lastIndex As Integer) As ArrayList
        ' A function that returns an arraylist that is part of the "arr" arraylist
        Dim partialArray As New ArrayList
        For i = startIndex To lastIndex
            partialArray.Add(arr(i))
        Next
        Return partialArray
    End Function

    Function GetRounds(questions As ArrayList) As List(Of ArrayList)
        ' A function that returns a list of 4 partial arraylists
        Return New List(Of ArrayList) From {
            GetPartialList(questions, 0, 19),
            GetPartialList(questions, 20, 39),
            GetPartialList(questions, 40, 59),
            GetPartialList(questions, 60, questions.Count - 1)}
    End Function

    Function RandomiseOptions(question As Array) As Array
        ' A function that randomises the text of each option button for every new question in "FrmGame"
        Dim options As New ArrayList()
        For j = 1 To 4
            options.Add(question(j))
        Next
        Call ShuffleArray(options)
        options.Add(question(5))
        For j = 1 To 4
            question(j) = options(j - 1)
        Next
        Return question
    End Function

    Function GetQuestions(path As String) As ArrayList
        ' A function that reads text from a file separated by commas
        Dim questions As New ArrayList()
        Using MyReader As New FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                questions.Add(MyReader.ReadFields())
            End While
        End Using
        'Call ShuffleArray(questions)
        Return questions
    End Function

    Sub ShuffleArray(arr As ArrayList)
        ' A subroutine that returns a randomised "arr" arraylist, by using the "Fisher–Yates shuffle" algorithm
        ' which generates a random permutation of a finite sequence (in this case, an "ArrayList")
        Dim lastIndex As Integer = arr.Count - 1
        Dim randIndex As Integer
        Dim randGen As New Random

        While lastIndex > 0
            randIndex = randGen.Next(0, arr.Count)
            Dim temp = arr(lastIndex)
            arr(lastIndex) = arr(randIndex)
            arr(randIndex) = temp
            lastIndex -= 1
        End While
    End Sub

End Module
