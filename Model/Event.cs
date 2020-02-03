using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmaker.Model
{
    class Event
    {
        private int Id;
        private string Name;
        private string Description;
        private string Place;
        private DateTime DateTime;

        public Event(int id,string name,string desc,string place,DateTime dateTime)
        {
            Id = id;
            Name = name;
            Place = place;
            Description = desc;
            DateTime = dateTime;
        }

        override public string  ToString()
        {
            return Name;
        }
    }
}
