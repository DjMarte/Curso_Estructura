using System.Data;

namespace Curso_Estructura;
/*
class Program
{
    //Metodo busqueda secuencial
    static int busquedaSecuencial(int[] arreglo, int valorBuscado)
    {
        //se recorre el arreglo
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valorBuscado) //si se encuentra el valor se devuelve su posicion
            {
                return i; //se retorna la posicion donde se encontró el valor
            }
        }
        return -1; 
    }


    static void Main(string[] args)
    {
        int[] numeros = { 10, 25, 3, 47, 8, 15, 92 }; //arreglo de enteros

        int valorABuscar = 10; //valor que queremos buscar

        int resultado = busquedaSecuencial(numeros, valorABuscar); //realiza la buqueda secuencial
        
        //-1 indica que no se encontró el valor a buscar
        if (resultado != -1)
        {
            System.Console.WriteLine($"El numero {valorABuscar} se encontró en la posicion {resultado}");
        }
        else
        {
            System.Console.WriteLine($"El numero {valorABuscar} no se encontró en el arreglo");
        }
    }
    
}

//Prog oriendata a objetos. Ejemplo 1
class Persona //clase
{
    public string Nombre; //atributo

    public Persona(string nombre) //constructor
    {
        Nombre = nombre;
    }

    public void Saludar() //metodo
    {
        System.Console.WriteLine("Hola, soy " + Nombre);
    }


}

class Program
{
    static void Main()//creando un objeto e invocando su metodo
    {
        Persona p = new Persona("Alma");
        p.Saludar(); //llamando al metodo
    }
}

*/
//Prog oriendata a objetos. Ejemplo 2 SIN CONSTRUCTOR

/*
public class Estudiante
{
    //atributos
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
    public string Matricula { get; set; }

    //constructor

    //metodo
    public void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {Nombre}");
        System.Console.WriteLine($"Apellido: {Apellido}");
        System.Console.WriteLine($"Edad: {Edad}");
        System.Console.WriteLine($"Carrera: {Carrera}");
        System.Console.WriteLine($"Matricula: {Matricula}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //crear al objeto
        Estudiante e = new Estudiante();

        //se le asignan los valores a los atributos
        e.Nombre = "Enmanuel";
        e.Apellido = "Garcia";
        e.Edad = 20;
        e.Carrera = "Ing en Sis";
        e.Matricula = "2023-2596";

        //se llama al metodo
        e.MostrarInfo();
    }
}
*/

//Prog oriendata a objetos. Ejemplo 2 CON CONSTRUCTOR
public class Estudiante
{
    //atributos
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
    public string Matricula { get; set; }

    //constructor
    public Estudiante(string nombre, string apellido, int edad, string carrera, string matricula)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Carrera = carrera;
        Matricula = matricula;
    }
    //metodo
    public void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {Nombre}");
        System.Console.WriteLine($"Apellido: {Apellido}");
        System.Console.WriteLine($"Edad: {Edad}");
        System.Console.WriteLine($"Carrera: {Carrera}");
        System.Console.WriteLine($"Matricula: {Matricula}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //crear al objeto
        Estudiante e = new Estudiante("Alma", "Marte", 21, "Ing en Sis", "20220078");

        //se llama al metodo
        e.MostrarInfo();
    }
}

