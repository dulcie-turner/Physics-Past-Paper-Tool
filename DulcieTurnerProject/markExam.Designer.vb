<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class markExam
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
        Me.markingPanel = New System.Windows.Forms.Panel()
        Me.prevAnsButton = New System.Windows.Forms.Button()
        Me.finalReviewPanel = New System.Windows.Forms.Panel()
        Me.mainMenuButton = New System.Windows.Forms.Button()
        Me.finalTimeLabel = New System.Windows.Forms.Label()
        Me.finalMarkLabel = New System.Windows.Forms.Label()
        Me.numMarksBox = New System.Windows.Forms.NumericUpDown()
        Me.commentTxtBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.marksLabel = New System.Windows.Forms.Label()
        Me.ansLabel = New System.Windows.Forms.Label()
        Me.qCompareLabel = New System.Windows.Forms.Label()
        Me.qTimeLabel = New System.Windows.Forms.Label()
        Me.commentLabel = New System.Windows.Forms.Label()
        Me.ansTxtBox = New System.Windows.Forms.TextBox()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.erButton = New System.Windows.Forms.Button()
        Me.msButton = New System.Windows.Forms.Button()
        Me.qButton = New System.Windows.Forms.Button()
        Me.markPaperLabel = New System.Windows.Forms.Label()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.questionGroupBox = New System.Windows.Forms.GroupBox()
        Me.mcqAnsLabel = New System.Windows.Forms.Label()
        Me.tablePanel = New System.Windows.Forms.Panel()
        Me.answerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.imageButtonToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.markingPanel.SuspendLayout()
        Me.finalReviewPanel.SuspendLayout()
        CType(Me.numMarksBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.questionGroupBox.SuspendLayout()
        Me.tablePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'markingPanel
        '
        Me.markingPanel.Controls.Add(Me.prevAnsButton)
        Me.markingPanel.Controls.Add(Me.finalReviewPanel)
        Me.markingPanel.Controls.Add(Me.numMarksBox)
        Me.markingPanel.Controls.Add(Me.commentTxtBox)
        Me.markingPanel.Controls.Add(Me.submitButton)
        Me.markingPanel.Controls.Add(Me.marksLabel)
        Me.markingPanel.Controls.Add(Me.ansLabel)
        Me.markingPanel.Controls.Add(Me.qCompareLabel)
        Me.markingPanel.Controls.Add(Me.qTimeLabel)
        Me.markingPanel.Controls.Add(Me.commentLabel)
        Me.markingPanel.Controls.Add(Me.ansTxtBox)
        Me.markingPanel.Controls.Add(Me.prevButton)
        Me.markingPanel.Controls.Add(Me.erButton)
        Me.markingPanel.Controls.Add(Me.msButton)
        Me.markingPanel.Controls.Add(Me.qButton)
        Me.markingPanel.Controls.Add(Me.markPaperLabel)
        Me.markingPanel.Controls.Add(Me.nextButton)
        Me.markingPanel.Controls.Add(Me.questionGroupBox)
        Me.markingPanel.Location = New System.Drawing.Point(-3, -2)
        Me.markingPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.markingPanel.Name = "markingPanel"
        Me.markingPanel.Size = New System.Drawing.Size(1336, 754)
        Me.markingPanel.TabIndex = 20
        '
        'prevAnsButton
        '
        Me.prevAnsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevAnsButton.Location = New System.Drawing.Point(8, 597)
        Me.prevAnsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.prevAnsButton.Name = "prevAnsButton"
        Me.prevAnsButton.Size = New System.Drawing.Size(200, 43)
        Me.prevAnsButton.TabIndex = 2
        Me.prevAnsButton.Text = "Previous Answers"
        Me.imageButtonToolTips.SetToolTip(Me.prevAnsButton, "Show your previous answers for this question")
        Me.prevAnsButton.UseVisualStyleBackColor = True
        '
        'finalReviewPanel
        '
        Me.finalReviewPanel.BackColor = System.Drawing.SystemColors.Window
        Me.finalReviewPanel.Controls.Add(Me.mainMenuButton)
        Me.finalReviewPanel.Controls.Add(Me.finalTimeLabel)
        Me.finalReviewPanel.Controls.Add(Me.finalMarkLabel)
        Me.finalReviewPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.finalReviewPanel.Location = New System.Drawing.Point(285, 18)
        Me.finalReviewPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.finalReviewPanel.Name = "finalReviewPanel"
        Me.finalReviewPanel.Size = New System.Drawing.Size(744, 729)
        Me.finalReviewPanel.TabIndex = 37
        Me.finalReviewPanel.Visible = False
        '
        'mainMenuButton
        '
        Me.mainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainMenuButton.Location = New System.Drawing.Point(208, 576)
        Me.mainMenuButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mainMenuButton.Name = "mainMenuButton"
        Me.mainMenuButton.Size = New System.Drawing.Size(328, 106)
        Me.mainMenuButton.TabIndex = 38
        Me.mainMenuButton.Text = "Return to Main Menu"
        Me.mainMenuButton.UseVisualStyleBackColor = True
        '
        'finalTimeLabel
        '
        Me.finalTimeLabel.AutoSize = True
        Me.finalTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalTimeLabel.Location = New System.Drawing.Point(125, 320)
        Me.finalTimeLabel.Name = "finalTimeLabel"
        Me.finalTimeLabel.Size = New System.Drawing.Size(495, 32)
        Me.finalTimeLabel.TabIndex = 40
        Me.finalTimeLabel.Text = "You completed the exam in [X] time"
        Me.finalTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'finalMarkLabel
        '
        Me.finalMarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalMarkLabel.Location = New System.Drawing.Point(-8, 213)
        Me.finalMarkLabel.Name = "finalMarkLabel"
        Me.finalMarkLabel.Size = New System.Drawing.Size(760, 122)
        Me.finalMarkLabel.TabIndex = 39
        Me.finalMarkLabel.Text = "You got [X] out of [Y] correct!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " The final percentage is [Z]%"
        Me.finalMarkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'numMarksBox
        '
        Me.numMarksBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMarksBox.Location = New System.Drawing.Point(563, 703)
        Me.numMarksBox.Margin = New System.Windows.Forms.Padding(4)
        Me.numMarksBox.Name = "numMarksBox"
        Me.numMarksBox.Size = New System.Drawing.Size(69, 30)
        Me.numMarksBox.TabIndex = 7
        Me.numMarksBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'commentTxtBox
        '
        Me.commentTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentTxtBox.Location = New System.Drawing.Point(828, 523)
        Me.commentTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.commentTxtBox.Multiline = True
        Me.commentTxtBox.Name = "commentTxtBox"
        Me.commentTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.commentTxtBox.Size = New System.Drawing.Size(481, 157)
        Me.commentTxtBox.TabIndex = 6
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(1103, 690)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(209, 58)
        Me.submitButton.TabIndex = 5
        Me.submitButton.Text = "Submit Exam"
        Me.submitButton.UseVisualStyleBackColor = True
        Me.submitButton.Visible = False
        '
        'marksLabel
        '
        Me.marksLabel.AutoSize = True
        Me.marksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marksLabel.Location = New System.Drawing.Point(637, 706)
        Me.marksLabel.Name = "marksLabel"
        Me.marksLabel.Size = New System.Drawing.Size(148, 25)
        Me.marksLabel.TabIndex = 32
        Me.marksLabel.Text = "/ [Num Marks]"
        '
        'ansLabel
        '
        Me.ansLabel.AutoSize = True
        Me.ansLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ansLabel.Location = New System.Drawing.Point(211, 495)
        Me.ansLabel.Name = "ansLabel"
        Me.ansLabel.Size = New System.Drawing.Size(71, 20)
        Me.ansLabel.TabIndex = 31
        Me.ansLabel.Text = "Answer"
        '
        'qCompareLabel
        '
        Me.qCompareLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qCompareLabel.Location = New System.Drawing.Point(965, 46)
        Me.qCompareLabel.Name = "qCompareLabel"
        Me.qCompareLabel.Size = New System.Drawing.Size(363, 39)
        Me.qCompareLabel.TabIndex = 30
        Me.qCompareLabel.Text = "This was []% longer than average"
        Me.qCompareLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'qTimeLabel
        '
        Me.qTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qTimeLabel.Location = New System.Drawing.Point(1005, 7)
        Me.qTimeLabel.Name = "qTimeLabel"
        Me.qTimeLabel.Size = New System.Drawing.Size(299, 39)
        Me.qTimeLabel.TabIndex = 29
        Me.qTimeLabel.Text = "This question took [] time"
        Me.qTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'commentLabel
        '
        Me.commentLabel.AutoSize = True
        Me.commentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.commentLabel.Location = New System.Drawing.Point(805, 494)
        Me.commentLabel.Name = "commentLabel"
        Me.commentLabel.Size = New System.Drawing.Size(166, 20)
        Me.commentLabel.TabIndex = 35
        Me.commentLabel.Text = "Answer Comments"
        '
        'ansTxtBox
        '
        Me.ansTxtBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ansTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ansTxtBox.Location = New System.Drawing.Point(215, 523)
        Me.ansTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ansTxtBox.Multiline = True
        Me.ansTxtBox.Name = "ansTxtBox"
        Me.ansTxtBox.ReadOnly = True
        Me.ansTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ansTxtBox.Size = New System.Drawing.Size(579, 157)
        Me.ansTxtBox.TabIndex = 28
        Me.ansTxtBox.TabStop = False
        '
        'prevButton
        '
        Me.prevButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevButton.Location = New System.Drawing.Point(8, 690)
        Me.prevButton.Margin = New System.Windows.Forms.Padding(4)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(208, 58)
        Me.prevButton.TabIndex = 4
        Me.prevButton.Text = "Previous Question"
        Me.prevButton.UseVisualStyleBackColor = True
        '
        'erButton
        '
        Me.erButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erButton.Location = New System.Drawing.Point(8, 648)
        Me.erButton.Margin = New System.Windows.Forms.Padding(4)
        Me.erButton.Name = "erButton"
        Me.erButton.Size = New System.Drawing.Size(200, 34)
        Me.erButton.TabIndex = 3
        Me.erButton.Text = "Examiner Report"
        Me.imageButtonToolTips.SetToolTip(Me.erButton, "Show the examiner's report for this question")
        Me.erButton.UseVisualStyleBackColor = True
        '
        'msButton
        '
        Me.msButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msButton.Location = New System.Drawing.Point(8, 546)
        Me.msButton.Margin = New System.Windows.Forms.Padding(4)
        Me.msButton.Name = "msButton"
        Me.msButton.Size = New System.Drawing.Size(200, 43)
        Me.msButton.TabIndex = 1
        Me.msButton.Text = "Mark Scheme"
        Me.imageButtonToolTips.SetToolTip(Me.msButton, "Show the mark scheme for this question")
        Me.msButton.UseVisualStyleBackColor = True
        '
        'qButton
        '
        Me.qButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qButton.Location = New System.Drawing.Point(8, 495)
        Me.qButton.Margin = New System.Windows.Forms.Padding(4)
        Me.qButton.Name = "qButton"
        Me.qButton.Size = New System.Drawing.Size(202, 43)
        Me.qButton.TabIndex = 0
        Me.qButton.Text = "Question"
        Me.imageButtonToolTips.SetToolTip(Me.qButton, "Show the question")
        Me.qButton.UseVisualStyleBackColor = True
        '
        'markPaperLabel
        '
        Me.markPaperLabel.AutoSize = True
        Me.markPaperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markPaperLabel.Location = New System.Drawing.Point(8, 18)
        Me.markPaperLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.markPaperLabel.Name = "markPaperLabel"
        Me.markPaperLabel.Size = New System.Drawing.Size(202, 39)
        Me.markPaperLabel.TabIndex = 22
        Me.markPaperLabel.Text = "Mark Paper"
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(1103, 690)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(208, 58)
        Me.nextButton.TabIndex = 27
        Me.nextButton.Text = "Next Question"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'questionGroupBox
        '
        Me.questionGroupBox.Controls.Add(Me.tablePanel)
        Me.questionGroupBox.Controls.Add(Me.mcqAnsLabel)
        Me.questionGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionGroupBox.Location = New System.Drawing.Point(8, 80)
        Me.questionGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.questionGroupBox.Name = "questionGroupBox"
        Me.questionGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.questionGroupBox.Size = New System.Drawing.Size(1297, 406)
        Me.questionGroupBox.TabIndex = 21
        Me.questionGroupBox.TabStop = False
        Me.questionGroupBox.Text = "(question number)"
        '
        'mcqAnsLabel
        '
        Me.mcqAnsLabel.AutoSize = True
        Me.mcqAnsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcqAnsLabel.Location = New System.Drawing.Point(541, 185)
        Me.mcqAnsLabel.Name = "mcqAnsLabel"
        Me.mcqAnsLabel.Size = New System.Drawing.Size(214, 69)
        Me.mcqAnsLabel.TabIndex = 0
        Me.mcqAnsLabel.Text = "Label1"
        Me.mcqAnsLabel.Visible = False
        '
        'tablePanel
        '
        Me.tablePanel.AutoScroll = True
        Me.tablePanel.Controls.Add(Me.answerTable)
        Me.tablePanel.Location = New System.Drawing.Point(7, 30)
        Me.tablePanel.Name = "tablePanel"
        Me.tablePanel.Size = New System.Drawing.Size(1283, 369)
        Me.tablePanel.TabIndex = 39
        '
        'answerTable
        '
        Me.answerTable.AutoSize = True
        Me.answerTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.answerTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.answerTable.ColumnCount = 4
        Me.answerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.answerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.answerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.answerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.answerTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.answerTable.Location = New System.Drawing.Point(0, 0)
        Me.answerTable.Name = "answerTable"
        Me.answerTable.RowCount = 1
        Me.answerTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.answerTable.Size = New System.Drawing.Size(1283, 4)
        Me.answerTable.TabIndex = 2
        '
        'markExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1328, 750)
        Me.Controls.Add(Me.markingPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1346, 797)
        Me.MinimumSize = New System.Drawing.Size(1346, 797)
        Me.Name = "markExam"
        Me.Text = "markExam"
        Me.markingPanel.ResumeLayout(False)
        Me.markingPanel.PerformLayout()
        Me.finalReviewPanel.ResumeLayout(False)
        Me.finalReviewPanel.PerformLayout()
        CType(Me.numMarksBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.questionGroupBox.ResumeLayout(False)
        Me.questionGroupBox.PerformLayout()
        Me.tablePanel.ResumeLayout(False)
        Me.tablePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents markingPanel As Panel
    Friend WithEvents numMarksBox As NumericUpDown
    Friend WithEvents commentTxtBox As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents marksLabel As Label
    Friend WithEvents ansLabel As Label
    Friend WithEvents qCompareLabel As Label
    Friend WithEvents qTimeLabel As Label
    Friend WithEvents commentLabel As Label
    Friend WithEvents ansTxtBox As TextBox
    Friend WithEvents prevButton As Button
    Friend WithEvents erButton As Button
    Friend WithEvents msButton As Button
    Friend WithEvents qButton As Button
    Friend WithEvents markPaperLabel As Label
    Friend WithEvents nextButton As Button
    Friend WithEvents questionGroupBox As GroupBox
    Friend WithEvents mcqAnsLabel As Label
    Friend WithEvents finalReviewPanel As Panel
    Friend WithEvents mainMenuButton As Button
    Friend WithEvents finalTimeLabel As Label
    Friend WithEvents finalMarkLabel As Label
    Friend WithEvents prevAnsButton As Button
    Friend WithEvents tablePanel As Panel
    Friend WithEvents answerTable As TableLayoutPanel
    Friend WithEvents imageButtonToolTips As ToolTip
End Class
