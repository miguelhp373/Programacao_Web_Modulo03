using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_POO
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cont01.Checked == true)
            {
                FrInterface_Corrente FrInterface_Corrente = new FrInterface_Corrente();
                FrInterface_Corrente.Show();
            }

            if (cont02.Checked == true)
            {
                FrInterface_Poupanca FrInterface_Poupanca = new FrInterface_Poupanca();
                FrInterface_Poupanca.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
