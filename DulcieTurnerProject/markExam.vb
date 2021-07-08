Imports System.Data
Imports System.Data.SqlClient

Public Class markExam
    Dim exam As Exam
    Dim selectedQ As Integer
    Dim examSize As Integer

    Dim currentQItem As Question

    Dim averageTimePerMark As Double
    Dim qTime As Integer
    Dim qTimeFormat As String
    Dim avgTimeForQ As Double

    Dim valueBeingChanged = False

    Dim picBox As PictureBox

    Public Sub setup(ByRef exObject)
        markingPanel.Controls.Remove(finalReviewPanel)
        markingPanel.Visible = True
        Me.Controls.Add(finalReviewPanel)
        finalReviewPanel.Visible = False

        ' set up the form
        Me.Show()

        exam = exObject
        examSize = exam.getExamSize()

        averageTimePerMark = getAverageTime()

        selectedQ = 0
        currentQItem = exam.getQuestionByIndex(selectedQ)
        displayInterface()

    End Sub

    Private Function getAverageTime()
        Return exam.getTotalTime / exam.getTotalNumMarks
    End Function

    Private Sub displayInterface()
        ' for displaying the form

        displayButtons()
        displayQuestionNumber()
        ' display question image first
        displayImage(currentQItem.getQFP)

        displayTimes()

        commentTxtBox.Focus()
        commentTxtBox.Text = exam.getAnswerComment(selectedQ)
        ansTxtBox.Text = exam.getAnswerText(selectedQ)

        setupMarks()


        ' only show button to select examiner report if there is one available
        ' didn't do this for mark scheme or question since every q has one of those
        If currentQItem.getEFP.length < 5 Then
            erButton.Enabled = False
        Else
            erButton.Enabled = True
        End If

        ' only enable button to look at previous answers if there are previous answers to look at
        If currentQItem.getPrevAnswers.count = 0 Then
            prevAnsButton.Enabled = False
        Else
            prevAnsButton.Enabled = True
        End If
    End Sub

    Private Sub setupMarks()
        ' show how many marks out of
        marksLabel.Text = "/ " & currentQItem.getMarks()

        ' because otherwise it could crash
        ' eg going from question worth 3 marks to one worth 7
        ' trying to put 7 in the box would break it
        numMarksBox.Maximum = 10000

        valueBeingChanged = True
        numMarksBox.Value = exam.getMarksAchieved(selectedQ)
        numMarksBox.Text = numMarksBox.Value
        valueBeingChanged = False

        ' set maximum and fill box with previous saved value
        numMarksBox.Maximum = currentQItem.getMarks()



    End Sub

    Private Sub displayTimes()
        ' display upper label
        qTime = exam.getQuestionTime(selectedQ)
        qTimeFormat = Math.Floor(qTime / 3600).ToString.PadLeft(2, "0") & ":" & Math.Floor((qTime / 60) Mod 60).ToString.PadLeft(2, "0") & ":" & (qTime Mod 60).ToString.PadLeft(2, "0")
        qTimeLabel.Text = "Time taken : " & qTimeFormat

        ' display lower label
        ' compare actual time taken with (avg time per mark * number of marks)
        avgTimeForQ = averageTimePerMark * currentQItem.getMarks()
        If qTime < avgTimeForQ Then
            qCompareLabel.Text = "This was " & 100 - Int((qTime / avgTimeForQ) * 100) & "% shorter than average"
        ElseIf qTime = avgTimeForQ Then
            qCompareLabel.Text = "This was average"
        Else
            qCompareLabel.Text = "This was " & Int((qTime / avgTimeForQ) * 100) - 100 & "% longer than average"
        End If
    End Sub

    Private Sub displayButtons()
        ' only show prev button if not first
        If selectedQ <> 0 Then
            prevButton.Show()
        Else
            prevButton.Hide()
        End If
        ' only show next button if not last
        ' else show submit
        If selectedQ <> examSize - 1 Then
            nextButton.Show()
            submitButton.Hide()
        Else
            nextButton.Hide()
            submitButton.Show()
        End If
    End Sub

    Private Sub displayQuestionNumber()
        ' show which question it is
        questionGroupBox.Text = "Question " & (selectedQ + 1) & " out of " & (examSize)
    End Sub

    Private Sub displayImage(fp As String)
        ' display image + adjust size
        Dim imageFP = System.IO.Directory.GetCurrentDirectory() & "\" & fp

        ' place the picture box inside an autoscrolling panel so the image can be scrolled
        Dim picPanel = New Panel
        picPanel.Width = questionGroupBox.Size.Width - 10
        picPanel.Height = questionGroupBox.Size.Height - 25
        picPanel.Top += 20
        picPanel.Left += 5
        picPanel.AutoScroll = True

        picBox = New PictureBox
        picBox.Dock = DockStyle.None
        picBox.Image = Image.FromFile(imageFP)
        picBox.SizeMode = PictureBoxSizeMode.AutoSize

        picPanel.Controls.Add(picBox)

        questionGroupBox.Controls.Clear()
        questionGroupBox.Controls.Add(picPanel)
    End Sub

    Private Sub markExam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' if next button pressed, move to next question
        selectedQ += 1
        currentQItem = exam.getQuestionByIndex(selectedQ)
        displayInterface()

    End Sub

    Private Sub prevButton_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        ' if prev button pressed, move to prev question
        selectedQ -= 1
        currentQItem = exam.getQuestionByIndex(selectedQ)
        displayInterface()
    End Sub

    Private Sub commentTxtBox_TextChanged(sender As Object, e As EventArgs) Handles commentTxtBox.TextChanged
        ' always save the answer text box contents to the relevant answer object
        exam.setAnswerComment(selectedQ, commentTxtBox.Text)
    End Sub

    Private Sub numMarksBox_ValueChanged(sender As Object, e As EventArgs) Handles numMarksBox.ValueChanged
        ' save number of marks achieved
        If Not valueBeingChanged Then
            exam.setMarksAchieved(selectedQ, numMarksBox.Value)
        End If
    End Sub

    Private Sub qButton_Click(sender As Object, e As EventArgs) Handles qButton.Click
        displayImage(currentQItem.getQFP)
    End Sub

    Private Sub msButton_Click(sender As Object, e As EventArgs) Handles msButton.Click
        If currentQItem.isMC Then
            ' if multiple choice
            ' get rid of images in box
            ' display answer as text
            questionGroupBox.Controls.Clear()
            questionGroupBox.Controls.Add(mcqAnsLabel)
            mcqAnsLabel.Text = currentQItem.getMCQAns
            mcqAnsLabel.Visible = True
        Else
            ' display answer as image
            mcqAnsLabel.Visible = False
            displayImage(currentQItem.getMFP)
        End If

    End Sub

    Private Sub erButton_Click(sender As Object, e As EventArgs) Handles erButton.Click
        displayImage(currentQItem.getEFP)
    End Sub

    Private Sub prevAnsButton_Click(sender As Object, e As EventArgs) Handles prevAnsButton.Click
        ' create + format the heading labels
        Dim headerText() = {"Date Taken", "Score", "Answer", "Answer Comment"}
        Dim headerLabels() = {New Label(), New Label(), New Label(), New Label()}
        For i = 0 To headerLabels.Length - 1
            headerLabels(i).Text = headerText(i)
            headerLabels(i).AutoSize = True
            headerLabels(i).Font = New Font("Sans Serif", 10, FontStyle.Bold)
        Next
        ' set up table
        questionGroupBox.Controls.Clear()
        answerTable.Controls.Clear()
        answerTable.RowCount = 0
        questionGroupBox.Controls.Add(tablePanel)
        ' reverse the list of answers since want later answers at the top
        Dim answerList = currentQItem.getPrevAnswers
        Dim reversedAnswerArray(answerList.count - 1) As Answer
        answerList.copyTo(reversedAnswerArray)
        Array.Reverse(reversedAnswerArray)
        ' for each row, add label showing date, marks achieved, answer and comment
        Dim cellLabels = New List(Of List(Of Label))
        For row As Integer = 0 To reversedAnswerArray.Length - 1
            cellLabels.Add(New List(Of Label))
            For col As Integer = 0 To 3
                cellLabels(row).Add(New Label)
            Next
            cellLabels(row)(0).Text = reversedAnswerArray(row).getDate
            cellLabels(row)(1).Text = reversedAnswerArray(row).returnMarksAchieved & " \ " & currentQItem.getMarks
            cellLabels(row)(2).Text = reversedAnswerArray(row).getText
            cellLabels(row)(3).Text = reversedAnswerArray(row).getComment
        Next
        ' add headings to table
        For Each label In headerLabels
            answerTable.Controls.Add(label)
        Next
        ' add each row to the table
        Dim columnCount
        For Each row In cellLabels
            answerTable.RowCount += 1
            columnCount = 0
            For Each cell In row
                ' this lets the cells expand vertically but not horizontally
                cell.AutoSize = True
                cell.MaximumSize = New Size((answerTable.ColumnStyles.Item(columnCount).Width * (answerTable.Width / 100)) - 5, 0)
                columnCount += 1
                answerTable.Controls.Add(cell)
            Next
        Next
    End Sub


    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim userAnswer = MessageBox.Show("Have you finished marking the exam?", "", MessageBoxButtons.YesNo)
        If userAnswer = DialogResult.Yes Then
            ' save to db
            Me.Cursor = Cursors.WaitCursor
            saveToDatabase()
            Me.Cursor = Cursors.Default
            displaySummary()
        End If
    End Sub

    Private Sub displaySummary()

        ' hide the rest of the form
        markingPanel.Controls.Remove(finalReviewPanel)
        markingPanel.Visible = False
        Me.Controls.Add(finalReviewPanel)

        ' set up the labels
        finalMarkLabel.Text = "You got " & exam.getTotalMarksAchieved & " out of " & exam.getTotalNumMarks & " correct!"
        finalMarkLabel.Text += Environment.NewLine & "The final percentage is " & CInt((exam.getTotalMarksAchieved / exam.getTotalNumMarks) * 100) & "%"
        finalTimeLabel.Text = "You completed the exam in " & Math.Floor(exam.getTotalTime / 3600).ToString.PadLeft(2, "0") & ":" & Math.Floor((exam.getTotalTime / 60) Mod 60).ToString.PadLeft(2, "0") & ":" & (exam.getTotalTime Mod 60).ToString.PadLeft(2, "0")

        finalReviewPanel.Visible = True
    End Sub


    Private Sub saveToDatabase()
        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")
        Dim command = New SqlCommand()
        Dim paperForeignID

        command.CommandType = CommandType.Text
        command.Connection = connection


        ' open connection
        Try
            connection.Open()
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try

        ' save paper in db
        Dim sqlQuery As String = "INSERT INTO Paper (dateStarted, timeTaken, marksAchieved, marksAvailable) "
        sqlQuery += "VALUES (@dateS, @timeT, @marksAch, @marksAv)"
        With command
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@dateS", exam.getDateStarted())
            .Parameters.AddWithValue("@timeT", exam.getTotalTime())
            .Parameters.AddWithValue("@marksAch", exam.getTotalMarksAchieved())
            .Parameters.AddWithValue("@marksAv", exam.getTotalNumMarks())
        End With
        Try
            command.ExecuteNonQuery()
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try

        ' get last generated paper id (for foreign key)
        ' need to retrieve it because it isn't generated by the code
        ' it's automatically generated by the sql server
        sqlQuery = "SELECT MAX(paperID) FROM Paper"
        ' set up SQL command
        command.CommandText = sqlQuery
        Try
            command.ExecuteNonQuery()
            paperForeignID = command.ExecuteScalar()
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try

        For i As Integer = 0 To examSize - 1
            ' save each answer in db
            sqlQuery = "INSERT INTO Answer "
            sqlQuery += "VALUES (@paID, @quID, @ansText, @ansComment, @timeForQ, @marksAc)"

            ' set up SQL command + fill placeholders with data
            With command
                .CommandText = sqlQuery
                .Parameters.AddWithValue("@paID", paperForeignID)
                .Parameters.AddWithValue("@quID", exam.getQuestionByIndex(i).getID())
                .Parameters.AddWithValue("@ansText", exam.getAnswerText(i))
                .Parameters.AddWithValue("@ansComment", exam.getAnswerComment(i))
                .Parameters.AddWithValue("@timeForQ", exam.getQuestionTime(i))
                .Parameters.AddWithValue("@marksAc", exam.getMarksAchieved(i))
            End With
            Try
                command.ExecuteNonQuery()
            Catch sqlEx As SqlException
                MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
            End Try


            command.Parameters.Clear()
        Next
        connection.Close()
        MsgBox("Paper Saved to Database")
    End Sub

    Private Sub mainMenuButton_Click(sender As Object, e As EventArgs) Handles mainMenuButton.Click
        Me.Hide()
        mainMenu.Show()
    End Sub
End Class