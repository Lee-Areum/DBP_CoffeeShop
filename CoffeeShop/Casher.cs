using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace CoffeeShop
{
    class Casher
    {
        public int ordernum = 0; //주문번호를 저장해두는 변수
        public void AddCoffee(List<string> list) //커피 버튼 클릭시 판매한 커피를 저장하는 함수
        { 
            QueryManager.Insert("CoffeeSold", "ordernumber,date,username,coffeeid,coffeename,coffeeprice,count").Values(list).EmpExec();
          
            MessageBox.Show("구매완료", "확인");
        }
    }
}
