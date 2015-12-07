Public Class Form1

    Private users As Array
    Private numtries As Integer
    Public Function validuser(u As String) As Boolean
        For index = 1 To users.Length
            If users(index)==u
                Return True
            End If

        Next
        Return False
    End Function
    Private Sub login_click(sender As Object, e As EventArgs) Handles Button1.Click
        If validuser(User_Text.Text) Then
            Error_Label.Text = "welcome " + User_Text.Text
        Else
            Error_Label.Text = "no such user"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numtries = 0
        Dim logins(1) As String
        Dim i As Integer
        i = 0
        FileOpen(1, "MASTERFILE.txt", OpenMode.Input)
        Do While Not EOF(1)
            logins(i) = LineInput(1)
            i = i + 1
            ReDim Preserve logins(i)
        Loop
        FileClose(1)
        users = logins

    End Sub
End Class
