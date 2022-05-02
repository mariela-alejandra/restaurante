using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (tbusuario.Text=="leonardo")
            {
                if (tbcontraseña.Text=="1234")
                {

                    MessageBox.Show("Sesion Iniciada");
                    Form1 abrir = new Form1();
                    Login login = new Login();
                    login.Close();
                    abrir.Show();
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }
                
            }
            else
            {
                MessageBox.Show("usuario incorrecta");
            }
        }

        private void tbcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo números", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
