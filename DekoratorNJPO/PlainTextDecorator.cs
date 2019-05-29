using System;
using System.Collections.Generic;
using System.Text;

namespace DekoratorNJPO
{
    public class PlainTextDecorator : AbstractElement
    {

        protected AbstractElement elem;

        public PlainTextDecorator(AbstractElement elem)
        {
            this.elem = elem;
        }

        public override void write()
        {
            elem.write();
        }
    }
}
