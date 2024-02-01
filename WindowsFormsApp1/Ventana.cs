using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
        public abstract class Ventana
        {
            public Ventana(int pAlto, int pAncho)
            {
                material = "Vidrio";
                alto = pAlto;
                ancho = pAncho;
            }

            public string color;
            public string tamaño;
            public string forma;
            public bool estado;
            public int alto;
            public int ancho;
            public string material;

        public void propiedades()
        {
            MessageBox.Show("Color: " + color + "\n" +
                    "Tamaño " + tamaño + "\n" +
                    "Forma " + forma + "\n" +
                    "Alto = " + alto + "\n" +
                    "Ancho " + ancho + "\n"
                    );
        }
        public abstract int area(int pAlto, int pAncho);
        }



    }

