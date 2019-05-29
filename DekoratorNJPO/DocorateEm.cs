using System;
using System.Collections.Generic;
using System.Text;

namespace DekoratorNJPO
{
    class DocorateEm : PlainTextDecorator
    {
        public DocorateEm(AbstractElement elem) : base(elem)
        {
        }
        public override void write()
        {
            Console.Write("<em>");
            base.write();
            Console.Write("<em>");
        }

    }
}
