using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsConsole;
using Tools;
using static ToolsConsole.ToolsConsoleArr2;
namespace _10._17_console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<NoteBook> books = ConverterBooks.Arr2ToList(ReadArr2());
                books.Sort();
                Console.WriteLine("кол-во денег:");
                int Money = ReadInt();
                bool flag = false;
                for (int i = books.Count - 1; i >= 0; i--)
                {
                    if (books[i].Cost <= Money)
                    {
                        flag = true;
                        OutputStr(books[i].ToString());
                        return;
                    }
                }
                if(!flag) OutputStr("недостаточно денег");
            }
        }
    }
}
