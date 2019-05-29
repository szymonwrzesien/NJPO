using System;
using System.Collections.Generic;
using System.Text;

namespace DekoratorNJPO
{
    class DecorateP : PlainTextDecorator
    {

        public DecorateP(AbstractElement elem) : base (elem)
        {
        }
        public override void write()
        {
            Console.Write("<p>");
            base.write();
            Console.Write("<p>");
        }
    }
}
