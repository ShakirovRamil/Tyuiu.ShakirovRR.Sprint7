using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShakirovRR.Sprint7.Project.V7.Lib;

namespace Tyuiu.ShakirovRR.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridViewInfo_SRR.RowCount = 100;
            dataGridViewInfo_SRR.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewInfo_SRR.Columns[i].Width = 130;
            }
            dataGridViewInfo_SRR.Columns[2].Width = 180;
        }
        DataService ds = new DataService();
        public static string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint7\file\Домоуправление.csv";
        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonAbout_SRR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }



        private void buttonDeletePeople_SRR_Click(object sender, EventArgs e)
        {
            if ((textBoxDeleteEntrance_SRR.Text == "") || (textBoxDeleteFlat_SRR.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxDeleteEntrance_SRR.Text), Convert.ToInt32(textBoxDeleteFlat_SRR.Text));

                if (FlatBusy == false)
                    MessageBox.Show("Такой квартиры нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string[] strRows = File.ReadAllLines(path);

                    for (int i = 0; i < strRows.Length; i++)
                    {
                        string[] strIndex = strRows[i].Split(';');
                        if ((strIndex[0] == textBoxDeleteEntrance_SRR.Text) && (strIndex[1] == textBoxDeleteFlat_SRR.Text))
                            strRows[i] = "";
                    }
                    strRows = strRows.Where(i => i != "").ToArray();

                    File.Delete("Домоуправление.csv");

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_SRR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_SRR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Квартирант выселен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxDeleteEntrance_SRR.Text = "";
            textBoxDeleteFlat_SRR.Text = "";
        }

        private void buttonSaveFile_SRR_Click(object sender, EventArgs e)
        {
            if ((textBoxFIO_SRR.Text == "") || (textBoxAddEntrance_SRR.Text == "") || (textBoxFlatArea_SRR.Text == "") || (textBoxAddFlat_SRR.Text == "") || (textBoxSumPeople_SRR.Text == "") || (textBoxSumRoom_SRR.Text == ""))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxAddEntrance_SRR.Text), Convert.ToInt32(textBoxAddFlat_SRR.Text));

                if (FlatBusy)
                    MessageBox.Show("Данная квартира занята", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        str = $"{textBoxAddEntrance_SRR.Text};{textBoxAddFlat_SRR.Text};{textBoxFIO_SRR.Text};{textBoxSumPeople_SRR.Text};{textBoxFlatArea_SRR.Text};{textBoxSumRoom_SRR.Text};покупка";
                    }
                    File.AppendAllText(path, str + "\n");
                    textBoxFIO_SRR.Text = "";
                    textBoxAddEntrance_SRR.Text = "";
                    textBoxFlatArea_SRR.Text = "";
                    textBoxAddFlat_SRR.Text = "";
                    textBoxSumPeople_SRR.Text = "";
                    textBoxSumRoom_SRR.Text = "";
                    string[,] DataMatrix = ds.GetMatrix(path);
                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);
                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_SRR.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInfo_SRR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Новый житель зарегистрирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
