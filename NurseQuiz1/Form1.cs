using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseQuiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string gender;
        Form hospital = new TheHospital();
        private void bt_female_Click(object sender, EventArgs e)
        {
            gender = "female";
            hospital.Show();
            bt_female.Enabled = false; bt_male.Enabled = false;
            
        }

        private void bt_male_Click(object sender, EventArgs e)
        {
            gender = "male";
            hospital.Show();
            bt_male.Enabled = false; bt_female.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false; bt_female.Visible = false; bt_male.Visible = false;
            groupBox1.Visible = true; panel2.Visible = false; richTextBox1.Visible = true; pictureBox3.Visible = true; button1.Visible = true;
            groupBox1.Size = new System.Drawing.Size(480, 446); label2.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.Hide();
            richTextBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.Visible = false; label2.Visible = true;
            richTextBox2.Visible = false;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = true; bt_female.Visible = true; bt_male.Visible = true;
            panel2.Visible = true; pictureBox1.Visible = true;
           }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = " أهلا بك في برنامج اختبار الممرض \n  البرنامج عبارة عن محاكاة لجولة ممرض/ة في مشفى والتي هي عبارة عن اختبار له/ا للقبول للعمل في المشفى\n تبدأ الجولة فعلياً بعد أن تنتهي الطبيبة منى من اعطاء الارشادات وتوضيح شروط القبول للعمل \n الاسئلة ستظهر الواحد تلو الآخر بينما خلال تجول الممرض/ة بين اقسام المشفى وعليه/ا الاجابة عليها\nالاسئلة تتنوع بين ترتيب أحداث واختيار الاجابة الصحيحة ، وايضا فأن للممرض/ة فرصة واحدة فقط للأجابة على كل سؤال\n عدد النقاط الكلي سيظهر أسفل يسار الشاشة ، وفي نهاية الجولة سوف يعرض عدد النقاط الكلي وايضا نتيجة الاختبار (رفض/قبول)";
            richTextBox2.Text = "البرنامج فكرة وتصميم : خلود خالد خديجة \n\n\n تم أصداره في تاريخ 29.5.2016 ";

        }
    }
}
