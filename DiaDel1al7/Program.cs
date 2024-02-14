using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDel1al7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número del 1 al 7");
            int numero = Convert.ToInt32(Console.ReadLine());

            string diaSemana = "";

            switch (numero)
            {
                case 1:
                    diaSemana = "Lunes";
                    break;
                case 2:
                    diaSemana = "Martes";
                    break;
                case 3:
                    diaSemana = "Miércoles";
                    break;
                case 4:
                    diaSemana = "Jueves";
                    break;
                case 5:
                    diaSemana = "Viernes";
                    break;
                case 6:
                    diaSemana = "Sábado";
                    break;
                case 7:
                    diaSemana = "Domingo";
                    break;
                default:
                    Console.WriteLine("Número no válido.");
                    return;
            }

            Console.WriteLine($"El número {numero} es el día {diaSemana} .");
        }
    }
}
