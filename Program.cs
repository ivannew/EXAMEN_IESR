using EXAMEN_IESR.metodos;
using Microsoft.VisualBasic;

namespace EXAMEN_IESR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intervalo
             Console.Write("Introduce el primer número del intervalo: ");
             int inicio = int.Parse(Console.ReadLine());

             Console.Write("Introduce el segundo número del intervalo: ");
             int final = int.Parse(Console.ReadLine());

             Tabla tabla = new Tabla();
             tabla.CalcularIntervalo(inicio, final);

            //Calculadora
              Console.WriteLine("ingrese el numero que quiere multiplicar");
              int numero = Convert.ToInt32(Console.ReadLine());

              Tabla tabla1 = new Tabla();
              tabla1.CalcularTabla(numero, 1);

            //El de la curp
            Console.WriteLine("ingrese su curp(18 digitos)");
            string curp = Console.ReadLine();
            



        }
    }
}