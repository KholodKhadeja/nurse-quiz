using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NurseQuiz1
{
    public partial class TheEnd : Form
    {
        public TheEnd()
        {
            InitializeComponent();
        }
        int score; SoundPlayer sp1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TheEnd_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Form1.gender == "female")
            {
                sp1 = new SoundPlayer(@"sound\FemaleEnd.wav");
                sp1.Play();
            }
            if (Form1.gender == "male")
            {
                sp1 = new SoundPlayer(@"sound\MaleEnd.wav");
                sp1.Play();
            }
            score = TheHospital.lasrScore;
        }
        int timerC = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerC++; label3.Visible = true;
            if(timerC==48)
            {
                groupBox1.Visible = true; button1.Visible = true;
                label3.Text = "" + TheHospital.lasrScore; label5.Visible = true;
                if(TheHospital.lasrScore>=135)
                {
                    label5.Text = "تهانينا , لقد حصلت على الوظيفة";
                }
                else
                {
                    if(Form1.gender=="female")
                    {
                        label5.Text = "نعتذر ، لم تحصلي على الوظيفة";
                    }
                    if(Form1.gender=="male")
                    {
                        label5.Text = "نعتذر ، لم تحصل على الوظيفة";

                    }
                }
            }
        }

    }
}
