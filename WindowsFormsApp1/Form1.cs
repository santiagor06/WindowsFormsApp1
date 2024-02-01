using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            webBrowser1.Visible = false;
            Matriz();
        }                                   
        private void Message()
        {
          
            //Marco _Marco = new Marco(15, 20, "Tubo");

            //MessageBox.Show(
            //                //"El alto de la ventana es de :" + _Ventana.alto + "\n"                                          +
            //                //"El ancho de la ventana es de :" + _Ventana.ancho + "\n" +
            //                //"El material es " + _Ventana.material + "\n" +
            //                "\n" +
            //                "El alto del marco es de :" + _Marco.alto + "\n" +
            //                "El ancho del marco es de :" + _Marco.ancho + "\n" +
            //                "El material es " + _Marco.material + "\n" +
            //                "El area del marco es de:" + _Marco.area(_Marco.alto, _Marco.ancho)
            //                );


        }
        private void Matriz()
        {
            int[,] matriz = new int[6, 5];
                    Random random=new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    matriz[i, j] = random.Next(1, 50);

                }
            }
            string cadena = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                 
                    cadena +=(j==0)? $"{matriz[i, j]}": $",{matriz[i, j]}";

                }
                cadena += "\n";
            }
            MessageBox.Show(cadena);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            button1.Visible=true;
            webBrowser1.Visible=true;  
        }
    }
}
