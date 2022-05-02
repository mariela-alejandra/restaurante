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
    public partial class Form1 : Form
    {
        BDRestauranteDataSet DS = new BDRestauranteDataSet();
        BDRestauranteDataSetTableAdapters.registrousuariosTableAdapter registar = new BDRestauranteDataSetTableAdapters.registrousuariosTableAdapter();

        public Form1()
        {
             InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registar.Fill(DS.registrousuarios);
            dgregistro.DataSource = DS.registrousuarios;

            DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            btnedit.Name = "Editar";
            dgregistro.Columns.Add(btnedit);
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            registar.Insert(txtnombre.Text, txtapellidoP.Text, txtapellidoM.Text, Convert.ToInt32(txttel.Text), txtci.Text,cbcargo.Text);
            registar.Fill(DS.registrousuarios);         
            dgregistro.DataSource = DS.registrousuarios;
            borrar();
        }

        void borrar()
        {
            txtnombre.Text = "";
            txtci.Text = "";
            txtapellidoM.Text = "";
            txtapellidoP.Text = "";
            txttel.Text = "";


        }

        private void dgregistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgregistro.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell cellbtnedit = this.dgregistro.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\editar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                    this.dgregistro.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                    this.dgregistro.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                    e.Handled = true;
                }
        }

        private void dgregistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgregistro.Columns[e.ColumnIndex].Name == "editar");
            {
                txtnombre.Text = dgregistro.CurrentRow.Cells[1].Value.ToString();
                txtapellidoP.Text = dgregistro.CurrentRow.Cells[2].Value.ToString();
                txtapellidoM.Text = dgregistro.CurrentRow.Cells[3].Value.ToString();
                txtci.Text = dgregistro.CurrentRow.Cells[4].Value.ToString();
                txttel.Text = dgregistro.CurrentRow.Cells[5].Value.ToString();
                cbcargo.Text = dgregistro.CurrentRow.Cells[6].Value.ToString();

                lblidusuario.Text = dgregistro.CurrentRow.Cells[0].Value.ToString();
               
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            this.registar.modificar(txtnombre.Text, txtapellidoP.Text, txtapellidoM.Text, Convert.ToInt32(txttel.Text), txtci.Text, cbcargo.Text, Convert.ToInt32(lblidusuario.Text));
            this.registar.Fill(this.DS.registrousuarios);
         
            MessageBox.Show("SE MODIFICO LOS DATOS  DATOS DEL USUARIO CORRECTAMENTE");
           borrar();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtapellidoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Porfavor ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MENU abrir = new MENU();
            this.Hide();
            abrir.Show();
        }

       
    }
}
