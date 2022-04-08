using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salak_Mısın
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            int fwidth = Screen.PrimaryScreen.WorkingArea.Width / 15 * 8;
            int fheight = Screen.PrimaryScreen.WorkingArea.Height / 15 * 8;
            int fvar = this.ClientSize.Height / 50 * 27;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - fwidth,
                Screen.PrimaryScreen.WorkingArea.Height - fheight - fvar);
        }


        private void hyr_MouseEnter(object sender, EventArgs e)
        {
            var maxwidth = this.ClientSize.Width - hyr.ClientSize.Width;
            var maxheight = this.ClientSize.Height - hyr.ClientSize.Height;
            this.hyr.Location = new Point(
                rnd.Next(99, maxwidth), rnd.Next(75, maxheight));
        }

        private void hyr_MouseHover(object sender, EventArgs e)
        {
            var maxwidth = this.ClientSize.Width - hyr.ClientSize.Width;
            var maxheight = this.ClientSize.Height - hyr.ClientSize.Height;
            this.hyr.Location = new Point(
                rnd.Next(99, maxwidth), rnd.Next(75, maxheight));
        }

        private void evt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("biliyordum :3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ClientSize = new Size(rnd.Next(350, 555), this.ClientSize.Height);
            e.Cancel = true;
        }
    }
}
