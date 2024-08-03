Imports System.IO
Module modMain
    Public Const MsgboxHeader As String = "Store Manager"
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
    Public Function CalculateProductAmount(Price As Decimal, Qty As Integer, Optional DiscountPrcntg As Decimal = 0, Optional TaxPrcntg As Decimal = 0) As Decimal
        Try
            Dim total As Decimal = Price * Qty
            Return (total - (total * DiscountPrcntg / 100) + (total * TaxPrcntg / 100))
        Catch ex As Exception
            WriteErrLog(ex.Message, "CalculateProductAmount")
        End Try
    End Function
    'Function EscapeCsvField(field As String, Optional readwrite As Byte = 0) As String
    '    'readwrite: 0 = write to csv, 1 = read from csv
    '    Const escapecomma As String = "?comma?"
    '    Const escapedblqts As String = "?dblqts?"
    '    Try
    '        Dim returnstr As String
    '        If readwrite = 0 Then
    '            returnstr = field.Replace(",", escapecomma)
    '            returnstr = field.Replace("""", escapedblqts)
    '            Return returnstr
    '        Else
    '            returnstr = field.Replace(escapecomma, ",")
    '            returnstr = field.Replace(escapedblqts, """")
    '            Return returnstr
    '        End If
    '    Catch ex As Exception
    '        WriteErrLog(ex.Message, "EscapeCsvField")
    '    End Try
    'End Function
End Module







