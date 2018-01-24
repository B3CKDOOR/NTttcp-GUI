Public Class Form1
    Dim dataDirectory = Environment.CurrentDirectory
    Dim executable = dataDirectory + "\Skull.exe"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell(executable)
    End Sub
End Class
