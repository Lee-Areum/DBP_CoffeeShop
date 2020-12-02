using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    class Manager
    {
        private DataGridView grid_; //DataGridView
        private ComboBox howto_; //ComboBox

        //생성자
        public Manager(DataGridView grid, ComboBox howto)
        {
            grid_ = grid; howto_ = howto;
        } 
        
        //수정됨
        //DataGridView에 띄우는 함수
        public void ShowtoGridCoffee()
        {
            string query = null;
            DataTable dt = new DataTable();
            if (howto_.Text == "") //아무석도 선택하지 않을 경우
            {
                MessageBox.Show("타입을 선택하세요", "타입선택 필요");
                return;
            }
            switch (howto_.SelectedIndex)
            {
                case 0:     //사용자별 일일 판매 -> 날짜/사용자id/판매량/판매액
                    //Select date AS 날짜, userid AS 사용자이름,SUM(count) AS 판매량, SUM(coffeeprice * count) AS 판매액 From CoffeeSold Where valid IS null GROUP BY userid, date
                    dt = QueryManager.Select("DATE_FORMAT(date, '%Y-%m-%d') AS 날짜, userid AS 사용자이름,SUM(count) AS 판매량 ,SUM(coffeeprice * count) AS 판매액").From("CoffeeSold").Where("valid = 1").GroupBy("userid, DATE_FORMAT(date, '%Y-%m-%d')").Exec();
                 
                    break;
                case 1:     //커피종류별 일일 판매 -> 날짜(일)/커피종류/판매량/판매액
                    dt = QueryManager.Select("DATE_FORMAT(date, '%Y-%m-%d') AS 날짜, Coffee.name AS 커피종류,SUM(count) AS 판매량,SUM(price * count) AS 판매액").From("CoffeeSold join Coffee on CoffeeSold.coffeeid = Coffee.id").Where("CoffeeSold.valid = 1").GroupBy("Coffee.name, DATE_FORMAT(date, '%Y-%m-%d')").Exec();
               
                    break;
                case 2:     //커피종류별 월별 판매 -> 날짜(월)/커피종류/판매액/판매량
                    dt = QueryManager.Select("DATE_FORMAT(date,'%Y-%m')AS 날짜, Coffee.name AS 커피종류,SUM(count) AS 판매량,SUM(coffeeprice*count) AS 판매액").From("CoffeeSold join Coffee on CoffeeSold.coffeeid = Coffee.id").Where("CoffeeSold.valid = 1").GroupBy("Coffee.name, DATE_FORMAT(date,'%Y-%m')").Exec();
                    break;
                case 3: //시간별 커피종류 월별 판매 -> 시간/커피종류/판매액/판매량
                    dt = QueryManager.Select("DATE_FORMAT(date,'%p %h시')AS 시간, Coffee.name AS 커피종류,SUM(count) AS 판매량,SUM(coffeeprice*count) AS 판매액").From("CoffeeSold join Coffee on CoffeeSold.coffeeid = Coffee.id").Where("CoffeeSold.valid = 1").GroupBy("Coffee.name, DATE_FORMAT(date,'%p %h시')").Exec();
                    break;
                default: 
                    MessageBox.Show("잘못된 값을 선택하셨습니다.", "index error");
                    return;
            }

           // MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            
            grid_.DataSource = dt; //원격으로 가져오는 것도 가능.
        }
        public void ShowtogridUserLog(DataGridView grid) //사용자의 로그인 시간 정보를 가져오는 함수
        {
            string query = "SELECT name AS 이름, userlogin AS 로그인시간, userlogout AS 로그아웃시간 FROM CoffeeLoginLogout JOIN CoffeeUser ON CoffeeLoginLogout.userid = CoffeeUser.num";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            grid.DataSource = dt;
            rdr.Close(); 
        }
        //수정됨
        public void ShowtolistViewMenu(ListView v) //메뉴의 값을 가져오는 함수
        {
            v.BeginUpdate(); //업데이트 시작
            string query = "SELECT * FROM Coffee WHERE valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                ListViewItem items = new ListViewItem(rdr["id"].ToString()); //커피 id을 가져옴.
                items.SubItems.Add(rdr["name"].ToString());//커피 이름을 가져옴.
                items.SubItems.Add(rdr["price"].ToString()); //커피 가격을 가져옴
                v.Items.Add(items); //listview에 더함
            }
            rdr.Close();
            // 컬럼명과 컬럼사이즈 지정
            v.Columns.Add("커피id", 70, HorizontalAlignment.Left);
            v.Columns.Add("커피이름", 100, HorizontalAlignment.Left); 
            v.Columns.Add("가격", 70, HorizontalAlignment.Left);

            v.EndUpdate(); //업데이트 종료
        }
        public void ShowtolistViewUser(ListView v) //사용자의 정보를 가져와서 listview에 넣음.
        {
            v.BeginUpdate(); //업데이트 시작
            string query = "SELECT * FROM CoffeeUser";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                ListViewItem items = new ListViewItem(rdr["id"].ToString()); //사용자의 id를 가져옴.
                items.SubItems.Add(rdr["name"].ToString()); //사용자의 이름을 가져옴.
                v.Items.Add(items); //item을 넣음.
            }
            rdr.Close();
            // 컬럼명과 컬럼사이즈 지정
            v.Columns.Add("유저id", 70, HorizontalAlignment.Left);
            v.Columns.Add("유저이름", 70, HorizontalAlignment.Left);

            v.EndUpdate(); //업데이트 종료
        }
        //변경됨
        public void AddMenu(string name, int num) //커피 메뉴 추가
        { 
            string query = "INSERT INTO Coffee(name,price,valid) VALUES('" + name + "'," + num + ", 1)";
            DBManager.GetInstance().DBquery(query);
            //로그 저장
            query = "SELECT * FROM Coffee WHERE name = '" + name + "' AND price = " + num + " AND valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            int id = 0;
            while (rdr.Read())
            {
                id = Int32.Parse(rdr["id"].ToString());
            }
            rdr.Close();
            UserLogManager.GetInstance().SetLog(1,id,id);
            MessageBox.Show("추가되었습니다.", "확인");
        }
        //변경됨
        public void ChangeMenu(string name, int num, int idx) //커피 메뉴 수정
        { //valid = 1 :존재하는 것 valid = 0 삭제된 것
            string query = "UPDATE Coffee SET valid = 0 WHERE id = " + idx; //기존 값 삭제된 것으로 처리
            DBManager.GetInstance().DBquery(query);

            List<string> list = new List<string>();
            list.Add("'" + name + "', " + num + ", 1");
            QueryManager.Insert("Coffee", "name, price, valid").Values(list).EmpExec(); //새로운 값 저장
            
            //로그 저장
            query = "SELECT * FROM Coffee WHERE name = '" + name + "' AND price = " + num + " AND valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            int id = 0;
            while (rdr.Read())
            {
                id = Int32.Parse(rdr["id"].ToString());
            }
            rdr.Close();
            UserLogManager.GetInstance().SetLog(1,idx,id);
            MessageBox.Show("수정되었습니다.", "확인");
        }

        public void ShowtoGridLog(ComboBox c, DataGridView v)
        {
            if (c.Text == "") //아무석도 선택하지 않을 경우
            {
                MessageBox.Show("타입을 선택하세요", "타입선택 필요");
                return;
            }
            switch (c.SelectedIndex)
            {
                case 0:
                    UserLogManager.GetInstance().GetLog(1, v);
                    break;

                case 1:
                    UserLogManager.GetInstance().GetLog(2, v);
                    break;

            }
        }

        #region 유저관리 탭

        public void ShowListUserManage(ListView v)
        {
            v.Items.Clear();
            v.BeginUpdate(); //업데이트 시작
            string query = "SELECT * FROM CoffeeUser";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                ListViewItem items = new ListViewItem(rdr["num"].ToString()); //사용자의 순서번호를 가져옴.
                items.SubItems.Add(rdr["id"].ToString()); //사용자의 id을 가져옴.
                items.SubItems.Add(rdr["name"].ToString()); //사용자의 이름을 가져옴.
                string str = "점원";
                if (Int32.Parse(rdr["manager"].ToString()) == 1) str = "관리자";
                items.SubItems.Add(str); //사용자의 id을 가져옴.
                switch (Int32.Parse(rdr["valid"].ToString()))
                {
                    case 0: //승인 대기중인 사용자
                        str = "승인 대기중";
                        break;
                    case 1: //승인완료된 사용자
                        str = "-";
                        break;
                    case -1: //로그인 제한된 사용자
                        str = "로그인 제한됨";
                        break;
                    default:
                        str = "";
                        break; 
                }
                items.SubItems.Add(str); //사용자의 id을 가져옴.
                v.Items.Add(items); //item을 넣음.
            }
            rdr.Close();
            v.EndUpdate(); //업데이트 종료
        }

        public void ChangeButtonName(ListView v, Button b, int idx)
        {//버튼의 이름을 변경하는 함수
            string query = "SELECT * FROM CoffeeUser WHERE num = " + v.Items[idx].SubItems[0].Text;
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                switch(Int32.Parse(rdr["valid"].ToString())){
                    case 0: //승인 대기중인 사용자
                        b.Text = "가입 승인";
                        break;
                    case 1: //승인완료된 사용자
                        b.Text = "로그인 제한";
                        break;
                    case -1: //로그인 제한된 사용자
                        b.Visible = false;
                        break;
                }
            }
        }

        public void ChangeUserState(ListView v, Button b, int idx)
        {//상태 변경하는 함수
            int valid = 1;
            if(b.Text == "가입 승인") //가입 승인일 경우
            {
                valid = 1;
            }else if(b.Text == "로그인 제한") //로그인 제한일 우
            {
                valid = -1;
            }
            QueryManager.Update("CoffeeUser").Set("valid = " + valid).Where("num = "+ v.Items[idx].SubItems[0].Text).Exec();
            MessageBox.Show("적용되었습니다.","확인");
        }

        #endregion

    }
}
