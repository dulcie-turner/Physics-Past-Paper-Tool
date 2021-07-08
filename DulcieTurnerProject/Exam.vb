Imports System.Data
Imports System.Data.SqlClient
Public Class Exam
    Dim questionList As New List(Of Question)
    Dim answerList As New List(Of Answer)

    Dim numMarksTotal As Integer
    Dim numMarksAchieved As Integer
    Dim marksRunningTotal = 0

    Dim topicArray() As String

    Dim dateStarted As Date

    Dim totalTime As Integer
    Dim answerTimes() As Integer

    Dim paperID As Integer

    Dim createdSuccessfully = False

    Public Sub New(totalMarks, topics)
        ' subroutine to create a brand new exam
        dateStarted = Date.Today()

        numMarksTotal = totalMarks
        topicArray = topics

        marksRunningTotal = 0

        selectExamQuestions()
        If createdSuccessfully Then
            For i As Integer = 0 To questionList.Count - 1
                answerList.Add(New Answer(questionList(i).getID()))
            Next
        End If
    End Sub

    Public Sub New(totM, achM, dat, totTime, id)
        ' subroutine to load an old exam
        numMarksTotal = totM
        numMarksAchieved = achM
        dateStarted = dat
        totalTime = totTime
        paperID = id

        ' load all answers from the database
        answerList = getAllAnswersFromDB()

        ' for each answer, load its question and its time taken
        Dim count = 0
        answerTimes = New Integer(answerList.Count) {}

        For Each answer In answerList
            questionList.Add(getQuestionByID(answer.getQuestionID()))
            answerTimes(count) = answer.getTimeTaken()
            count += 1
        Next


    End Sub


    Private Function shuffleList(ByVal l As List(Of Question))
        Dim index As Integer
        Dim temp As Question

        Dim randomGen As New System.Random()


        For i As Integer = 0 To l.Count() - 1
            ' loop through the list and swap values randomly
            index = Int(randomGen.Next(0, l.Count()))
            temp = l(i)
            l(i) = l(index)
            l(index) = temp
        Next
        Return l
    End Function

    Public Sub selectExamQuestions()
        ' get list of all possible questions for the selected topics
        Dim tempQuestionList = New List(Of Question)
        For Each topic In topicArray
            ' join the list of retrieved questions to the list of questions
            tempQuestionList.AddRange(getQuestionsByTopic(topic))
        Next

        ' sum up total marks for topics selected
        Dim tempTotal = 0
        For Each q In tempQuestionList
            tempTotal += q.getMarks()
        Next

        ' don't create exam if not enough questions
        If tempTotal < numMarksTotal Then
            MsgBox("There is a total of " & tempTotal & " marks worth of questions in these topics, but you want an exam with " & numMarksTotal & " marks. Either reduce the length of the exam or select more topics.")
        Else
            ' shuffle list of questions to select from
            tempQuestionList = shuffleList(tempQuestionList)

            ' select questions from the list
            Dim paperList = selectDifficultQuestions(tempQuestionList)
            paperList = selectRemainingQuestions(paperList, tempQuestionList)


            shuffleList(paperList)

                questionList = paperList
                answerList = New List(Of Answer)

                numMarksTotal = 0
                For Each question In questionList
                    numMarksTotal += question.getMarks
                Next

                createdSuccessfully = True
            End If

    End Sub

    Private Function selectDifficultQuestions(ByRef questionSource As List(Of Question))

        Dim questionIterator As New List(Of Question)(questionSource)
        Dim selectedQuestions = New List(Of Question)

        For Each question In questionIterator
            ' if exam paper not full
            If marksRunningTotal < numMarksTotal Then
                ' if it has previous answers
                If question.getPrevAnswers.count() > 0 Then

                    Dim tempPrevAnswers = question.getPrevAnswers
                    Dim marksAchieved = tempPrevAnswers(tempPrevAnswers.count() - 1).returnMarksAchieved()

                    If Not marksAchieved = question.getMarks() Then
                        ' if the latest answer is not correct, add to list
                        selectedQuestions.Add(question)
                        marksRunningTotal += question.getMarks
                        questionSource.Remove(question)
                    End If
                End If
            End If
        Next
        Return selectedQuestions
    End Function

    Private Function selectRemainingQuestions(selectedQList As List(Of Question), questionSource As List(Of Question))

        For Each question In questionSource
            ' if exam paper not full
            If marksRunningTotal < numMarksTotal Then
                Dim toAdd = True
                ' if it has previous answers
                If question.getPrevAnswers.count() > 0 Then
                    Dim tempPrevAnswers = question.getPrevAnswers

                    For Each answer In tempPrevAnswers
                        If answer.returnMarksAchieved() = question.getMarks() Then
                            ' if answered correctly in past week
                            If DateDiff(DateInterval.DayOfYear, answer.getDate(), DateAndTime.Now) <= 7 Then
                                ' able to choose whether to exclude the correct answers or not
                                ' otherwise errors would be caused if all answers in topic are correct
                                toAdd = False

                            End If
                        End If
                    Next
                End If

                If toAdd Then
                    ' if fitting criteria, add to list
                    selectedQList.Add(question)
                    marksRunningTotal += question.getMarks
                End If

            End If
        Next

        ' this bit of code is to stop errors
        ' since if there aren't enough questions (that haven't been answered correctly recently)
        ' it could end up with an empty exam
        ' so it iterates and, while the exam still isn't full, adds the recently correct ones
        For Each question In questionSource
            If marksRunningTotal < numMarksTotal Then
                Dim toAdd = False
                If question.getPrevAnswers.count() > 0 Then
                    Dim tempPrevAnswers = question.getPrevAnswers
                    For Each answer In tempPrevAnswers
                        If answer.returnMarksAchieved() = question.getMarks() Then
                            If DateDiff(DateInterval.DayOfYear, answer.getDate(), DateAndTime.Now) <= 7 Then
                                toAdd = True
                            End If
                        End If
                    Next
                End If
                If toAdd Then
                    selectedQList.Add(question)
                    marksRunningTotal += question.getMarks
                End If
            End If
        Next

        Return selectedQList
    End Function

    Private Function getQuestionsByTopic(t As String)
        Dim tempQList = New List(Of Question)

        ' create SQL query with placeholder
        Dim sqlQuery As String = "SELECT * FROM Question WHERE subtopic = @topic"

        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")

        ' set up SQL command + fill placeholders with data
        Dim command As New SqlCommand()
        With command
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@topic", t)
        End With

        ' try and execute command
        ' otherwise display error message
        Try
            command.Connection.Open()
            Using reader As SqlClient.SqlDataReader = command.ExecuteReader
                ' loop through all returned records 
                While reader.Read
                    ' convert each record to Question + add to list
                    tempQList.Add(New Question(reader("questionID"),
                    reader("questionFilePath"), reader("markSchemeFilePath"), reader("examinerReportFilePath"),
                    reader("isMultipleChoice"), reader("multipleChoiceAnswer"), reader("topic"), reader("subtopic"),
                    reader("yearAppears"), reader("marksWorth"), False))
                End While
            End Using
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try
        connection.Close()

        Return tempQList
    End Function

    Public Function isCreatedSuccessfully()
        Return createdSuccessfully
    End Function

    Public Sub resetTimes()
        totalTime = 0
        answerTimes = New Integer(questionList.Count) {}
        For i As Integer = 0 To questionList.Count - 1
            answerTimes(i) = 0
        Next
    End Sub

    Public Sub incrementTimes(ind)
        ' increment the total time + the time on a specific q
        totalTime += 1
        answerTimes(ind) += 1
    End Sub

    Public Function getTotalTime()
        Return totalTime
    End Function

    Public Function getAnswerList()
        Return answerList
    End Function

    Public Function getQuestionList()
        Return questionList
    End Function

    Public Function getQuestionTime(ind)
        Return answerTimes(ind)
    End Function

    Public Function getExamSize()
        Return questionList.Count
    End Function

    Public Function getTotalNumMarks()
        Return numMarksTotal
    End Function

    Public Function getQuestionByIndex(ind)
        Return questionList(ind)
    End Function

    Public Function getMarksAchieved(ind)
        Return answerList(ind).returnMarksAchieved()
    End Function

    Public Function getTotalMarksAchieved()
        Dim total = 0
        For Each ans In answerList
            total += ans.returnMarksAchieved
        Next
        Return total
    End Function

    Public Sub setMarksAchieved(ind, val)
        answerList(ind).updateMarksAchieved(val)
    End Sub
    Public Sub setAnswerText(ind, val)
        answerList(ind).updateAnswerText(val)
    End Sub

    Public Sub setAnswerComment(ind, val)
        answerList(ind).updateAnswerComment(val)
    End Sub

    Public Function getAnswerText(ind)
        Return answerList(ind).getText()
    End Function

    Public Function getAnswerComment(ind)
        Return answerList(ind).getComment()
    End Function

    Public Function getDateStarted()
        Return dateStarted
    End Function

    Private Function getAllAnswersFromDB()
        Dim tempAList = New List(Of Answer)
        '
        ' create SQL query with placeholder
        Dim sqlQuery As String = "SELECT * FROM Answer WHERE paperForeignID = @id"

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
        '' otherwise display error message
        Try
            command.Connection.Open() '(totM, achM, dat, totTime)
            Using reader As SqlClient.SqlDataReader = command.ExecuteReader
                '' loop through all returned records 
                While reader.Read
                    ' convert each record to Answer + add to list
                    tempAList.Add(New Answer(reader("paperForeignID"),
                  reader("questionForeignID"), reader("answerText"), reader("answerComments"),
                    reader("marksAchieved"), reader("timeTaken"), dateStarted))
                End While
            End Using
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try
        connection.Close()

        Return tempAList
    End Function

    Private Function getQuestionByID(idInput As Integer)
        Dim tempQ

        ' create SQL query with placeholder
        Dim sqlQuery As String = "SELECT * FROM Question WHERE questionID = @id"

        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")

        ' set up SQL command + fill placeholders with data
        Dim command As New SqlCommand()
        With command
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@id", idInput)
        End With

        ' try and execute command
        '' otherwise display error message
        Try
            command.Connection.Open() '(totM, achM, dat, totTime)
            Using reader As SqlClient.SqlDataReader = command.ExecuteReader
                '' loop through all returned records 
                While reader.Read
                    ' convert each record to Question + add to list
                    tempQ = New Question(reader("questionID"),
                  reader("questionFilePath"), reader("markSchemeFilePath"), reader("examinerReportFilePath"),
                    reader("isMultipleChoice"), reader("multipleChoiceAnswer"), reader("topic"), reader("subtopic"),
                    reader("yearAppears"), reader("marksWorth"), True)
                End While
            End Using
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try
        connection.Close()

        Return tempQ
    End Function
End Class
