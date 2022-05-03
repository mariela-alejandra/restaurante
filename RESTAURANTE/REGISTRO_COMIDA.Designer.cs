
namespace REGISTRO_COMIDA
{
    partial class REGISTRO_COMIDA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        protected override void Dispose(bool disposing)
       
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblidusuario = new System.Windows.Forms.Label();
            this.numprecio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregis = new System.Windows.Forms.Button();
            this.dgregistro = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidusuario
            // 
            this.lblidusuario.AutoSize = true;
            this.lblidusuario.Location = new System.Drawing.Point(17, 230);
            this.lblidusuario.Name = "lblidusuario";
            this.lblidusuario.Size = new System.Drawing.Size(13, 13);
            this.lblidusuario.TabIndex = 102;
            this.lblidusuario.Text = "1";
            // 
            // numprecio
            // 
            this.numprecio.Location = new System.Drawing.Point(475, 88);
            this.numprecio.Name = "numprecio";
            this.numprecio.Size = new System.Drawing.Size(101, 20);
            this.numprecio.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(210, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 50);
            this.label5.TabIndex = 100;
            this.label5.Text = "REGISTRAR  COMIDA";
            // 
            // btnregis
            // 
            this.btnregis.BackColor = System.Drawing.Color.Silver;
            this.btnregis.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregis.Location = new System.Drawing.Point(501, 174);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(118, 39);
            this.btnregis.TabIndex = 99;
            this.btnregis.Text = "REGISTAR";
            this.btnregis.UseVisualStyleBackColor = false;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // dgregistro
            // 
            this.dgregistro.AllowUserToAddRows = false;
            this.dgregistro.AllowUserToDeleteRows = false;
            this.dgregistro.BackgroundColor = System.Drawing.Color.Silver;
            this.dgregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgregistro.Location = new System.Drawing.Point(20, 230);
            this.dgregistro.Name = "dgregistro";
            this.dgregistro.ReadOnly = true;
            this.dgregistro.Size = new System.Drawing.Size(591, 175);
            this.dgregistro.TabIndex = 98;
            this.dgregistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgregistro_CellClick);
            this.dgregistro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgregistro_CellPainting);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Silver;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodificar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(366, 179);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(118, 28);
            this.btnmodificar.TabIndex = 97;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txtdetalle
            // 
            this.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalle.Location = new System.Drawing.Point(165, 132);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(185, 58);
            this.txtdetalle.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 95;
            this.label3.Text = "Detalle";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(165, 86);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(185, 22);
            this.txtnombre.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "Nombres";
            // 
            // REGISTRO_COMIDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.lblidusuario);
            this.Controls.Add(this.numprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.dgregistro);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "REGISTRO_COMIDA";
            this.Text = "REGISTRO_COMIDA";
            this.Load += new System.EventHandler(this.REGISTRO_COMIDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgregistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidusuario;
        private System.Windows.Forms.NumericUpDown numprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnregis;
        private System.Windows.Forms.DataGridView dgregistro;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
    }
}
