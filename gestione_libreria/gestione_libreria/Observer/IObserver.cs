using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_libreria.Observer
{
    public interface IObserver
    {
        // Aggiorna la variabile count 
        void Update(int count);
    }
}
