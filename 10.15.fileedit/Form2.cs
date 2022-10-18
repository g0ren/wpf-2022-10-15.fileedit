using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._15.fileedit
{
    public partial class Form2 : Form
    {
        public void setText(string text)
        {
            textBox1.Text=text;
        }

        public string getText()
        {
            return textBox1.Text;
        }

        public Form2()
        {
            InitializeComponent();
            button1.DialogResult= DialogResult.OK;
            button2.DialogResult= DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
