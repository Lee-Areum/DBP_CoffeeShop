using MySql.Data.MySqlClient;
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
    public partial class FormManager : Form
    {
        private Manager m;
        
        public FormManager()
        {
            InitializeComponent();
            InitValue(); //값 초기화 함수 호출
        }
        public void InitValue() //값 초기화 함수
        {
            m = new Manager(dataGridViewShow, comboBoxHowShow);
            labelState.Text = LoginManager.GetInstance().name_+"님 환영합니다."; //LABEL 값 변경
            //커피판매 확인 부분
            dataGridViewShow.DataSource = null; //datagridviewshow clear
            comboBoxHowShow.Text = ""; //combobox clear
            //유저로그 조회부분
            listViewShowUser.Clear();
            m.ShowtolistViewUser(listViewShowUser);
            dataGridViewUserLog.DataSource = null;
            //메뉴 관리부분
            listViewShowMenu.Clear();
            m.ShowtolistViewMenu(listViewShowMenu);
            textBoxMenuName.Text = "";
            textBoxMenuPrice.Text = "";
        }

        private void buttonLogOut_Click(object sender, EventArgs e) //로그아웃 버튼 클릭시
        {
            LoginManager.GetInstance().Logout(0);
            this.Close();
        }

        private void buttonOkHow_Click(object sender, EventArgs e) //확인 버튼 클릭시
        {
            m.ShowtoGridCoffee(); //DataGridView에 띄우는 함수 호출 
        }

        private void buttonUserChoose_Click(object sender, EventArgs e) //로그기록을 볼 유저 선택 버튼 클릭시
        {
            m.ShowtogridUserLog(dataGridViewUserLog);
        }

        private void buttonChangeMenu_Click(object sender, EventArgs e) //수정버튼 클릭시
        {
            if(textBoxMenuName.Text =="" || textBoxMenuPrice.Text == "") //비었는지 확인
            {
                MessageBox.Show("메뉴를 입력해주세요", "확인");
                return;
            }
            if (listViewShowMenu.SelectedIndices.Count == 0) //커피를 선택하지 않고 수정할 경우
            {
                MessageBox.Show("커피를 선택해주세요", "확인");
                return;
            }
            int i = 0;
            if (int.TryParse(textBoxMenuPrice.Text, out i) == false) //가격이 정수가 아닐경우
            {
                MessageBox.Show("정수 가격을 입력해주세요", "확인");
                return;
            }
            string pastname = listViewShowMenu.Items[listViewShowMenu.FocusedItem.Index].SubItems[1].Text;
            string pastprice = listViewShowMenu.Items[listViewShowMenu.FocusedItem.Index].SubItems[2].Text;
            if (textBoxMenuName.Text == pastname && textBoxMenuPrice.Text == pastprice)
            {
                MessageBox.Show("값을 수정해주세요", "확인");
                return;
            }
            int idx = Int32.Parse(listViewShowMenu.Items[listViewShowMenu.FocusedItem.Index].SubItems[0].Text);
            m.ChangeMenu(textBoxMenuName.Text, Int32.Parse(textBoxMenuPrice.Text), idx);
            InitValue(); //초기화
        }

        private void buttonAddMenu_Click(object sender, EventArgs e) //추가버튼 클릭시
        {
            if (textBoxMenuName.Text == "" || textBoxMenuPrice.Text == "") //이름또는 가격이 빌 경우
            {
                MessageBox.Show("메뉴를 입력해주세요", "확인");
                return;
            }
            int i = 0;
            if(int.TryParse(textBoxMenuPrice.Text, out i) == false) //가격이 정수가 아닐경우
            {
                MessageBox.Show("정수 가격을 입력해주세요", "확인");
                return;
            }
            string pastname = listViewShowMenu.Items[listViewShowMenu.FocusedItem.Index].SubItems[1].Text;
            string pastprice = listViewShowMenu.Items[listViewShowMenu.FocusedItem.Index].SubItems[2].Text;
            if (textBoxMenuName.Text == pastname && textBoxMenuPrice.Text == pastprice)
            {
                MessageBox.Show("값을 수정해주세요", "확인");
                return;
            }
            m.AddMenu(textBoxMenuName.Text, Int32.Parse(textBoxMenuPrice.Text));
            InitValue(); //초기화
        }

        private void listViewShowMenu_SelectedIndexChanged(object sender, EventArgs e) //menulistview의 선택이 변경될 경우
        {//값 초기화
            int idx = listViewShowMenu.FocusedItem.Index;
            string name = listViewShowMenu.Items[idx].SubItems[1].Text;
            string price = listViewShowMenu.Items[idx].SubItems[2].Text;
            textBoxMenuName.Text = name;
            textBoxMenuPrice.Text = price;
        }

        private void FormManager_FormClosing(object sender, FormClosingEventArgs e) //폼이 닫힐 경우
        {
            LoginManager.GetInstance().Logout(1); // 자동 로그아웃
        }

        private void buttonlogOK_Click(object sender, EventArgs e)
        {
            m.ShowtoGridLog(comboBoxshowlog,dataGridViewshowlog); //DataGridView에 띄우는 함수 호출 
        }

        private void buttonmanagerchangePW_Click(object sender, EventArgs e)
        {
            //Dialog폼을 띄움
            DialogChangePW dig = new DialogChangePW(LoginManager.GetInstance().pw_);
            dig.Show();
        }
    }
}
