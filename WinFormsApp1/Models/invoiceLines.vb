Public Class invoiceLines
    Public Property description As String
    Public Property itemType As String
    Public Property itemCode As String
    Public Property unitType As String
    Public Property quantity As Decimal
    Public Property unitValue As unitValue
    Public Property salesTotal As Decimal
    Public Property total As Decimal
    Public Property valueDifference As Decimal
    Public Property totalTaxableFees As Decimal
    Public Property netTotal As Decimal
    Public Property itemsDiscount As Decimal
    Public Property discount As Decimal
    Public Property taxableItems As List(Of taxableItems)
    Public Property internalCode As String
End Class
