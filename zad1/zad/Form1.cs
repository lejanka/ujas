using System.Collections.Generic;

namespace zad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int i, j, k;
            List<string> Vhod = new List<string>();
            List<int> arrayInt = new List<int>();


            Vhod.AddRange(tb1.Text.Split(' ').Select(txt => txt.Trim()).ToArray());
            if (tb1.Text.Length != 0 || string.IsNullOrWhiteSpace(tb1.Text))
            {
                arrayInt = Vhod.Select(s => int.Parse(s)).ToList();


            }
            else
            {
                MessageBox.Show("Input a Real Number");
                return;
            }

            int countZero = 0;

            for (i = 0; i < arrayInt.Count(); i++)
            {
                if (arrayInt[i] == 0)
                {
                    countZero++;
                    arrayInt.RemoveAt(i);

                }
            }


            for (i = 1; i < arrayInt.Count(); i++)
            {
                j = i;

                while (j > 0 && arrayInt[j - 1] > arrayInt[j])
                {
                    k = arrayInt[j];
                    arrayInt[j] = arrayInt[j - 1];
                    arrayInt[j - 1] = k;
                    j--;
                }

            }



            for (i = 0; i < arrayInt.Count(); i++)
            {
                tb2.Text += arrayInt[i] + " ";
            }
            var min_stoinost = arrayInt.First();
            tb_min.Text = min_stoinost.ToString();

            var max_stoinost = arrayInt.Last();
            tb_max.Text = max_stoinost.ToString();
            tb_zero.Text = countZero.ToString();

            int mid = arrayInt.Count() / 2;
            double median;
            if (arrayInt.Count() % 2 == 0)
            {

                median = (arrayInt[arrayInt.Count() / 2 - 1] + arrayInt[arrayInt.Count() / 2]) / 2;
                tb_median.Text = median.ToString();
            }
            else
            {
                median = arrayInt[arrayInt.Count() / 2];
                tb_median.Text = median.ToString();
            }



        }

        private void te(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
