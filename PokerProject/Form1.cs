using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PokerProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            const byte dWidth = 14;
            const byte dHeight = 6;

            
            List<PictureBox> picBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4,
                                                               pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                                                               pictureBox9, pictureBox10, pictureBox11, pictureBox12,
                                                               pictureBox13, pictureBox14, pictureBox15, pictureBox16 };
            Thread.Sleep(500);
            foreach (PictureBox pb in picBoxes)
            {
                pb.Width = this.Size.Width / dWidth;
                pb.Height = this.Size.Height / dHeight;
            }
            pictureBox1.Location = new Point(this.Size.Width - this.Size.Width / 3, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox1.Location.X + 20, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(this.Size.Width/4,pictureBox3.Location.Y);
            pictureBox4.Location = new Point(pictureBox3.Location.X - 20, pictureBox4.Location.Y);
        }
    }
}
