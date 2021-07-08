Imports System.Data
Imports System.Data.SqlClient
' general functions that need to be used in multiple classes
Module helperFunctions
    Public Function getTopics()
        ' open CSV file
        FileOpen(1, "topics.csv", OpenMode.Input)
        ' store CSV contents as a list of lists
        Dim tempList As New List(Of List(Of String))
        ' loop thru rows in file
        Do Until EOF(1)
            ' create a list of each element on the row
            ' then add to the main list
            tempList.Add(Split(LineInput(1), ", ").ToList())
        Loop
        FileClose(1)
        Return tempList
    End Function

    Public Function getPapersByDate(d As Date)
        Dim tempEList = New List(Of Exam)
        '
        ' create SQL query with placeholder
        Dim sqlQuery As String = "SELECT * FROM Paper WHERE dateStarted >= @thresholdDate"
        ' set up SQL connection using db connection string
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9) + "ExamProjectDB.mdf;Integrated Security=True")
        ' set up SQL command + fill placeholders with data
        Dim command As New SqlCommand()
        With command
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = sqlQuery
            .Parameters.AddWithValue("@thresholdDate", d)
        End With

        ' try and execute command, otherwise display error message
        Try
            command.Connection.Open() '(totM, achM, dat, totTime)
            Using reader As SqlClient.SqlDataReader = command.ExecuteReader
                '' loop through all returned records 
                While reader.Read
                    ' convert each record to Exam + add to list
                    tempEList.Add(New Exam(reader("marksAvailable"),
                  reader("marksAchieved"), reader("dateStarted"), reader("timeTaken"), reader("paperID")))
                End While
            End Using
        Catch sqlEx As SqlException
            MessageBox.Show(sqlEx.Message.ToString(), "Error Message")
        End Try
        connection.Close()
        Return tempEList
    End Function
End Module
