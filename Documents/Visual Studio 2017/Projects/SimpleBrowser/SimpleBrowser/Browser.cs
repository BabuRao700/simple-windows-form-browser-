using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Dictionary<string, string> dict = new Dictionary<string, string>();
           /* GetData obj = new GetData();
            string searchString = txtSearch.Text.ToString().Trim();
            string result = "";
            result=obj.GetMetaData(searchString);*/
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            GetData obj = new GetData();
             string searchString = txtSearch.Text.ToString().Trim();
             string result = "";
             result=obj.GetMetaData(searchString);
            richTextBox1.Text = result;
            

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(richTextBox1.Text);
            Process.Start(sInfo);
        }
    }
}
