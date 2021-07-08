Public Class CreateExam
    Dim topicsList = mainMenu.getTopicList()
    Dim checkBoxArray As List(Of List(Of CheckBox))
    Dim labelArray
    Dim selectAction
    Dim yPosition

    Dim topicFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    Dim subtopicFont As New Font("Microsoft Sans Serif", 8, FontStyle.Italic)


    Public Sub displayInterface()
        ' show the form
        Me.Show()

        createExamGroupBox.Controls.Clear()
        labelArray = New List(Of Label)
        checkBoxArray = New List(Of List(Of CheckBox))
        ' define whether select all topics or deselect all
        selectAction = "all"
        yPosition = 0


        ' create scrollable panel
        Dim scrollPanel = New Panel
        scrollPanel.Show()
        scrollPanel.BackColor = Color.Transparent
        scrollPanel.AutoScroll = True
        scrollPanel.Dock = DockStyle.Fill
        createExamGroupBox.Controls.Add(scrollPanel)

        ' loop thru topics
        For Each row As List(Of String) In topicsList
            For Each item As String In row

                ' get indexes of topic
                Dim index1 = topicsList.indexOf(row)
                Dim index2 = row.IndexOf(item)

                If index2 = 0 Then
                    ' display as topic
                    ' create label
                    labelArray.Add(New Label)
                    labelArray(index1).Text = item
                    labelArray(index1).Location = New Point(10, yPosition)
                    labelArray(index1).AutoSize = True
                    labelArray(index1).Font = topicFont
                    scrollPanel.Controls.Add(labelArray(index1))

                    ' create checkbox
                    checkBoxArray.Add(New List(Of CheckBox)({New CheckBox}))
                    checkBoxArray(index1)(0).Location = New Point(350, yPosition)
                    checkBoxArray(index1)(0).AutoSize = True

                Else
                    ' display as subtopic
                    ' create checkbox
                    checkBoxArray(index1).Add(New CheckBox)
                    checkBoxArray(index1)(index2).Location = New Point(50, yPosition)
                    checkBoxArray(index1)(index2).AutoSize = True
                    checkBoxArray(index1)(index2).Text = item
                    checkBoxArray(index1)(index2).Font = subtopicFont

                End If

                ' set handler to tell if checked
                AddHandler checkBoxArray(index1)(index2).Click, AddressOf handleCheckboxes
                ' add name to checkboxes so they can be found in the array
                checkBoxArray(index1)(index2).Name = index1 & "," & index2

                ' add controls to form
                scrollPanel.Controls.Add(checkBoxArray(index1)(index2))

                yPosition += 20
            Next
        Next

        ' handle time per mark
        changeTimeText()
    End Sub

    Private Sub createExam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' close program properly
        Application.Exit()
    End Sub

    Private Sub handleCheckboxes(sender As Object, e As EventArgs)
        Dim index1 = -1
        Dim index2 = -1
        ' get the checkbox that fired the event
        Dim changedBox As CheckBox = CType(sender, CheckBox)

        ' get indexes of checked box
        For Each row In checkBoxArray
            For Each item In row
                If item.Name = changedBox.Name Then
                    index1 = item.Name.Split(",")(0)
                    index2 = item.Name.Split(",")(1)
                End If
            Next
        Next

        ' if topic clicked, then either select or unselect all of its subtopics
        If index2 = 0 Then
            For Each item In checkBoxArray(index1)
                item.Checked = changedBox.Checked
            Next
        Else
            ' if subtopic & selected then select its topic
            If changedBox.Checked = True Then
                checkBoxArray(index1)(0).Checked = True
            Else
                ' if subtopic and unselected    
                Dim toCheck = False
                For Each item In checkBoxArray(index1)
                    ' check if any other subtopic is selected
                    If item.Checked = True And checkBoxArray(index1).IndexOf(item) <> 0 Then
                        toCheck = True
                    End If
                Next
                ' if no subtopics are selected, deselect topic
                checkBoxArray(index1)(0).Checked = toCheck
            End If
        End If
    End Sub

    Private Sub selectAllButton_Click(sender As Object, e As EventArgs) Handles selectAllButton.Click
        ' loop through checkboxes
        For Each row As List(Of CheckBox) In checkBoxArray
            For Each check As CheckBox In row
                ' either select all or deselect all
                If selectAction = "all" Then
                    check.Checked = True
                Else
                    check.Checked = False
                End If
            Next
        Next
        ' toggle the action so it does the opposite next time
        If selectAction = "all" Then
            selectAction = "none"
        Else
            selectAction = "all"
        End If
    End Sub

    Private Function getTimePerMark()
        ' get papers from last 6 months
        Dim examList = getPapersByDate(Today.AddMonths(-6))
        ' if not sufficient data, return standard time per mark
        If examList.count < 3 Then
            Return 1.5
        Else
            ' get list of time per mark for each paper
            Dim timePerMarks = New List(Of Decimal)
            For Each exam In examList
                timePerMarks.Add(exam.getTotalTime() / exam.getTotalNumMarks())
            Next

            ' calculate median of list
            timePerMarks.Sort()
            ' if odd number of items in list
            If timePerMarks.Count Mod 2 = 0 Then
                ' return middle value of list
                Return timePerMarks((timePerMarks.Count - 1) / 2) / 60
            Else
                ' return average of middle two items
                Return (timePerMarks(timePerMarks.Count / 2) + timePerMarks((timePerMarks.Count / 2) - 1)) / 120
            End If

        End If
    End Function

    Private Sub changeTimeText()
        ' reset text box
        timeEstimate.Text = "This should take about "

        ' calculate total time then display
        Dim time = getTimePerMark() * numMarksSelector.Value
        If time >= 60 Then
            If time >= 120 Then
                timeEstimate.Text &= Int(time / 60) & " hours and " & Int(time Mod 60) & " minutes"
            Else
                timeEstimate.Text &= Int(time / 60) & " hour and " & Int(time Mod 60) & " minutes"
            End If
        Else
            timeEstimate.Text &= Int(time) & " minutes"
        End If
    End Sub


    Private Sub numMarksSelector_ValueChanged(sender As Object, e As EventArgs) Handles numMarksSelector.ValueChanged
        changeTimeText()
    End Sub

    Private Function validateData()
        ' check if at least one topic selected
        Dim testsPassed = 0
        For Each row In checkBoxArray
            For Each item In row
                If item.Checked = True Then
                    testsPassed = 1
                End If
            Next
        Next
        If testsPassed = 0 Then MsgBox("You must select at least one topic")

        ' check that the user hasn't deleted the number in the marks selector
        If numMarksSelector.Controls.Item(1).Text = "" Then
            MsgBox("You must enter a number of marks for the exam")
        Else
            testsPassed += 1
        End If

        ' if in countdown mode
        If countdownCheckBox.Checked Then
            ' check that the user hasn't deleted the number in the countdown selector
            If countdownUpDown.Controls.Item(1).Text = "" Then
                MsgBox("You must enter a time for the exam")
            Else
                testsPassed += 1
            End If
        Else
            testsPassed += 1
        End If
        Return testsPassed
    End Function

    Private Function getTopicArray()
        Dim tempList = New List(Of String)
        For Each row In checkBoxArray
            For Each value In row
                If value.Checked() Then
                    Dim index1 = checkBoxArray.IndexOf(row)
                    Dim index2 = row.IndexOf(value)
                    ' don't add topics to list
                    'since e.g.if a topic is selected but only two of its subtopics are
                    ' retrieveing by topic would get all of the subtopics, not just the ones wanted
                    If Not index2 = 0 Then
                        tempList.Add(topicsList(index1)(index2))
                    End If
                End If
            Next
        Next
        Return tempList.ToArray()
    End Function

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        If validateData() = 3 Then
            Me.Cursor = Cursors.WaitCursor
            Dim selectedTopicArray = getTopicArray()
            Dim exam = New Exam(numMarksSelector.Value, selectedTopicArray)

            If exam.isCreatedSuccessfully Then
                Me.Hide()
                Me.Cursor = Cursors.Default
                If countdownCheckBox.Checked Then
                    answerExam.setup(exam, countdownUpDown.Value * 60)
                Else
                    answerExam.setup(exam, 0)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' hide this interface and return to the main menu 
        Me.Hide()
        mainMenu.Show()
    End Sub


    Private Sub countdownCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles countdownCheckBox.CheckedChanged
        ' if user enables countdown mode, display interface to select time
        countdownLabel.Visible = countdownCheckBox.Checked
        countdownUpDown.Visible = countdownCheckBox.Checked
    End Sub

End Class
