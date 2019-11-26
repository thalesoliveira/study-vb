Public Class Plantas

    Public Property common As String
    Public Property botanical As String
    Public Property zone As String
    Public Property light As String
    Public Property price As String
    Public Property availability As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal common_ As String, ByVal botanical_ As String, ByVal zone_ As String, ByVal light_ As String, ByVal price_ As String, ByVal availability_ As String)
        common = common_
        botanical = botanical_
        zone = zone_
        light = light_
        price = price_
        availability = availability_

    End Sub


End Class
