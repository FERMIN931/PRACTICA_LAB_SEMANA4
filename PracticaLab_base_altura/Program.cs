using System;

class Program
{
    // Función para calcular el área del rectángulo
    static double CalcularArea(double baseRec, double altu)
    {
        return baseRec * altu;
    }

    static void Main()
    {
        // Solicitar al usuario que ingrese la base y la altura del rectángulo
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Llamar a la función para calcular el área
        double area = CalcularArea(baseRectangulo, altura);

        // Mostrar el resultado
        Console.WriteLine($"El área del rectángulo es: {area}");

        // Esperar para que el usuario vea el resultado
        Console.ReadKey();
    }
}