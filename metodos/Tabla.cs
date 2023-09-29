using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_IESR.metodos
{
    internal class Tabla
    {
        public void CalcularIntervalo(int inicio, int final)
        {

            if (inicio > final)
            {
                Console.WriteLine("El número de inicio debe ser menor o igual al número final.");
            }
            else
            {

                for (int numero = inicio; numero <= final; numero++)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        public void CalcularTabla(int numero, int multiplicador)
        {
            if (multiplicador <= 10)
            {
                int resultado = numero * multiplicador;

                Console.WriteLine($"{numero}x{multiplicador}={resultado}");

                CalcularTabla(numero, ++multiplicador);
            }
           
        }


        public void CalcularDatos(string fecha, string datos, int digitos)
        {
            for(int i = 0; i < datos.Length; i++)
            {
                if(digitos>18)
                {
                    Console.WriteLine("lo siento son demaciados digitos");

                }
                else if (digitos > 18)
                {
                    Console.WriteLine("lo siento faltan digitos");
                }
                else
                {

                }



            }
           
        }




    }
}
