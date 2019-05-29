using System;
using System.Collections.Generic;
using System.Text;

namespace DekoratorNJPO
{
    class DecorateMark : PlainTextDecorator
    {
        public DecorateMark(AbstractElement elem) : base(elem)
        {
        }
        public override void write()
        {
            Console.Write("<mark>");
            base.write();
            Console.Write("<mark>");
        }
    }
}
