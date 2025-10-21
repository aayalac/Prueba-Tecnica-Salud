using System;

public class Program
{
    public static int GetMedia(int n)
    {
        int moduloA;
        int moduloB;
        string mensaje;

        moduloA = n % 3;
        moduloB = n % 3;
        
        if (moduloA == moduloB) {         
            return -1;
        }
        else
        {
            int media = (moduloA + moduloB) / 2;
            return media;
        }       
    }

    public static (int totalA, int totalB, int totalC) GetPyramid(int levels)
    {
        Console.WriteLine($"Piramide de {levels} niveles, Modulo A:");
        int totalStars = 0;
        for (int i = 1; i <= levels; i++)
        {
            totalStars += i;            
            Console.WriteLine(new string(' ', levels - i) + new string('#', i) );
        }

        Console.WriteLine($"Piramide de {levels} niveles, Modulo B:");
        int totalStars1 = 0;
        for (int i = levels; i >= 1; i--)
        {
            totalStars1 += i;
            Console.WriteLine(new string(' ', levels - i) + new string('#', i));
        }

        Console.WriteLine($"Piramide de {levels} niveles, Modulo C:");
        int totalStars3 = 0;
        for (int i = 1; i <= levels; i++)
        {
            totalStars += i;
            Console.WriteLine(new string(' ', levels - i) + new string('#', i));
        }
        while(totalStars3 < levels * (levels + 1) / 2)
        {
            for (int i = levels; i >= 1; i--)
            {
                totalStars3 += i;
                Console.WriteLine(new string(' ', levels - i) +  new string('#', i));
            }
        }

        return (totalStars, totalStars1, totalStars3);
    }

    static void Main(string[] args)
    {
        // Prueba de la función GetMedia
        int resultado = GetMedia(5);
        Console.WriteLine("Resultado de función GetMedia:");
        if (resultado != -1)
            System.Console.WriteLine(resultado);
        else
            System.Console.WriteLine("Sin moda");
        Console.WriteLine("-----------------------");

        // Prueba de la función GetPyramid
        int valorModulo = 4;
        var (totalEstrellasA, totalEstrellasB, toltalEstrellasC) = GetPyramid(valorModulo);
        Console.WriteLine("-----------------------");
    }
}