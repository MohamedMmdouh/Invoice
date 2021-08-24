Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports RestSharp

Public Class Form1
    Shared Sub Main()
        Dim Test As New Validate
        Test.FindToken("ca80e4f0-8d2b-46d0-80a9-98c428c185b7", "a11a71ce-c29d-4a3c-9faa-3f26a4e19750")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FindToken("", "")
    End Sub

    Public Function FindToken(ClientID As String, ClientSecret As String) As String

        Dim client = New RestClient("https://id.preprod.eta.gov.eg/connect/token")
        client.Timeout = -1
        Dim request = New RestRequest(Method.POST)
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded")
        request.AddHeader("", "")
        request.AddHeader("Cookie", "3f6bf69972563c3e0e619b78edf73035=a13cec801711e4a98f3debc310d43a18")
        request.AddParameter("grant_type", "client_credentials")
        request.AddParameter("client_id", ClientID)
        request.AddParameter("client_secret", ClientSecret)
        request.AddParameter("scope", "InvoicingAPI")
        Dim response As IRestResponse = client.Execute(request)

        Return response


    End Function

End Class
