using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RESTAURANTE
{
    public partial class INICIO_SECION : Form
    {
        public INICIO_SECION()
        {
            InitializeComponent();
        }
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =D:\\UAB\\ing software\\PROYECTO UAB\\BDRestaurante.accdb");
       
        private void btncancelar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Adios"));
            Application.Exit();
        }

        private void INICIO_SECION_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conectado");
            }
            catch (Exception a)
            {
                MessageBox.Show("error por :" + a.ToString());
            }

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string consulta = "select Ci,Apellido_P from registrousuarios where Apellido_P ='" + txtusuario.Text + "' and Ci ='" + txtcontraseña.Text + "'; ";
            OleDbCommand comando = new OleDbCommand(consulta,conexion);
            OleDbDataReader lectordatos ;
            
            lectordatos = comando.ExecuteReader();
            Boolean existenciadatos = lectordatos.HasRows;
            if (existenciadatos)
            {
                MessageBox.Show("bienvenido al sistema " + txtusuario.Text);
                MENU abrir = new MENU();
                this.Hide();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Aceso denegado ");
                return;
            }
            conexion.Close();

        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
