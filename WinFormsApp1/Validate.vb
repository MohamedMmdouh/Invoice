Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports RestSharp
Public Class Validate

    Public Function FindToken(ClientID As String, ClientSecret As String) As String

        Dim check As String
        Dim response As IRestResponse

        check = CheckNull(ClientID, ClientSecret)
        If check.Length > 0 Then
            Return check
        Else
            Dim client = New RestClient("https://id.preprod.eta.gov.eg/connect/token")
            client.Timeout = -1
            Dim request = New RestRequest(Method.POST)
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded")
            request.AddParameter("grant_type", "client_credentials")
            request.AddParameter("client_id", ClientID)
            request.AddParameter("client_secret", ClientSecret)
            request.AddParameter("scope", "InvoicingAPI")
            response = client.Execute(request)
        End If
        If response Is Nothing Then Return "bad request"
        Dim Result = CheckResponse(response)

        If Result.Contains("error") Or Result = "500" Then
            Return Result
        Else
            Return Result
        End If
    End Function


    Public Function CheckResponse(response As IRestResponse) As String

        Dim resp As New Result()
        resp = New Result
        Dim Message As String
        Dim myData As Result
        Try
            If response.StatusCode = HttpStatusCode.OK Then
                myData = JsonConvert.DeserializeObject(Of Result)(response.Content)
                Return myData.access_token
            ElseIf response.StatusCode = HttpStatusCode.BadRequest Then
                Message = response.Content
            ElseIf response.StatusCode = HttpStatusCode.InternalserverError Then
                Message = "500"
            End If
        Catch ex As Exception
            ' in case the structure of the object is not what we expected.
        End Try
        Return Message

    End Function

    Public Function CheckNull(ClientID As String, ClientSecret As String) As String
            Dim response As String
            If ClientID = "" And ClientSecret = "" Then
                response = "حدث خطأ أثناء الارسال"
            ElseIf ClientID = "" Or ClientID.Length < 5 Then
                response = "رقم العميل لا يمكن ان يكون فارغ"

            ElseIf ClientSecret = "" Or ClientSecret.Length < 5 Then
                response = "خطأ في كلمه المرور"
            Else
                response = ""
            End If
            Return response

        End Function

    End Class
