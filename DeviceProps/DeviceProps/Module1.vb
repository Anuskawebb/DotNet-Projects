' Base class
Public Class Device
    Public Sub DisplayType()
        Console.WriteLine("This is a generic device.")
    End Sub
End Class

' Intermediate class
Public Class SmartDevice
    Inherits Device

    Public Sub DisplaySmartFeatures()
        Console.WriteLine("This device has smart features.")
    End Sub
End Class

' Derived class: Smartphone
Public Class Smartphone
    Inherits SmartDevice

    Public Sub MakeCall()
        Console.WriteLine("Making a call from the smartphone.")
    End Sub
End Class

' Derived class: Smartwatch
Public Class Smartwatch
    Inherits SmartDevice

    Public Sub TrackHealth()
        Console.WriteLine("Tracking health data on the smartwatch.")
    End Sub
End Class

' Demonstration
Module Module1
    Sub Main()
        Dim phone As New Smartphone()
        phone.DisplayType()
        phone.DisplaySmartFeatures()
        phone.MakeCall()

        Dim watch As New Smartwatch()
        watch.DisplayType()
        watch.DisplaySmartFeatures()
        watch.TrackHealth()
        Console.ReadKey()
    End Sub
End Module
