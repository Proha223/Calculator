﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Substract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        return a / b;
    }
    public double SquareRoot(double d)
    {
        return Math.Sqrt(d);
    }
}