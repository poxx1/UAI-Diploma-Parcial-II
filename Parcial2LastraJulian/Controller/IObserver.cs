using Parcial2LastraJulian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2LastraJulian.Controller
{
    public interface IObserver
    {
        // Receive update from subject
        float Update(Vuelo vuelo);

        float Update(Hotel hotel);


    }
}
