Public Class mainMenu
    Dim topicsList As New List(Of List(Of String))

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load topics when form run
        topicsList = getTopics()
    End Sub

    Private Sub takeExamButton_Click(sender As Object, e As EventArgs) Handles takeExamButton.Click
        ' Move to CREATE EXAM section
        Me.Hide()

        CreateExam.displayInterface()
    End Sub

    Private Sub viewProgressButton_Click(sender As Object, e As EventArgs) Handles viewProgressButton.Click
        ' Move to VIEW PROGRESS section
        Me.Hide()

        viewCharts.displayInterface()
    End Sub

    Private Sub addQuestionButton_Click(sender As Object, e As EventArgs) Handles addQuestionButton.Click
        ' Move to ADD QUESTION section
        Me.Hide()

        addQuestion.displayInterface()
    End Sub

    Public Function getTopicList()
        Return topicsList
    End Function

    Private Sub mainMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


End Class
