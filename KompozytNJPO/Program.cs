using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytNJPO
{
    class Program
    {

        static void Main(string[] args)
        {
            Catalog mainFolder = new Catalog("głównyKatalog");
            Catalog handler = mainFolder;
            Console.WriteLine("Witaj w konsoli!!!");
            help();
            for (; ;)
            {
                Console.WriteLine("***********************************************");
                handler.writePath(); 
                string command = Console.ReadLine();

                if (command.Equals("h"))        //wyswietlanie helpa
                    help();
                if (command.StartsWith("md"))    //tworzenie nowego folderu
                {
                    string[] tab = command.Split(' ');
                    string FolderName = tab[1];
                    Catalog k = new Catalog(FolderName);
                    handler.add(k);
                    k.setParent(handler);

                }
                if (command.Equals("dir"))           //wyswietla strukture katalogu
                {
                    Console.WriteLine("");
                    handler.writeInfo();
                    Console.WriteLine("");
                }
                if (command.StartsWith("cd.."))
                {
                    handler = handler.getParent();
                }
                if (command.StartsWith("cd "))
                {
                    string[] tab = command.Split(' ');
                    string nazwaFolderu = tab[1];
                    foreach (Catalog item in handler.list)
                    {
                        if (nazwaFolderu.Equals(item.getName()))
                        {
                            handler = item;
                        }


                    }
                }
                if (command.StartsWith("txt "))
                {
                    string[] tab = command.Split(' ');
                    string FileName = tab[1];
                    File p = new File(FileName);
                    handler.add(p);


                }

            }
          
        }
            private static void help()
        {
            Console.WriteLine("dir pokazuje strukture katalogu \ntxt tworzy nowy plik \nmd tworzy nowy katalog \ncd przechodzi do wybranego katalogu\nh wyświetl help ");
          
        }
    }
}
