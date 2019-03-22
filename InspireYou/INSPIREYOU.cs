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
    public partial class InspireYouForm : Form
    {   int userchoice;
        public InspireYouForm()
        {
            InitializeComponent();
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1exit_Click(object sender, EventArgs e)
        {//close the app
            this.Close();
        }

        private void button1clear_Click(object sender, EventArgs e)
        {//clears the checked choices
         

        }

        void button1_Click(object sender, EventArgs e)
        {//select button to display the results of what ails you.

            int o = userchoice;

            switch (o)
            {
                case 0:

                    {
                        checkBox1_checkchanged.ThreeState = true;

                        
                        return;
                    }
                    
                case 1:

                    {
                        checkBox2.ThreeState = true;

                        MessageBox.Show("Are you procrastinating?  May I suggest making a to do list?");
                        return;
                    }
                                     
                case 2:

                    {
                        checkBox3.ThreeState = true;
                        MessageBox.Show("Hungry eh?  Go get a snack.  If you can't, drinking water will help.");
                        return;
                    }
                case 3:

                    {
                        checkBox4.ThreeState = true;
                        MessageBox.Show("Feeling sluggish?  Get up!  Talk a walk!  Stretch");
                        return;
                    }
                case 4:

                    {
                        checkBox5.ThreeState = true;
                        MessageBox.Show("Okay, okay. It's ok to be mad.  Breathe...count to 10.");
                        return;
                    }
                case 5:

                    {
                        checkBox6.ThreeState = true;
                        MessageBox.Show("Aw...I'm sorry that you're sad. May I suggest watching Cat videos on Youtube? ");
                        return;
                    }
                case 6:

                    {
                        checkBox7.ThreeState = true;
                        MessageBox.Show("Thirsty?  Go get some water.");
                        return;
                    }
                case 7:

                    {
                        checkBox8.ThreeState = true;
                        MessageBox.Show("Stumped huh?  Try reading a book.");
                        return;
                    }

                default:
                    {
                        break;
                    }
            };

            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 4;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 2;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 3;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 5;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 6;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            userchoice = 7;
        }

        private void InspireYou_Load(object sender, EventArgs e)
        {

        }
    }
}
    

             
        

    

