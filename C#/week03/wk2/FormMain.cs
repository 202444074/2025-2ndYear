using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week02Prog01
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked; //ture or false
            if (isToggle)
            { // C#은 0이나 1로 false true 지정 불가능, for while 등등에도 똑같음 
                string data1 = tbxInput1.Text; // 문자열에 넣기위해 Text로 바꿈
                string data2 = tbxInput2.Text;
                string result = data1 + data2; // 문자열연결연산자
                lblResult.Text = result;
            }
            else
            {
                int data1 = int.Parse(tbxInput1.Text); // int로 변환
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; // 산술연산자
                lblResult.Text = result.ToString();
            }

        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if (chkToggle.Checked == false)
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2;
                lblResult.Text = "더하기: " + result.ToString();
            }
            else
            {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 - data2;
                lblResult.Text = "빼기: " + result; // C#은 문자열과 숫자를 더하면 문자열로 바꿔줌 
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxInput1.Text);
            int data2 = int.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                int result = data1 + data2;
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                int result = data1 - data2;
                lblResult.Text = $"빼기: {result}"; //문자열보간법
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInput1.Text); //int.Parse는 소수점을 사용하면 코드가 죽어버림
            double data2 = double.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false) 
            {
                double result = data1 + data2;
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                double result = data1 - data2;
                lblResult.Text = $"빼기: {result}";            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine; // 윈도우에서는 문자열"\r\n"로 줄바꿈, 다른 환경에서는 "\n"만 사용해서 
            //lblResult.Text = Environment.NewLine;
            lblResult.Text += tbxInput1.Text.GetType();
            //lblResult.Text = tbxInput1.Text.GetType(); 밑에있는 주석문과 비슷한 이유로 안돼는거같음
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0];
            //lblResult.Text = tbxInput1.Text[0]; 문자''(char)와 문자열""을 다르게 취급함 그래서 +로 문자열로 바꿔줘야함
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];//C언어 : 1바이트 (ascii) //C# : 2바이트 (unicode)
            byte result1 = (byte)test1; // 1바이트 부호 미지원 정수형, char 2바이트를 1바이트에 넣어서 오류가 생겨서 변환해야함
            sbyte result4 = (sbyte)test1; // 1바이트 부호 지원 정수형, 1바이트라 byte만 s를 붙이는 특수한 경우
            short result2 = (short)test1; //2바이트 부호지원 정수형
            ushort result3 = test1; // char은 부호가 필요없어서 부호가 없는 unsinged는 오류 없음 

            lblResult.Text += $"{test1} {result1} {result2} {result3}"; // 박스 1 2에 abc a넣으면 a의 아스키코드인 97이 나옴
        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            // 정수 -> 실수 : ok
            // 실수 -> 정수 : 처리 필요
            // 작은 숫자 -> 큰 숫자 : ok
            // 큰 숫자 -> 작은 숫자 : 처리 필요
            int data1 = int.Parse(tbxInput1.Text);
            float data2 = (float)double.Parse(tbxInput2.Text);
            long data3 = long.Parse(tbxInput3.Text);
            int data4 = (int)data3;
            double result1 = data1 + data2 + data3 + data4; // int float long이 가장 큰 float으로 바뀌고 더 큰 double에 들어감
            lblResult.Text = result1.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)1.9 + (int)1.6 -> 2
            long result2 = data1 + (long)data2 + data3 + data4; // 실수인 float이 double에 들어가려고해서 에러
            lblResult.Text = result2.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)(1.9 + 1.6) -> 3  위 방법과 결과가 다름
            long result3 = (long)(data1 + data2 + data3 + data4);
            lblResult.Text = result3.ToString();
        }

        private void btnOutput07_Click(object sender, EventArgs e)
        {
            // 관계연산자 이용
            bool result1 = tbxInput1.Text == tbxInput2.Text;
            bool result2 = tbxInput2.Text == tbxInput3.Text;
            bool result3 = tbxInput1.Text == tbxInput3.Text;

            // 논리연산자
            if (result1 && result2 && result3)
            {
                lblResult.Text = "모두 일치";
            }
            else if (result1 || result2 || result3)
            {
                lblResult.Text = "적어도 일치하는 데이터가 있음";
            }
            else
                lblResult.Text = "모두 불일치";
            {

            }
        }

        private void btnOutput08_Click(object sender, EventArgs e)
        {
            var data1 = int.Parse(tbxInput1.Text);
            var data2 = int.Parse(tbxInput2.Text);

            string result; // 지역변수 : 초기화 자동으로 안됨.
            if (data1 == data2) {
                result = "같아요"; // {}안에 각각 string을 선언하면 지역변수라서 아래 result에 안 걸림
            } else if (data1 < data2) {
                result = "뒤가 커요";
            } else {// if (data1 > data2)   { else if를 사용하면 else를 한번더 써야 오류가 없음
                result = "앞이 커요";
            }

            lblResult.Text = result;
        }

        private void btnOutput09_Click(object sender, EventArgs e)
        {
            lblResult.Text = int.MinValue.ToString() + "\r\n";
            lblResult.Text += int.MaxValue.ToString() + "\r\n";
            lblResult.Text += Environment.NewLine;
            lblResult.Text += uint.MinValue.ToString() + "\r\n";
            lblResult.Text += uint.MaxValue.ToString() + "\r\n";
            lblResult.Text += Environment.NewLine;
            //고정소수점
            lblResult.Text += decimal.MinValue.ToString() + "\r\n";
            lblResult.Text += decimal.MaxValue.ToString() + "\r\n";
        }

        private void btnOutput10_Click(object sender, EventArgs e)
        {
            // 배열 array
            TextBox[] textBoxes; // 배열변수 선언
            textBoxes = new TextBox[5]; // 배열 생성해서 변수에 위치 할당

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            // 객체지향 언어의 특징
            // 자료형은 class(or struct)로 만든다
            // class : (값 + 추가 meta data) + 기능 
            int sum = 0;
            for (int i=0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "") {// 주소가 없으면 null, trim은 strip과 같음
                    sum += int.Parse(textBoxes[i].Text);
                }
            }

            lblResult.Text = "총 합:" + sum;

        }

        private void btnOutput11_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes;
            textBoxes = new TextBox[5];

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            int sum = 0;
            int count = 0; // null이거나 값이 없을 때 length로 나누면 안돼서
            for (int i = 0; i < textBoxes.Length; i++) {
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "") {
                    sum += int.Parse(textBoxes[i].Text);
                    ++count;
                } // 모두 값이 없을 때 등 여러 문제는 많음
            }

            lblResult.Text = "평균" + sum / textBoxes.Length;
        }
    }
}
