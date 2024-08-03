'******************************************************************PRODUCT****************************************************
Public Class Product
    Public Property Name As String
    Public Property Description As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
    Public Property Category As String
    Public Property PercentgeDiscount As Decimal

    Public Sub New(name As String, description As String, price As Decimal, quantity As Integer, Optional category As String = "General", Optional discount As Decimal = 0)
        Me.Name = name
        Me.Description = description
        Me.Price = price
        Me.Quantity = quantity
        Me.Category = category
        Me.PercentgeDiscount = discount
    End Sub

    Public Function ToCsvString() As String
        Try
            Return $"{Name},{Description},{Price},{Quantity},{Category},{PercentgeDiscount}"
        Catch ex As Exception
            WriteErrLog(ex.Message, "ToCsvString")
        End Try
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Product
        Try
            Dim values = csvLine.Split(","c)
            Return New Product(values(0), values(1), Decimal.Parse(values(2)), Integer.Parse(values(3)), values(4), Decimal.Parse(values(5)))
        Catch ex As Exception
            WriteErrLog(ex.Message, "FromCsvString")
        End Try
    End Function
End Class
'******************************************************************CATEGORY****************************************************
Public Class Category
    Public Property Name As String
    Public Property Description As String

    Public Sub New(name As String, description As String)
        Me.Name = name
        Me.Description = description
    End Sub

    Public Function ToCsvString() As String
        Try
            Return $"{Name},{Description}"
        Catch ex As Exception
            WriteErrLog(ex.Message, "ToCsvString")
        End Try
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Category
        Try
            Dim values = csvLine.Split(","c)
            Return New Category(values(0), values(1))
        Catch ex As Exception
            WriteErrLog(ex.Message, "FromCsvString")
        End Try
    End Function
End Class
'******************************************************************CUSTOMER****************************************************
Public Class Customer
    Public Property Name As String
    Public Property Email As String
    Public Property Address As String
    Public Property ContactNumber As String

    Public Sub New(name As String, email As String, address As String, contactNumber As String)
        Me.Name = name
        Me.Email = email
        Me.Address = address
        Me.ContactNumber = contactNumber
    End Sub

    Public Function ToCsvString() As String
        Try
            Return $"{Name},{Email},{Address},{ContactNumber}"
        Catch ex As Exception
            WriteErrLog(ex.Message, "ToCsvString")
        End Try
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Customer
        Try
            Dim values = csvLine.Split(","c)
            Return New Customer(values(0), values(1), values(2), values(3))
        Catch ex As Exception
            WriteErrLog(ex.Message, "FromCsvString")
        End Try
    End Function
End Class
'******************************************************************INVOICE****************************************************

Public Class Invoice
    Public Property InvoiceDate As Date
    Public Property Customer As Customer
    Public Property Items As List(Of Cart)
    Public Property PaymentOption As String
    Public Property TotalAmount As Decimal

    Public Sub New(datetime As Date, customer As Customer, items As List(Of Cart), paymentOption As String, total As Decimal)
        Me.InvoiceDate = datetime
        Me.Customer = customer
        Me.Items = items
        Me.PaymentOption = paymentOption
        Me.TotalAmount = total
    End Sub

    Public Function ToCsvString() As String
        Try
            Dim itemsCsv = Replace(String.Join("|", Items.Select(Function(p) p.ToCsvString())), ",", "/")
            Dim custCsv = Replace(Customer.ToCsvString(), ",", "/")
            Return $"{InvoiceDate},{custCsv},{itemsCsv},{PaymentOption},{TotalAmount}"
        Catch ex As Exception
            WriteErrLog(ex.Message, "ToCsvString")
        End Try
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Invoice
        Try
            Dim values = csvLine.Split(","c)
            Dim cust = Customer.FromCsvString(Replace(values(1), "/", ","))
            Dim items = Replace(values(2), "/", ",").Split("|"c).Select(Function(p) Cart.FromCsvString(p)).ToList()
            Return New Invoice(Date.Parse(values(0)), cust, items, values(3), Decimal.Parse(values(4)))
        Catch ex As Exception
            WriteErrLog(ex.Message, "FromCsvString")
        End Try
    End Function
End Class
'******************************************************************CART***********************************************************

Public Class Cart
    Public Property Product As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
    Public Property Percentage_Discount As Decimal
    Public Property Amount As Decimal

    Public Sub New(name As String, price As Decimal, quantity As Integer, Optional discount As Decimal = 0)
        Me.Product = name
        Me.Price = price
        Me.Quantity = quantity
        Me.Percentage_Discount = discount
        Me.Amount = ((price - (Percentage_Discount * price / 100)) * quantity)
    End Sub
    Public Function ToCsvString() As String
        Try
            Return $"{Product},{Price},{Quantity},{Percentage_Discount},{Amount}"
        Catch ex As Exception
            WriteErrLog(ex.Message, "ToCsvString")
        End Try
    End Function
    Public Shared Function FromCsvString(csvLine As String) As Cart
        Try
            Dim values = csvLine.Split(","c)
            Return New Cart(values(0), Decimal.Parse(values(1)), Integer.Parse(values(2)), Decimal.Parse(values(3)))
        Catch ex As Exception
            WriteErrLog(ex.Message, "FromCsvString")
        End Try
    End Function
End Class
