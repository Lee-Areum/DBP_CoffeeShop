using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e) //로그인 버튼 클릭시
        {
            string id, pw;

            id = textBoxId.Text; //id 값 가져옴
            pw = textBoxPW.Text; //pw 값 가져옴

            //초기화
            textBoxId.Text = "";
            textBoxPW.Text = "";

            //예외처리
            if (id == "" || pw == "")   //아무것도 입력하지 않았을 시
            {
                MessageBox.Show("ID와 PW를 입력하세요", "입력필요");
                return;
            }
            switch(LoginManager.GetInstance().Login(id, pw))
            {
                case 0: //id,pw 다름
                    MessageBox.Show("로그인에 실패하였습니다.", "로그인 실패");
                    return;
                case 1: //로그인 성공
                    break;
                case 2: //로그인 제한됨
                    MessageBox.Show("로그인이 제한되었습니다.");
                    return;
                case 3://승인대기중
                    MessageBox.Show("가입 대기중입니다.");
                    return;
            }

            if(LoginManager.GetInstance().type_ == 1) // 1 : 매니저 0 :점원
            { //매니저 폼 호출
                FormManager form = new FormManager();
                form.Show();
                Program.ac.MainForm = form;

            }else //점원 폼 호출
            {
                FormCasher form = new FormCasher();
                form.Show();
                Program.ac.MainForm = form;
            }

            this.Close(); //로그인 폼 닫기
           
        }

        private void buttonSign_Click(object sender, EventArgs e) //회원가입 버튼 클릭시
        {
            //Dialog폼을 띄움
            FormSign dig = new FormSign();
            dig.Show();
        }
    }
}