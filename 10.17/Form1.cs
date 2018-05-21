using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsGrid;
using Tools;
namespace _10._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Input, 105, false, false, true, true, false, false);
            Input.ColumnCount = 4;
            Input.Columns[0].Width = 119;
            Input.Columns[0].HeaderText = "название";
            Input.Columns[1].HeaderText = "память Gb";
            Input.Columns[2].HeaderText = "рейтинг";
            Input.Columns[3].HeaderText = "цена";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToolsFile toolsFile = new ToolsFile(openFileDialog.FileName);
                    string[,] Arr2 = toolsFile.ReadArr2();
                    DataGridViewUtils.Array2ToGrid(Input, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToolsFile toolsFile = new ToolsFile(saveFileDialog.FileName);
                    toolsFile.WriteArr2(DataGridViewUtils.GridToArray2<string>(Input));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<NoteBook> books = ConverterBooks.Arr2ToList(DataGridViewUtils.GridToArray2<string>(Input));
                books.Sort();
                for (int i = books.Count-1; i >= 0; i--)
                {
                    if(books[i].Cost <= Money.Value)
                    {
                        Output.Text = books[i].ToString();
                        save.Enabled = true;
                        return;
                    }
                }
                Output.Text = "недостаточно денег";
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
