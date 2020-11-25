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
    class DBManager
    {
        //서버 주소
        private string strConn = "Server=49.50.174.201;Database =s5532883;Uid=s5532883;pwd=s5532883;Charset=utf8";

        //singleton을 위한 처리
        private static DBManager instance = new DBManager(); //객체 생성
        public static DBManager GetInstance() { return instance; } //객체를 리턴
        private DBManager() { } //생성자

        public void DBquery(string query) //insert 문
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open(); //db연결
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery(); //실행
            }
        }

        public MySqlDataReader Select(string query)//select 문
        {
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open(); //db연결
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader(); //값 받아옴
            return rdr;
        }

    }

    class QueryManager
    {
        public QueryManager(){} //생성자

        string query = ""; //쿼리를 저장하는 함수

        public static QueryManager Select(string columns) //SELECT문
        {
            QueryManager instance = new QueryManager();
            
            instance.query = "SELECT " + columns;

            return instance;
        }
        
        public QueryManager From(string table) //FROM문
        {
            query += " FROM " + table;
            return this;
        }

        public QueryManager Where(string where) //WHERE문
        {
            query += " WHERE " + where;
            return this;
        }

        public QueryManager GroupBy(string groupby) //GROUP BY문
        {
            query += " Group By " + groupby;
            return this;
        }

        public static QueryManager Insert(string table, string columns)   //insert into문
        { 
            QueryManager instance = new QueryManager();

            instance.query = "INSERT INTO " + table +"( "+columns+" )";

            return instance;
        }

        public QueryManager Values(List<string> values) //value문
        {
            query += " VALUES (";
            int i = 0;
            foreach (string value in values)
            {
                if(i == 0)
                {
                    query += value + " )";
                    i++;
                }else
                query += ", ( " + value + " )";
            }
            return this;
        }

        public static QueryManager Update(string table) //update문
        {
            QueryManager instance = new QueryManager();

            instance.query = "UPDATE " + table;

            return instance;
        }

        public QueryManager Set(string data) //set문
        {
            query += " SET " + data;
            return this;
        }

        public static QueryManager Delete(string table) //delete문
        {
            QueryManager instance = new QueryManager();

            instance.query = "DELETE FROM " + table;

            return instance;
        }
        public DataTable Exec() //select의 실행문
        {
            DataTable dt = new DataTable(); //가져온 데이터들을 담는 table
            
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //실행코드
            dt.Load(rdr);

            return dt;
        }
        public void EmpExec() //select 외의 실행문
        {
            DBManager.GetInstance().DBquery(query); //실행코드
        }
    }
}
