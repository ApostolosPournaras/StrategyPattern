Public Class CantFight
    Implements IFight

    Private levelValue As Integer
    Public ReadOnly Property level As Integer Implements IFight.level
        Get
            Return levelValue
        End Get
    End Property

    Sub New()
        Me.levelValue = 0
    End Sub

    Public Function Fight() As Tuple(Of Integer, String) Implements IFight.Fight
        Return New Tuple(Of Integer, String)(0, "I'm helpless!!")
    End Function

    Public Sub updateLevel() Implements IFight.updateLevel
        Me.levelValue = 0
        Console.WriteLine("Cant update CantFight's level")
    End Sub

    Public Sub updateLevel(newLevel As Integer) Implements IFight.updateLevel
        Me.levelValue = 0
        Console.WriteLine("Cant update CantFight's level")
    End Sub

End Class