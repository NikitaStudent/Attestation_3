using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public enum Cell
    {
        BlueSquare,
        BlueCricle,
        GreenSquare,
        GreenCricle
    }
    public class Game
    {
        int[,,] levels;
        Cell[,] pole = new Cell[3,3];
        bool[,] was = new bool[3, 3];
        int y = 0;
        int x = 0;
        public Cell[,] Pole => pole;
        public bool[,] Was => was;

        public Game()
        {
            string[] data = File.ReadAllLines(@"levels.txt");
            levels = new int[data.Length, 3, 3];
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < 9; j++)
                {
                    levels[i, j / 3, j % 3] = int.Parse(data[i][j].ToString());
                }
        }
        public void Restart(int level)
        {
            if (level > levels.GetLength(0) || level <1)
                throw new ArgumentException();
            level--;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    pole[i, j] = (Cell)levels[level, i, j];
                    was[i,j] = (i + j == 0);
                }
            y = 0;x = 0;
        }
        public bool GoTo(int i, int j)
        {
            if(!was[i,j] && ( ((int)pole[i,j]) / 2 == ((int)pole[x,y])/2 || ((int)pole[i, j]) % 2 == ((int)pole[x, y]) % 2))
            {
                x = i;
                y = j;
                was[x, y] = true;
                return true;
            }
            return false;
        }
        public bool CheckWin()
        {
            for (int i = 0; i < 9; i++)
            {
                if (!was[i / 3, i % 3])
                    return false;
            }
            return true;
        }
    }
}
