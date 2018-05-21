using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class ConvertArr2
    {
        public static string[,] StrToArr2(string str)
        {
            string[] Row = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (Row.Length == 0) return new string[0, 0];
            string[] Split = Row[0].Split(new char[] { ',', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[,] arr2 = new string[Row.Length, Split.Length];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                Split = Row[i].Split(new char[] { ',', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (Split.Length != arr2.GetLength(1)) throw new Exception("0");
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = Split[j];
                }
            }
            return arr2;
        }
        public static string Arr2ToStr(string[,] arr2)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    str.Append(arr2[i, j] + ((j != arr2.GetLength(1) - 1) ? " " : ""));
                }
                if (i != arr2.GetLength(0))
                    str.AppendLine();
            }
            return str.ToString();
        }
        public static string Arr2ToStr(bool[,] arr2)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    str.Append(arr2[i, j] + ((j != arr2.GetLength(1) - 1) ? (arr2[i,j]?"  ":" ") : ""));
                }
                if (i != arr2.GetLength(0))
                    str.AppendLine();
            }
            return str.ToString();
        }
    }
}
