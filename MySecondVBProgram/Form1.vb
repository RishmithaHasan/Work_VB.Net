Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the text from the text boxes
        Dim text1 As String = TextBox1.Text
        Dim text2 As String = TextBox2.Text

        ' Combine the text into a single string
        Dim combinedText As String = "Text Box 1: " & text1 & vbCrLf & "Text Box 2: " & text2

        ' Specify the path for the text file
        Dim filePath As String = "C:\Users\Mypc\source\repos\MySecondVBProgram\VB.NET.txt"

        ' Write the combined text to the file
        Try
            File.WriteAllText(filePath, combinedText)
            MessageBox.Show("Text saved to file successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
