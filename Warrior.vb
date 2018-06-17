Public Class Warrior

    Private nameValue As String
    Public Property name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property

    Private fightTypeValue As IFight
    Public Property fightType() As IFight
        Get
            Return fightTypeValue
        End Get
        Set(ByVal value As IFight)
            fightTypeValue = value
        End Set
    End Property

    Sub New(name As String, fighttype As IFight)
        Me.name = name
        Me.fightType = fighttype
    End Sub

    Public Sub attack()
        Dim attackResult = Me.fightType.Fight()
        Dim description As String = attackResult.Item2
        Dim damage As Integer = attackResult.Item1

        Console.WriteLine("I am " & Me.name & ". " & description & " I made " & damage & " damage.")
    End Sub

End Class
