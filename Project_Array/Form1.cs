using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Array
{
    public partial class Form1 : Form
    {
        int[] array = new int[22];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//кнопка генерации случайного массива
        {
            dataGridView1.ColumnCount = 22;//кол-во полей под каждый элемент массива
            Random rand = new Random();//переменная rand под подбор случайных чисел
            for (int i = 0; i < array.Length; i++)//начало цикла
            {
                array[i] = rand.Next(-200, 200);//формирование массива с элементами от -200 до 200
                dataGridView1.Rows[0].Cells[i].Value = array[i];//вывод элементов в соответствующее поле
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sort_button_Click(object sender, EventArgs e)//кнопка сортировки массива
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = array[i];
            }
        }

        private void grafic_button_Click(object sender, EventArgs e)//кнопка построения графика
        {
            int[] x = array;
            int[] y = new int[22];
            for (int i = 0; i < 22; i++)
            {
                y[i] = array[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 10;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
                chart1.Series[0].Points.DataBindXY(x, y);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)//кнопка очистки полей
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = "";
            }

            label2.Text = "";
            label3.Text = "";
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void quest_button_Click(object sender, EventArgs e)//кнопка выполнения задания
        {
            int sum1 = 0;//переменная под сумму положительных элементов
            int sum2 = 0;//переменная под сумму отрицательных элементов
            for (int i = 0; i < array.Length; i++)//начало цикла
            {
                if (array[i] > 0)//проверка элементов массива
                {
                    sum1 += array[i];//сложение положительных элементов
                    label2.Text = "Сумма положительных элементов массива : " + sum1.ToString();
                }
            }

            for (int i = 0; i < array.Length; i++)//начало цикла
            {
                if (array[i] < 0)//проверка элементов массива
                {
                    sum2 += array[i];//сложение отрицательных элементов 
                    label3.Text = "Сумма отрицательных элементов массива : " + sum2.ToString();
                }
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void form2_button_Click(object sender, EventArgs e)
        {
        
        }

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)//кнопка перехода на 3 форму
        {
            Form1.ActiveForm.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)//кнопка перехода на 2 форму
        {
            Form1.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
