using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stikiwebapp
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sDMSTIKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sdm.stik-immanuel.ac.id");
        }

        public void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void sIMAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.simak.stik-immanuel.ac.id");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void sISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sister.stik-immanuel.ac.id");
        }

        private void interlocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://pdpt.stik-immanuel.ac.id/");
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ip_local ip = new Form_Ip_local();
            ip.Show();
        }
    }
}
