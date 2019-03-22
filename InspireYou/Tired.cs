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
    public partial class Tired : Form
    {
        public Tired()
        {
            InitializeComponent();
        }

        private void ReturntoMain_Click(object sender, EventArgs e)
        {
            this.Close();
            InspireYouForm x = new InspireYouForm();
            x.ShowDialog();
            
        }

        private void tiredtablelayout1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkcoffee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/maps?osid=44b00399-c90e-42ec-a9d3-fd853d80125b&cp=47.134951~-122.758529&lvl=10&imgid=598ebb85-0480-4f2d-b87b-92541ed5c86e&v=2&sV=2&form=S00027");
        }
    }
}
