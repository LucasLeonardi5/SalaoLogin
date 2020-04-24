using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalãoLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtNum.Text = "";
            mskTel.Text = "";
            cmbServ.Text = "";
            dtpHora.Text = "";
        }

        private void DropDownList(object sender, EventArgs e)
        {

        }

        private void cmbServ_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
