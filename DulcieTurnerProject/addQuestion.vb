Imports System.Data
Imports System.Data.SqlClient

Public Class addQuestion
    Dim topicsList = mainMenu.getTopicList()
    Dim questionFilePath As String = ""
    Dim markSchemeFilePath As String = ""
    Dim examinerReportFilePath As String = ""


    Public Sub displayInterface()
        ' show the form
        Me.Show()

        subtopicComboBox.Items.Clear()
        topicComboBox.Items.Clear()
        ' populate the topics box with topics
        For Each row As List(Of String) In topicsList
            topicComboBox.Items.Add(row(0))
        Next
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' hide this interface and return to the main menu 
        Me.Hide()
        mainMenu.Show()
    End Sub

    Private Sub addQuestion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' close everything down when form closed
        Application.Exit()
    End Sub

    Private Sub topicComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles topicComboBox.SelectedIndexChanged
        ' (don't change if topic box becomes unselected)
        If topicComboBox.SelectedIndex <> -1 Then
            ' when user selects a topic
            ' enable + empty subtopic box
            subtopicComboBox.Enabled = True
            subtopicComboBox.Items.Clear()

            ' loop through the list of the selected topic & add to subtopic box
            ' (excluding index 0 since that is a topic not a subtopic)
            Dim topicIndex = topicComboBox.SelectedIndex
            For i As Integer = 1 To topicsList(topicIndex).count - 1
                subtopicComboBox.Items.Add(topicsList(topicIndex)(i))
            Next
        End If
    End Sub

    Private Function getFile()
        ' when browse button clicked open Load File window in Desktop
        ' only allow images to be loaded
        Dim fileBrowser = New OpenFileDialog()
        fileBrowser.InitialDirectory = System.IO.Directory.GetCurrentDirectory()
        fileBrowser.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"
        ' if user pressed okay, return selected file
        If fileBrowser.ShowDialog() = DialogResult.OK Then
            Return fileBrowser.FileName
        Else
            Return ""
        End If
    End Function

    Private Sub questionImageButton_Click(sender As Object, e As EventArgs) Handles questionImageButton.Click
        ' get question image file path
        questionFilePath = getFile()
        ' write the file name (excluding the rest of the path) in a label
        questionFilePathLabel.Show()
        questionFilePathLabel.Text = System.IO.Path.GetFileName(questionFilePath)
    End Sub

    Private Sub markSchemeImageButton_Click(sender As Object, e As EventArgs) Handles markSchemeImageButton.Click
        ' get mark scheme image file path
        markSchemeFilePath = getFile()
        ' write the file name in a label
        msFilePathLabel.Show()
        msFilePathLabel.Text = System.IO.Path.GetFileName(markSchemeFilePath)
    End Sub

    Private Sub examinerReportImageButton_Click(sender As Object, e As EventArgs) Handles examinerReportImageButton.Click
        ' get examiner report file path
        examinerReportFilePath = getFile()
        ' write the file name in a label
        erFilePathLabel.Show()
        erFilePathLabel.Text = System.IO.Path.GetFileName(examinerReportFilePath)
    End Sub

    Private Sub multipleChoiceCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles multipleChoiceCheckBox.CheckedChanged
        If multipleChoiceCheckBox.Checked Then
            ' if multiple choice selected, display box for answer
            multipleChoiceTextBox.Visible = True
        Else
            multipleChoiceTextBox.Visible = False
        End If
    End Sub

    Private Function checkIfImage(ByRef iV, ByRef e, ByVal imgType, ByVal fp)
        ' return true if selected file is image
        Select Case System.IO.Path.GetExtension(fp).ToUpper()
            Case ".JPG", ".JPEG", ".GIF", ".BMP"
                Return True
            Case Else
                iV = False
                e += "You must select a JPG, GIF or BMP file for the " & imgType & Environment.NewLine
                Return False
        End Select
    End Function

    Private Function checkImgSize(ByRef iv, ByRef e, ByVal imgType, ByVal fp)
        ' return true if image valid size
        Dim img = Image.FromFile(fp)
        If img.Size.Width > 960 Or img.Size.Height > 305 Then
            iv = False
            e += "Your " & imgType & " image dimensions must be no larger than (960, 305)" & Environment.NewLine
            Return False
        End If
        Return True
    End Function

    Private Function validateData()
        Dim isValid = True
        Dim errorMessage = ""

        ' check if topic selected
        If topicComboBox.SelectedIndex = -1 Then
            isValid = False
            errorMessage += "You must select a topic" & Environment.NewLine
        End If

        ' check if subtopic selected
        If subtopicComboBox.SelectedIndex = -1 Then
            isValid = False
            errorMessage += "You must select a subtopic" & Environment.NewLine
        End If

        If questionFilePath = "" Then
            'check if image selected
            isValid = False
            errorMessage += "You must select a Question image" & Environment.NewLine
        Else
            ' check if of image file type
            If checkIfImage(isValid, errorMessage, "Question", questionFilePath) Then
                ' check image dimensions
                checkImgSize(isValid, errorMessage, "Question", questionFilePath)

            End If
        End If

        If markSchemeFilePath = "" Then
            'check if image selected
            ' only complain about not having a ms if it's not multiple choice
            If Not multipleChoiceCheckBox.Checked Then
                isValid = False
                errorMessage += "You must select a Mark Scheme image" & Environment.NewLine
            End If

        Else
            ' check if of image file type
            checkIfImage(isValid, errorMessage, "Mark Scheme", markSchemeFilePath)
            ' check if of image file type
            If checkIfImage(isValid, errorMessage, "Mark Scheme", markSchemeFilePath) Then
                ' check image dimensions
                checkImgSize(isValid, errorMessage, "Mark Scheme", markSchemeFilePath)

            End If
        End If

        If examinerReportFilePath <> "" Then
            ' check if of image file type
            checkIfImage(isValid, errorMessage, "Examiner Report", examinerReportFilePath)
            ' check if of image file type
            If checkIfImage(isValid, errorMessage, "Examiner Report", examinerReportFilePath) Then
                ' check image dimensions
                checkImgSize(isValid, errorMessage, "Examiner Report", examinerReportFilePath)

            End If
        End If

        ' if it's not empty, it's invalid if it's not numbers or 4 digits
        If yearTextBox.Text.Length <> 0 Then
            If yearTextBox.Text.Length <> 4 Or Not IsNumeric(yearTextBox.Text) Then
                isValid = False
                errorMessage += "You must enter a 4 digit year" & Environment.NewLine
            End If
        Else
            yearTextBox.Text = 0
        End If

        ' checks if marks available is a number then checks if less than 30
        If IsNumeric(marksAvailableTextBox.Text) Then
            If Convert.ToInt32(marksAvailableTextBox.Text) > 30 Then
                isValid = False
                errorMessage += "You must enter a lower number of marks"
            End If
        Else
            isValid = False
            errorMessage += "You must enter a number for the Marks Available"
        End If

        If multipleChoiceCheckBox.Checked Then
            ' check if multiple choice answer a, b, c or d
            Select Case multipleChoiceTextBox.Text.ToUpper
                Case "A", "B", "C", "D"
                Case Else
                    isValid = False
                    errorMessage += "You must enter a multiple choice answer of A, B, C or D" & Environment.NewLine
            End Select
        End If

        If Not isValid Then
            MsgBox(errorMessage)
        End If

        Return isValid

    End Function

    Private Sub updateFilePaths()
        questionFilePath = "Questions\" + System.IO.Path.GetFileName(questionFilePath)
        If Not markSchemeFilePath = "" Then
            markSchemeFilePath = "Mark Schemes\" + System.IO.Path.GetFileName(markSchemeFilePath)
        End If
        If Not examinerReportFilePath = "" Then
            examinerReportFilePath = "Examiner Reports\" + System.IO.Path.GetFileName(examinerReportFilePath)
        End If
    End Sub

    Private Sub saveToDatabase()
        ' create SQL query with placeholders
        Dim sqlQuery As String = "INSERT INTO Question (questionFilePath, isMultipleChoice, multipleChoiceAnswer, "
        sqlQuery += "topic, subtopic, yearAppears, marksWorth, markSchemeFilePath, examinerReportFilePath)  "
        sqlQuery += "VALUES (@qPath, @isMC, @mcAnswer, @topic, @subtopic, @year, @mark, @msFilePath, @erFilePath)"

        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")

        ' set up SQL command + fill placeholders with data
        Dim command As New SqlCommand()
        With command
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@qPath", questionFilePath)
            .Parameters.AddWithValue("@isMC", multipleChoiceCheckBox.Checked)
            .Parameters.AddWithValue("@mcAnswer", multipleChoiceTextBox.Text)
            .Parameters.AddWithValue("@topic", topicComboBox.SelectedItem)
            .Parameters.AddWithValue("@subtopic", subtopicComboBox.SelectedItem)
            .Parameters.AddWithValue("@year", Convert.ToInt16(yearTextBox.Text))
            .Parameters.AddWithValue("@mark", Convert.ToInt16(marksAvailableTextBox.Text))
            .Parameters.AddWithValue("@msFilePath", markSchemeFilePath)
            .Parameters.AddWithValue("@erFilePath", examinerReportFilePath)
        End With

        ' try and execute command
        ' otherwise display error message
        Try
            command.Connection.Open()
            command.ExecuteNonQuery()
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try

        connection.Close()
    End Sub

    Private Sub clearBoxes()
        ' reset dropdown boxes
        topicComboBox.SelectedIndex = -1
        subtopicComboBox.SelectedIndex = -1

        ' deselect images + hide label
        questionFilePath = ""
        questionFilePathLabel.Text = questionFilePath
        markSchemeFilePath = ""
        msFilePathLabel.Text = markSchemeFilePath
        examinerReportFilePath = ""
        erFilePathLabel.Text = examinerReportFilePath

        ' empty text boxes
        yearTextBox.Clear()
        marksAvailableTextBox.Clear()
        multipleChoiceCheckBox.Checked = False
        multipleChoiceTextBox.Clear()

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' if valid, save q to database
        If validateData() Then
            Me.Cursor = Cursors.WaitCursor
            updateFilePaths()
            saveToDatabase()
            Me.Cursor = Cursors.Default
            MsgBox("Saved to Database")
            clearBoxes()
        End If
    End Sub
End Class