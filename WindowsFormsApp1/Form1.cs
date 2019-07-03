using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbResult 초기화
            this.lbResult.Items.Clear();

            //선택된 아이템이 "2 단"인 경우 s="2 단"
            var s = this.cbbSelect.SelectedItem.ToString();

            //gustr[0]='2',gustr[0]='단'
            var gustr = s.Split(new char[] { ' ' });

            //lbResult에 "2단 실행 결과" 문자열 출력
            this.lbResult.Items.Add(gustr[0] + "단 실행 결과");

            //lbResult에 공백 문자열 출력
            this.lbResult.Items.Add("****************");
            this.lbResult.Items.Add("****************");

            //변수.ToString:변수를 문자열로 변환
            //Convert.ToInt32(변수):변수를 정수형으로 변환
            for (var i = 1; i < 10; i++)
            {//lbResult에 "2 * 1 = 2"문자열 출력
                this.lbResult.Items.Add(gustr[0] + " 곱하기 " + i.ToString() + " = " + (Convert.ToInt32(gustr[0]) * i).ToString()+ "입니다");
            }
            


        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbResult1.Items.Clear();

            // 선택된 아이템이 "0 1 시"인 경우 s="0 1 시"
            var s = this.cbbTime.SelectedItem.ToString();

            //gustr[0]='0',gustr[0]='1'
            var gustr = s.Split(new char[] { ' ' });
            int aa = Convert.ToInt16(gustr[0] + gustr[1]); //aa에 ‘0’+’1’->’01’->1숫자
                                                           //lbResult에 “~시를 초로 계산하면" 문자열 출력

            this.lbResult1.Items.Add( aa + "시를 초로 계산하면"); //시간출력

            //lbResult에 공백 문자열 출력
            this.lbResult1.Items.Add("");
            this.lbResult1.Items.Add("");

            string i1;
            //('0'+'1‘)를 숫자로 변경(aa)했다가 초를 계산 (숫자로변경된시간x60x60)하고 그 결과를 다시 문자열로 변경
            i1 = (Convert.ToInt32(aa)*60*60).ToString();

            //(gustr[0] + gustr[1])->(’0’+’1’ )을 숫자로 변경했다가 문자열로 변경+계산된 초(i1) 초 추가
            // ‘02’시를 ‘2’로 출력하기 위함 
            this.lbResult1.Items.Add(aa.ToString() + "시는 " + i1 +"초");

        }

        private void lbResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
