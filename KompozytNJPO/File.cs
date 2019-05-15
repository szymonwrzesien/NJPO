using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytNJPO
{
    class File : Component
    {
        private string name;
       public File(string name)
        {
            this.name = name;
        }
        public void writeInfo()
        {
            Console.WriteLine(name);

        }

        public string getName()
        {
            return name;
        }
    }
}
