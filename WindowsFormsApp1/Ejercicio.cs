using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Ejercicio
    {
        public string nombre;
        public string apellido;
        public int num1;
        public int num2;
        public Ejercicio(string nombre,string apellido,int num1,int num2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.num1 = num1;
            this.num2 = num2;
        }

        public int suma()
        {
            return num1+num2;
        }
    }
}
