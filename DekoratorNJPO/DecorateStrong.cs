using System;
using System.Collections.Generic;
using System.Text;

namespace DekoratorNJPO
{
    class DecorateStrong : PlainTextDecorator
    {
        public DecorateStrong(AbstractElement elem) : base(elem)
        {
        }
        public override void write()
        {
            Console.Write("<strong>");
            base.write();
            Console.Write("<strong>");
        }
    }
}
