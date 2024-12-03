using System;

public class Program
{
    // Constantes:
    const string MsgWidthRetangle = "Introdueix l'amplada del rectangle:";
    const string MsgHeightRetangle = "Introdueix l'altura del rectangle:";
    const string MsgAreaResult = "L'àrea del rectangle és: ";

    const string MsgRadiusCircle = "Introdueix el radi del cercle:";
    const string MsgCircleResult = "La circumferència del cercle és: ";

    const string MsgAreaIsGreater = "L'àrea és més gran de 50";
    const string MsgAreaIsEqual = "L'àrea és entre 20 i 50";
    const string MsgAreaIsLower = "L'àrea és menor o igual a 20";

    const string MsgInvalidNum = "Error, torna a provar: ";

    public static void Main(string[] args)
    {
        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.WriteLine(MsgWidthRetangle);
        double width = UserNumIntput();
        Console.WriteLine(MsgHeightRetangle);
        double height = UserNumIntput();

        // Calcula l'àrea d'un rectangle
        double area = CalculateArea(width, height);
        Console.WriteLine(MsgAreaResult + area);


        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.WriteLine(MsgRadiusCircle);
        double radius = UserNumIntput();

        // Calcula circumferència d'un cercle
        double circumference = CalculateCircumference(radius);
        Console.WriteLine(MsgCircleResult + circumference);

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
            Console.WriteLine(MsgAreaIsGreater);
        }
        else if (area > 20)
        {
            Console.WriteLine(MsgAreaIsEqual);
        }
        else
        {
            Console.WriteLine(MsgAreaIsLower);
        }
    }

    public static double UserNumIntput()
    {
        double userNum;
        bool chekUserNum = double.TryParse(Console.ReadLine(), out userNum);

        while (!chekUserNum)
        {
            Console.WriteLine(MsgInvalidNum);
            chekUserNum = double.TryParse(Console.ReadLine(), out userNum);
        }
        return userNum;
    }

}