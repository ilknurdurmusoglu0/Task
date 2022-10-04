using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cat : Animal
    {
        public string Name { get; set; }
        public string Feature { get; set; }
        public int Leg { get; set; }

        public Cat()
        {

        }

        public Cat(int id, Color color, int size, string name, string feature, int leg) : this()
        {
            Id = id;
            Color = color;
            Size = size;
            Name = name;
            Feature = feature;
            Leg = leg;
        }
    }
}
