using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    public class Empleados
    {
        public Empleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        //public string Nombre;
        private string _Nombre;
        public decimal SueldoDiario;
        public int Edad;

        // ENCAPSULAMIENTO: Sirve para poder tener una variable privada
        // _Nombre de la clase, pero que pueda ser accesada públicamente 
        // mediante la variable pública Nombre.
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public decimal CalculaSalario(int Dias)
        {
            return Dias * SueldoDiario;
        }
    }
}
