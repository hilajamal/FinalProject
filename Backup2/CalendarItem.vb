Public Class CalendarItem
    Dim _day As String
    Public Sub New(ByVal day As String)
        _day = day
    End Sub

    Public Property Day() As String
        Get
            Return _day
        End Get
        Set(ByVal value As String)
            _day = value
        End Set
    End Property


    Public ReadOnly Property IsEnabled() As Boolean
        Get
            If (String.IsNullOrEmpty(_day)) Then
                Return True
            Else
                If (IsNumeric(_day)) Then
                    Return True
                End If
            End If
            Return False
        End Get
    End Property

End Class
