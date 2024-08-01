Imports System.IO
Module modMain
    Public Sub WriteToFile(filePath As String, data As IEnumerable(Of String))
        Try
            File.WriteAllLines(filePath, data)
        Catch ex As Exception
            WriteErrLog(ex.Message, "WriteToFile")
        End Try
    End Sub

    Public Function ReadFromFile(filePath As String) As List(Of String)
        Try
            Return File.ReadAllLines(filePath).ToList()
        Catch file_ex As FileNotFoundException
            Return New List(Of String)()
        Catch ex As Exception
            WriteErrLog(ex.Message, "ReadFromFile")
        End Try
    End Function
    Public Sub WriteErrLog(ErrDesc As String, ProcName As String)
        Try
            Using writr As New StreamWriter(My.Application.Info.DirectoryPath & "\ErrLog.log", True)
                writr.WriteLine($"{Now & vbTab} Err: {ErrDesc} | From: {ProcName & vbCrLf}")
            End Using
        Catch ex As Exception
            MsgBox($"Error: {ErrDesc} | From: {ProcName & vbCrLf}")
        End Try
    End Sub
End Module
