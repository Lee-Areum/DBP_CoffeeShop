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
    public partial class FormCasher : Form 
    {
        private List<Order> order = new List<Order>(); //주문을 저장하는 list
        private Casher c = new Casher(); //Casher 클래스 선언

        public FormCasher() //생성자
        {
            InitializeComponent();
            InitVariables(); //초기화 값
            getMenuData(flowLayoutPanelMenu); //메뉴 값을 가져옴.
        }
        private void InitVariables() //초기화
        {
            labelState.Text = LoginManager.GetInstance().name_ + "님 환영합니다."; //LABEL 값 변경
            dateTimePickerSellDate.Value = DateTime.Now; //현재 시간 설정
            listViewShowOrder.Items.Clear();
            dataGridViewShowPastOrder.Rows.Clear();
            dataGridViewShowPastOrder.CurrentCell = null; 
            updateShowPastOrder(); //지난 주문 불러오기
        }
        #region 첫번째탭
        public void getMenuData(FlowLayoutPanel f) //메뉴 버튼 생성하는 함수
        { //커피 메뉴 추가
            int i = 0;
            string query = "SELECT * FROM Coffee WHERE valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {  //커피의 id,이름.가격을 주문list에 넣음
                Order o = new Order(rdr["id"].ToString(), rdr["name"].ToString(), rdr["price"].ToString());
                order.Add(o);
                //버튼 생성
                Button b = new Button();
                b.Name = i.ToString();
                i++;
                b.Click += new EventHandler(btn_Click);//클릭 리스너
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
            int idx = checkDouble(btn.Text); ; //기존에 같은 커피를 주문하였는가 확인
            if (idx == -1) //기존에 주문한적 없을 때
            {
                ListViewItem items = new ListViewItem(order[Int32.Parse(btn.Name)].id); //커피 id를 가져옴.
                items.SubItems.Add(btn.Text);   //커피 이름을 가져옴.
                items.SubItems.Add(order[Int32.Parse(btn.Name)].price); //커피 가격을 가져옴
                items.SubItems.Add("1"); //개수를 1로 정함
                listViewShowOrder.Items.Add(items); //listview에 더함
            }else
            {//기존에 주문한 적이 있을 경우 - 기존 개수 + 1
                listViewShowOrder.Items[idx].SubItems[3].Text = (Int32.Parse(listViewShowOrder.Items[idx].SubItems[3].Text) + 1).ToString();
            }
        }

        private int checkDouble(string name) { //기존에 주문한 커피였는지 확인 
            int idx = 0;
            foreach(ListViewItem item in listViewShowOrder.Items)
            {
                if(item.SubItems[1].Text== name) //이름이 같은 주문기록이 있는 경우
                {
                    return idx;
                }
                idx ++;
            }
            idx = -1;
            return idx;
        }

        private void buttonSendOrder_Click_1(object sender, EventArgs e) //주문하기 버튼
        {
            if (listViewShowOrder.Items.Count < 1) //아무것도 선택되지 않을 경우
            {
                MessageBox.Show("메뉴를 선택해주세요", "확인");
                return;
            }
            //개수가 0인지 확인
            string query = "SELECT count(*)as count FROM CoffeeSold WHERE valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            while (rdr.Read())
            {
                c.ordernum = Int32.Parse(rdr["count"].ToString());
            }
            rdr.Close();
            if(c.ordernum != 0)
            {
                //가장 최근 주문번호를 받아오는 코드
                query = "SELECT * FROM CoffeeSold WHERE valid = 1 ORDER BY date DESC LIMIT 1";
                rdr = DBManager.GetInstance().Select(query);
                while (rdr.Read())
                {
                    c.ordernum = Int32.Parse(rdr["ordernumber"].ToString());
                }
                rdr.Close();
                if (c.ordernum == 10) c.ordernum = 0;
            }
            c.ordernum++;
            //insert 코드
            string date = dateTimePickerSellDate.Value.ToString("yyyy-MM-dd HH:mm:ss"); //가져온 날자의 모양 변경
            List<string> list = new List<string>(); //주문을 기록하는 list
            foreach (ListViewItem item in listViewShowOrder.Items)
            {
                query = c.ordernum+", '" + date + "', '" + LoginManager.GetInstance().num_; //주문번호, 시간, 이름
                query += "', " + item.SubItems[0].Text; //coffeeid
                query += ", '" + item.SubItems[1].Text; //coffeename
                query += "', " + item.SubItems[2].Text; //coffeeprice
                query += ", " + item.SubItems[3].Text; //count
                query += ", 1"; //valid
                list.Add(query);
            }
            c.AddCoffee(list); //주문을 데이터베이스에 기록하는 함수 호출
            InitVariables(); //값 초기화
        }

        private void buttonMenuDelete_Click(object sender, EventArgs e) //주문 삭제 버튼
        {
            if (listViewShowOrder.SelectedIndices.Count == 0) //아무것도 선택되지 않은 경우
            {
                MessageBox.Show("삭제할 주문을 선택해주세요", "확인");
                return;
            }
            //선택된 주문 삭제
            listViewShowOrder.Items.RemoveAt(listViewShowOrder.SelectedIndices[0]);
            MessageBox.Show("삭제완료", "확인");
        }

        #endregion
        #region 두번째 탭

        public void updateShowPastOrder()
        {
            string query = "SELECT * FROM CoffeeSold" +
                " WHERE userid = '" + LoginManager.GetInstance().num_ + "'";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                string valid = "";
                if (Int32.Parse(rdr["valid"].ToString()) == 0) //주문 값이 수정된 경우
                { continue; }
                if (Int32.Parse(rdr["valid"].ToString()) == -1) //주문 값이 삭제된 경우
                { valid = "취소됨"; }
                //gridview에 더함 - id값, 주문번호, 날짜, 커피이름, 커피가격, 개수, 비교
                dataGridViewShowPastOrder.Rows.Add(rdr["id"].ToString(),rdr["ordernumber"].ToString(), rdr["date"].ToString(), rdr["coffeename"].ToString(), rdr["coffeeprice"].ToString(),rdr["count"].ToString(),valid);
            }
            rdr.Close();
        }

        private void buttonChangeOrder_Click(object sender, EventArgs e) //지난주문 수정
        {
            if (dataGridViewShowPastOrder.CurrentCell == null) //아무것도 선택되지 않은 경우
            {
                MessageBox.Show("수정할 주문을 선택해주세요", "확인");
                return;
            }
            int rowindex = dataGridViewShowPastOrder.CurrentRow.Index; //선택된 row의 index 번호를 가져옴
            if (dataGridViewShowPastOrder.Rows[rowindex].Cells[6].Value.ToString() != "") //이미 취소된 주문일 경우
            {
                MessageBox.Show("이미 취소된 주문입니다.", "확인");
                return;
            }
            string time = dataGridViewShowPastOrder.Rows[rowindex].Cells[2].Value.ToString(); //주문 시간을 가져옴
            DateTime dt = DateTime.Parse(time);
            string date = dt.ToString("yyyy-MM-dd HH:mm:ss"); //가져온 날자의 모양 변경
            string ordernum = dataGridViewShowPastOrder.Rows[rowindex].Cells[1].Value.ToString(); //주문번호를 가져옴
            //Dialog폼을 띄움
            DialogChangeOrder dig = new DialogChangeOrder(this,date,ordernum); 
            dig.FormClosed += new FormClosedEventHandler(DialogChangeOrder_Closed);
            dig.Show();
        }

        void DialogChangeOrder_Closed(object sender, FormClosedEventArgs e) //지난주문 수정 dialog가 꺼졌을 때
        {
            InitVariables(); //값 초기화
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e) //지난주문 삭제
        {
            if (dataGridViewShowPastOrder.CurrentCell == null) //아무것도 선택되지 않은 경우
            {
                MessageBox.Show("취소할 주문을 선택해주세요", "확인");
                return;
            }
            int rowindex = dataGridViewShowPastOrder.CurrentRow.Index; //선택된 row의 index 번호를 가져옴
            if (dataGridViewShowPastOrder.Rows[rowindex].Cells[6].Value.ToString() != "") //이미 취소된 주문일 경우
            {
                MessageBox.Show("이미 취소된 주문입니다.", "확인");
                return;
            }
            //취소하는 코드
            string id = dataGridViewShowPastOrder.Rows[rowindex].Cells[0].Value.ToString();
            string where = "id = " + id;
            QueryManager.Update("CoffeeSold").Set("valid = -1").Where(where).EmpExec();

            //log 넣는 함수
            UserLogManager.GetInstance().SetLog(2,Int32.Parse(id), Int32.Parse(id));
            MessageBox.Show("취소되었습니다.", "확인");
            InitVariables();
        }

        private void buttonLogOut_Click(object sender, EventArgs e) //로그아웃 버튼 클릭
        {
            LoginManager.GetInstance().Logout(0); //로그아웃 호출
            this.Close(); //폼 닫기
        }
        #endregion

        private void dateTimePickerSellDate_ValueChanged(object sender, EventArgs e) //날자가 바뀌면
        {
            /*
            listBoxShowMenuToCasher.SelectedIndex = -1; //초기화
            */    
        }

        private void FormCasher_FormClosing(object sender, FormClosingEventArgs e) //폼이 닫기는 경우
        {
            LoginManager.GetInstance().Logout(1); //자동 로그아웃 기록
        }

        private void buttoncasherchangePW_Click(object sender, EventArgs e)
        {
            //Dialog폼을 띄움
            DialogChangePW dig = new DialogChangePW(LoginManager.GetInstance().pw_);
            dig.Show();
        }
    }


    class Order //커피메뉴 클래스
    {
        public string id { get; set; } //커피 id
        public string menuname { get; set; } //메뉴이름
        public string price { get; set; } //가격

        public Order() { } //생성자
        public Order(string id,string name, string price)
        {
            this.id = id;
            this.menuname = name;
            this.price = price;
        }
    }
}
