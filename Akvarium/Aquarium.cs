using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvarium
{
    internal class Aquarium<T>
    {
        public List<T> list;

        public Aquarium()
        {
            this.list = new List<T>();
        }

        public void AddCreature(T creature)
        {
            this.list.Add(creature);
        }

        public void RemoveCreature(T creature)
        {
            this.list.Remove(creature);
        }

        public void FeedAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} megetettve");
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in list)
            {
                s += item + " ";
            }
            return s;
        }
    }
}
