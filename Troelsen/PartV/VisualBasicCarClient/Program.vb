Imports System
Imports CarLibrary

Module Program
    Sub Main(args As String())
        Dim myMiniVan As New MiniVan()
        myMiniVan.TurboBoost()

        Dim mySportsCar As New SportsCar()
        mySportsCar.TurboBoost()

        Dim dreamCar As New PerfomanceCar()
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()
        Console.ReadLine()
    End Sub
End Module
