using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class FormSign : Form
    {
        public FormSign()
        {
            InitializeComponent();
            initvalues(); //초기화 함수
        }

        private void initvalues() //초기화 함수
        {
            buttonCheckID.Visible = true;
            labelOK.Visible = false;
            labelidok.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!labelidok.Visible) //id 중복체크 안된 경우
            {
                MessageBox.Show("id 중복확인을 해주세요");
                return;
            }
            if(!labelOK.Visible) //pw 형식에 맞지 않은 경우
            {
                MessageBox.Show("pw 형식이 옳지 않습니다.");
                return;
            }
            if(comboBoxManager.Text == ""|| textBoxname.Text =="") //입력되지 않은 경우
            {
                MessageBox.Show("입력할 것이 남아 있습니다.");
                return;
            }
            List<string> value = new List<string>();
            string query = "'"+ textBoxid.Text; //id
            query += "', hex(aes_encrypt('" + textBoxpw.Text + "', 'dblogin'))"; //pw
            query += ", '"+textBoxname.Text; //이름
            if (comboBoxManager.Text == "관리자") //직책
            {
                query += "', 1";
            }
            else
            {
                query += "', 0";
            }
            query += ", 0"; //valid
            value.Add(query);
            //디비에 입력함
            QueryManager.Insert("CoffeeUser", "id,pw,name,manager,valid").Values(value).EmpExec(); 
            MessageBox.Show("회원가입 완료");
            this.Close();
        }

        private void buttonCheckID_Click(object sender, EventArgs e)
        {
            if(textBoxid.Text == "") //id 입력되지않음.
            {
                MessageBox.Show("id를 입력해주세요");
                return;
            }
            string query = "select count(id) as count from CoffeeUser where id = '" + textBoxid.Text + "'";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            if(rdr.Read())
            {
                if (Int32.Parse(rdr["count"].ToString()) <= 0){ //중복되지 않음.
                    labelidok.Visible = true;
                    buttonCheckID.Visible = false;
                }else //중복되는 id
                {
                    MessageBox.Show("이미 있는 id입니다.");
                    return;
                }
            }

        }

        private void textBoxpw_TextChanged(object sender, EventArgs e)
        {
            Regex regex_count = new Regex(@"^(?=.*[A-Z])^(?=.*[0-9])^(?=.*[\W])^(?=.*[\W]).{8,}$"); //글자수 확인
            bool type = regex_count.IsMatch(textBoxpw.Text);
            if (type == true) labelOK.Visible = true; //형식이 맞는 경우
            else labelOK.Visible = false; //형식이 맞지 않는 경우
        }
    }
}
