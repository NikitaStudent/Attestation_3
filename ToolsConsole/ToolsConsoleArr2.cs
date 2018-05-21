using System;
using System.IO;
using System.Text;
using Tools;

namespace ToolsConsole
{
    public static class ToolsConsoleArr2
    {
        public static string[,] ReadArr2()
        {
            Console.Write("Считать данные из файла ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if ((key.KeyChar == 'y') || (key.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            return FileReadArr2(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((key.KeyChar == 'n') || (key.KeyChar == 'N'))
                {
                    string[,] t;
                    while (true)
                    {
                        Console.WriteLine("введите данные ");
                        try
                        {
                            t = ConsoleReadArr2(); ;
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    OutputArr2(t);
                    return t;
                }
            }
        }
        static string[,] ConsoleReadArr2()
        {
            StringBuilder str = new StringBuilder();
            string line;
            line = Console.ReadLine();
            while (line != "")
            {
                str.AppendLine(line);
                line = Console.ReadLine();
            }
            return ConvertArr2.StrToArr2(str.ToString());
        }
        static string[,] FileReadArr2(string Path)
        {
            ToolsFile file = new ToolsFile(Path);
            return file.ReadArr2();
        }
        static void FileWriteArr2(string[,] Arr2, string Path)
        {
            ToolsFile file = new ToolsFile(Path);
            file.WriteArr2(Arr2);
        }
        public static void OutputArr2(string[,] Arr2)
        {
            Console.Write("записать данные в файл ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            FileWriteArr2(Arr2, Console.ReadLine());
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    break;
                }
            }
        }
        public static void OutputStr(string s)
        {
            Console.Write("записать ответ в файл ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.WriteLine("введите имя файла:");
                        try
                        {
                            File.WriteAllText(Console.ReadLine(), s.ToString());
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                    return;
                }
            }
        }
        public static int ReadInt()
        {
            int a;
            do
            {
                Console.WriteLine("Введите число");
            } while (!int.TryParse(Console.ReadLine(), out a));
            return a;
        }
    }
}
