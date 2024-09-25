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

    public partial class Form2 : Form
    {
        
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        
        public void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            Form3.Instance.lab1.Text = "Alien Romulus";
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }
    }
}
