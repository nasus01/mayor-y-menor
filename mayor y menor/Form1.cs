using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_y_menor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gracias por utilizar mi programa--att:jack01");
            this.Close();
            
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            lblmayor.Text = "";
            lblmenor.Text = "";
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void Btnactivar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(txtnumero1.Text);
            num2 = int.Parse(txtnumero2.Text);
            if (num1 > num2)
            {
                lblmayor.Text = num2.ToString();
                lblmenor.Text = num1.ToString();
                lblmayor.Visible = true;
                lblmenor.Visible = true;

            }
            else
               if (num2 > num1)
            {
                lblmayor.Text = num2.ToString();
                lblmenor.Text = num1.ToString();
                lblmayor.Visible = true;
                lblmenor.Visible = true;

            }
            else
                if (num1 == num2)
            {
                MessageBox.Show("los dos digitos son iguales");
                lblmayor.Visible = false;
                lblmenor.Visible = false;
            }
        }
    }
}
