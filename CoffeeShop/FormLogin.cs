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
            if (LoginManager.GetInstance().Login(id, pw) == 0)  //데이터 베이스에 id와 pw가 같은 값이 없다면
            {
                MessageBox.Show("로그인에 실패하였습니다.", "로그인 실패");
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
       
    }
}