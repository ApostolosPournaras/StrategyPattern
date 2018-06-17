Module Module1

    Sub Main()

        Dim connan As New Warrior("Connan", New CantFight())
        connan.fightType.updateLevel()
        connan.attack()

        connan.fightType = New SwordFight()
        connan.fightType.updateLevel(10)
        connan.attack()
        connan.fightType.updateLevel(100)
        connan.attack()
        connan.fightType.updateLevel()
        connan.attack()

        Dim spaceSoldier As New Warrior("Stormtrooper", New LaserFight())
        spaceSoldier.fightType = New LaserFight()
        spaceSoldier.fightType.updateLevel(16)
        spaceSoldier.attack()
        spaceSoldier.fightType.updateLevel()
        spaceSoldier.attack()

        Dim gandalf As New Warrior("Gandalf the white", New MagicFight())
        gandalf.fightType.updateLevel(100)
        gandalf.attack()

        gandalf.fightType = New SwordFight()
        gandalf.fightType.updateLevel(20)
        gandalf.attack()

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
