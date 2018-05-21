using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;    

namespace _13._17
{
    public partial class Form1 : Form
    {
        Game game;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GV.RowCount = 3;
            for (int i = 0; i < 3; i++)
            {
                GV.Rows[i].Height = 100;
                GV.Columns[i].Width = 100;
            }
            game = new Game();
            game.Restart(1);
        }

        private void GV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            GV[e.ColumnIndex, e.RowIndex].Style.BackColor = game.Was[e.RowIndex, e.ColumnIndex] ? Color.Gray : Color.White;
            e.PaintBackground(e.CellBounds, false);
            if (((int)game.Pole[e.RowIndex, e.ColumnIndex]) % 2 == 1)
            e.Graphics.FillEllipse(((int)game.Pole[e.RowIndex, e.ColumnIndex]) < 2 ? Brushes.Blue : Brushes.Green, new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 10, 81, 81));
            else e.Graphics.FillRectangle(((int)game.Pole[e.RowIndex, e.ColumnIndex]) < 2 ? Brushes.Blue : Brushes.Green, new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 10, 81, 81));
            e.Handled = true;
        }

        private void rstbtn_Click(object sender, EventArgs e)
        {
            WIN.Visible = false;
            game.Restart((int)Level.Value);
            GV.Refresh();
        }

        private void GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(game.GoTo(e.RowIndex,e.ColumnIndex))
            {
                GV.Refresh();
                if (game.CheckWin())
                    WIN.Visible = true;
            }
        }
    }
}
