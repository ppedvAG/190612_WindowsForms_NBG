Public Class Konto
    Private _kontostand As String
    Public Property Kontostand() As Decimal
        Get
            Return _kontostand
        End Get
        Set(ByVal value As Decimal)
            _kontostand = value
        End Set
    End Property

    Public Sub Einzahlen(betrag As Decimal)
        Kontostand = Kontostand + betrag
    End Sub
End Class