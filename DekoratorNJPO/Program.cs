using System;

namespace DekoratorNJPO
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractElement elem = new DecorateP(new PlainTextDecorator(new PlainText("napis")));
            elem.write();
        }
    }
}
