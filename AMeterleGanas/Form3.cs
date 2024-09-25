using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMeterleGanas
{
    public partial class Form3 : Form
    {
        public static Form3 Instance;
        public Label lab1;
        public int Entradas;
        public int Total;
        public Form3()
        {
            InitializeComponent();
            Instance = this;
            lab1 = lblMovie;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2 = null;        
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Entradas = 0;
            Total = 0;
            if (checkBox1.Checked == true) {
                Entradas = Entradas + 1;
            }
            if (checkBox2.Checked == true)
            {
                Entradas = Entradas + 1;
            }
            if (checkBox3.Checked == true)
            {
                Entradas = Entradas + 1;
            }
            if (checkBox4.Checked == true)
            {
                Entradas = Entradas + 1;
            }
            if (checkBox5.Checked == true)
            {
                Entradas = Entradas + 1;
            }
            Total = Entradas * 2000;
            lblPreFin.Text = Total.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
