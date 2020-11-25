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
    public partial class DialogChangeOrder : Form
    {
        private FormCasher detail_ = new FormCasher(); //부모폼에서 값을 받기위해

        private List<Order> order = new List<Order>(); //주문을 저장하는 list
        private string time; //주문시간
        private string ordernumber; //주문번호
        private Casher c = new Casher(); //Casher 클래스 선언

        public DialogChangeOrder(FormCasher detail,string time, string ordernumber) //생성자
        {
            InitializeComponent();
            detail_ = detail;
            getMenuData(flowLayoutPanelChangeMenu); //메뉴를 불러옴
            this.time = time;
            this.ordernumber = ordernumber;
            InitVariables();
        }

        private void InitVariables() //초기화
        {
            listViewShowOrdertoChange.Items.Clear();
            updateShowPastOrder();
        }

        public void updateShowPastOrder() //listview를 업데이트하기 위한 함수
        {
            //쿼리 작성
            string query = "SELECT * FROM CoffeeSold" +
                " WHERE userid = '" + LoginManager.GetInstance().num_ + "' AND date = '"+time+"' AND ordernumber = "+ordernumber + " AND valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴

            while (rdr.Read())
            {
                ListViewItem items = new ListViewItem(rdr["coffeeid"].ToString()); //커피 id를 가져옴.
                items.SubItems.Add(rdr["coffeename"].ToString());   //커피 이름을 가져옴.
                items.SubItems.Add(rdr["coffeeprice"].ToString()); //커피 가격을 가져옴
                items.SubItems.Add(rdr["count"].ToString()); //주문 개수를 가져옴
                listViewShowOrdertoChange.Items.Add(items); //listview에 더함
            }

            rdr.Close();
        }
        //수정됨
        public void getMenuData(FlowLayoutPanel f) //메뉴 버튼을 가져오는 함수
        { //커피 메뉴 추가
            int i = 0;
            string query = "SELECT * FROM Coffee WHERE valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {   //커피의 id,이름.가격을 주문list에 넣음
                Order o = new Order(rdr["id"].ToString(), rdr["name"].ToString(), rdr["price"].ToString()); 
                order.Add(o);
                //버튼 생성
                Button b = new Button();
                b.Name = i.ToString();
                i++;
                b.Click += new EventHandler(btn_Click); //클릭 리스너
                b.Text = o.menuname;
                f.Controls.Add(b);

                //가격 label 생성
                Label l = new Label();
                l.Text = o.price;
                l.Margin = new Padding(0, 10, 0, 0);
                f.Controls.Add(l);
            }
        }

        public void btn_Click(object sender, EventArgs e) //메뉴버튼이 클릭될때
        {
            Button btn = (Button)sender; //클릭된 버튼 값
            int idx = checkDouble(btn.Text); //기존에 같은 커피를 주문하였는가 확인
            if (idx == -1) //기존에 주문한적 없을 때
            {
                ListViewItem items = new ListViewItem(order[Int32.Parse(btn.Name)].id); //커피 id를 넣음.
                items.SubItems.Add(btn.Text);   //커피 이름을 넣음.
                items.SubItems.Add(order[Int32.Parse(btn.Name)].price); //커피 가격을 넣음.
                items.SubItems.Add("1"); //개수를 1로 정함
                listViewShowOrdertoChange.Items.Add(items); //listview에 더함
            }
            else
            { //기존에 주문한 적이 있을 경우 - 기존 개수 + 1
                listViewShowOrdertoChange.Items[idx].SubItems[3].Text = (Int32.Parse(listViewShowOrdertoChange.Items[idx].SubItems[3].Text) + 1).ToString();
            }
        }

        private int checkDouble(string name)
        { //기존에 주문한 커피였는지 확인하는 함수
            int idx = 0;
            foreach (ListViewItem item in listViewShowOrdertoChange.Items)
            {
                if (item.SubItems[1].Text == name) //이름이 같은 주문기록이 있는 경우
                {
                    return idx;
                }
                idx++;
            }
            idx = -1;
            return idx;
        }

        //수정됨
        private void buttonChangeOK_Click(object sender, EventArgs e) //주문 수정버튼
        { //CoffeeSold의 valid = 1 - 값 존재함, 0 - 값 수정됨 -1 - 값 삭제됨
            if (listViewShowOrdertoChange.Items.Count < 1) //아무것도 선택되지 않을 경우
            {
                MessageBox.Show("메뉴를 선택해주세요", "확인");
                return;
            }
            //delete 코드

            QueryManager.Update("CoffeeSold").Set("valid = 0").Where("userid = '" + LoginManager.GetInstance().num_ + "' AND date = '" + time + "' AND ordernumber = " + ordernumber).EmpExec();

            string query;

            List<int> idx = new List<int>();
            //log를 위한 이전 주문 id 가져오는 코드
            query = "SELECT * FROM CoffeeSold WHERE userid = '" + LoginManager.GetInstance().num_ + "' AND date = '" + time + "' AND ordernumber = " + ordernumber;
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            int id = 0;
            while (rdr.Read())
            {
                idx.Add(Int32.Parse(rdr["id"].ToString()));
            }
            rdr.Close();

            //insert 코드
            DataTable dt = new DataTable();
            
            List<string> list = new List<string>(); //주문을 기록하는 list
            foreach (ListViewItem item in listViewShowOrdertoChange.Items)
            {
                query = ordernumber + ", '" + time + "', '" + LoginManager.GetInstance().num_; //주문번호, 시간, 이름
                query += "', " + item.SubItems[0].Text; //coffeeid
                query += ", '" + item.SubItems[1].Text; //coffeename
                query += "', " + item.SubItems[2].Text; //coffeeprice
                query += ", " + item.SubItems[3].Text; //count
                query += ", 1"; //valid
                list.Add(query);
            }
            c.AddCoffee(list); //주문을 데이터베이스에 기록하는 함수 호출
            
            //log 함수 호출
            query = "SELECT * FROM CoffeeSold WHERE userid = '" + LoginManager.GetInstance().num_ + "' AND date = '" + time + "' AND ordernumber = " + ordernumber + " AND valid = 1";
            rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            int i = 0;
            while (rdr.Read())
            {
                id = Int32.Parse(rdr["id"].ToString());
                //로그 저장
                if (idx.Count <= i)
                {
                    //로그 저장
                    UserLogManager.GetInstance().SetLog(3, id, id);
                }else
                    UserLogManager.GetInstance().SetLog(2, idx[i], id);
                i++;
            }
            rdr.Close();

            InitVariables(); //값 초기화
            this.Close(); //부모 폼으로 돌아감
        }

        private void buttonMenuChangeDelete_Click(object sender, EventArgs e) //주문 삭제 버튼
        {

            if (listViewShowOrdertoChange.SelectedIndices.Count == 0) //아무것도 선택되지 않은 경우
            {
                MessageBox.Show("삭제할 주문을 선택해주세요", "확인");
                return;
            }
            //선택된 주문 삭제
            listViewShowOrdertoChange.Items.RemoveAt(listViewShowOrdertoChange.SelectedIndices[0]);
            MessageBox.Show("삭제완료", "확인");
        }
    }
}