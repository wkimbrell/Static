using System;

public static class Calculator
{
    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static double Divide(double x, double y)
    {
        return x / y;
    }

    public static double Modulo(double x, double y)
    {
        return x % y;
    }


}


/* 2 non-static attributes
* 2 static attributes
* 2 non-static methods
* 1 static method
*
*
* id: 1111
* name: Alice
* university: Augusta University
* Number of students: 1
*
* id: 1112
* name: Bob
* university: Augusta University
* Number of students: 2
*
* It wouldn't work unless you had an instance as a parameter
*/
