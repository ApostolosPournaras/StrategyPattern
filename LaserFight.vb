Public Class LaserFight
    Implements IFight

    
    Private levelValue As Integer
    Public ReadOnly Property level As Integer Implements IFight.level
        Get
            Return levelValue
        End Get
    End Property

    Sub New()
        Me.levelValue = 1
    End Sub

    Public Function Fight() As Tuple(Of Integer, String) Implements IFight.Fight
        Return New Tuple(Of Integer, String)(Me.level + 5, "I use laser beams!!")
    End Function

    Public Sub updateLevel() Implements IFight.updateLevel
        Me.levelValue += 1
    End Sub

    Public Sub updateLevel(newLevel As Integer) Implements IFight.updateLevel
        Me.levelValue = newLevel
    End Sub
End Class
