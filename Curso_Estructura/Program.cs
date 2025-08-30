namespace Curso_Estructura;

class Program
{
    static void Main(string[] args)
    {
        // Búsqueda Binaria
        int[] arreglo = { 20, 25, 15, 3, 2, 1, 9, 19, 10 };
        //  0,  1,  2,  3, 4, 5, 6, 7,  8

        int valorBuscado = 15;

        Console.Write("Arreglo desordenado: ");

        foreach (int numero in arreglo)
        {
            System.Console.Write($"{numero}\t");
        }

        Console.WriteLine("\n");

        OrdenamientoBurbuja(arreglo);

        Console.Write("Arreglo ordenado: ");

        foreach (int numero in arreglo)
        {
            System.Console.Write($"{numero}\t");
        }

        System.Console.WriteLine("\n");

        int resultado = BusquedaBinaria(arreglo, valorBuscado);

        // Validacion
        if (resultado == -1)
        {
            Console.WriteLine($"El dato {valorBuscado} no se encuentra en tu arreglo");
        }
        else
        {
            Console.WriteLine($"El dato {valorBuscado} se encuentra en el indice {resultado} de tu arreglo");
        }


    }
    
    public static int BusquedaBinaria(int[] arreglo, int valorBuscado)
    {
        int bajo = 0; // Se ubica en el indice inicial del arreglo
        int alto = arreglo.Length - 1; // Se ubica en el indice final del arreglo

        while (bajo <= alto)
        {
            int medio = bajo + (alto - bajo) / 2; // Se encuentra el centro del arreglo (posiciones)
            //           0   + (8 - 0) / 2 = 4     

            if (arreglo[medio] == valorBuscado)
            {
                return medio; // 4
            }

            if (arreglo[medio] < valorBuscado)
            {
                bajo = medio + 1; // Va a ignorar todas posiciones a la izquierda
            }

            else
            {
                alto = medio - 1; // Va a ignorar todas posiciones a la derecha
            }

        }

        return -1; // Retorna -1, si el valorBuscado no se encuentra en nuestro arreglo.
    }





    public static void Intercambio(int x, int y, int[] arreglo)
    {
        int aux = arreglo[x];
        arreglo[x] = arreglo[y];
        arreglo[y] = aux;
    }

    public static void OrdenamientoBurbuja(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            for (int j = 0; j < arreglo.Length - 1 - i; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    Intercambio(j, j + 1, arreglo);
                }
            }
        }
    }


}