namespace Curso_Estructura;

class Program
{
    static void Main(string[] args)
    {
        // Switch

        // Dias de la semana

        // Entrada
        /*int dia;

        Console.WriteLine("Ingrese un dia de la semana entre [1-7] de la semana");
        dia = Convert.ToInt32(Console.ReadLine());

        // Proceso
        switch (dia)
        {
            case 1:
                // Salida
                System.Console.WriteLine("Domingo");
                break;
            case 2:
                System.Console.WriteLine("Lunes");
                break;
            case 3:
                System.Console.WriteLine("Martes");
                break;
            case 4:
                System.Console.WriteLine("Miercoles");
                break;
            case 5:
                System.Console.WriteLine("Jueves");
                break;
            case 6:
                System.Console.WriteLine("Viernes");
                break;
            case 7:
                System.Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("Brother no son 8 dias, son solo 7 y si pusiste un caracter, tampoco va a funcionar");
                break;
        }
        */

        // Ciclo For

        //for (/* Declaracion -->*/ int i = 0; /* condicion -->*/ i < 3; /* Incremento/Decremento */ i++)
        /*{
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{i}\t");
            }
            Console.Write("\n");
        }*/



        // Ciclo while

        /*int num = 5;

        while (num <= 5)
        {
            System.Console.WriteLine(num);
            num++;
        }*/



        // Do-While

        /*int num = 0;

        do
        {
            Console.WriteLine(num);
            num++;
        } while (num <= 5);
        */

        // ciclo for each

        // Entrada
        int[] arreglo = {1, 2, 3, 4, 5};
        //               0, 1, 2, 3, 4 -> Posiciones

        // Proceso
        foreach (int numeros in arreglo)
        {
            // Salida
            Console.WriteLine(numeros);
        }
    }
}