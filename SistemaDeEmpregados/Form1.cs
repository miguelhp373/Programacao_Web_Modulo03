using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEmpregados
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }

        Empregado EMP = new Empregado();

        private void button1_Click(object sender, EventArgs e)
        {
            EMP.ImprimirDados(Convert.ToInt32(id_field.Text), name_field.Text, Convert.ToDouble(salario_field.Text), cargo_field.Text);

            if (porcentagem_field.Text.Length > 0)
            {
                EMP.AumentarSalario(Convert.ToDouble(porcentagem_field.Text),Convert.ToDouble(salario_field.Text));
                lb_sal.Text = Convert.ToString(EMP.salario);
            }
            else
            {
                lb_sal.Text = Convert.ToString(EMP.salario);
            }

            lb_id.Text      = Convert.ToString(EMP.id);
            lb_name.Text    = EMP.nome;
            lb_cargo.Text   = EMP.cargo;


        }

        private void FrMenu_Load(object sender, EventArgs e)
        {
            //limpa Campos do formulário
            lb_id.Text      = "";
            lb_name.Text    = "";
            lb_sal.Text     = "";
            lb_cargo.Text   = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_id.Text      = "";
            lb_name.Text    = "";
            lb_sal.Text     = "";
            lb_cargo.Text   = "";

            lb_id.Text      = "";
            lb_name.Text    = "";
            lb_sal.Text     = "";
            lb_cargo.Text   = "";
        }
    }
}
