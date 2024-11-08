' Base class
Public Class Shape
    Public Overridable Function CalculateArea() As Double
        Return 0
    End Function
End Class

' Derived class: Circle
Public Class Circle
    Inherits Shape
    Public Property Radius As Double

    Public Sub New(radius As Double)
        Me.Radius = radius
    End Sub

    Public Overrides Function CalculateArea() As Double
        Return Math.PI * Radius * Radius
    End Function
End Class

' Derived class: Rectangle
Public Class Rectangle
    Inherits Shape
    Public Property Length As Double
    Public Property Width As Double

    Public Sub New(length As Double, width As Double)
        Me.Length = length
        Me.Width = width
    End Sub

    Public Overrides Function CalculateArea() As Double
        Return Length * Width
    End Function
End Class

' Demonstration
Module Module1
    Sub Main()
        Dim circle As New Circle(5)
        Console.WriteLine("Area of Circle: " & circle.CalculateArea())

        Dim rectangle As New Rectangle(4, 6)
        Console.WriteLine("Area of Rectangle: " & rectangle.CalculateArea())
    End Sub
End Module
