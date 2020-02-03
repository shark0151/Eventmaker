using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance;
        private ObservableCollection<Event> Catalog = new ObservableCollection<Event>();
        private EventCatalogSingleton()
        {
            Add(new Event(1, "Initial", "test", "Singleton", DateTime.Now));
        }

        public static EventCatalogSingleton Instance()
        {
            if(_instance == null)
            {
                _instance = new EventCatalogSingleton();
            }
            return _instance;
        }

        public void Add(Event newEvent)
        {
            Catalog.Add(newEvent);
        }
    }
}
