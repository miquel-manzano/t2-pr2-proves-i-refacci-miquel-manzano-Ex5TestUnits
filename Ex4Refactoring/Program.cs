using System;

namespace Ex4Refactoring
{
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

        public static void Main(string[] args)
        {
            // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
            Console.WriteLine(MsgWidthRetangle);
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MsgHeightRetangle);
            double height = Convert.ToDouble(Console.ReadLine());

            // Calcula l'àrea d'un rectangle
            double area = CalculateArea(width, height);
            Console.WriteLine(MsgAreaResult + area);


            // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
            Console.WriteLine(MsgRadiusCircle);
            double radius = Convert.ToDouble(Console.ReadLine());

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
    }
}