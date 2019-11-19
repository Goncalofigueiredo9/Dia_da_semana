using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_da_semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        diadasemana dia = new diadasemana();

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dia.recebe = textBox1.Text;
            label2.Text = dia.envia;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                dia.recebe = textBox1.Text;
                label2.Text = dia.envia;
                label2.Text = ("O dia da semana é " + dia.envia);
            }
        }
    }
}
