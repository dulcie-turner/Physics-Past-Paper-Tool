Imports System.Data
Imports System.Data.SqlClient
Public Class Answer
    Dim questionID As String
    Dim paperID As String
    Dim answerText As String = ""
    Dim answerComment As String = ""

    Dim timeTaken As Integer
    Dim marksAchieved As Integer
    Dim dateMade As Date

    Public Sub New(id As String)
        ' for answers created as the program is running
        questionID = id
    End Sub
    Public Sub New(pID As String, qID As String, answerT As String, answerC As String, marksA As Integer, t As Integer)
        ' for answers retrieved from the database
        paperID = pID
        questionID = qID
        answerText = answerT
        answerComment = answerC

        marksAchieved = marksA
        timeTaken = t

        ' since this is stored in the Paper table, not the Answer one
        dateMade = getDateFromDB()
    End Sub

    Public Sub New(pID As String, qID As String, answerT As String, answerC As String, marksA As Integer, t As Integer, d As Date)
        ' for answers retrieved from the database
        ' this constructor will be used when generating the answers from the paper
        ' as opposed to generating answers from the question
        ' since the paper already has the date there is no point retrieving it again
        paperID = pID
        questionID = qID
        answerText = answerT
        answerComment = answerC

        marksAchieved = marksA
        timeTaken = t

        dateMade = d
    End Sub

    Public Sub updateAnswerText(answerT As String)
        answerText = answerT
    End Sub

    Public Function getText()
        Return answerText
    End Function

    Public Sub updateAnswerComment(answerC As String)
        answerComment = answerC
    End Sub

    Public Function getComment()
        Return answerComment
    End Function

    Public Sub updateMarksAchieved(marksA As Integer)
        marksAchieved = marksA
    End Sub

    Public Sub updateDate(d As Date)
        dateMade = d
    End Sub

    Public Function getDate()
        Return dateMade
    End Function

    Public Function getTimeTaken()
        Return timeTaken
    End Function

    Public Function returnMarksAchieved()
        Return marksAchieved
    End Function

    Public Sub updateTime(t As Integer)
        timeTaken = t
    End Sub

    Private Function getDateFromDB()

        ' create SQL query with placeholder
        Dim sqlQuery As String = "SELECT dateStarted FROM Paper WHERE paperID = @id"

        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")

        ' set up SQL command + fill placeholders with data
        Dim command As New SqlCommand()
        With command
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@id", paperID)
        End With

        ' try and execute command
        ' otherwise display error message
        Try
            command.Connection.Open()
            Using reader As SqlClient.SqlDataReader = command.ExecuteReader
                ' return the date of the answer
                While reader.Read
                    Return reader("dateStarted")
                End While
            End Using
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try
        connection.Close()
        Return 0
    End Function

    Public Function getQuestionID()
        Return questionID
    End Function
End Class
