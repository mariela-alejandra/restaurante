using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTRO_COMIDA
{
    public partial class REGISTRO_COMIDA : Form
    {
        RestauranteDataSet ds = new RestauranteDataSet();
        RestauranteDataSetTableAdapters.comidaTableAdapter registrarcomida = new RestauranteDataSetTableAdapters.comidaTableAdapter();

        public REGISTRO_COMIDA()
        {
            InitializeComponent();
        }

        private void REGISTRO_COMIDA_Load(object sender, EventArgs e)
        {
            registrarcomida.Fill(ds.comida);
            dgregistro.DataSource = ds.comida;

            DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            btnedit.Name = "Editar";
            dgregistro.Columns.Add(btnedit);
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            registrarcomida.Insert(txtnombre.Text, txtdetalle.Text, Convert.ToInt32(numprecio.Value));
            registrarcomida.Fill(ds.comida);
            dgregistro.DataSource = ds.comida;
            borrar();
        }
        void borrar()
        {
            txtnombre.Text = "";
            txtdetalle.Text = "";
            numprecio.Value = 0;
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
            if (this.dgregistro.Columns[e.ColumnIndex].Name == "editar") ;
            {
                txtnombre.Text = dgregistro.CurrentRow.Cells[1].Value.ToString();
                txtdetalle.Text = dgregistro.CurrentRow.Cells[2].Value.ToString();
                numprecio.Value = Convert.ToInt32(dgregistro.CurrentRow.Cells[3].Value.ToString());

                lblidusuario.Text = dgregistro.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            this.registrarcomida.modificar(txtnombre.Text, txtdetalle.Text, numprecio.Value);
            this.registrarcomida.Fill(this.ds.registrarcomida);

            MessageBox.Show("SE MODIFICO LOS DATOS  DATOS DEL USUARIO CORRECTAMENTE");
            borrar();
        }
    }
}
