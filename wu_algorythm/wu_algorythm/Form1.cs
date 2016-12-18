using System;
using System.Drawing;
using System.Windows.Forms;

namespace wu_algorythm
{
    public partial class Form1 : Form
    {
        int[] m_p = new int[5];
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Algorithm.DrawWuLine(e.Graphics, Color.Black, m_p[1], m_p[2], m_p[3], m_p[4]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pictureBox1);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для построения линии введите значения начальных и конечных координат.\n Для построения новой линии выберите соответствующую кнопку меню.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ввестиНовыеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            pictureBox1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try {
                m_p[1] = Convert.ToInt32(textBox1.Text.ToString());
                m_p[2] = Convert.ToInt32(textBox2.Text.ToString());
                m_p[3] = Convert.ToInt32(textBox3.Text.ToString());
                m_p[4] = Convert.ToInt32(textBox4.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
           

        }

    }
}

