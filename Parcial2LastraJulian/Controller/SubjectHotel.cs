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
    public class Subject : Cliente, ISubject
    {
        private List<IObserver> _observersVuelos = new List<IObserver>();
        
        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observersVuelos.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observersVuelos.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            MessageBox.Show("Notificancion enviada a los subscriptores! ");

            foreach (var observer in _observersVuelos)
            {
                //observer.Update(this);
            }
        }

        public Form CrearClienteHotel(ConcreteObserverHoteles cliente)
        {
            MessageBox.Show("Nuevo hotel susbscripto");
            //return new Form().MdiParent = ParentUI;
            return new HotelUI(cliente);
        }

        public List<ConcreteObserverVuelos> Notify(List<ConcreteObserverVuelos> lista)
        {
            throw new NotImplementedException();
        }
    }
}