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
    public partial class TheHospital : Form
    {
        public TheHospital()
        {
            InitializeComponent();
        }
        // system.threading.thread.Sleep(500);time of delay
        Image img = new Bitmap(@"pic\scene1.png");
        //string path;
        SoundPlayer sp1,Que2, Que3, Que4, Que5, Que6, Que7, Que8, Que9, Que10, Que11;
        private void TheHospital_Load(object sender, EventArgs e)
        {
            timer1.Start();
            sp1 = new SoundPlayer(@"sound\ambu.wav");
            sp1.Play();
        }
         int countGif = 0;
         SoundPlayer sp2 = new SoundPlayer();
        private void timer1_Tick(object sender, EventArgs e)
        {
            countGif++;
            if(countGif==46)
            {
                picBox1.Image = Image.FromFile(@"pic\gif1.gif");
            }
            if (countGif == 92)
            {
                picBox1.Image = Image.FromFile(@"pic\gif2.gif");
            }
            if (countGif == 137)
            {
                picBox1.Image = Image.FromFile(@"pic\gif3.gif");
            }
            if (countGif == 183)
            {
                picBox1.Image = Image.FromFile(@"pic\gif4.gif");
            }
            if(countGif==205)
            {
                if (Form1.gender == "female")
                {
                    sp1 = new SoundPlayer(@"sound\femaleSp1.wav");
                    sp1.Play();
                }
                if (Form1.gender == "male")
                {
                    sp1 = new SoundPlayer(@"sound\maleSp1.wav");
                    sp1.Play();
                }
            }
            if (countGif == 211)
            {
                picBox1.Visible = false; this.BackgroundImage = (img);
                picBox2.Visible = true;
            }
            //////////////all above no need to change
            if(countGif==412)
            {
                this.BackgroundImage = null;
                picBox1.Visible = true; picBox2.Visible = false;
                picBox1.Image = Image.FromFile(@"pic\gif5.gif");
            }
            if(countGif==458)
            {
                picBox1.Image = Image.FromFile(@"pic\gif6.gif");
            }
            if (countGif == 504)
            {
                picBox1.Image = Image.FromFile(@"pic\gif7.gif");
            }
            /////first question 
            if (countGif == 550)
            {
                picBox1.Visible = false;
                img=new Bitmap(@"pic\scene2.png");
                this.BackgroundImage = (img);
                picBox3.Visible = true;
                picBox2.Visible = true;
                picBox2.Location = new Point(243, 103);
                groupBox1.Visible = true;
                panel1.Visible = true;
                button1.Visible = true; label7.Visible = true;
                if (Form1.gender == "female")
                {
                    sp2 = new SoundPlayer(@"sound\femaleQue1.wav");
                    sp2.Play();
                }
                if (Form1.gender == "male")
                {
                    sp2 = new SoundPlayer(@"sound\maleQue1.wav");
                    sp2.Play();
                }
                timer1.Stop();
            }
        }
        bool right = false;
        public static int score = 0;
        int counGif2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            counGif2++;
            if(counGif2==1)
            {
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox1.Visible = true;
                picBox1.Image = Image.FromFile(@"pic\gif8.gif");
                this.BackgroundImage = null;
            }
            if(counGif2==47)
            {
                picBox1.Image = Image.FromFile(@"pic\gif9.gif");
            }
            if(counGif2==71)
            { // the second question 
                picBox1.Visible = false;
                picBox1.Image = null;
                img = new Bitmap(@"pic\scene3.png");
                this.BackgroundImage = (img);
                picBoxChild.Visible = true;
                picBox2.Visible = true;
                picBox2.Location = new Point(770, 147);
                picBox2.Size = new System.Drawing.Size(230, 400);
                //groupBox1.Location = new Point(12, 43);
                groupBox2.Visible = true; button2.Visible = true;
                if (Form1.gender == "female")
                {
                   Que2 = new SoundPlayer(@"sound\femaleQue2.wav");
                   Que2.Play();
                }
                if (Form1.gender == "male")
                {
                    Que2 = new SoundPlayer(@"sound\maleQue2.wav");
                    Que2.Play();
                }
            }
        }
        bool isSelected = false;
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            isSelected = true;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.ForeColor = System.Drawing.Color.Red;
            checkBox8.Enabled = false;
        }
        SoundPlayer spGood, spBad;
        private void button1_Click(object sender, EventArgs e)
        {
            sp1.Stop();
            if (textBox1.Text == "5" && textBox2.Text == "3" && textBox3.Text == "6" && textBox4.Text == "4" && textBox5.Text == "1" && textBox6.Text == "2" && textBox8.Text == "7")
            {
                right = true;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            else
            {
                spBad = new SoundPlayer(@"sound\noChance.wav");
                spBad.Play();
            }
            groupBox1.Visible = false;
            timer2.Start();
            if (right == true)
                score = score + 15;
            label7.Text = "مجموع النقاط :" + score;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // right answer for question 2
            Que2.Stop();
            picBox1.Visible = false;
            picBox2.Visible = false;
            groupBox2.Visible = false;
            picBoxChild.Visible = false;
            if (isSelected == true)
            {
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
                score = score + 15;
            }
            picBox1.Visible = true;
            picBox1.Image = Image.FromFile(@"pic\gif10.gif");
            groupBox2.Text = "السؤال الثالث";
            timer3.Start();
            this.BackgroundImage = null;
            label7.Text = "مجموع النقاط :" + score;
        }
        int countTime = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            countTime++;
            if(countTime==4)
            {
                    checkBox8.Visible = false;
                    button2.Visible = false;
                    label7.Text = "مجموع النقاط :" + score;
                    picBox1.Visible = false;
                    img = new Bitmap(@"pic\scene5.png");
                    this.BackgroundImage = (img);
                    picBox2.Visible = true;
                    panel2.Visible = true; button3.Visible = true;
                      Que3 = new SoundPlayer(@"sound\FemMaleQue3.wav");
                      Que3.Play();

                    picBox4.Visible = true;
                    groupBox2.Visible = true;
                    label11.Visible = false;
                    checkBox6.Visible = false;
                    checkBox5.Visible = false;
                    checkBox7.Visible = false;
                    timer3.Stop();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        { 
            Que3.Stop();
            if(que3==true)
            {
                // sound play saying cool
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score;
            panel2.Visible = false;
            groupBox2.Text = "السؤال الرابع";
            panel3.Visible = true;
            button4.Visible = true;
            Que4 = new SoundPlayer(@"sound\FemMaleQue4.wav");
            Que4.Play();
        }
        bool que3 = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { 
            // right answer for question3
            que3 = true;
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            checkBox2.ForeColor = System.Drawing.Color.Red;
            checkBox2.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Enabled = false;
            checkBox5.Enabled = false;
            checkBox7.Enabled = false;
            checkBox6.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Enabled = false;
            checkBox8.Enabled = false;
            checkBox7.Enabled = false;
            checkBox5.Enabled = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Enabled = false;
            checkBox5.Enabled = false;
            checkBox8.Enabled = false;
            checkBox7.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox1.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Que4.Stop();
            if (ques4 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score;
            picBox1.Visible = true;
            this.BackgroundImage = null;
            groupBox2.Visible = false;
            panel3.Visible = false;
            picBox2.Visible = false;
            picBox4.Visible = false; button5.ForeColor = System.Drawing.Color.Black;
            picBox1.Image = Image.FromFile(@"pic\gif11.gif");
            timer4.Start();
        }
        bool ques4 = false;
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ques4 = true;
            checkBox10.Enabled = false;
            checkBox9.Enabled = false;
            checkBox4.ForeColor = System.Drawing.Color.Red;
            checkBox4.Enabled = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Enabled = false;
            checkBox4.Enabled = false;
            checkBox9.Enabled = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
        }
        int countTime2 = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            countTime2++;
            if(countTime2==10)
            {
                picBox1.Image = Image.FromFile(@"pic\gif12.gif");
            }
            if (countTime2 == 20)
            {
                picBox1.Image = Image.FromFile(@"pic\gif13.gif");
            }
            if (countTime2 == 23)
            {
                picBox1.Visible = false;
                img = new Bitmap(@"pic\scene6.png");
                this.BackgroundImage = (img);
                picBox2.Visible = true;
                picBox2.Location = new Point(850,230);
                picBox2.Size = new System.Drawing.Size(170,290);
                picBro.Visible = true; 
                picDocRay.Visible = true;
                groupBox2.Visible = true; groupBox2.Text = "السؤال الخامس";
                groupBox2.Location = new Point(532,46);
                panel4.Visible = true; button5.Visible = true;
                Que5 = new SoundPlayer(@"sound\FemMaleQue5.wav");
                Que5.Play();
            }
        }
        bool ques5 = false;
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            // the right answer for question 5
            ques5 = true;
            checkBox11.Enabled = false;
            checkBox13.Enabled = false;
            checkBox12.ForeColor = System.Drawing.Color.Red;
            checkBox12.Enabled = false;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox11.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Que5.Stop();
            if (ques5 == true)
            {
                // sound play saying cool
                score = score + 15;
            }
            else
            {
                // sound play saying bad
            }
            label7.Text = "مجموع النقاط :" + score;
            panel4.Visible = false; button5.Visible = false; groupBox2.Visible = false;
            groupBox3.Visible = true; groupBox3.Location = new Point(559, 68);
            panel5.Visible = true; button6.Visible = true; button6.ForeColor = System.Drawing.Color.Black; panel5.BringToFront();
            Que6 = new SoundPlayer(@"sound\FemMaleQue6.wav");
            Que6.Play();
        }
        bool ques6 = false;
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            ques6 = true;
            checkBox14.Enabled = false;
            checkBox16.Enabled = false;
            checkBox15.ForeColor = System.Drawing.Color.Red;
            checkBox15.Enabled = false;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
            checkBox14.Enabled = false;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Que6.Stop();
            if (ques6 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score;
            groupBox3.Visible = false; panel5.Visible = false; button6.Visible = false;
            picBro.Visible = false; picDocRay.Visible = false;
            picBox1.Visible = true; button7.ForeColor = System.Drawing.Color.Black;
            picBox2.Visible = false;
            timer5.Start();
            picBox1.Image = Image.FromFile(@"pic\gif132.gif");
            if (Form1.gender == "female")
            {
                spGood = new SoundPlayer(@"sound\femalePress6.wav");
                spGood.Play();
            }
            if (Form1.gender == "male")
            {
                spGood = new SoundPlayer(@"sound\malePress6.wav");
                spGood.Play();
            }
        }
        int counTime3 = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {
            counTime3++;
            if(counTime3==17)
            {
                picBox1.Image = Image.FromFile(@"pic\gif14.gif");
            }
            if(counTime3==45)
            {
                picBox1.Image = Image.FromFile(@"pic\gifOp1.gif");
            }
            if (counTime3 == 75)
            {
                picBox1.Image = Image.FromFile(@"pic\gifOp2.gif");
            }
            if(counTime3==105)
            {
                picBox1.Visible =false;
                img = new Bitmap(@"pic\scene7.png");
                this.BackgroundImage = (img);
                picBoxNurse.Visible = true;
                picBoxWash.Visible = true;
                groupBox3.Visible = true; panel6.Visible = true; button7.Visible = true;
                groupBox3.Text = "السؤال السابع";
                groupBox3.ForeColor = System.Drawing.Color.White;
                button5.ForeColor = System.Drawing.Color.Black;
                label15.ForeColor = System.Drawing.Color.White;
                checkBox17.ForeColor = System.Drawing.Color.White;
                checkBox19.ForeColor = System.Drawing.Color.White;
                checkBox18.ForeColor = System.Drawing.Color.White;
                groupBox3.Location = new Point(690,130);
                if (Form1.gender == "female")
                {
                    Que7 = new SoundPlayer(@"sound\femaleQue7.wav");
                    Que7.Play();
                }
                if (Form1.gender == "male")
                {
                    Que7 = new SoundPlayer(@"sound\maleQue7.wav");
                    Que7.Play();
                }
                label15.Visible = true;
            }
        }
        bool ques7 = false;
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {//right answer for qustion 7
            ques7 = true;
            checkBox17.Enabled = false;
            checkBox19.Enabled = false;
            checkBox18.Enabled=false;
            
        }
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            checkBox19.Enabled = false;
            checkBox17.Enabled = false;
            checkBox18.Enabled = false;
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Enabled = false;
            checkBox18.Enabled = false;
            checkBox19.Enabled = false;
        }
        bool ques8 = false;
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            // the right answer for question 8
            checkBox20.Enabled = false;
            checkBox22.Enabled = false;
            checkBox21.Enabled = false;
        }
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Enabled = false;
            checkBox22.Enabled = false;
            checkBox21.Enabled = false;
        }
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            ques8 = true;
            checkBox20.Enabled = false;
            checkBox22.Enabled = false;
            checkBox21.Enabled = false;
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            Que8.Stop();
            if (ques8 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score;
            button8.Visible = false;
            label14.Visible = false; panel8.Visible = false;
            panel9.Visible = true; panel9.BringToFront();
            groupBox4.Text = "السؤال التاسع"; label16.Visible = true; button9.Visible = true;
            if (Form1.gender == "female")
            {
                Que9 = new SoundPlayer(@"sound\femaleQue9.wav");
                Que9.Play();
            }
            if (Form1.gender == "male")
            {
                Que9 = new SoundPlayer(@"sound\maleQue9.wav");
                Que9.Play();
            }

        }
        private void button7_Click_2(object sender, EventArgs e)
        {
            Que7.Stop();
            if (ques7 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score;
            panel6.Visible = false; button7.Visible = false; groupBox3.Visible = false;
            groupBox4.Visible = true; button8.Visible = true; label14.Visible = true; panel8.Visible = true;
            if (Form1.gender == "female")
            {
                Que8 = new SoundPlayer(@"sound\femaleQue8.wav");
                Que8.Play();
            }
            if (Form1.gender == "male")
            {
                Que8 = new SoundPlayer(@"sound\maleQue8.wav");
                Que8.Play();
            }
        }
        bool ques9 = false;
        private void button9_Click(object sender, EventArgs e)
        {
            if (ques9 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score; groupBox5.Text = "السؤال العاشر";
            panel9.Visible = false; button9.Visible = false; label16.Visible = false;
            groupBox4.Visible = false; groupBox5.Visible = true;
            panel10.Visible = true; label17.Visible = true; button10.Visible = true;
            
            if (Form1.gender == "female")
            {
                Que10 = new SoundPlayer(@"sound\femaleQue10.wav");
                Que10.Play();
            }
            if (Form1.gender == "male")
            {
                Que10 = new SoundPlayer(@"sound\maleQue10.wav");
                Que10.Play();
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            // the right answer for question 9
            ques9 = true;
            checkBox23.Enabled = false; checkBox24.Enabled = false; 
            checkBox25.Enabled = false;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            checkBox25.Enabled = false;
            checkBox24.Enabled = false;
            checkBox23.Enabled = false;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            checkBox23.Enabled = false;
            checkBox24.Enabled = false;
            checkBox25.Enabled = false;
        }
        bool ques10 = false;
        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            ques10 = true;
            checkBox26.Enabled = false;
            checkBox27.Enabled = false;
            checkBox28.Enabled = false;
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            checkBox26.Enabled = false;
            checkBox27.Enabled = false;
            checkBox28.Enabled = false;
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            checkBox26.Enabled = false;
            checkBox27.Enabled = false;
            checkBox28.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Que10.Stop();
            if (ques10 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score;
            panel10.Visible = false; button10.Visible = false; groupBox5.Visible = false;
            picBoxNurse.Visible = false;
            picBoxWash.Visible = false;
            this.BackgroundImage = null;
            picBox1.Visible = true;
            timer6.Start();
            picBox1.Image = Image.FromFile(@"pic\gifOp3.gif");      
        }
        int timerCount6 = 0;
        private void timer6_Tick(object sender, EventArgs e)
        {
            timerCount6++;
            if(timerCount6==27)
            {
                picBox1.Image = Image.FromFile(@"pic\gif15.gif");
            }
            if(timerCount6==69)
            {
                picBox1.Image = Image.FromFile(@"pic\gif16.gif");
            }
            if(timerCount6==90)
            {
                picBox1.Visible = false;
                img = new Bitmap(@"pic\scene8.png");
                this.BackgroundImage = (img);
                picBoxBaby.Visible = true;
                piBoDoc.Visible = true;
                piBoTemr.Visible = true; label18.Visible = true;
                groupBox5.Visible = true; groupBox5.Text = "السؤال الحادي عشر";
                panel11.Visible = true; button11.Visible = true; panel11.BringToFront();
                    Que11 = new SoundPlayer(@"sound\FemMaleQue11.wav");
                    Que11.Play();

            }
        }
        bool ques11 = false;
        private void button11_Click(object sender, EventArgs e)
        {
            Que11.Stop();
            if (ques11 == true)
            {
                score = score + 15;
                if (Form1.gender == "female")
                {
                    spGood = new SoundPlayer(@"sound\femaleGood.wav");
                    spGood.Play();
                }
                if (Form1.gender == "male")
                {
                    spGood = new SoundPlayer(@"sound\maleGood.wav");
                    spGood.Play();
                }
            }
            label7.Text = "مجموع النقاط :" + score; piBoDoc.Visible = false; piBoTemr.Visible = false; picBoxBaby.Visible = false;
            this.BackgroundImage = null; groupBox5.Visible = false; panel11.Visible = false; button11.Visible = false;
            picBox1.Visible = true; lasrScore = score;
            picBox1.Image = Image.FromFile(@"pic\gif17.gif");
            timer7.Start();
        }
        public static int lasrScore;
        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            ques11 = true;
            checkBox29.Enabled = false;
            checkBox30.Enabled = false;
            checkBox31.Enabled = false;
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            checkBox29.Enabled = false;
            checkBox30.Enabled = false;
            checkBox31.Enabled = false;
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            checkBox29.Enabled = false;
            checkBox30.Enabled = false;
            checkBox31.Enabled = false;
        }
        int timerCount7 = 0;
        private void timer7_Tick(object sender, EventArgs e)
        {
            timerCount7++;
            if (timerCount7 == 35)
            {
                picBox1.Image = Image.FromFile(@"pic\gif18.gif");
            }
            if (timerCount7 == 66)
            {
                picBox1.Image = null;
                this.Close();
                Form end = new TheEnd();
                end.Show();
            }

        }

    }
}
