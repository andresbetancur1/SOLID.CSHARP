using System;

public interface IEmployee
{
    string Fullname { get; set; }
    int HoursWorked { get; set; }

    decimal CalculateSalaryMonthly();
}
