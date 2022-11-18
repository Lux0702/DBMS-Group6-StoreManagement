using PrepareForFinal.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.BSLayer
{
    public class Account
    {
        MyData db = null; //Lớp dữ liệu thực hiện các thao tác đóng, mở kết nối, lấy chuỗi, lấy dữ liệu
        SqlCommand cmd;

        public string username { get; set; }
        public string password { get; set; }
        public bool isRole  { get; set; }

        public string name { get; set; }

        public string eid { get; set; }


        public Account(string Username, string Password, string Name, string Eid, bool Role)
        {
            username = Username;
            password = Password;
            name = Name;
            isRole = Role;
            eid = Eid;
        }



        public Account()
        {
            db = new MyData();
        }

        public bool testLogin(string username, string password)
        {
            db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("SELECT dbo.uf_CheckLogin(@a_username, @a_password)", db.getSqlConn);
            cmd.Parameters.AddWithValue("@a_username", username);
            cmd.Parameters.AddWithValue("@a_password", password);
            int result = (int)cmd.ExecuteScalar();
            if(result > 0)
            {
                return true;
            }
            
            return false;
        }


        public DataSet GetAccount(string username, string password)
        {
            return db.ExecuteQueryDataSet("Select * from dbo.uf_PermissionRole('"+username+"', '"+password+"')", CommandType.Text);
        }

        public bool getRole(string username, string password)
        {
            db.openConnectionManager();

            
            return true;
        }

    }
}
