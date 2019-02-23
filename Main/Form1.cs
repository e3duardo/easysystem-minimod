using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EasySystem.Mod.Cliente.Form1 f1 = new EasySystem.Mod.Cliente.Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EasySystem.Mod.Shared.ConfiguracaoView cfg = new EasySystem.Mod.Shared.ConfiguracaoView();
            cfg.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EasySystem.Mod.Cliente.Form2 f2 = new EasySystem.Mod.Cliente.Form2();
            f2.Show();
        }
    }
}
