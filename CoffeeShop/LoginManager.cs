using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    class LoginManager
    {
        public string id_ { get; set; } //id 값
        public int num_ { get; set; } //사원 번호
        public string pw_ { get; set; }  //pw
        public string name_ { get; set; }  //사람 이름
        public int type_ { get; set; }  //매니저 유무(1- 매니저, 0- 점원)
        public string logintime_ { get; set; } //로그인 시간

        //singleton을 위한 처리
        private static LoginManager instance = new LoginManager(); //객체 생성
        public static LoginManager GetInstance() { return instance; } //객체를 리턴
        private LoginManager() { } //생성자
        
        public int Login(string id, string pw) //로그인 메소드
        {
            //   string query = "SELECT * FROM CoffeeUser WHERE id = '" //select 쿼리
            //     + id + "'AND pw = 'AES_DECRYPT(UNHEX(" + pw + ",'dblogin'))'"; 
            string query = "select num,id, cast(AES_DECRYPT(UNHEX(pw), 'dblogin') as char(10000)character set utf8) AS pw,name,manager FROM CoffeeUser";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //db 호출
            while(rdr.Read())//로그인 성공한다면
            {
                if(rdr["id"].ToString() == id && rdr["pw"].ToString() == pw)
                {
                    num_ = Int32.Parse(rdr["num"].ToString()); //사원 번호 저장
                    id_ = rdr["id"].ToString(); //id 저장
                    pw_ = rdr["pw"].ToString(); //pw 저장
                    name_ = rdr["name"].ToString(); //이름 저장
                    type_ = Int32.Parse(rdr["manager"].ToString()); //타입 저장
                    logintime_ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
                    rdr.Close();
                    query = "INSERT INTO CoffeeLoginLogout(userid,userlogin) VALUES("+ num_ +", '"+logintime_+"')"; 
                    DBManager.GetInstance().DBquery(query); //로그인 시간 기록
                    return 1; //로그인 성공
                }
            }
            rdr.Close();
            return 0; //로그인 실패
        }

        public void Logout(int type) //type = 0 : 로그아웃 버튼 클릭시 / type = 1 : x 버튼으로 강제 종료시
        {
            string query = "UPDATE CoffeeLoginLogout SET userlogout = '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE userlogin = '"+logintime_+"' AND userid = "+num_;
            DBManager.GetInstance().DBquery(query); //로그아웃 시간 기록
            if(type == 0) { //로그아웃 버튼 클릭시
                MessageBox.Show("로그아웃 되었습니다.", "확인");

                FormLogin form = new FormLogin(); //새로운 폼 생성
                form.Show(); //폼 show
                Program.ac.MainForm = form; //동적으로 시작 폼 변경
            }
        }

        public void ChangePW_DB() //pw 변경 함수
        {//8자 이상 / 1개 이상의 대문자, 특수문자, 숫자 포함

        }


    }
}
