<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class answerExam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.questionGroupBox = New System.Windows.Forms.GroupBox()
        Me.answerPaperLabel = New System.Windows.Forms.Label()
        Me.timeButton = New System.Windows.Forms.Button()
        Me.answerBox = New System.Windows.Forms.TextBox()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.timePanel = New System.Windows.Forms.Panel()
        Me.totalTime = New System.Windows.Forms.Label()
        Me.qTime = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.timePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'questionGroupBox
        '
        Me.questionGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionGroupBox.Location = New System.Drawing.Point(16, 73)
        Me.questionGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.questionGroupBox.Name = "questionGroupBox"
        Me.questionGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.questionGroupBox.Size = New System.Drawing.Size(1297, 459)
        Me.questionGroupBox.TabIndex = 0
        Me.questionGroupBox.TabStop = False
        Me.questionGroupBox.Text = "(question number)"
        '
        'answerPaperLabel
        '
        Me.answerPaperLabel.AutoSize = True
        Me.answerPaperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerPaperLabel.Location = New System.Drawing.Point(16, 11)
        Me.answerPaperLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.answerPaperLabel.Name = "answerPaperLabel"
        Me.answerPaperLabel.Size = New System.Drawing.Size(243, 39)
        Me.answerPaperLabel.TabIndex = 1
        Me.answerPaperLabel.Text = "Answer Paper"
        '
        'timeButton
        '
        Me.timeButton.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.timeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.timeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.timeButton.Location = New System.Drawing.Point(-4, -5)
        Me.timeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.timeButton.Name = "timeButton"
        Me.timeButton.Size = New System.Drawing.Size(239, 60)
        Me.timeButton.TabIndex = 2
        Me.timeButton.Text = "View Time"
        Me.timeButton.UseVisualStyleBackColor = False
        '
        'answerBox
        '
        Me.answerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerBox.Location = New System.Drawing.Point(16, 540)
        Me.answerBox.Margin = New System.Windows.Forms.Padding(4)
        Me.answerBox.Multiline = True
        Me.answerBox.Name = "answerBox"
        Me.answerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.answerBox.Size = New System.Drawing.Size(1296, 131)
        Me.answerBox.TabIndex = 3
        '
        'prevButton
        '
        Me.prevButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevButton.Location = New System.Drawing.Point(16, 679)
        Me.prevButton.Margin = New System.Windows.Forms.Padding(4)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(208, 58)
        Me.prevButton.TabIndex = 4
        Me.prevButton.Text = "Previous Question"
        Me.prevButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(1104, 679)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(209, 58)
        Me.nextButton.TabIndex = 5
        Me.nextButton.Text = "Next Question"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(1104, 679)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(209, 58)
        Me.submitButton.TabIndex = 6
        Me.submitButton.Text = "Submit Exam"
        Me.submitButton.UseVisualStyleBackColor = True
        Me.submitButton.Visible = False
        '
        'timePanel
        '
        Me.timePanel.Controls.Add(Me.timeButton)
        Me.timePanel.Controls.Add(Me.totalTime)
        Me.timePanel.Controls.Add(Me.qTime)
        Me.timePanel.Location = New System.Drawing.Point(1079, 16)
        Me.timePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.timePanel.Name = "timePanel"
        Me.timePanel.Size = New System.Drawing.Size(235, 65)
        Me.timePanel.TabIndex = 7
        '
        'totalTime
        '
        Me.totalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTime.Location = New System.Drawing.Point(4, 5)
        Me.totalTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalTime.Name = "totalTime"
        Me.totalTime.Size = New System.Drawing.Size(227, 30)
        Me.totalTime.TabIndex = 0
        Me.totalTime.Text = "Label1"
        Me.totalTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'qTime
        '
        Me.qTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qTime.Location = New System.Drawing.Point(0, 34)
        Me.qTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.qTime.Name = "qTime"
        Me.qTime.Size = New System.Drawing.Size(235, 31)
        Me.qTime.TabIndex = 8
        Me.qTime.Text = "Label1"
        Me.qTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'answerExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1328, 751)
        Me.Controls.Add(Me.timePanel)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.prevButton)
        Me.Controls.Add(Me.answerBox)
        Me.Controls.Add(Me.answerPaperLabel)
        Me.Controls.Add(Me.questionGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1346, 798)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1346, 798)
        Me.Name = "answerExam"
        Me.Text = "Answer Exam"
        Me.timePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents questionGroupBox As GroupBox
    Friend WithEvents answerPaperLabel As Label
    Friend WithEvents timeButton As Button
    Friend WithEvents answerBox As TextBox
    Friend WithEvents prevButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents timePanel As Panel
    Friend WithEvents timer As Timer
    Friend WithEvents totalTime As Label
    Friend WithEvents qTime As Label
End Class
