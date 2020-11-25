using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    class UserLogManager
    { 
        //singleton을 위한 처리
        private static UserLogManager instance = new UserLogManager(); //객체 생성
        public static UserLogManager GetInstance() { return instance; } //객체를 리턴
        private UserLogManager() { } //생성자

        public void SetLog(int type,int beforeid, int afterid) //로그를 작성하는 함수
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //가져온 날자의 모양 변경
            List<string> list = new List<string>();
            switch (type)
            {
                case 1: //커피 가격 정보 변경 
                    //beforwid == afterid 추가 /else 수정
                    list.Add(LoginManager.GetInstance().num_ + ", '"+date+"', "+beforeid+", "+afterid);
                    QueryManager.Insert("LogCoffee", "userid, date, beforemenuid, aftermenuid").Values(list).Exec();
                    break;
                case 2: // 커피 주문 정보 수정/삭제
                    //beforeorderid == afterorderid 삭제 /else 수정
                    list = new List<string>();
                    list.Add(LoginManager.GetInstance().num_ + ", '" + date + "', " + beforeid + ", " + afterid);
                    QueryManager.Insert("LogCoffeeSold", "userid, date, beforeorderid, afterorderid").Values(list).Exec();
                    break;
                case 3: // 커피 주문 정보 추가
                    //beforeorderid == afterorderid 삭제 /else 수정
                    list = new List<string>();
                    list.Add(LoginManager.GetInstance().num_ + ", '" + date + "', " + beforeid + ", " + afterid + ", " + 1);
                    QueryManager.Insert("LogCoffeeSold", "userid, date, beforeorderid, afterorderid, addtype").Values(list).Exec();
                    break;
            }
        }
        public void GetLog(int type, DataGridView v) //로그를 불러오는 함수
        {
            v.Rows.Clear();
            string query = "";
            MySqlDataReader rdr;
            switch (type)
            {
                case 1://커피 가격 정보 변경 
                    SetColumn(type, v);
                    query =
                        "SELECT l.beforemenuid as beforemenuid, l.aftermenuid as aftermenuid, u.name as username, l.date as date, c1.name as beforename, c1.price as beforeprice, c2.name as aftername, c2.price as afterprice"
                        + " FROM LogCoffee as l join CoffeeUser as u on u.num = l.userid join Coffee as c1 on l.beforemenuid = c1.id join Coffee as c2 on l.aftermenuid = c2.id";
                    rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
                    while (rdr.Read())
                    {
                        string valid;
                        if (rdr["beforemenuid"].ToString() == rdr["aftermenuid"].ToString())
                        {
                            valid = "추가";
                            v.Rows.Add(rdr["username"].ToString(), rdr["date"].ToString(), valid, "", "", rdr["aftername"].ToString(), rdr["afterprice"].ToString());
                        }
                        else
                        {
                            valid = "수정";
                            v.Rows.Add(rdr["username"].ToString(), rdr["date"].ToString(), valid, rdr["beforename"].ToString(), rdr["beforeprice"].ToString(), rdr["aftername"].ToString(), rdr["afterprice"].ToString());
                        }
                    }
                    rdr.Close();
                    break;

                case 2:// 커피 주문 정보 수정/삭제
                    SetColumn(type, v);
                    query =
                        "SELECT l.addtype as addtype, l.beforeorderid as beforemenuid, l.afterorderid as aftermenuid, c1.ordernumber as ordernumber,"
                        + " u.name as username, l.date as date, c1.coffeename as beforename, c1.coffeeprice as beforeprice, c1.count as beforecount, c2.coffeename as aftername, c2.coffeeprice as afterprice, c2.count as aftercount"
                        + " FROM LogCoffeeSold as l join CoffeeUser as u on u.num = l.userid join CoffeeSold as c1 on l.beforeorderid = c1.id join CoffeeSold as c2 on l.afterorderid = c2.id";
                    rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
                    while (rdr.Read())
                    {
                        string valid;
                        if (rdr["addtype"].ToString() == "1")
                        {
                            valid = "추가";
                            v.Rows.Add(rdr["username"].ToString(), rdr["date"].ToString(), rdr["ordernumber"].ToString(), valid, "", "", "", rdr["aftername"].ToString(), rdr["afterprice"].ToString(), rdr["aftercount"].ToString());
                        }
                        else if(rdr["beforemenuid"].ToString() == rdr["aftermenuid"].ToString())
                        {
                            valid = "삭제";
                            v.Rows.Add(rdr["username"].ToString(), rdr["date"].ToString(), rdr["ordernumber"].ToString(), valid, rdr["beforename"].ToString(), rdr["beforeprice"].ToString(), rdr["beforecount"].ToString(), "", "", "");
                        }
                        else
                        {
                            valid = "수정";
                            v.Rows.Add(rdr["username"].ToString(), rdr["date"].ToString(), rdr["ordernumber"].ToString(), valid, rdr["beforename"].ToString(), rdr["beforeprice"].ToString(), rdr["beforecount"].ToString(), rdr["aftername"].ToString(), rdr["afterprice"].ToString(), rdr["aftercount"].ToString());
                        }
                    }
                    rdr.Close();
                    break;
            }
        }

        public void SetColumn(int type, DataGridView v)
        {
            switch (type)
            {
                case 1://커피 가격 정보 변경 
                    v.ColumnCount = 7;
                    v.Columns[0].Name = "유저이름";
                    v.Columns[1].Name = "날자";
                    v.Columns[2].Name = "수정내용";
                    v.Columns[3].Name = "변경전 메뉴 이름";
                    v.Columns[4].Name = "변경전 메뉴 가격";
                    v.Columns[5].Name = "변경후 메뉴 이름";
                    v.Columns[6].Name = "변경후 메뉴 가격";
                    break;
                case 2:// 커피 주문 정보 수정/삭제
                    v.ColumnCount = 10;
                    v.Columns[0].Name = "유저이름";
                    v.Columns[1].Name = "날자";
                    v.Columns[2].Name = "주문번호";
                    v.Columns[3].Name = "수정내용";
                    v.Columns[4].Name = "변경전 메뉴 이름";
                    v.Columns[5].Name = "변경전 메뉴 가격";
                    v.Columns[6].Name = "변경전 메뉴 개수";
                    v.Columns[7].Name = "변경후 메뉴 이름";
                    v.Columns[8].Name = "변경후 메뉴 가격";
                    v.Columns[9].Name = "변경후 메뉴 개수";
                    break;
            }
        }
    }
}
