using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado = new Empleados();
            empleado.Edad = 25;
            empleado.Nombre = "Jesus Armando";
            //empleado.SueldoDiario = 255.5m;
            
            Console.WriteLine("Introduce el sueldo diario: ");
            var sueldodiario = Console.ReadLine();
            empleado.SueldoDiario = Convert.ToDecimal(sueldodiario);
            decimal total = empleado.CalculaSalario(30);

            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es: " + total.ToString("C") + 
                " (Sueldo Diario = " + empleado.SueldoDiario.ToString("C") + ")");
            Console.ReadKey();


        }
    }
}
