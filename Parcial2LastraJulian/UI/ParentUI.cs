using Parcial2LastraJulian.Controller;
using Parcial2LastraJulian.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LastraJulian.UI
{
    public partial class ParentUI : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<ConcreteObserverVuelos> ListaFormulariosVuelos = new List<ConcreteObserverVuelos>();
        List<Form> ListaFormulariosHoteles = new List<Form>();

        SubjectVuelo subjectA = new SubjectVuelo();
        ConcreteObserverVuelos observerA = new ConcreteObserverVuelos();

        int precioVuelo = 100;

        public ParentUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Subscribir Vuelos
          
            observerA.Email = ((Cliente)comboBox1.SelectedItem).Email;
            observerA.Nombre = ((Cliente)comboBox1.SelectedItem).Nombre;

            subjectA.Attach(observerA);

            Form f = subjectA.CrearClienteVuelo(observerA);
            f.MdiParent = this;
            f.Name = "VueloUI"+ observerA.Nombre;
            f.Show();

            ListaFormulariosVuelos.Add(observerA);

            comboBox4.DataSource = null;
            comboBox4.DataSource = subjectA._observersVuelos;
            comboBox4.DisplayMember = "Name"; //no anda el cornudo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Desuscribir Vuelo
            observerA.Email = ((Cliente)comboBox1.SelectedItem).Email;
            observerA.Nombre = ((Cliente)comboBox1.SelectedItem).Nombre;

            List<Form> forms = new List<Form>();

            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
            }

            foreach (Form f in forms)
            {
                if (f.Name == "VueloUI"+observerA.Nombre)
                {
                    f.Close();
                }
            }

            subjectA.Detach(observerA);
            
        }

        #region Hoteles
        private void button4_Click(object sender, EventArgs e)
        {
            ////Subscribir Hoteles
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Desubscribir Hoteles
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Controller.JSONManager serializer = new JSONManager();
            //serializer.SerializeJSON(ListaFormulariosVuelos);
            serializer.SerializeJSON(ListaFormulariosHoteles);
        }

        private void ParentUI_Load(object sender, EventArgs e)
        {
            ClientesGenerator gen = new ClientesGenerator();
            clientes = gen.clientesGen();

            comboBox1.DataSource = null;
            comboBox1.DataSource = clientes;

            comboBox1.DisplayMember = "Nombre";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            if (subjectA._observersVuelos.Count > 0 && (precioVuelo <=90))
            {
                subjectA.Notify(ListaFormulariosVuelos);
            }

            precioVuelo -= 10;
            label8.Text = precioVuelo.ToString();
        }
    }
}
