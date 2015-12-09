Public Class Form1
    REM friday 8:00
    REM avoid gloabl variables
    Private users As Array
    Private numtries As Integer
    Private Sub login(user As String)
        Error_Label.Text = "welcome " + user
        Form2.BringToFront()

    End Sub
    Public Function validuser(u As String) As Boolean
        If u = "" Then
            Return False
        End If
        For index = 0 To users.Length - 1
            If users(index) = u Then
                Return True
            End If

        Next
        Return False
    End Function
    Private Sub login_click(sender As Object, e As EventArgs) Handles Button1.Click
        If Password_Text.Text = "" Or User_Text.Text = "" Then
            MessageBox.Show("You must enter a password and username")
        Else
            If validuser(User_Text.Text) Then
                login(User_Text.Text)
            Else
                Error_Label.Text = "No such user. Failed attempts: " + numtries.ToString()
                numtries = numtries + 1
            End If
            If numtries > 5 Then
                Close()
            End If
        End If

        REM dont clear the text boxes, that's super annoying
        REM if we did want to we would run the textboxobject.Clear() method
        REM dont grab users focus, that's jaring

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
        User_Text.Focus()

    End Sub
End Class
