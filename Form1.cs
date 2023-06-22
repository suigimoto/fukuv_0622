using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace fukuv_0622
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                data[i] = rand.Next(0, 101);
                a = data[i] + a;
            }
            label1.Text = $"{data[0]},{data[1]},{data[2]},{data[3]},{data[4]},{data[5]},{data[6]},{data[7]},{data[8]},{data[9]},";

            a = a / 10;
            MessageBox.Show($"{a}");
        }
    }
}
