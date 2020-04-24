using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SalãoLogin
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }
        private void abrirjanela(object obj)
        {
            Application.Run(new Form2());

        }
    }
}
