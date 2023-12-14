using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        Triangulo triangulo = new Triangulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            triangulo.alturaTriangulo = Convert.ToDouble(txtBoxAltura.Text);
            triangulo.baseTriangulo = Convert.ToDouble(txtBoxBase.Text);
            lbResulado.Text = triangulo.calcularArea().ToString();
        }
    }
}
