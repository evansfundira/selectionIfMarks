Public Class Form1
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim Score As Integer

        'To test if a number was entered

        If IsNumeric(txtMark.Text) = True Then
            Score = txtMark.Text
        Else
            MsgBox("Enter a number please!")
            Exit Sub
        End If

        If Score < 0 Or Score > 100 Then
            MsgBox("You enterend an invalid score!")

        ElseIf Score >= 50 Then
            MsgBox("PASS!")

        ElseIf Score < 50 Then
            MsgBox("Fail!")



        End If
    End Sub
End Class
