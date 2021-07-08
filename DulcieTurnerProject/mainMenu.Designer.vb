<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.title = New System.Windows.Forms.Label()
        Me.takeExamButton = New System.Windows.Forms.Button()
        Me.viewProgressButton = New System.Windows.Forms.Button()
        Me.addQuestionButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.SystemColors.Window
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(133, 122)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(526, 51)
        Me.title.TabIndex = 0
        Me.title.Text = "Physics Paper Generator"
        '
        'takeExamButton
        '
        Me.takeExamButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.takeExamButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.takeExamButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.takeExamButton.Location = New System.Drawing.Point(3, 2)
        Me.takeExamButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.takeExamButton.Name = "takeExamButton"
        Me.takeExamButton.Size = New System.Drawing.Size(208, 62)
        Me.takeExamButton.TabIndex = 1
        Me.takeExamButton.Text = "Take an Exam"
        Me.takeExamButton.UseVisualStyleBackColor = False
        '
        'viewProgressButton
        '
        Me.viewProgressButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewProgressButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.viewProgressButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewProgressButton.Location = New System.Drawing.Point(3, 68)
        Me.viewProgressButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.viewProgressButton.Name = "viewProgressButton"
        Me.viewProgressButton.Size = New System.Drawing.Size(208, 62)
        Me.viewProgressButton.TabIndex = 2
        Me.viewProgressButton.Text = "View Your Progress"
        Me.viewProgressButton.UseVisualStyleBackColor = False
        '
        'addQuestionButton
        '
        Me.addQuestionButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addQuestionButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.addQuestionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addQuestionButton.Location = New System.Drawing.Point(3, 134)
        Me.addQuestionButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addQuestionButton.Name = "addQuestionButton"
        Me.addQuestionButton.Size = New System.Drawing.Size(208, 63)
        Me.addQuestionButton.TabIndex = 3
        Me.addQuestionButton.Text = "Add Questions"
        Me.addQuestionButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.takeExamButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.addQuestionButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.viewProgressButton, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(293, 213)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(214, 199)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "mainMenu"
        Me.Text = "Physics Paper Generator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents takeExamButton As Button
    Friend WithEvents viewProgressButton As Button
    Friend WithEvents addQuestionButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
