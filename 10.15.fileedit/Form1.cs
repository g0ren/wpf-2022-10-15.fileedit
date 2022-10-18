using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10._15.fileedit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                string[] lines= System.IO.File.ReadAllLines(openFileDialog1.FileName);
                StringBuilder stringBuilder = new StringBuilder();

                foreach(string line in lines)
                {
                    stringBuilder.AppendLine(line);
                }
                textBox1.Text = stringBuilder.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.setText(textBox1.Text);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = form2.getText();
            }
        }
    }
}