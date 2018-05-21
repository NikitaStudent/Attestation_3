using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public class ToolsFile
    {
        public string Path { get; set; }
        public ToolsFile(string path)
        {
            this.Path = path;
        }
        public void WriteArr2(string[,] Arr2)
        {
            try
            {
                File.WriteAllText(Path, ConvertArr2.Arr2ToStr(Arr2));
            }
            catch (Exception)
            {
                throw new Exception("ошибка записи");
            }
        }
        public string[,] ReadArr2()
        {
            if (Path == null)
                throw new Exception("ошибка чтения");
            return ConvertArr2.StrToArr2(File.ReadAllText(Path));
        }
    }
}
