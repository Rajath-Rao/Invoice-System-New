Public Class Product
    Public Property Name As String
    Public Property Description As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
    Public Property Category As String

    Public Sub New(name As String, description As String, price As Decimal, quantity As Integer, category As String)
        Me.Name = name
        Me.Description = description
        Me.Price = price
        Me.Quantity = quantity
        Me.Category = category
    End Sub

    Public Function ToCsvString() As String
        Return $"{Name},{Description},{Price},{Quantity},{Category}"
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Product
        Dim values = csvLine.Split(","c)
        Return New Product(values(0), values(1), Decimal.Parse(values(2)), Integer.Parse(values(3)), values(4))
    End Function
End Class
Public Class Category
    Public Property Name As String
    Public Property Description As String

    Public Sub New(name As String, description As String)
        Me.Name = name
        Me.Description = description
    End Sub

    Public Function ToCsvString() As String
        Return $"{Name},{Description}"
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Category
        Dim values = csvLine.Split(","c)
        Return New Category(values(0), values(1))
    End Function
End Class
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
        Return $"{Name},{Email},{Address},{ContactNumber}"
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Customer
        Dim values = csvLine.Split(","c)
        Return New Customer(values(0), values(1), values(2), values(3))
    End Function
End Class

Public Class Invoice
    Public Property Customer As Customer
    Public Property Products As List(Of Product)
    Public Property TotalAmount As Decimal
    Public Property PaymentOption As String

    Public Sub New(customer As Customer, products As List(Of Product), paymentOption As String)
        Me.Customer = customer
        Me.Products = products
        Me.PaymentOption = paymentOption
        Me.TotalAmount = CalculateTotalAmount()
    End Sub

    Private Function CalculateTotalAmount() As Decimal
        Return Products.Sum(Function(p) p.Price * p.Quantity)
    End Function

    Public Function ToCsvString() As String
        Dim productsCsv = String.Join(";", Products.Select(Function(p) p.ToCsvString()))
        Return $"{Customer.ToCsvString()},{productsCsv},{TotalAmount},{PaymentOption}"
    End Function

    Public Shared Function FromCsvString(csvLine As String) As Invoice
        Dim values = csvLine.Split(","c)
        Dim cust = Customer.FromCsvString(values(0))
        Dim products = values(1).Split(";"c).Select(Function(p) Product.FromCsvString(p)).ToList()
        Return New Invoice(cust, products, values(2))
    End Function
End Class