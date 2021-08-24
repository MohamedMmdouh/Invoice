Public Class Result

    Public Property access_token() As String
        Get
            Return accesstoken
        End Get
        Set
            accesstoken = Value
        End Set
    End Property
    Private accesstoken As String

    Public Property expires_in() As String
        Get
            Return expiresin
        End Get
        Set
            expiresin = Value
        End Set
    End Property
    Private expiresin As String

    Public Property token_type() As String
        Get
            Return tokentype
        End Get
        Set
            tokentype = Value
        End Set
    End Property

    Private tokentype As String
    Public Property scope() As String
        Get
            Return _scope
        End Get
        Set
            _scope = Value
        End Set
    End Property
    Private _scope As String


    Public Class Collectionss
        Public Property column As Result()
    End Class

End Class
