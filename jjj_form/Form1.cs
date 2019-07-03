using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jjj_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnPoll_Click(object sender, EventArgs e)
        {
            if (this.chb01.Checked != false || this.chb02.Checked != false)//chb01, chb02 중 하나라도 체크된 경우
            {
                foreach (RadioButton c in this.gbHobby.Controls)//gbHobby에 속한 RadioButton컨트롤 차례로 c에 대입
                {  //c<- rbtn01, rbtn02
                    if (c.Checked == true)  //rbtn01.Checked가 참이면, rbtn02.Checked가 참이면
                        this.IblHobby.Text = c.Text; // rbtn01.Text를 lblHobby.Text에 대입 
                }
                this.IblSports.Text = ""; //label초기화
                foreach (CheckBox c in this.gbSports.Controls) //gbSports에 속한 CheckBox컨트롤 차례로 c에 대입
                {//c<- chb01, chb02
                    if (c.Checked == true) //chb01.Checked가 참이면, chb02.Checked가 참이면
                    {
                        this.IblSports.Text += c.Text + " "; //checkBox는 두개 모두 선택이 가능하므로 ‘+=‘연산자로 누적
                    }
                }
                this.IblMe.Text = "";
                foreach(CheckBox b in this.gbMe.Controls)
                {
                    if(b.Checked==true)
                    {
                        this.IblMe.Text = b.Text;
                    }
                }
                this.IblDrink.Text = "";
                if (rbtn03.Checked == true)
                {
                    this.IblDrink.Text += rbtn03.Text + " ";  //콜라레이블에 출력
                }
                if (chb03.Checked == true)
                {
                    this.IblDrink.Text += chb03.Text + " ";//사이다레이블에 출력
                }
            }
            else
            {
                this.IblHobby.Text = "체크박스가 체크되어있지 않음.\r\n해당 박스를 체크하세요";   //\r\n 개행 
                this.IblSports.Text = " ";  // 스포츠 칸 공백
                this.IblDrink.Text = " ";
                this.IblMe.Text = " ";
            }
        }

        private void chb02_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
