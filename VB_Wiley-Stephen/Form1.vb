Public Class Form1
    REM friday 8:00
    REM avoid gloabl variables
    Private users As Array
    Private numtries As Integer
    Private verified As Boolean
    Private Sub login(user As String)
        Error_Label.Text = "welcome " + user
        verified = True
        Form2.BringToFront()

    End Sub
    REM Methods should have access specifiers. no other section of the code needs this so it should be private
    Public Function validuser(u As String, p As String) As Boolean
        If u = "" Then
            Return False
        End If
        Dim query = From line In IO.File.ReadAllLines("Masterfile.TXT")
                    Where line = u & "_" & p
                    Select line
        If query.Count > 0 Then
            Return True
        Else
            Return False
        End If
        'For index = 0 To users.Length - 1
        '    If users(index) = u Then
        '        Return True
        '    End If

        'Next
        Return False
    End Function
    Private Sub login_click(sender As Object, e As EventArgs) Handles Button1.Click
        If Password_Text.Text = "" Or User_Text.Text = "" Then
            MessageBox.Show("You must enter a password and username")
        Else
            If validuser(User_Text.Text, Password_Text.Text) Then
                login(User_Text.Text)
            Else
                Error_Label.Text = "No such user,password combination. Failed attempts: " + numtries.ToString()
                numtries = numtries + 1
            End If
            If numtries > 3 Then
                REM error messages should describe the problem
                MessageBox.Show("Number of allowed attempts exceded.")
                REM modal dialog boxes are jaring and should be avoided
                Close()
                REM the Me object seems to be the visual basic analog to the "this" object. 
                REM If this is true then Me.close() will typically does the same thing
                REM as close() on it's own so Me.close() is not really necesary here
                REM this works because all of these are methods of the Form1 class so Me.Close() or just Close()
                REM really means Form1.Close()
            End If
        End If

        REM dont clear the text boxes, that's super annoying
        REM if we did want to we would run the textboxobject.Clear() method
        REM dont steal focus, that's jaring

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
        verified = False

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        REM for next semester: go to the designer -> select the form -> events ->  double click FormClosing
        If Not verified Then
            MessageBox.Show("login fialed")
        Else

        End If
    End Sub
End Class
