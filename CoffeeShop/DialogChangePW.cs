using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class DialogChangePW : Form
    {
        string pw;

        public DialogChangePW(string pw) //생성자
        {
            InitializeComponent();
            this.pw = pw;
            InitVariables();
        }

        private void InitVariables() //초기화
        {
            textBoxchangepw.Text = pw;
        }

        public bool checkpw()
        {
            string test = textBoxchangepw.Text;

            Regex regex_count = new Regex(@".{8,}$"); //글자수 확인
            bool type = regex_count.IsMatch(test);
            if (!type)
            {
                MessageBox.Show("글자수가 적습니다.", "확인");
                return false;
            }
            Regex regex_big = new Regex(@"^(?=.*[A-Z])"); //대문자 있는지
            type = regex_big.IsMatch(test);
            if (!type)
            {
                MessageBox.Show("대문자가 없습니다.", "확인");
                return false;
            }

            Regex regex_in = new Regex(@"^(?=.*[0-9])"); //숫자가 있는지
            type = regex_in.IsMatch(test);
            if (!type)
            {
                MessageBox.Show("숫자가 없습니다.", "확인");
                return false;
            }

            Regex regex_ex = new Regex(@"^(?=.*[\W])"); //특수문자가 있는지
            type = regex_ex.IsMatch(test);
            if (!type)
            {
                MessageBox.Show("특수문자가 없습니다.", "확인");
                return false;
            }
            return true;
        }

        private void buttonchangepwOK_Click(object sender, EventArgs e)
        {
            if (checkpw())
            { //update CoffeeUser set pw = hex(aes_encrypt('abcd1234','dblogin')) where num = 3
                QueryManager.Update("CoffeeUser").Set("pw = hex(aes_encrypt('"+ textBoxchangepw.Text + "','dblogin'))").Where("num = "+LoginManager.GetInstance().num_).Exec();
                MessageBox.Show("비밀번호가 변경되었습니다.", "확인");
                this.Close();
            }
        }
        
    }
}
