using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANTE
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btnregisusuari_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            this.Hide();
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" ESTA SEGURO DE CERRAR SECION"," TITULO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}
