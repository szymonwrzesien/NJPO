using System;

namespace DekoratorNJPO
{
    class Program
    {
        static void Main(string[] args)
        {
            string text="";
            Console.Write("podaj tekst: ");
            text = Console.ReadLine();
            AbstractElement elem = new PlainText(text);
            int nr;
            do
            {
                Console.WriteLine(" 1. dodaj <p>\n 2. dodaj <strong>\n 3. dodaj <em>\n 4. dodaj <mark>\n 5. wyświetl tekst\n 6. wyjście");
                Console.Write(">>");
                nr = int.Parse(Console.ReadLine());
                switch (nr)
                {
                    case 1:
                        elem = new DecorateP(elem);
                    break;
                    case 2:
                        elem = new DecorateStrong(elem);
                        break;
                    case 3:
                        elem = new DocorateEm(elem);
                        break;
                    case 4:
                        elem = new DecorateMark(elem);
                        break;
                    case 5:
                        elem.write();
                        Console.WriteLine();
                        break;

                }
            }
                while (nr != 6) ;


        }
    }
}
