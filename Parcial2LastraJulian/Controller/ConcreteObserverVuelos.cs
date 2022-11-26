using Parcial2LastraJulian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2LastraJulian.Controller
{
    public class ConcreteObserverVuelos : Cliente, IObserver
    {        
        public float cambiarPrecio(Vuelo vuelo)
        {
            vuelo.Precio = vuelo.Precio - 10;
            return vuelo.Precio;
        }

        public float Update(Vuelo vuelo)
        {
            vuelo.Precio = vuelo.Precio - 10;
            return vuelo.Precio;
        }


        float IObserver.Update(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
