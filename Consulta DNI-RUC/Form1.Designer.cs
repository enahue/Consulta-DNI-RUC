namespace Consulta_DNI_RUC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_rdnirz = new System.Windows.Forms.TextBox();
            this.lbl_numdoc = new System.Windows.Forms.Label();
            this.lbl_nameap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_nroruc = new System.Windows.Forms.TextBox();
            this.txb_estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_condicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_ruc = new System.Windows.Forms.TextBox();
            this.txb_ubigeo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_distrito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_provincia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_departamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DisplayMember = "DNI";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.comboBox1.Location = new System.Drawing.Point(236, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(113, 65);
            this.txb_dni.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_dni.MaxLength = 8;
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(100, 20);
            this.txb_dni.TabIndex = 1;
            this.txb_dni.TextChanged += new System.EventHandler(this.txb_dni_TextChanged);
            // 
            // txb_rdnirz
            // 
            this.txb_rdnirz.Location = new System.Drawing.Point(113, 91);
            this.txb_rdnirz.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_rdnirz.Name = "txb_rdnirz";
            this.txb_rdnirz.ReadOnly = true;
            this.txb_rdnirz.Size = new System.Drawing.Size(462, 20);
            this.txb_rdnirz.TabIndex = 2;
            // 
            // lbl_numdoc
            // 
            this.lbl_numdoc.AutoSize = true;
            this.lbl_numdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numdoc.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_numdoc.Location = new System.Drawing.Point(72, 72);
            this.lbl_numdoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numdoc.Name = "lbl_numdoc";
            this.lbl_numdoc.Size = new System.Drawing.Size(29, 13);
            this.lbl_numdoc.TabIndex = 3;
            this.lbl_numdoc.Text = "DNI";
            // 
            // lbl_nameap
            // 
            this.lbl_nameap.AutoSize = true;
            this.lbl_nameap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameap.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_nameap.Location = new System.Drawing.Point(5, 98);
            this.lbl_nameap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nameap.Name = "lbl_nameap";
            this.lbl_nameap.Size = new System.Drawing.Size(106, 13);
            this.lbl_nameap.TabIndex = 4;
            this.lbl_nameap.Text = "NOMBRES O RZ.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(-1, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NUMERO DE DOC";
            // 
            // txb_nroruc
            // 
            this.txb_nroruc.Location = new System.Drawing.Point(113, 117);
            this.txb_nroruc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_nroruc.Name = "txb_nroruc";
            this.txb_nroruc.ReadOnly = true;
            this.txb_nroruc.Size = new System.Drawing.Size(134, 20);
            this.txb_nroruc.TabIndex = 6;
            // 
            // txb_estado
            // 
            this.txb_estado.Location = new System.Drawing.Point(113, 143);
            this.txb_estado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_estado.Name = "txb_estado";
            this.txb_estado.ReadOnly = true;
            this.txb_estado.Size = new System.Drawing.Size(100, 20);
            this.txb_estado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(47, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ESTADO";
            // 
            // txb_condicion
            // 
            this.txb_condicion.Location = new System.Drawing.Point(113, 169);
            this.txb_condicion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_condicion.Name = "txb_condicion";
            this.txb_condicion.ReadOnly = true;
            this.txb_condicion.Size = new System.Drawing.Size(100, 20);
            this.txb_condicion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CONDICION";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(113, 195);
            this.txb_direccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.ReadOnly = true;
            this.txb_direccion.Size = new System.Drawing.Size(462, 20);
            this.txb_direccion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(32, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DIRECCION";
            // 
            // txb_ruc
            // 
            this.txb_ruc.Location = new System.Drawing.Point(113, 65);
            this.txb_ruc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_ruc.MaxLength = 11;
            this.txb_ruc.Name = "txb_ruc";
            this.txb_ruc.Size = new System.Drawing.Size(153, 20);
            this.txb_ruc.TabIndex = 13;
            this.txb_ruc.TextChanged += new System.EventHandler(this.txb_ruc_TextChanged);
            // 
            // txb_ubigeo
            // 
            this.txb_ubigeo.Location = new System.Drawing.Point(113, 221);
            this.txb_ubigeo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_ubigeo.Name = "txb_ubigeo";
            this.txb_ubigeo.ReadOnly = true;
            this.txb_ubigeo.Size = new System.Drawing.Size(100, 20);
            this.txb_ubigeo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(50, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "UBIGEO";
            // 
            // txb_distrito
            // 
            this.txb_distrito.Location = new System.Drawing.Point(113, 247);
            this.txb_distrito.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_distrito.Name = "txb_distrito";
            this.txb_distrito.ReadOnly = true;
            this.txb_distrito.Size = new System.Drawing.Size(206, 20);
            this.txb_distrito.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(40, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "DISTRITO";
            // 
            // txb_provincia
            // 
            this.txb_provincia.Location = new System.Drawing.Point(113, 273);
            this.txb_provincia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_provincia.Name = "txb_provincia";
            this.txb_provincia.ReadOnly = true;
            this.txb_provincia.Size = new System.Drawing.Size(206, 20);
            this.txb_provincia.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(33, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "PROVINCIA";
            // 
            // txb_departamento
            // 
            this.txb_departamento.Location = new System.Drawing.Point(113, 299);
            this.txb_departamento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_departamento.Name = "txb_departamento";
            this.txb_departamento.ReadOnly = true;
            this.txb_departamento.Size = new System.Drawing.Size(206, 20);
            this.txb_departamento.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SlateGray;
            this.label8.Location = new System.Drawing.Point(1, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "DEPARTAMENTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 378);
            this.Controls.Add(this.txb_departamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_provincia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_distrito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_ubigeo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_ruc);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_condicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_nroruc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nameap);
            this.Controls.Add(this.lbl_numdoc);
            this.Controls.Add(this.txb_rdnirz);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Consulta DNI-RUC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_rdnirz;
        private System.Windows.Forms.Label lbl_numdoc;
        private System.Windows.Forms.Label lbl_nameap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_nroruc;
        private System.Windows.Forms.TextBox txb_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_condicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_ruc;
        private System.Windows.Forms.TextBox txb_ubigeo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_distrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_provincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_departamento;
        private System.Windows.Forms.Label label8;
    }
}

