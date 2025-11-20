Module Reservations
    Dim nbPlaceDisponible As Integer = 50
    Public Structure Resarvation
        Dim ligne As String
        Dim villeDepart As String
        Dim villeArrive As String
        Dim h_Debut As String
        Dim h_Fin As String
        Dim places As Integer
        Dim options As List(Of String)
        Dim type As String
        Public Sub initReservation()
            options = New List(Of String)
        End Sub
    End Structure
    Public listeReservation As New List(Of Resarvation)
    Public Function AjouterReservation(r As Resarvation)
        If r.places <= nbPlaceDisponible Then
            listeReservation.Add(r)
            nbPlaceDisponible = nbPlaceDisponible - r.places
            Return True
        Else
            Return False
        End If
    End Function
End Module
