
Public Class viewCharts
    Dim allButtons As Button() = New Button() {accuracyButton, timePMarkButton, errorButton, overviewButton, topicButton, mcButton}

    Dim topicsList As New List(Of String)
    Dim tempTopicsList As New List(Of List(Of String))
    Dim graphTopics

    Dim examList As New List(Of Exam)
    Dim tempQList
    Dim tempAList


    Dim majorChartType = "Accuracy"
    Dim minorChartType = "Overview"

    Public Sub displayInterface()
        ' show the form
        Me.Show()

        Me.Cursor = Cursors.WaitCursor

        ' get the list of topics and subtopics
        ' extract the topics from it
        ' add to dropdown box
        topicsList = New List(Of String)
        graphTopics = New List(Of String)
        tempTopicsList = mainMenu.getTopicList
        topicsList.Add("All Topics")
        For Each item In tempTopicsList
            topicsList.Add(item.Item(0))
            graphTopics.Add(item.Item(0))
        Next
        topicSelectBox.DataSource = topicsList

        setupData()
        selectChartType()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub setupData()
        ' get exam papers from last 6 months
        examList = getPapersByDate(Date.Today.AddMonths(-6))
    End Sub

    Private Sub selectChartType()
        ' handle a change in the chart type
        Me.Cursor = Cursors.WaitCursor

        changeAllButtons(1)
        Select Case majorChartType
            Case "Accuracy"
                handleAccuracyCharts()
            Case "Time Per Mark"
                handleTimeCharts()
            Case "Error Breakdown"
                handleErrorCharts()
        End Select

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub handleAccuracyCharts()
        ' select the appropriate accuracy chart
        Select Case minorChartType
            Case "Overview"
                overallAccuracy()
            Case "Topics"
                topicsAccuracy()
            Case "Multiple Choice"
                mcAccuracy()
        End Select
    End Sub

    Private Sub handleTimeCharts()
        ' select the appropriate time chart
        Select Case minorChartType
            Case "Overview"
                overallTime()
            Case "Topics"
                topicsTime()
            Case "Multiple Choice"
                mcTime()
        End Select
    End Sub

    Private Sub handleErrorCharts()
        ' select the appropriate error chart
        ' button is hidden since no error overview available
        overviewButton.Visible = False
        Select Case minorChartType
            Case "Topics"
                topicsErrors()
            Case "Multiple Choice"
                mcErrors()
        End Select
    End Sub

    Private Sub overallAccuracy()
        ' disable the selected buttons
        accuracyButton.Enabled = False
        overviewButton.Enabled = False

        ' set up the chart
        resetChart()
        chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart1.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle

        ' set up the axes
        chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
        chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
        chart1.ChartAreas(0).AxisX.Title = "Date Taken"
        chart1.ChartAreas(0).AxisY.Title = "Percentage Accuracy"
        chart1.Legends(0).Enabled = False
        chart1.ChartAreas(0).AxisY.Maximum = 100

        ' create points where x = date , y = accuracy
        For Each exam In examList
            chart1.Series(0).Points.AddXY(exam.getDateStarted, (exam.getTotalMarksAchieved / exam.getTotalNumMarks) * 100)
        Next
        chart1.Titles(0).Text = "Overall Accuracy"
    End Sub

    Private Sub topicsAccuracy()
        ' allow the user to select topics
        topicSelectBox.Visible = True

        ' disable the selected buttons
        accuracyButton.Enabled = False
        topicButton.Enabled = False
        If topicSelectBox.SelectedValue = "All Topics" Then
            ' set up the chart
            resetChart()
            chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar

            ' create running total arrays to calculate accuracy for each topic
            Dim topicMarksAvailable(graphTopics.Count)
            Dim topicMarksAchieved(graphTopics.Count)
            For i As Integer = 0 To graphTopics.Count - 1
                topicMarksAvailable(i) = 0
                topicMarksAchieved(i) = 0
            Next

            Dim topicIndex
            For Each exam In examList
                ' get the lists of questions and answers
                tempQList = exam.getQuestionList
                tempAList = exam.getAnswerList

                ' loop through the exam and add the marks achieved/available to the appropriate topic
                For i As Integer = 0 To exam.getExamSize - 1
                    topicIndex = graphTopics.IndexOf(tempQList(i).getTopic())
                    topicMarksAvailable(topicIndex) += tempQList(i).getMarks()
                    topicMarksAchieved(topicIndex) += tempAList(i).returnMarksAchieved()
                Next
            Next
            ' calculate accuracy for each topic
            Dim topicAccuracies = New List(Of Integer)
            For i As Integer = 0 To graphTopics.Count - 1
                If topicMarksAvailable(i) = 0 Then
                    ' avoid division by 0 error
                    topicAccuracies.Add(0)
                Else
                    topicAccuracies.Add(Int((topicMarksAchieved(i) / topicMarksAvailable(i)) * 100))
                End If
                ' add datapoint to graph
                chart1.Series("chartSeries").Points.AddXY(graphTopics(i), topicAccuracies(i))
            Next

            ' set up the axes
            chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
            chart1.ChartAreas(0).AxisX.Title = ""
            chart1.ChartAreas(0).AxisY.Title = "Percentage Accuracy"
            chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
            chart1.Legends(0).Enabled = False
            chart1.ChartAreas(0).AxisY.Maximum = 100
            chart1.Titles(0).Text = "Accuracy by Topic"

        Else
            ' handle accuracy for a single topic
            ' set up the chart
            resetChart()
            chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            chart1.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            chart1.Titles(0).Text = "Accuracy over Time for " & topicSelectBox.SelectedValue

            Dim tempIndex
            Dim dateList As New List(Of Date)
            Dim marksAvList As New List(Of Integer)
            Dim marksAchList As New List(Of Integer)
            For Each exam In examList
                ' get the lists of questions and answers
                tempQList = exam.getQuestionList
                tempAList = exam.getAnswerList

                ' loop through all questions
                For i As Integer = 0 To exam.getExamSize - 1
                    ' if current question from selected topic
                    If tempQList(i).getTopic = topicSelectBox.SelectedValue Then
                        ' if date already in datelist
                        If dateList.Contains(tempAList(i).getDate()) Then
                            ' add marks to list at that date
                            tempIndex = dateList.IndexOf(tempAList(i).getDate())
                            marksAvList(tempIndex) += tempQList(i).getMarks()
                            marksAchList(tempIndex) += tempAList(i).returnMarksAchieved()
                        Else
                            ' add date to list
                            dateList.Add(tempAList(i).getDate())
                            marksAvList.Add(tempQList(i).getMarks())
                            marksAchList.Add(tempAList(i).returnMarksAchieved())
                        End If
                    End If
                Next
            Next
            ' add each point to chart
            For i = 0 To dateList.Count - 1
                chart1.Series(0).Points.AddXY(dateList(i), (marksAchList(i) / marksAvList(i)) * 100)
            Next

            ' set up the axes
            chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
            chart1.ChartAreas(0).AxisX.Title = "Date Taken"
            chart1.ChartAreas(0).AxisY.Title = "Percentage Accuracy"
            chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
            chart1.Legends(0).Enabled = False
            chart1.ChartAreas(0).AxisY.Maximum = 100
        End If
    End Sub

    Private Sub mcAccuracy()
        ' handle accuracy for multiple choice vs not multiple choice
        resetChart()
        chart1.Series.Add("Multiple Choice")
        chart1.Series.Add("Not Multiple Choice")
        chart1.Series.Remove(chart1.Series("chartSeries"))
        accuracyButton.Enabled = False
        mcButton.Enabled = False
        chart1.Series("Multiple Choice").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart1.Series("Multiple Choice").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        chart1.Series("Not Multiple Choice").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart1.Series("Not Multiple Choice").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        chart1.Titles(0).Text = "Multiple Choice Accuracy"

        Dim mcqDateList As New List(Of Date)
        Dim nonMCQDateList As New List(Of Date)
        Dim mcqMarksAv As New List(Of Integer)
        Dim mcqMarksAch As New List(Of Integer)
        Dim nonMCQMarksAv As New List(Of Integer)
        Dim nonMCQMarksAch As New List(Of Integer)
        For Each exam In examList
            ' get the lists of questions and answers
            tempQList = exam.getQuestionList
            tempAList = exam.getAnswerList
            ' loop through all questions
            For i As Integer = 0 To exam.getExamSize - 1
                ' if current question is multiple choice
                If tempQList(i).isMC = True Then
                    ' if date already in datelist
                    If mcqDateList.Contains(tempAList(i).getDate()) Then
                        ' add marks to list at that date
                        Dim tempIndex = mcqDateList.IndexOf(tempAList(i).getDate())
                        mcqMarksAv(tempIndex) += tempQList(i).getMarks()
                        mcqMarksAch(tempIndex) += tempAList(i).returnMarksAchieved()
                    Else
                        ' add date to list then add marks
                        mcqDateList.Add(tempAList(i).getDate())
                        mcqMarksAv.Add(tempQList(i).getMarks())
                        mcqMarksAch.Add(tempAList(i).returnMarksAchieved())
                    End If
                Else
                    ' if not multiple choice and date already in datelist
                    If nonMCQDateList.Contains(tempAList(i).getDate()) Then
                        ' add marks to list at that date
                        Dim tempIndex = nonMCQDateList.IndexOf(tempAList(i).getDate())
                        nonMCQMarksAv(tempIndex) += tempQList(i).getMarks()
                        nonMCQMarksAch(tempIndex) += tempAList(i).returnMarksAchieved()
                    Else
                        ' add date to list then add marks
                        nonMCQDateList.Add(tempAList(i).getDate())
                        nonMCQMarksAv.Add(tempQList(i).getMarks())
                        nonMCQMarksAch.Add(tempAList(i).returnMarksAchieved())
                    End If
                End If
            Next
        Next
        ' add points to chart
        For i = 0 To mcqDateList.Count - 1
            chart1.Series("Multiple Choice").Points.AddXY(mcqDateList(i), (mcqMarksAch(i) / mcqMarksAv(i)) * 100)
        Next
        For i = 0 To nonMCQDateList.Count - 1
            chart1.Series("Not Multiple Choice").Points.AddXY(nonMCQDateList(i), (nonMCQMarksAch(i) / nonMCQMarksAv(i)) * 100)
        Next
        ' set up the axes
        chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
        chart1.ChartAreas(0).AxisX.Title = "Date Taken"
        chart1.ChartAreas(0).AxisY.Title = "Percentage Accuracy"
        chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
        chart1.Legends(0).Enabled = True
        chart1.ChartAreas(0).AxisY.Maximum = 100
    End Sub


    Private Sub overallTime()
        ' disable the selected buttons
        timePMarkButton.Enabled = False
        overviewButton.Enabled = False

        ' set up the chart
        resetChart()
        chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart1.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle

        ' set up the axes
        chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
        chart1.ChartAreas(0).AxisX.Title = "Date Taken"
        chart1.ChartAreas(0).AxisY.Title = "Seconds Per Mark"
        chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
        chart1.Legends(0).Enabled = False

        ' create points where x = date , y = time per mark
        For Each exam In examList
            chart1.Series(0).Points.AddXY(exam.getDateStarted, (exam.getTotalTime / exam.getTotalNumMarks))
        Next
        chart1.Titles(0).Text = "Overall Time Per Mark"
    End Sub

    Private Sub topicsTime()
        topicSelectBox.Visible = True
        timePMarkButton.Enabled = False
        topicButton.Enabled = False
        resetChart()
        ' if all topics selected
        If topicSelectBox.SelectedIndex = 0 Then
            chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
            ' create running total arrays to calculate times for each topic
            Dim marksAvailable(graphTopics.Count - 1)
            Dim timeTaken(graphTopics.Count - 1)
            For i As Integer = 0 To graphTopics.Count - 1
                marksAvailable(i) = 0
                timeTaken(i) = 0
            Next
            Dim topicIndex
            For Each exam In examList
                tempQList = exam.getQuestionList
                tempAList = exam.getAnswerList
                ' loop through the exam and add the marks achieved / time taken to the appropriate topic
                For i As Integer = 0 To exam.getExamSize - 1
                    topicIndex = graphTopics.IndexOf(tempQList(i).getTopic())
                    timeTaken(topicIndex) += tempAList(i).getTimeTaken()
                    marksAvailable(topicIndex) += tempQList(i).getMarks()
                Next
            Next
            ' calculate time per mark for each topic
            Dim timePerMarks = New List(Of Integer)
            For i As Integer = 0 To graphTopics.Count - 1
                If marksAvailable(i) = 0 Then
                    timePerMarks.Add(0)
                Else
                    timePerMarks.Add(Int(timeTaken(i) / marksAvailable(i)))
                End If
                chart1.Series(0).Points.AddXY(graphTopics(i), timePerMarks(i))
            Next
            ' set up the axes
            chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
            chart1.ChartAreas(0).AxisY.Title = "Seconds Per Mark"
            chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
            chart1.Legends(0).Enabled = False
            chart1.Titles(0).Text = "Time Per Mark by Topic"
        Else
            ' handle times for a single topic
            chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            chart1.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            chart1.Titles(0).Text = "Time per Mark for " & topicSelectBox.SelectedValue
            Dim tempIndex
            Dim dateList As New List(Of Date)
            Dim marksAvList As New List(Of Integer)
            Dim timesList As New List(Of Integer)
            For Each exam In examList
                ' get the lists of questions and answers
                tempQList = exam.getQuestionList
                tempAList = exam.getAnswerList
                For i As Integer = 0 To exam.getExamSize - 1
                    ' if current question from selected topic
                    If tempQList(i).getTopic = topicSelectBox.SelectedValue Then
                        ' if date already in datelist
                        If dateList.Contains(tempAList(i).getDate()) Then
                            ' add marks to list at that date
                            tempIndex = dateList.IndexOf(tempAList(i).getDate())
                            marksAvList(tempIndex) += tempQList(i).getMarks()
                            timesList(tempIndex) += tempAList(i).getTimeTaken()
                        Else
                            ' add date to list
                            dateList.Add(tempAList(i).getDate())
                            marksAvList.Add(tempQList(i).getMarks())
                            timesList.Add(tempAList(i).getTimeTaken())
                        End If
                    End If
                Next
            Next
            ' add each point to chart
            For i = 0 To dateList.Count - 1
                chart1.Series(0).Points.AddXY(dateList(i), timesList(i) / marksAvList(i))
            Next
            chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
            chart1.ChartAreas(0).AxisX.Title = "Date Taken"
            chart1.ChartAreas(0).AxisY.Title = "Seconds per Mark"
            chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
            chart1.Legends(0).Enabled = False
        End If
    End Sub


    Private Sub mcTime()
        ' handle time per mark for multiple choice vs not multiple choice
        resetChart()
        chart1.Series.Add("Multiple Choice")
        chart1.Series.Add("Not Multiple Choice")
        chart1.Series.Remove(chart1.Series("chartSeries"))
        timePMarkButton.Enabled = False
        mcButton.Enabled = False
        timingInfoPanel.Visible = True
        chart1.Series("Multiple Choice").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart1.Series("Multiple Choice").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        chart1.Series("Not Multiple Choice").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chart1.Series("Not Multiple Choice").MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        chart1.Titles(0).Text = "Multiple Choice Times Per Mark"

        Dim mcqDateList As New List(Of Date)
        Dim nonMCQDateList As New List(Of Date)
        Dim mcqMarksAv As New List(Of Integer)
        Dim mcqTimeTaken As New List(Of Integer)
        Dim nonMCQMarksAv As New List(Of Integer)
        Dim nonMCQTimeTaken As New List(Of Integer)
        For Each exam In examList
            tempQList = exam.getQuestionList
            tempAList = exam.getAnswerList
            For i As Integer = 0 To exam.getExamSize - 1
                ' if current question is multiple choice
                If tempQList(i).isMC = True Then
                    ' if date already in datelist
                    If mcqDateList.Contains(tempAList(i).getDate()) Then
                        ' add marks to list at that date
                        Dim tempIndex = mcqDateList.IndexOf(tempAList(i).getDate())
                        mcqMarksAv(tempIndex) += tempQList(i).getMarks()
                        mcqTimeTaken(tempIndex) += tempAList(i).getTimeTaken()
                    Else
                        ' add date to list
                        mcqDateList.Add(tempAList(i).getDate())
                        mcqMarksAv.Add(tempQList(i).getMarks())
                        mcqTimeTaken.Add(tempAList(i).getTimeTaken())
                    End If
                Else
                    If nonMCQDateList.Contains(tempAList(i).getDate()) Then
                        Dim tempIndex = nonMCQDateList.IndexOf(tempAList(i).getDate())
                        nonMCQMarksAv(tempIndex) += tempQList(i).getMarks()
                        nonMCQTimeTaken(tempIndex) += tempAList(i).getTimeTaken()
                    Else
                        nonMCQDateList.Add(tempAList(i).getDate())
                        nonMCQMarksAv.Add(tempQList(i).getMarks())
                        nonMCQTimeTaken.Add(tempAList(i).getTimeTaken())
                    End If
                End If
            Next
        Next
        For i = 0 To mcqDateList.Count - 1
            chart1.Series("Multiple Choice").Points.AddXY(mcqDateList(i), mcqTimeTaken(i) / mcqMarksAv(i))
        Next
        For i = 0 To nonMCQDateList.Count - 1
            chart1.Series("Not Multiple Choice").Points.AddXY(nonMCQDateList(i), nonMCQTimeTaken(i) / nonMCQMarksAv(i))
        Next
        chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = 0
        chart1.ChartAreas(0).AxisX.Title = "Date Taken"
        chart1.ChartAreas(0).AxisY.Title = "Seconds per Mark"
        chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = 0
        chart1.Legends(0).Enabled = True
    End Sub


    Private Sub topicsErrors()
        ' handle error breakdown by topic
        errorButton.Enabled = False
        topicButton.Enabled = False

        ' set up the chart
        resetChart()
        chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        chart1.Series(0)("PieLabelStyle") = "Disabled"
        ' create running total arrays to calculate errors for each topic
        Dim marksAvailable(graphTopics.Count - 1)
        Dim marksAchieved(graphTopics.Count - 1)
        For i As Integer = 0 To graphTopics.Count - 1
            marksAvailable(i) = 0
            marksAchieved(i) = 0
        Next
        Dim topicIndex
        For Each exam In examList
            ' get the lists of questions and answers
            tempQList = exam.getQuestionList
            tempAList = exam.getAnswerList

            ' loop through the exam and add the marks achieved / marks available to the appropriate topic
            For i As Integer = 0 To exam.getExamSize - 1
                topicIndex = graphTopics.IndexOf(tempQList(i).getTopic())
                marksAchieved(topicIndex) += tempAList(i).returnMarksAchieved()
                marksAvailable(topicIndex) += tempQList(i).getMarks()
            Next
        Next

        For i As Integer = 0 To graphTopics.Count - 1
            ' add each datapoint (of total errors in a topic) to the graph
            chart1.Series(0).Points.AddXY(graphTopics(i), marksAvailable(i) - marksAchieved(i))
        Next
        ' set up the axes
        chart1.Legends(0).Enabled = True
        chart1.Titles(0).Text = "Errors Made By Topic"
    End Sub

    Private Sub mcErrors()
        ' handle error breakdown by multiple choice / not
        errorButton.Enabled = False
        mcButton.Enabled = False

        ' set up the chart
        resetChart()
        chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        chart1.Series(0)("PieLabelStyle") = "Disabled"
        Dim mcMarksAv = 0
        Dim mcMarksAch = 0
        Dim nonMCMarksAv = 0
        Dim nonMCMarksAch = 0

        For Each exam In examList
            ' get the lists of questions and answers
            tempQList = exam.getQuestionList
            tempAList = exam.getAnswerList
            For i As Integer = 0 To exam.getExamSize - 1
                If tempQList(i).isMC Then
                    mcMarksAv += tempQList(i).getMarks()
                    mcMarksAch += tempAList(i).returnMarksAchieved()
                Else
                    nonMCMarksAv += tempQList(i).getMarks()
                    nonMCMarksAch += tempAList(i).returnMarksAchieved()
                End If
            Next
        Next

        chart1.Series(0).Points.AddXY("Multiple Choice", mcMarksAv - mcMarksAch)
        chart1.Series(0).Points.AddXY("Not Multiple Choice", nonMCMarksAv - nonMCMarksAch)
        chart1.Legends(0).Enabled = True
        chart1.Titles(0).Text = "Multiple Choice Errors Made"
    End Sub

    Private Sub viewCharts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' close program properly
        Application.Exit()
    End Sub

    Private Sub resetChart()
        chart1.Series.Clear()
        chart1.ChartAreas.Clear()
        chart1.ChartAreas.Add("area1")
        chart1.Series.Add("chartSeries")
    End Sub

    Private Sub menuButton_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        ' hide this interface and return to the main menu 
        Me.Hide()
        mainMenu.Show()
    End Sub

    Private Sub changeAllButtons(value)
        accuracyButton.Enabled = value
        timePMarkButton.Enabled = value
        errorButton.Enabled = value
        overviewButton.Enabled = value
        topicButton.Enabled = value
        mcButton.Enabled = value

        topicSelectBox.Visible = False
        overviewButton.Visible = True
        timingInfoPanel.Visible = False
    End Sub

    Private Sub accuracyButton_Click(sender As Object, e As EventArgs) Handles accuracyButton.Click
        majorChartType = "Accuracy"
        selectChartType()
    End Sub

    Private Sub timePMarkButton_Click(sender As Object, e As EventArgs) Handles timePMarkButton.Click
        majorChartType = "Time Per Mark"
        selectChartType()
    End Sub

    Private Sub errorButton_Click(sender As Object, e As EventArgs) Handles errorButton.Click
        majorChartType = "Error Breakdown"
        ' there is no overall error breakdown
        If minorChartType = "Overview" Then
            minorChartType = "Topics"
        End If
        selectChartType()
    End Sub

    Private Sub topicButton_Click(sender As Object, e As EventArgs) Handles topicButton.Click
        minorChartType = "Topics"
        selectChartType()
    End Sub

    Private Sub overviewButton_Click(sender As Object, e As EventArgs) Handles overviewButton.Click
        minorChartType = "Overview"
        selectChartType()
    End Sub

    Private Sub topicSelectBox_SelectedChangeCommitted(sender As Object, e As EventArgs) Handles topicSelectBox.SelectionChangeCommitted
        selectChartType()
    End Sub

    Private Sub mcButton_Click(sender As Object, e As EventArgs) Handles mcButton.Click
        minorChartType = "Multiple Choice"
        selectChartType()
    End Sub

End Class
