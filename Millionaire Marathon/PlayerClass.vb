Public Class PlayerClass
    Property Name As String
    Property Money As Integer = 0
    Property Qansd As Integer = 0
    Property Passes As Integer = 5

    ' placeholder constructor method
    Sub New()

    End Sub

    ' main constructor method
    Sub New(name As String)
        Me.Name = name
    End Sub
End Class