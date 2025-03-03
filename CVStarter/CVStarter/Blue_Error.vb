Public Class Blue_Error
	Public Sub ErrorBox(s As String)
		Me.ShowDialog()
		Label1.Text = s
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Close()
	End Sub
End Class