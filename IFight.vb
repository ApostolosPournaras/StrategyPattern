Public Interface IFight

    ReadOnly Property level As Integer
    Sub updateLevel(newLevel As Integer)
    Sub updateLevel()
    Function Fight() As Tuple(Of Integer, String)

End Interface

