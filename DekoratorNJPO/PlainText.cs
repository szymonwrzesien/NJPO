using System;
using System.Collections.Generic;
using System.Text;

namespace DekoratorNJPO
{
    public class PlainText : AbstractElement
    {
        protected string text;

        public PlainText(string text)
        {
            this.text = text;
        }

        public override void write()
        {
            Console.Write(text); ;
        }
    }
}
