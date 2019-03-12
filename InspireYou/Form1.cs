using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspireYou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         var items = checkedListBox1.Items;
            items.Add("Tired");
            items.Add("Checked", true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkedListBox1.SelectedIndex;
            if(selected != -1)
            {
                this.Text = checkedListBox1.Items[selected].ToString();
            }
        }
    }
}
