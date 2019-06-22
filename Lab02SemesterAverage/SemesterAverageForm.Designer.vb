<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterAverageForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCaclulate = New System.Windows.Forms.Button()
        Me.ToolTipGuide = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblValidation = New System.Windows.Forms.Label()
        Me.lblGradeResult1 = New System.Windows.Forms.Label()
        Me.lblGradeResult2 = New System.Windows.Forms.Label()
        Me.lblGradeResult3 = New System.Windows.Forms.Label()
        Me.lblGradeResult4 = New System.Windows.Forms.Label()
        Me.lblGradeResult5 = New System.Windows.Forms.Label()
        Me.lblGradeResult6 = New System.Windows.Forms.Label()
        Me.lblGradeResultSemester = New System.Windows.Forms.Label()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCourse1
        '
        Me.lblCourse1.AutoSize = True
        Me.lblCourse1.Location = New System.Drawing.Point(25, 25)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course 1:"
        Me.ToolTipGuide.SetToolTip(Me.lblCourse1, "Name of the Course")
        '
        'txtCourse1
        '
        Me.txtCourse1.Location = New System.Drawing.Point(83, 17)
        Me.txtCourse1.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse1.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse1.TabIndex = 1
        Me.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipGuide.SetToolTip(Me.txtCourse1, "Enter the Student Grade 0 to 100")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(221, 437)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(126, 437)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.ToolTipGuide.SetToolTip(Me.btnReset, "Reset the App")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCaclulate
        '
        Me.btnCaclulate.Location = New System.Drawing.Point(28, 437)
        Me.btnCaclulate.Name = "btnCaclulate"
        Me.btnCaclulate.Size = New System.Drawing.Size(75, 23)
        Me.btnCaclulate.TabIndex = 22
        Me.btnCaclulate.Text = "&Calculate"
        Me.ToolTipGuide.SetToolTip(Me.btnCaclulate, "Calculate Semester Average")
        Me.btnCaclulate.UseVisualStyleBackColor = True
        '
        'txtCourse2
        '
        Me.txtCourse2.Location = New System.Drawing.Point(83, 50)
        Me.txtCourse2.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse2.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse2.TabIndex = 4
        Me.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipGuide.SetToolTip(Me.txtCourse2, "Enter the Student Grade 0 to 100")
        '
        'lblCourse2
        '
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Location = New System.Drawing.Point(25, 58)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course 2:"
        Me.ToolTipGuide.SetToolTip(Me.lblCourse2, "Name of the Course")
        '
        'txtCourse6
        '
        Me.txtCourse6.Location = New System.Drawing.Point(83, 182)
        Me.txtCourse6.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse6.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse6.TabIndex = 16
        Me.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipGuide.SetToolTip(Me.txtCourse6, "Enter the Student Grade 0 to 100")
        '
        'lblCourse6
        '
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Location = New System.Drawing.Point(25, 189)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course 6:"
        Me.ToolTipGuide.SetToolTip(Me.lblCourse6, "Name of the Course")
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(25, 221)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(54, 13)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "Semester:"
        Me.ToolTipGuide.SetToolTip(Me.lblSemester, "Sememster")
        '
        'lblValidation
        '
        Me.lblValidation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValidation.Location = New System.Drawing.Point(28, 248)
        Me.lblValidation.Name = "lblValidation"
        Me.lblValidation.Size = New System.Drawing.Size(268, 173)
        Me.lblValidation.TabIndex = 21
        Me.ToolTipGuide.SetToolTip(Me.lblValidation, "Validation Errors will show here")
        '
        'lblGradeResult1
        '
        Me.lblGradeResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResult1.Location = New System.Drawing.Point(196, 17)
        Me.lblGradeResult1.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult1.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult1.Name = "lblGradeResult1"
        Me.lblGradeResult1.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResult1.TabIndex = 2
        Me.lblGradeResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResult1, "Letter Grade")
        '
        'lblGradeResult2
        '
        Me.lblGradeResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResult2.Location = New System.Drawing.Point(196, 51)
        Me.lblGradeResult2.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult2.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult2.Name = "lblGradeResult2"
        Me.lblGradeResult2.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResult2.TabIndex = 5
        Me.lblGradeResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResult2, "Letter Grade")
        '
        'lblGradeResult3
        '
        Me.lblGradeResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResult3.Location = New System.Drawing.Point(196, 81)
        Me.lblGradeResult3.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult3.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult3.Name = "lblGradeResult3"
        Me.lblGradeResult3.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResult3.TabIndex = 8
        Me.lblGradeResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResult3, "Letter Grade")
        '
        'lblGradeResult4
        '
        Me.lblGradeResult4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResult4.Location = New System.Drawing.Point(196, 114)
        Me.lblGradeResult4.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult4.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult4.Name = "lblGradeResult4"
        Me.lblGradeResult4.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResult4.TabIndex = 11
        Me.lblGradeResult4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResult4, "Letter Grade")
        '
        'lblGradeResult5
        '
        Me.lblGradeResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResult5.Location = New System.Drawing.Point(196, 148)
        Me.lblGradeResult5.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult5.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult5.Name = "lblGradeResult5"
        Me.lblGradeResult5.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResult5.TabIndex = 14
        Me.lblGradeResult5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResult5, "Letter Grade")
        '
        'lblGradeResult6
        '
        Me.lblGradeResult6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResult6.Location = New System.Drawing.Point(196, 182)
        Me.lblGradeResult6.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult6.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResult6.Name = "lblGradeResult6"
        Me.lblGradeResult6.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResult6.TabIndex = 17
        Me.lblGradeResult6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResult6, "Letter Grade")
        '
        'lblGradeResultSemester
        '
        Me.lblGradeResultSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeResultSemester.Location = New System.Drawing.Point(196, 214)
        Me.lblGradeResultSemester.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResultSemester.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblGradeResultSemester.Name = "lblGradeResultSemester"
        Me.lblGradeResultSemester.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeResultSemester.TabIndex = 20
        Me.lblGradeResultSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblGradeResultSemester, "Semester Letter Grade")
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverage.Location = New System.Drawing.Point(85, 214)
        Me.lblSemesterAverage.MaximumSize = New System.Drawing.Size(100, 20)
        Me.lblSemesterAverage.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(100, 20)
        Me.lblSemesterAverage.TabIndex = 19
        Me.lblSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipGuide.SetToolTip(Me.lblSemesterAverage, "Semester Average")
        '
        'lblCourse3
        '
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Location = New System.Drawing.Point(25, 90)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course 3:"
        '
        'txtCourse3
        '
        Me.txtCourse3.Location = New System.Drawing.Point(83, 82)
        Me.txtCourse3.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse3.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse3.TabIndex = 7
        Me.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourse4
        '
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Location = New System.Drawing.Point(25, 122)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course 4:"
        '
        'txtCourse4
        '
        Me.txtCourse4.Location = New System.Drawing.Point(83, 115)
        Me.txtCourse4.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse4.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse4.TabIndex = 10
        Me.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourse5
        '
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Location = New System.Drawing.Point(25, 156)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course 5:"
        '
        'txtCourse5
        '
        Me.txtCourse5.Location = New System.Drawing.Point(83, 149)
        Me.txtCourse5.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse5.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse5.TabIndex = 13
        Me.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SemesterAverageForm
        '
        Me.AcceptButton = Me.btnCaclulate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(324, 472)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblGradeResultSemester)
        Me.Controls.Add(Me.lblGradeResult6)
        Me.Controls.Add(Me.lblGradeResult5)
        Me.Controls.Add(Me.lblGradeResult4)
        Me.Controls.Add(Me.lblGradeResult3)
        Me.Controls.Add(Me.lblGradeResult2)
        Me.Controls.Add(Me.lblGradeResult1)
        Me.Controls.Add(Me.lblValidation)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.btnCaclulate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtCourse1)
        Me.Controls.Add(Me.lblCourse1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(340, 511)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(340, 511)
        Me.Name = "SemesterAverageForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1 As Label
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ToolTipGuide As ToolTip
    Friend WithEvents btnCaclulate As Button
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents lblValidation As Label
    Friend WithEvents lblGradeResult1 As Label
    Friend WithEvents lblGradeResult2 As Label
    Friend WithEvents lblGradeResult3 As Label
    Friend WithEvents lblGradeResult4 As Label
    Friend WithEvents lblGradeResult5 As Label
    Friend WithEvents lblGradeResult6 As Label
    Friend WithEvents lblGradeResultSemester As Label
    Friend WithEvents lblSemesterAverage As Label
End Class
