namespace Curso_Estructura;
//condiciones
public class Program
{
    static void Main(string[] args)
    {

        //saber si es mayor de edadd
        int edad = 18;

        if (edad >= 18)
        {
            System.Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            System.Console.WriteLine("Eres menor de edad");
        }

        //calificar notas

        int nota = 89;

        if (nota >= 90)
        {
            System.Console.WriteLine("ta pasao");
        }
        else if (nota >= 70)
        {
            System.Console.WriteLine("pasaste a chepa");
        }
        else
        {
            System.Console.WriteLine("ta quemao");
        }

        //saber si un numero es neg o posi

        int numero;
        System.Console.WriteLine("Ingrese un numero");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            System.Console.WriteLine("El numero es positivo");

        }
        else if (numero < 0)
        {
            System.Console.WriteLine("El numero es negativo");
        }
        else
        {
            System.Console.WriteLine("Cero");
        }


        //edades

        System.Console.WriteLine("Ingresa tu edad: ");
        int edad1 = Convert.ToInt32(Console.ReadLine());

        if (edad1 < 10)
        {
            System.Console.WriteLine("Eres un carajito");
        }
        else if (edad1 >= 10 && edad1 <= 18)
        {
            System.Console.WriteLine("Eres adolescente");
        }
        else if (edad1 >= 19 && edad1 <= 45)
        {
            System.Console.WriteLine("Eres adulto");
        }
        else
        {
            System.Console.WriteLine("Eres viejo");
        }

    }
}
