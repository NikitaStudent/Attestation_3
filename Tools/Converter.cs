using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class ConverterBooks
    {
        public static List<NoteBook> Arr2ToList(string[,] arr2)
        {
            try
            {
                if (arr2.GetLength(1) != 4)
                    throw new Exception();
                List<NoteBook> list = new List<NoteBook>();
                for (int i = 0; i < arr2.GetLength(0); i++)
                {
                    list.Add(new NoteBook(arr2[i, 0], int.Parse(arr2[i, 1]), int.Parse(arr2[i, 2]), int.Parse(arr2[i, 3])));
                }
                return list;
            }
            catch (Exception)
            {
                throw new Exception("некорректные данные");
            }
        }
        public static string[,] ListToArr2(List<NoteBook> books)
        {
            string[,] Arr2 = new string[books.Count, 4];
            for (int i = 0; i < books.Count; i++)
            {
                Arr2[i, 0] = books[i].Model;
                Arr2[i, 1] = books[i].Memory.ToString();
                Arr2[i, 2] = books[i].Rating.ToString();
                Arr2[i, 3] = books[i].Cost.ToString();
            }
            return Arr2;
        }
    }
}
