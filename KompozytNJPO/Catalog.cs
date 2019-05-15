using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytNJPO
{
    class Catalog : Component
    {
        private string name;
        
        private Catalog parent;
        public List<Component> list = new List<Component>();

        public Catalog(string name)
        {
            this.name = name;
        }

        public void add (Component c)
        {
            list.Add(c);
        }

        public void delete (Component c)
        {
            list.Remove(c);
        }

        public string getName()
        {
            return name;
        }
        public void writeInfo()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.getName());
            }
        }

        public void writePath()
        {
            if(parent!=null)                        
            {
                parent.writePath();
            }
            Console.Write(name + ">");
        }
        internal void setParent(Catalog k)
        {
            this.parent = k;
        }

        internal Catalog getParent()
        {
            return parent;
        }
    }
}
