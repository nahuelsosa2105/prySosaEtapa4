using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prySosaEtapa3;

namespace prySosaEtapa4
{
    public partial class frmMainEtapa4 : Form
    {
        

        public frmMainEtapa4()
        {
            InitializeComponent();
            

        }

        List<clsVehiculo> listaVehiculos = new List<clsVehiculo>();
        clsVehiculo objAuto = new clsVehiculo();
        clsVehiculo objAvion = new clsVehiculo();
        clsVehiculo objBarco = new clsVehiculo();
        



        bool Auto = false;
        bool Avion = false;
        bool Barco = false;

       



        public void btnAuto_Click_1(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            objAuto.pctAuto.Location = new Point(-20, 300);
            Controls.Add(objAuto.pctAuto);
            lblAuto.Text = objAuto.tipoVehiculo;
            Auto = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
                lblAvion.Text = "";
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
                lblBarco.Text = "";
            }
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objAvion.CrearAvion();
            objAvion.pctAvion.Location = new Point(350, 50);
            Controls.Add(objAvion.pctAvion);
            lblAvion.Text = objAvion.tipoVehiculo;
            Avion = true;
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
                lblAuto.Text = "";
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = true;
                lblBarco.Text = "";
            }
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objBarco.CrearBarco();
            objBarco.pctBarco.Location = new Point(600, 50);
            Controls.Add(objBarco.pctBarco);
            lblBarco.Text = objBarco.tipoVehiculo;
            Barco = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
                lblAvion.Text = "";
            }
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
                lblAuto.Text = "";
            }
        }

        private void frmMainEtapa4_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            listaVehiculos.Add(objAuto);
            objAvion.CrearAvion();
            listaVehiculos.Add(objAvion);
            objBarco.CrearBarco();
            listaVehiculos.Add(objBarco);

            lstMostrarVehiculos.Items.Clear();

            foreach(clsVehiculo vehiculo in listaVehiculos)
            {
                lstMostrarVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
        }
    }
}
