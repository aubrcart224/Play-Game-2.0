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
using System.Media;


namespace Play_Game_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = true;
            
        }

        

        private void button_Click(object sender, EventArgs e)
        {
            //sound 

            //SoundPlayer bleepPlayer = new SoundPlayer(A_Tone_His_Self_1266414414__1_);

            // button vanish countdown begin 

            button.Visible = false;
            //this.label1.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1100);
            label1.Visible = true;
            //bleepPlayer.Play();
            label1.Text = "Starting in 3";
            Refresh();
            Thread.Sleep(1100);
            label1.Text = "Starting in 2";
            Refresh();
            Thread.Sleep(1100);
            label1.Text = "Starting in 1";
            Refresh();
            Thread.Sleep(1100);
            label1.Text = " GO ";
            

            //go green 
            this.BackColor = Color.Green;
        }

        
    }
}
