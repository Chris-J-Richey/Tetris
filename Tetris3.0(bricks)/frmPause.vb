Public Class frmPause

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim p As New Form
        p = frmHelp
        p.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim p As New Form
        p = frmStart
        p.TopMost = True
        p.Show()
    End Sub

    Private Sub frmPause_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim key As KeyEventArgs
        key = e
        If key.KeyCode = Keys.P Then
            Me.Close()
        End If
    End Sub
End Class