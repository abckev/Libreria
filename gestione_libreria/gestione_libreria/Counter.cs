using gestione_libreria.Observer;
using gestione_libreria.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_libreria
{
    public class Counter : ISubject
    {
        // field for singleton
        private static Counter instance;

        // implementation of the singleton pattern
        public static Counter GetInstance()
        {
            if (instance == null)
                instance = new Counter();
            return instance;
        }

        // Lista di osservatori
        private List<IObserver> observers;

        // Variabile contatore
        private int count;

        public Counter()
        {
            observers = new List<IObserver>();
            count = 0;
        }

        public void Increment()
        {
            count++;
            NotifyObservers(count);
        }

        public void Decrement()
        {
            if (count > 0)
            {
                count--;
                NotifyObservers(count);
            }
        }
        public void NotifyObservers(int count)
        {
            foreach (IObserver ob in observers)
            {
                ob.Update(count);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}