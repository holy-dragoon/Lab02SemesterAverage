'@name: Lab 02 : Semester Average'
'description: Form to receive individual course grades.'
' Each grade will output the letter value.  A final calculation will
' give the final average of all grades.  Form can be reset to run form repeatedly. ' 
'@author: Shaun McCrum'
'@since: 21 May 2019'
Option Strict On
Public Class SemesterAverageForm
#Region "DECLARATIONS"
    Private Const MINIMUM_GRADE As Double = 0   'lowest possible grade'
    Private Const MAXIMUM_GRADE As Double = 100 'highest possible grade'
    Private Const COURSE_VALUES As Integer = 6  'course per semester for array indexing'

    Private gradeValue As Double = 0.0

    Private gradesValues(COURSE_VALUES - 1) As TextBox  'array for storing user text boxes'
    Private numberGrades(COURSE_VALUES - 1) As Double   'array for holding numeric converted grades'
    Private courseNames(COURSE_VALUES - 1) As Label     'array for holding course label names'
    Private letterGrades(COURSE_VALUES - 1) As Label    'array for holding grade letter labels 


#End Region

#Region "FORM AND CONTROLS"
    ''' <summary>
    ''' Form load declaration assignments
    ''' </summary>
    Private Sub SemesterAverageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'assign course labels for iteration access'
        courseNames(0) = lblCourse1
        courseNames(1) = lblCourse2
        courseNames(2) = lblCourse3
        courseNames(3) = lblCourse4
        courseNames(4) = lblCourse5
        courseNames(5) = lblCourse6

        'assign grade text boxesassign course labels for iteration access'
        gradesValues(0) = txtCourse1
        gradesValues(1) = txtCourse2
        gradesValues(2) = txtCourse3
        gradesValues(3) = txtCourse4
        gradesValues(4) = txtCourse5
        gradesValues(5) = txtCourse6

        'assign result text boxes assign course labels for iteration access'
        letterGrades(0) = lblGradeResult1
        letterGrades(1) = lblGradeResult2
        letterGrades(2) = lblGradeResult3
        letterGrades(3) = lblGradeResult4
        letterGrades(4) = lblGradeResult5
        letterGrades(5) = lblGradeResult6

    End Sub

    ''' <summary>
    ''' btnExit_Click Exits the application
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()      'exit the application'
    End Sub

    ''' <summary>
    ''' btnReset_Click clears all values and clears the form
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()     'call subroutine to clear form'
    End Sub

    ''' <summary>
    ''' btnCaclulate_Click will calculate the semester average.
    ''' </summary>
    Private Sub btnCaclulate_Click(sender As Object, e As EventArgs) Handles btnCaclulate.Click
        Dim validCalculate As Boolean = False
        Dim sumSemester As Double = 0.0     '
        Dim averageSemester As Double = 0.0
        Dim errorMessage As String = ""  'set an emppty error message
        lblValidation.Text = "" 'clearn any existing error'

        'Loop through the grades array And do the following
        'determine if number is valid assign it to the array
        'or generate error messages to be stored
        For indexCounter As Integer = 0 To gradesValues.Length - 1
            If (ValidateGrade(gradesValues(indexCounter).Text)) Then
                validCalculate = True 'flag the boolean as true for this iteration'
                numberGrades(indexCounter) = CDbl(gradesValues(indexCounter).Text)
            Else
                errorMessage += "Please ensure that what you input in " &
                courseNames(indexCounter).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
                validCalculate = False
            End If
        Next

        'if validation flag is true and our error message is empty, proceed
        If validCalculate = True And String.IsNullOrEmpty(errorMessage) Then
            'loop through the array and  disable text boxes
            For indexCounter As Integer = 0 To gradesValues.Length - 1
                gradesValues(indexCounter).ReadOnly = True
            Next
            'disable calculate button
            btnCaclulate.Enabled = False
            'call and calculate average'
            averageSemester = AverageGrades(numberGrades)
            'output the average grade and assign a letter grade to the value and output''
            lblSemesterAverage.Text = Math.Round(averageSemester, 2).ToString
            lblGradeResultSemester.Text = LetterGrade(averageSemester)
        Else 'an error was found, set an output meessage'
            lblValidation.Text = "ERROR(s)" & vbCrLf & errorMessage
        End If
    End Sub

    'Not in this scope of this assignment, but I could have dynamically created'
    'these focus textbox handlers which would simplified other code'
    ''' <summary>
    ''' txtCourse_Leave validates the value in the text box when no longer user focused.
    ''' </summary>
    Private Sub txtCourse1_Leave(sender As Object, e As EventArgs) Handles txtCourse1.Leave
        'Declare event variables for validation'
        Dim userInput As String = ""
        Dim userGrade As Double = 0.00
        userInput = gradesValues(0).Text 'Assign the text to a variable'
        'If the user input is validated cast as a double and evaluate its grade letter'
        If ValidateGrade(userInput) = True Then
            userGrade = CDbl(userInput)
            lblGradeResult1.Text = LetterGrade(userGrade)
        Else  'entry was not valid create error message '
            txtCourse1.SelectAll()
            lblValidation.Text += "Please ensure that what you input in " &
                courseNames(0).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
        End If
    End Sub

    ''' <summary>
    ''' txtCourse_Leave validates the value in the text box when no longer user focused.
    ''' </summary>
    Private Sub txtCourse2_Leave(sender As Object, e As EventArgs) Handles txtCourse2.Leave
        'Declare event variables for validation'
        Dim userInput As String = ""
        Dim userGrade As Double = 0.00
        userInput = gradesValues(1).Text 'Assign the text to a variable'
        'If the user input is validated cast as a double and evaluate its grade letter'
        If ValidateGrade(userInput) = True Then
            userGrade = CDbl(userInput)
            lblGradeResult2.Text = LetterGrade(userGrade)
        Else  'entry was not valid create error message '
            txtCourse2.SelectAll()
            lblValidation.Text += "Please ensure that what you input in " &
                courseNames(1).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
        End If
    End Sub

    ''' <summary>
    ''' txtCourse_Leave validates the value in the text box when no longer user focused.
    ''' </summary>
    Private Sub txtCourse3_Leave(sender As Object, e As EventArgs) Handles txtCourse3.Leave
        'Declare event variables for validation'
        Dim userInput As String = ""
        Dim userGrade As Double = 0.00
        userInput = gradesValues(2).Text 'Assign the text to a variable'
        'If the user input is validated cast as a double and evaluate its grade letter'
        If ValidateGrade(userInput) = True Then
            userGrade = CDbl(userInput)
            lblGradeResult3.Text = LetterGrade(userGrade)
        Else  'entry was not valid create error message '
            txtCourse3.SelectAll()
            lblValidation.Text += "Please ensure that what you input in " &
                courseNames(2).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
        End If
    End Sub

    ''' <summary>
    ''' txtCourse_Leave validates the value in the text box when no longer user focused.
    ''' </summary>
    Private Sub txtCourse4_Leave(sender As Object, e As EventArgs) Handles txtCourse4.Leave
        'Declare event variables for validation'
        Dim userInput As String = ""
        Dim userGrade As Double = 0.00
        userInput = gradesValues(3).Text 'Assign the text to a variable'
        'If the user input is validated cast as a double and evaluate its grade letter'
        If ValidateGrade(userInput) = True Then
            userGrade = CDbl(userInput)
            lblGradeResult4.Text = LetterGrade(userGrade)
        Else  'entry was not valid create error message '
            txtCourse4.SelectAll()
            lblValidation.Text += "Please ensure that what you input in " &
                courseNames(3).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
        End If
    End Sub

    ''' <summary>
    ''' txtCourse_Leave validates the value in the text box when no longer user focused.
    ''' </summary>
    Private Sub txtCourse5_Leave(sender As Object, e As EventArgs) Handles txtCourse5.Leave
        'Declare event variables for validation'
        Dim userInput As String = ""
        Dim userGrade As Double = 0.00
        userInput = gradesValues(4).Text 'Assign the text to a variable'
        'If the user input is validated cast as a double and evaluate its grade letter'
        If ValidateGrade(userInput) = True Then
            userGrade = CDbl(userInput)
            lblGradeResult5.Text = LetterGrade(userGrade)
        Else  'entry was not valid create error message '
            txtCourse5.SelectAll()
            lblValidation.Text += "Please ensure that what you input in " &
                courseNames(4).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
        End If
    End Sub

    ''' <summary>
    ''' txtCourse_Leave validates the value in the text box when no longer user focused.
    ''' </summary>
    Private Sub txtCourse6_Leave(sender As Object, e As EventArgs) Handles txtCourse6.Leave
        'Declare event variables for validation'
        Dim userInput As String = ""
        Dim userGrade As Double = 0.00
        userInput = gradesValues(5).Text 'Assign the text to a variable'
        'If the user input is validated cast as a double and evaluate its grade letter'
        If ValidateGrade(userInput) = True Then
            userGrade = CDbl(userInput)
            lblGradeResult6.Text = LetterGrade(userGrade)
        Else  'entry was not valid create error message '
            txtCourse6.SelectAll()
            lblValidation.Text += "Please ensure that what you input in " &
                courseNames(5).Text.Replace(":", "") & " is a number between 0 and 100" & vbCrLf
        End If
    End Sub
