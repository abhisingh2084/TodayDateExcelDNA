using ExcelDna.Integration;
using System;

public class ExcelFunctions
{
    [ExcelFunction(Name = "Func.Date", Description = "Returns today's date")]
    public static object GetToday()
    {
        return DateTime.Today;
    }

    [ExcelFunction(Name = "Func.2DArray", Description = "Return a 2x2 Array")]

    public static object[,] Get2DArray()
    {
        return new object[,] { { 1, 2 }, { 3, 4 } };
    }

     
}
  