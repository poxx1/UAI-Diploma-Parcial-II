using Parcial2LastraJulian.Model;
using Parcial2LastraJulian.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LastraJulian.Controller
{
    public class SubjectVuelo : Cliente, ISubject
    {
        public List<IObserver> _observersVuelos = new List<IObserver>();
        Vuelo vuelo = new Vuelo();

        public void Attach(IObserver observer)
        {
            //Console.WriteLine("Subject: Attached an observer.");
            this._observersVuelos.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observersVuelos.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }
        public List<ConcreteObserverVuelos> Notify(List<ConcreteObserverVuelos> lista)
        {
            MessageBox.Show("Notificancion enviada a los subscriptores! ");

            List <ConcreteObserverVuelos> listVuelos = new List<ConcreteObserverVuelos>();
            List<Form> forms = new List<Form>();

            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
            }

            foreach (var form in lista)
            {
                form.Nombre = "Cambio el precio";
                
                foreach (Form f in forms)
                {
                    if (f.Name.Contains("VueloUI"))
                    {
                        TextBox tb = (TextBox)f.Controls["TextBox1"];
                        tb.Text = "cambio el precio";
                    }
                }
            }
            return listVuelos;
        }

        public Form CrearClienteVuelo(ConcreteObserverVuelos cliente)
        {
            MessageBox.Show("Nuevo vuelo subscripto");
            return new VueloUI(cliente);
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
