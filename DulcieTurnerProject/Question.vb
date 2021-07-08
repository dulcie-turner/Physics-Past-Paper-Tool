Imports System.Data
Imports System.Data.SqlClient
Public Class Question
    Dim id As String

    Dim questionFilePath As String
    Dim msFilePath As String
    Dim erFilePath As String

    Dim isMultipleChoice As Boolean
    Dim multipleChoiceAnswer As Char

    Dim topic As String
    Dim subtopic As String

    Dim yearAppears As Integer
    Dim marksWorth As Integer

    Dim prevAnswers As List(Of Answer)


    Public Sub New(qID, qFP, msFP, erFP, isMC, mcA, qTopic, qSubtopic, yAppears, mW, noPreviousAnswers)
        id = qID

        questionFilePath = qFP
        msFilePath = msFP
        erFilePath = erFP

        isMultipleChoice = isMC
        multipleChoiceAnswer = mcA

        topic = qTopic
        subtopic = qSubtopic

        yearAppears = yAppears
        marksWorth = mW

        ' these are stored in the Answer table of the database
        ' only get previous answers if they are required
        If noPreviousAnswers = False Then
            prevAnswers = getPreviousAnswersFromDB()
        End If

    End Sub
    Private Function getPreviousAnswersFromDB()
        Dim tempAList = New List(Of Answer)

        ' create SQL query with placeholder
        Dim sqlQuery As String = "SELECT * FROM Answer WHERE questionForeignID = @id"

        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")

        ' set up SQL command + fill placeholders with data
        Dim command As New SqlCommand()
        With command
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@id", id)
        End With

        ' try and execute command
        ' otherwise display error message
        Try
            command.Connection.Open()
            Using reader As SqlClient.SqlDataReader = command.ExecuteReader
                ' loop through all returned records 
                While reader.Read
                    ' convert each record to Answer + add to list
                    tempAList.Add(New Answer(reader("paperForeignID"),
                    reader("questionForeignID"), reader("answerText"), reader("answerComments"),
                    CInt(reader("marksAchieved")), CInt(reader("timeTaken"))))
                End While
            End Using
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try
        connection.Close()

        Return tempAList
    End Function

    Public Function getMarks()
        Return marksWorth
    End Function

    Public Function getPrevAnswers()
        Return prevAnswers
    End Function

    Public Function getID()
        Return id
    End Function

    Public Function getQFP()
        Return questionFilePath
    End Function

    Public Function getMFP()
        Return msFilePath
    End Function

    Public Function getEFP()
        Return erFilePath
    End Function

    Public Function isMC()
        Return isMultipleChoice
    End Function

    Public Function getMCQAns()
        If isMultipleChoice Then
            Return multipleChoiceAnswer
        Else
            Return -1
        End If
    End Function

    Public Function getTopic()
        Return topic
    End Function
End Class
