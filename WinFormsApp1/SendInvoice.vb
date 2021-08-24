Public Class SendInvoice
    Public Function invoice() As WinFormsApp1.invoice
        Dim _invoice As New invoice()
        Dim documentsList As New List(Of documents)

        Dim Issure As issuer = New issuer With {
        .type = "",
        .id = "",
        .name = ""
        }
        Dim Address As New address()
        Dim issuerAddress As address = New address With {
        .branchId = "",
        .country = "",
        .governate = "",
        .regionCity = "",
        .street = "",
        .buildingNumber = ""
        }

        Dim _Resciver As receiver = New receiver With {
           .id = "",
           .type = "",
           .name = ""
        }
        Dim ReciveAddress As address = New address With {
                .country = "",
                .governate = "",
                .regionCity = "",
                .street = "",
                .buildingNumber = ""
        }
        Issure.address = issuerAddress
        _Resciver.address = ReciveAddress
        Dim invoiceLineList As New List(Of invoiceLines)
        documentsList.Add(New documents With
            {
                    .issuer = Issure,
                    .receiver = _Resciver,
                    .dateTimeIssued = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss z"),
                    .invoiceLines = invoiceLineList,
                    .documentType = "I",
                    .documentTypeVersion = "1.0"
             })
        invoice.documents = documentsList

    End Function


End Class
