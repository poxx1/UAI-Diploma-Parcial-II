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
    public partial class VueloUI : Form
    {
        //public string Nombre { get; set; }
        public static string Nombre;
        public VueloUI(ConcreteObserverVuelos cliente)
        {
            InitializeComponent();
            textBox1.Text = cliente.Email;
            textBox2.Text = cliente.Nombre;
            //this.Nombre = cliente.Nombre;
        }

        private void VueloUI_Load(object sender, EventArgs e)
        {

        }
        //public void ActualizarFormulario()
        //{
        //    textBox1.Text = "precio actualizado";
        //}
    }
}
