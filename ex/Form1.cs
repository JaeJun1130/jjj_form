using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string h = textBox1.Text;
            h = h.Trim();

            string k = textBox2.Text;
            k = k.Trim();

            string a = textBox3.Text;
            a = a.Trim();

            double ha = Convert.ToDouble(h);
            int ka = Convert.ToInt32(k);

            /*
            double ha = ?.?? (h);   //double 형변환
            int ka =?.?? (k);       // int 형변환
            */
            

            double bmi = ka / (ha * ha);
            bmi = bmi * 10000;

            this.lbResult.Items.Add("나이 :" +a +"  "+ "당신의 bmi =" + bmi + "입니다") ;

            if (bmi < 18.5)
            {
                this.lbResult.Items.Add("저체중입니다");
            }

            else if (bmi > 18.5 && bmi < 23)
            {
                this.lbResult.Items.Add("정상입니다");
            }

            else if (bmi > 23 && bmi < 25)
            {
                this.lbResult.Items.Add("과체중입니다");
            }

            else if (bmi > 25 && bmi < 30)
            {
                this.lbResult.Items.Add("비만입니다");
            }

            else if (bmi > 30)
            {
                this.lbResult.Items.Add("고도비만입니다");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbResult.Items.Clear();
            this.textBox1.Text = null; 
            this.textBox2.Text = null;
            this.textBox3.Text = null;

            /*
             ?.??.???.????();    // 초기화 시키는 명령어
             this.?.Text = null; // 텍스트박스 초기화
             this.?.Text = null;
             this.?.Text = null;
             */
        }

        private void lbResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
