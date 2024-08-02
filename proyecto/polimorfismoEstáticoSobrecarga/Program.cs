
using System;
public class Calculadora
{
    // Método para sumar dos números enteros
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método para sumar dos números flotantes
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    // Método para sumar tres números enteros
    public int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }
}

public class Program
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();

        // Llamada al método Sumar con dos enteros
        int resultado1 = calc.Sumar(5, 10);
        Console.WriteLine("Suma de dos enteros: " + resultado1);

        // Llamada al método Sumar con dos números de punto flotante
        double resultado2 = calc.Sumar(5.5, 10.5);
        Console.WriteLine("Suma de dos dobles: " + resultado2);

        // Llamada al método Sumar con tres enteros
        int resultado3 = calc.Sumar(1, 2, 3);
        Console.WriteLine("Suma de tres enteros: " + resultado3);
    }
}

