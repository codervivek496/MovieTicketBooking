using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieTicketBooking
{
    public partial class GetMovieImg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Movies> newmov = new List<Movies>();
            SqlConnection con = new SqlConnection(@"Server=HYDSQLDMO01\TRN01; Database=WI_Training_VivekKumar; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select movieid, moviename, movieimage from movies", con);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                newmov.Add(new Movies()
                {
                    MOVIEID = Convert.ToInt32(dataReader["MOVIEID"]),
                    MOVIENAME = Convert.ToString(dataReader["MOVIENAME"]),
                    MOVIEIMAGE = Convert.ToString(dataReader["MOVIEIMAGE"]),
                });
            }
            string strMovies = JsonConvert.SerializeObject(newmov);
            Response.Write(strMovies);
            con.Close();

        }
    }
}