Public Class frmHome
    Private Sub btn_ClickHome(sender As Object, e As EventArgs) Handles btnProductManager.Click, btnGenerateInvoice.Click, btnCustomerInfo.Click, btnUpdateCategory.Click
        Try
            pnlHome.Hide()
            Select Case sender
                Case btnProductManager

                Case btnUpdateCategory

                Case btnCustomerInfo

                Case btnGenerateInvoice

            End Select
        Catch ex As Exception
            WriteErrLog(ex.Message, "btn_ClickHome")
        End Try
    End Sub
End Class
