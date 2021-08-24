Public Class address

    Public Property branchId() As String
        Get
            Return _branchId
        End Get
        Set
            _branchId = Value
        End Set
    End Property


    Private _branchId As String

    Public Property country() As String
        Get
            Return _country
        End Get
        Set
            _country = Value
        End Set
    End Property
    Private _country As String

    Public Property governate() As String
        Get
            Return _governate
        End Get
        Set
            _governate = Value
        End Set
    End Property
    Private _governate As String

    Public Property regionCity() As String
        Get
            Return _regionCity
        End Get
        Set
            _regionCity = Value
        End Set
    End Property
    Private _regionCity As String

    Public Property street() As String
        Get
            Return _street
        End Get
        Set
            _street = Value
        End Set
    End Property
    Private _street As String

    Public Property buildingNumber() As String
        Get
            Return _buildingNumber
        End Get
        Set
            _buildingNumber = Value
        End Set
    End Property
    Private _buildingNumber As String


    Public Property postalCode() As String
        Get
            Return _postalCode
        End Get
        Set
            _postalCode = Value
        End Set
    End Property
    Private _postalCode As String

    Public Property floor() As String
        Get
            Return _floor
        End Get
        Set
            _floor = Value
        End Set
    End Property
    Private _floor As String
    Public Property room() As String
        Get
            Return _room
        End Get
        Set
            _room = Value
        End Set
    End Property
    Private _room As String

    Public Property landmark() As String
        Get
            Return landmark
        End Get
        Set
            landmark = Value
        End Set
    End Property
    Private _landmark As String
    Public Property additionalInformation() As String
        Get
            Return _additionalInformation
        End Get
        Set
            additionalInformation = Value
        End Set
    End Property
    Private _additionalInformation As String


End Class
