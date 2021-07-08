Public Class answerExam
    Dim exam As Exam
    Dim selectedQ As Integer = 0
    Dim examSize As Integer

    Dim answerFillerText = "Add an answer..."

    Dim isCountdown As Boolean
    Dim countdownTime = 0

    Dim picBox As PictureBox


    Public Sub setup(ByRef exObject, cTime)
        ' initialise exam on countdown mode
        If (cTime > 0) Then
            isCountdown = True
            countdownTime = cTime
        Else
            isCountdown = False
        End If

        ' set up the form
        Me.Show()
        exam = exObject
        exam.resetTimes()
        examSize = exam.getExamSize()
        answerBox.Text = answerFillerText

        totalTime.TextAlign = ContentAlignment.BottomCenter
        qTime.TextAlign = ContentAlignment.TopCenter
        selectedQ = 0
        displayInterface()

        timer.Enabled = True
    End Sub


    Private Sub displayInterface()
        ' for displaying the form
        timeButton.Enabled = False

        displayButtons()
        displayQuestionNumber()
        displayImage()

        answerBox.Focus()

    End Sub

    Private Sub displayButtons()
        ' only show prev button if not first
        If selectedQ <> 0 Then
            prevButton.Show()
        Else
            prevButton.Hide()
        End If
        ' only show next button if not last
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

    Private Sub displayImage()
        ' display image + adjust size
        Dim imageFP = System.IO.Directory.GetCurrentDirectory() & "\" & exam.getQuestionByIndex(selectedQ).getQFP

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

    Private Sub answerExam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' if next button pressed, move to next question
        selectedQ += 1
        displayInterface()
        answerBox.Text = exam.getAnswerText(selectedQ)
    End Sub

    Private Sub prevButton_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        ' if prev button pressed, move to prev question
        selectedQ -= 1
        displayInterface()
        answerBox.Text = exam.getAnswerText(selectedQ)
    End Sub

    Private Sub answerBox_TextChanged(sender As Object, e As EventArgs) Handles answerBox.TextChanged
        ' save the answer text box contents to the relevant answer object
        If Not answerBox.Text = answerFillerText Then exam.setAnswerText(selectedQ, answerBox.Text)
    End Sub

    Private Sub timePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles timePanel.MouseMove
        ' if hover over panel, hide button
        timeButton.Hide()
    End Sub

    Private Sub timePanel_MouseLeave(sender As Object, e As EventArgs) Handles timePanel.MouseLeave
        ' if not hovering over panel, show button
        timeButton.Show()
    End Sub


    Private Sub qTime_MouseMove(sender As Object, e As EventArgs) Handles qTime.MouseMove
        timeButton.Hide()
    End Sub

    Private Sub qTime_MouseLeave(sender As Object, e As EventArgs) Handles qTime.MouseLeave
        timeButton.Show()
    End Sub

    Private Sub totalTime_MouseMove(sender As Object, e As EventArgs) Handles totalTime.MouseMove
        timeButton.Hide()
    End Sub

    Private Sub totalTime_MouseLeave(sender As Object, e As EventArgs) Handles totalTime.MouseLeave
        timeButton.Show()
    End Sub


    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' increment timer
        exam.incrementTimes(selectedQ)

        ' get the time taken
        Dim totalTimeSeconds = exam.getTotalTime
        Dim qT = exam.getQuestionTime(selectedQ)

        If (isCountdown) Then
            ' display the label as (startTime - timeTaken)
            ' so it counts down
            totalTime.Text = Math.Floor((countdownTime - totalTimeSeconds) / 3600).ToString.PadLeft(2, "0") & ":" & Math.Floor(((countdownTime - totalTimeSeconds) / 60) Mod 60).ToString.PadLeft(2, "0") & ":" & ((countdownTime - totalTimeSeconds) Mod 60).ToString.PadLeft(2, "0")
            ' give a 5 min reminder
            ' and stop exam if complete
            If (countdownTime - totalTimeSeconds = 300) Then
                MsgBox("5 minutes remaining!")
            ElseIf (countdownTime - totalTimeSeconds <= 0) Then
                timer.Enabled = False
                MsgBox("Exam Finished!")
                Me.Hide()
                markExam.setup(exam)
            End If
        Else
            ' display the label as (timeTaken)
            totalTime.Text = Math.Floor(totalTimeSeconds / 3600).ToString.PadLeft(2, "0") & ":" & Math.Floor((totalTimeSeconds / 60) Mod 60).ToString.PadLeft(2, "0") & ":" & (totalTimeSeconds Mod 60).ToString.PadLeft(2, "0")
        End If
        qTime.Text = "Q" & (selectedQ + 1) & " : " & Math.Floor(qT / 3600).ToString.PadLeft(2, "0") & ":" & Math.Floor((qT / 60) Mod 60).ToString.PadLeft(2, "0") & ":" & (qT Mod 60).ToString.PadLeft(2, "0")

        totalTime.TextAlign = ContentAlignment.BottomCenter
        qTime.TextAlign = ContentAlignment.TopCenter
    End Sub



    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim userAnswer = MessageBox.Show("Do you want to end the exam?", "", MessageBoxButtons.YesNo)
        If userAnswer = DialogResult.Yes Then
            Me.Hide()
            timer.Enabled = False
            markExam.setup(exam)
        End If
    End Sub

    Private Sub answerBox_Click(sender As Object, e As EventArgs) Handles answerBox.Click
        If answerBox.Text = answerFillerText Then
            answerBox.Text = ""
        End If
    End Sub
End Class