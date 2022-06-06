using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consulta_DNI_RUC.REST;

namespace Consulta_DNI_RUC
{
    public partial class Form1 : Form
    {
        apic epic = new apic();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

       
        
        MaximizeBox = false;
        comboBox1.SelectedIndex = 0;
        
         


        }

        public void lcampos()

        {

            txb_dni.Text = "";
            txb_rdnirz.Text = "";
            txb_ruc.Text = "";
            txb_nroruc.Text = "";
            txb_estado.Text = "";
            txb_condicion.Text = "";
            txb_direccion.Text = "";
            txb_ubigeo.Text = "";
            txb_distrito.Text = "";
            txb_provincia.Text = "";
            txb_departamento.Text = "";

        }
        public void csize()
        {

            if (comboBox1.Text == "DNI")
            {

                Size = new Size(625, 153);
                lbl_numdoc.Text = "DNI";
                txb_dni.Text = "";
                txb_rdnirz.Text = "";
                txb_ruc.Text = "";
                txb_ruc.Visible = false;
                txb_dni.Visible = true;
                lcampos();
               


            }

            if (comboBox1.Text == "RUC")
            {
                Size = new Size(625, 376);
                lbl_numdoc.Text = "RUC";
                txb_dni.Text = "";
                txb_rdnirz.Text = "";
                txb_ruc.Text = "";
                txb_ruc.Visible = true;
                txb_dni.Visible = false;
                lcampos();

            }

        }

        public void rconsulta()
        {
            txb_rdnirz.Text = "";


            try
            {

                dynamic respuesta = epic.Get("https://api.apis.net.pe/v1/dni?numero=" + txb_dni.Text + "");
                txb_rdnirz.Text = respuesta.nombre.ToString();

            }
            catch
            {
                MessageBox.Show("DNI no existe");

                txb_dni.Text = "";
                txb_dni.Focus();
            }
        }

        public void rucconsula()
        {
            txb_rdnirz.Text = "";
            try
            {

                dynamic respuesta = epic.Get("https://api.apis.net.pe/v1/ruc?numero=" + txb_ruc.Text + "");
                txb_rdnirz.Text = respuesta.nombre.ToString();
                txb_nroruc.Text = respuesta.numeroDocumento.ToString();
                txb_estado.Text = respuesta.estado.ToString();
                txb_condicion.Text = respuesta.condicion.ToString();
                txb_direccion.Text = respuesta.direccion.ToString();
                txb_ubigeo.Text = respuesta.ubigeo.ToString();
                txb_distrito.Text = respuesta.distrito.ToString();
                txb_provincia.Text = respuesta.provincia.ToString();
                txb_departamento.Text = respuesta.departamento.ToString();




            }
            catch
            {
                MessageBox.Show("RUC no existe");

                txb_dni.Text = "";
                txb_ruc.Focus();
                lcampos();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            csize();
        }

        private void txb_dni_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_dni.Text.Length == 8)
            {
                this.txb_rdnirz.Focus();
                rconsulta();
            }
            
        }

        private void txb_ruc_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_ruc.Text.Length == 11)
            {
                this.txb_rdnirz.Focus();
                rucconsula();
            }

        }
    }
}
