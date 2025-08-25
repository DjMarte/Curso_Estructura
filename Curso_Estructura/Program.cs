namespace Curso_Estructura;

class Program
{
    const int FILA = 3;
    const int COLUMNA = 3;

    static void Main(string[] args)
    {

        Genericidad<int>(50);
        Genericidad<string>("DjMarte");
       Console.WriteLine("----------------------------");

        int resultado = CalcularFactorial(0);
        Console.WriteLine($"El factorial es: {resultado}");


        int[,] arregloNumerico = new int[FILA, COLUMNA];


        /*
        for (int i = 0; i < FILA; i++) // recorrer las posiciones 
        {
            for (int j = 0; j < COLUMNA; j++) // recorres los valores que encuentre en cada posicion
            {
                System.Console.Write($"{arregloNumerico[i, j]}\t");
            }
            Console.WriteLine();
        }
        */

        // Arreglos tipos str
        string[] nombres = { "Alma", "Pedro", "Samuel", "DjMarte", "Goku", "Vegeta", "Naruto" };

        foreach (var listaNombre in nombres)
        {
            System.Console.WriteLine(listaNombre);
        }

        int[] numeros = { 43, 23, 10, 25, 30 };

        Console.WriteLine($"La suma total del arreglo es: {CalcularSuma(numeros)}");
    }

    // Funcion que recibe un arreglo

    public static int CalcularSuma(int[] arregloNumeros)
    {
        int suma = 0; // contador
        foreach (int numero in arregloNumeros)
        {
            suma = suma + numero;
        }
        return suma;
    }

    // Genericidad
    public static void Genericidad<T>(T dato)
    {
        System.Console.WriteLine($"El tipo de dato es: {typeof(T)}");
        System.Console.WriteLine($"El valor es: {dato}");
    }


    //recursividad
    public static int CalcularFactorial(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        else
        {
            return numero * CalcularFactorial(numero - 1);
        }

    }

}