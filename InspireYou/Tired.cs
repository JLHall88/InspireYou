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
        int hour, minute;
        string alarmhour, alarmminute;
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

        private void alarmstart_Click(object sender, EventArgs e)
        {
            alarmhour = middlebox.Text;
            alarmminute = lowerbox.Text;
        }
        void alarm_goes_boom()
        {
            if (alarmhour == hour.ToString() && alarmminute == minute.ToString())
            {
                axWindowsMediaPlayer1.URL = "Properties.Resources.Alarm_song";
            }
        }
        private void Tired_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int x = 0; x < 25; x++)
            {
                middlebox.Items.Add(x);
            }

            for (int r = 0; r < 61; r++)
            {
                lowerbox.Items.Add(r);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            hourlabel.Text = hour.ToString();
            minutelabel.Text = minute.ToString();
            alarm_goes_boom();
        }
    }
         
        
        
}

