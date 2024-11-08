' Base class
Public Class Employee
    Public Overridable Function CalculateBonus(salary As Double) As Double
        Return salary * 0.1 ' Default bonus calculation (10% of salary)
    End Function
End Class

' Derived class: Manager
Public Class Manager
    Inherits Employee

    Public Overrides Function CalculateBonus(salary As Double) As Double
        Return salary * 0.2 ' Manager bonus calculation (20% of salary)
    End Function
End Class

' Derived class: SalesPerson
Public Class SalesPerson
    Inherits Employee

    Public Overrides Function CalculateBonus(salary As Double) As Double
        Return salary * 0.15 ' SalesPerson bonus calculation (15% of salary)
    End Function
End Class

' Demonstration
Module Module1
    Sub Main()
        Dim manager As New Manager()
        Console.WriteLine("Manager Bonus: " & manager.CalculateBonus(50000))

        Dim salesPerson As New SalesPerson()
        Console.WriteLine("SalesPerson Bonus: " & salesPerson.CalculateBonus(40000))

        Console.ReadLine()
    End Sub
End Module
