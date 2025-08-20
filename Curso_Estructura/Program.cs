namespace Curso_Estructura;

class Program
{
    static void Main(string[] args)
    {
        //suma de enteros

        //entrada
        int num1 = 5;
        int num2 = 6;

        //proceso
        int suma = num1 + num2;

        //salida
        Console.WriteLine("La suma es igual a: " + suma);


        // Entrada via usuario/cliente

        // Entrada
        int numero1, numero2, totalSum;

        Console.Write("Ingrese un primer numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un segundo numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        // Proceso
        totalSum = numero1 + numero2;

        // Salida
        Console.WriteLine("La suma es igual a: " + totalSum);


        //resta de decimales
        double a = 10.5;
        double b = 5.5;

        double resta = a - b;

        Console.WriteLine("La resta es igual a: " + resta);

        //multi de decimales
        float c = 8.5f;
        float d = 5.5f;

        float multi = c * d;

        Console.WriteLine("La multi es igual a: " + multi);


        //Concatenar cadenas
        string nombre = "Alma";
        string Apellido = "Marte";

        string nombreCompleto = nombre + " " + Apellido;

        Console.WriteLine("Nombre completo: " + nombreCompleto);


        //uso de char
        char letra = 'A';
        Console.WriteLine("La letra es: " + letra);

        //uso de bool
        int edad = 15;
        bool mayorDeEdad = edad >= 18;

        Console.WriteLine("Es mayor de edad? " + mayorDeEdad);

        // Operadores Logicos
        int p = 7;

        bool comprobarY = (p > 5) && (p < 10);
        Console.WriteLine("Dame la comprobacion: " + comprobarY);

        bool comprobarO = (p > 5) || (p < 6);
        Console.WriteLine("Dame la comprobacion: " + comprobarO);

        bool comprobarNegacion = !(p > 5);
        Console.WriteLine("Dame la comprobacion: " + comprobarNegacion);
    }
}