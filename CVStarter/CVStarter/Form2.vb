Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Product: " & My.Application.Info.ProductName
        Label2.Text = "Version: " & My.Application.Info.Version.ToString
        Label3.Text = My.Application.Info.Copyright
        Label4.Text = My.Application.Info.CompanyName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class