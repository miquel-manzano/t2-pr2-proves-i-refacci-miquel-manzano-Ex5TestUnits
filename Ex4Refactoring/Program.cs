using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.WriteLine("Introdueix l'amplada del rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introdueix l'altura del rectangle:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea d'un rectangle
        double area = CalculateArea(width, height);
        Console.WriteLine("L'àrea del rectangle és: " + area);


        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.WriteLine("Introdueix el radi del cercle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Calcula circumferència d'un cercle
        double circumference = CalculateCircumference(radius);
        Console.WriteLine("La circumferència del cercle és: " + circumference);

        // Imprimeix un missatge basat en el valor de l'àrea
        PrintMsgArea(area); 
    }


    public static double CalculateArea(double width, double height)
    {
        return width * height;
    }


    public static double CalculateCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static void PrintMsgArea(double area)
    {
        if (area > 50)
        {
            Console.WriteLine("L'àrea és més gran de 50");
        }
        else if (area > 20)
        {
            Console.WriteLine("L'àrea és entre 20 i 50");
        }
        else
        {
            Console.WriteLine("L'àrea és menor o igual a 20");
        }
    }

}