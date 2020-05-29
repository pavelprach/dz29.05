using System;
using System.IO;
using static System.Console;

namespace ConsoleApp4
{
    class Program
    {
        static void ShowCatalogInfo(string way)
        {

            string dirName = way;
            WriteLine("Подкаталоги:");
            string[] dirs = Directory.GetDirectories(dirName);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            WriteLine(); WriteLine("Файлы:");
            string[] files = Directory.GetFiles(dirName);
            foreach (string s in files)
            {
                WriteLine(s);
            }
        }
        static void DeleteCatalog(string way)
        {
            Directory.Delete(way, true);
        }
        static void CreateCatalog(string way)
        {
            Directory.CreateDirectory(way);
        }
        static void Main(string[] args)
        {
            int CONDITION = 4;
            while(CONDITION != 0){
                WriteLine("Введите номер операции: ");
                CONDITION=Convert.ToInt32(ReadLine());
                if (CONDITION == 1)
                {
                    WriteLine("Введите путь к каталогу: ");
                    string way = ReadLine();
                    ShowCatalogInfo(way);
                }
                if (CONDITION == 2)
                {
                    WriteLine("Введите путь к каталогу: ");
                    string way = ReadLine();
                    DeleteCatalog(way);
                }
                if (CONDITION == 3)
                {
                    WriteLine("Введите путь к каталогу: ");
                    string way = ReadLine();
                    CreateCatalog(way);
                }
                if (CONDITION == 0)
                {
                    break;
                }
            }
            WriteLine("Программа завершена.");
        }
    }
}
