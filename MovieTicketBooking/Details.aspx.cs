using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace MovieTicketBooking
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Server=HYDSQLDMO01\TRN01; Database=WI_Training_VivekKumar; Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Seat.html");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

            string name = TextBox1.Text;
            long mobnumber = Convert.ToInt64(TextBox2.Text);
            int movieid = Convert.ToInt32(TextBox3.Text);
            string seatnumber = TextBox4.Text;

            string query = string.Format("insert into BOOKINGTB values( '{0}', '{1}', '{2}', '{3}')", name, mobnumber, movieid, seatnumber);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ClientScript.RegisterClientScriptBlock(this.GetType(),"k", "swal(\"Congratulations!\", \"Your Ticket has been booked!\", \"success\")", true);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        
        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Cancel.html");
        }
    }
}
