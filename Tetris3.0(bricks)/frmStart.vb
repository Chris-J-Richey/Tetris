Public Class frmStart

    Public gamelevel As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'prevents you from going to high or low in levels
        If level.Text > 1 Then
            leveldown.Enabled = True
        Else
            leveldown.Enabled = False
        End If
        If level.Text < 10 Then
            levelup.Enabled = True
        Else
            levelup.Enabled = False
        End If
    End Sub

    Private Sub levelup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles levelup.Click
        'change level
        level.Text += 1
    End Sub

    Private Sub leveldown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leveldown.Click
        'change level
        level.Text -= 1
    End Sub

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Dim p As New Form
        'changes speed of piecies and opens game
        If level.Text = 1 Then
            gamelevel = 130
        ElseIf level.Text = 2 Then
            gamelevel = 120
        ElseIf level.Text = 3 Then
            gamelevel = 110
        ElseIf level.Text = 4 Then
            gamelevel = 100
        ElseIf level.Text = 5 Then
            gamelevel = 90
        ElseIf level.Text = 6 Then
            gamelevel = 80
        ElseIf level.Text = 7 Then
            gamelevel = 70
        ElseIf level.Text = 8 Then
            gamelevel = 60
        ElseIf level.Text = 9 Then
            gamelevel = 50
        ElseIf level.Text = 10 Then
            gamelevel = 40
        End If
        frmMain.movesdown.Interval = gamelevel
        p = frmMain
        Me.TopMost = False
        p.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        frmHelp.Show()
    End Sub
End Class