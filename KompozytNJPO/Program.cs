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
                Console.WriteLine(" ");
                try
                {
                    handler.writePath();
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine("nie można przejść do nadrzędnego katalogu");
                }
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
                if (command.StartsWith("cd..")) // przechodzi do poprzedniego katalogu
                {
                    if (handler.getParent()!=null)
                    handler = handler.getParent();
                }
                if (command.StartsWith("cd "))  //przechodzi do wybranego katalogu
                {
                    string[] tab = command.Split(' ');
                    string nazwaFolderu = tab[1];
                    try
                    {
                        foreach (Catalog item in handler.list)
                        {
                            if (nazwaFolderu.Equals(item.getName()))
                            {
                                handler = item;
                            }


                        }
                    }
                  catch( System.InvalidCastException )
                    {
                        Console.WriteLine("plik txt - nie można przejść do katalogu");
                    }
 
                }
                if (command.StartsWith("txt ")) //tworzy plik tekstowy
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
            Console.WriteLine("dir pokazuje strukture katalogu \ntxt tworzy nowy plik \nmd tworzy nowy katalog \ncd przechodzi do wybranego katalogu\ncd.. przechodzi do nadrzędnego katalogu\nh wyświetl help ");
          
        }
    }
}
