using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox3.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Webbrowser by Jose Copyright 2021 webbbrowser, you can contact me by this link: https://sites.google.com/view/websitejose/website-jose?read_current=1", "ABOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
