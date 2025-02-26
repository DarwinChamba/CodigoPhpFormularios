using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        //objeto de la clase Mateamtica declarado
        Matematica mat;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 =int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            calcularOperacion();
            mat = new Matematica(num1, num2);
             
        }

        private void calcularOperacion()
        {
            if(sumar.Checked)
            {
               
                MessageBox.Show("La suma es: " + mat.sumar());
                result.Text = mat.sumar().ToString();
            }
            if (restar.Checked)
            {
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Persona p = new Persona();
                p.Show();

        }
    }
}
