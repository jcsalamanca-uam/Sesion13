using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodoBurbuja.Model;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TbNumber.Text);
            numbers[i++] = number;
            ShowNumbers();
            Clear();

        }
        public void ShowNumbers()
        {
            if (LbNumeros.Items.Count > 0)
            {
                LbNumeros.Items.Clear();
            }
            foreach (int number in numbers)
            {
                LbNumeros.Items.Add(number);
            }

        }
        private void Clear()
        {
            TbNumber.Clear();
            TbNumber.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
            bubble.BubbleSort(numbers);
            ShowNumbers();
        }
    }
}
