Public Class documents
    Public Property issuer As issuer
    Public Property receiver As receiver
    Public Property documentType As String
    Public Property documentTypeVersion As String
    Public Property dateTimeIssued As String
    Public Property taxpayerActivityCode As String
    Public Property internalId As String
    Public Property purchaseOrderReference As String
    Public Property purchaseOrderDescription As String
    Public Property salesOrderReference As String
    Public Property salesOrderDescription As String
    Public Property proformaInvoiceNumber As String
    Public Property payment As payment
    Public Property delivery As delivery
    Public Property invoiceLines As List(Of invoiceLines)
    Public Property totalSalesAmount As Decimal
    Public Property totalDiscountAmount As Decimal
    Public Property netAmount As Decimal
    Public Property taxTotals As List(Of taxTotals)
    Public Property extraDiscountAmount As Decimal
    Public Property totalItemsDiscountAmount As Decimal
    Public Property totalAmount As Decimal
    Public Property signatures As List(Of signatures)


End Class