#End Region

#Region "SUBROUTINES AND FUNCTIONS"

    ''' <summary>
    ''' ClearForm subroutine empties out all inputs and resets the form to default states.
    ''' </summary>
    Private Sub ClearForm()
        'empty array related labels and text boxes'
        For i As Integer = 0 To gradesValues.Length - 1
            gradesValues(i).Clear()             'Clear grade input'
            gradesValues(i).ReadOnly = False     'Enable the user input'
            letterGrades(i).Text = ""           'Clear grade letter labels'
        Next
        'empty unique result outputs'
        lblGradeResultSemester.Text = ""
        lblSemesterAverage.Text = ""
        btnCaclulate.Enabled = True         'Enable enter button'
        txtCourse1.Select()                 'set the cursor to the user input'
        lblValidation.Text = ""             'reset the validation label'
        gradeValue = 0.0                    'reset any grade value'
    End Sub

    ''' <summary>
    ''' AverageGrades will loop through an array and calculate its average value
    ''' </summary>
    ''' <param name="gradeArray">Receivs an array of grade values</param>
    ''' <returns></returns>
    Private Function AverageGrades(ByVal gradeArray() As Double) As Double
        Dim averageSemester As Double = 0.0
        Dim sumSemester As Double = 0.0
        'Loop through the array sum the values in the array for average calculation'
        For indexCounter As Integer = 0 To gradeArray.Length - 1
            'debugging array line
            Console.WriteLine("index is " & indexCounter & ", and value is " & gradeArray(indexCounter))
            sumSemester += gradeArray(indexCounter)
        Next
        'process the average calculation'
        averageSemester = sumSemester / gradeArray.Length
        Return averageSemester
    End Function

    ''' <summary>
    ''' ValidateGrade determines if passed value is a double between 1 and 100
    ''' </summary>
    ''' <param name="userInput">text box user input</param>
    ''' <returns>boolean state if valid</returns>
    Private Function ValidateGrade(userInput As String) As Boolean
        Dim validGrade As Boolean = False  'assume false until proven true'
        If IsNumeric(userInput) Then    'if the user input is a number value'
            'If text string value can be parsed as an Double we know it can be used as a grade'
            If Double.TryParse(userInput, gradeValue) Then
                If gradeValue >= MINIMUM_GRADE And gradeValue <= MAXIMUM_GRADE Then
                    validGrade = True
                End If
                'Else will return false due to out of range'
            End If
            'Else will return false due not being a double'
        End If
        'Else will return false due to not being numeric'
        Return validGrade
    End Function

    ''' <summary>
    ''' LetterGrade assigns a grade value based on a double 
    ''' </summary>
    ''' <param name="gradeValue">passes validated double</param>
    ''' <returns>Letter grade string</returns>
    Private Function LetterGrade(gradeValue As Double) As String
        Dim gradeString As String = ""
        'Assign the grade to the corresponding value defined by the data set'
        If gradeValue >= MINIMUM_GRADE And gradeValue <= MAXIMUM_GRADE Then
            If gradeValue >= 90 And gradeValue <= 100 Then
                gradeString = "A+"
            ElseIf gradeValue >= 85 And gradeValue < 90 Then
                gradeString = "A"
            ElseIf gradeValue >= 80 And gradeValue < 90 Then
                gradeString = "A-"
            ElseIf gradeValue >= 77 And gradeValue < 85 Then
                gradeString = "B+"
            ElseIf gradeValue >= 73 And gradeValue < 77 Then
                gradeString = "B"
            ElseIf gradeValue >= 70 And gradeValue < 73 Then
                gradeString = "B-"
            ElseIf gradeValue >= 67 And gradeValue < 70 Then
                gradeString = "C+"
            ElseIf gradeValue >= 63 And gradeValue < 67 Then
                gradeString = "C"
            ElseIf gradeValue >= 60 And gradeValue < 63 Then
                gradeString = "C-"
            ElseIf gradeValue >= 57 And gradeValue < 60 Then
                gradeString = "D+"
            ElseIf gradeValue >= 53 And gradeValue < 57 Then
                gradeString = "D"
            ElseIf gradeValue >= 50 And gradeValue < 53 Then
                gradeString = "D-"
            Else
                gradeString = "F"
            End If
        End If
        'return the Letter Grade
        Return gradeString
    End Function
#End Region
End Class
