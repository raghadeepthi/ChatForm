using System;
using CalculatorLibrary;

class MyMath
{
    public int add(int a, int b)
    {
        return (a + b);
    }
}

class DelegateDemo
{
    static void Main()
    {
        MyMath m = new MyMath();
        MathOperation mo = new MathOperation(m.add);
        Calculator cal = new Calculator(mo);
        cal.CalculateAndPrint(10, 30);

    }
}

