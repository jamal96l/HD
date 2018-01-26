using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDesktop.Forms
{
    public partial class ValoresGenerales : Form
    {
        private HotelEntities hotelContext;
        private Class.ValoresGenerales losValores = new Class.ValoresGenerales();

        public ValoresGenerales()
        {
            InitializeComponent();
            
        }

        private void AsignarValores()
        {
            losValores.CedulaJuridica = Int32.Parse(txtCedula.Text);
            losValores.NombreEmpresa = txtNombre.Text;
            losValores.ImpuestoVenta = Int32.Parse(txtVenta.Text);
            losValores.ImpuestoConsumo = Int32.Parse(txtConsumo.Text);
            losValores.ImpuestoServicio = Int32.Parse(txtServicio.Text);
            losValores.Propietario = txtPropietario.Text;
            losValores.Direccion = txtDireccion.Text;
            losValores.HoraCheckIn = TimeSpan.Parse(txtCheckIn.Text);
            losValores.HoraCheckOut = TimeSpan.Parse(txtCheckOut.Text);
    }

        private void ValoresGenerales_Load(object sender, EventArgs e)
        {
            hotelContext = new HotelEntities();

            var valoresQuery = (from h in hotelContext.Valores_Generales
                             select h).ToList();
            if (!valoresQuery.Any())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                txtCedula.Text = valoresQuery[0].Cedula_Juridica;
                txtNombre.Text = valoresQuery[0].Nombre_Empresa;
                txtVenta.Text = valoresQuery[0].Impuesto_Venta.ToString();
                txtConsumo.Text = valoresQuery[0].Impuesto_Consumo.ToString();
                txtServicio.Text = valoresQuery[0].Impuesto_Servicio.ToString();
                txtPropietario.Text = valoresQuery[0].Propietario;
                txtDireccion.Text = valoresQuery[0].Direccion;
                txtCheckIn.Text = valoresQuery[0].Hora_CheckIn.ToString();
                txtCheckOut.Text = valoresQuery[0].Hora_CheckOut.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Console.WriteLine(losValores.HoraCheckIn);
        }
    }
}