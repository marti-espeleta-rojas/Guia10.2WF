using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia10._2WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region métodos y variables estáticas del form
        static int contador=0;
        static int acumulador = 0;
        static double CalcularPromedio()
        {
            double promedio = 0;
            promedio = acumulador / contador;
            return promedio;
        }
        static void ProcesarNumero(int num)
        {
            contador++;
            acumulador += num;
        }
        static int[] Burbuja(int[]vecNumeros)
        {

            return vecNumeros;
        }
        #endregion
        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            int[] vecNum = new int[100];
            int numero = Convert.ToInt32(tbNumero.Text);
            ProcesarNumero(numero);

            tbNumero.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
