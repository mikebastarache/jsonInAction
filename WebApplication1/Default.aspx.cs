using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JsonInAction
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Emp> emp = GetAllEmp();

            //Serialize
            var jsonString = JsonConvert.SerializeObject(emp);

            //Print
            Response.Write(jsonString);

            // De-serialize
            var empObj = JsonConvert.DeserializeObject<List<Emp>>(jsonString);

            grd1.DataSource = empObj;
            grd1.DataBind();


            /*
            Emp emp = new Emp()
            {
                FirstName = "Mike",
                LastName = "Bastarache",
                ExperLevel = "Ace"
            };
              
            //Serialize
            var jsonString = JsonConvert.SerializeObject(emp);

            //Print
            Response.Write(jsonString);
            
            // De-serialize
            var empObj = JsonConvert.DeserializeObject<Emp>(jsonString);
            
            // Print
            Response.Write(
                "<hr>First name = " + empObj.FirstName +
                "<br>Last name = " + empObj.LastName +
                "<br>Expert Level = " + empObj.ExperLevel
                );
            */

        }

        private List<Emp> GetAllEmp()
        {
            List<Emp> empList = new List<Emp>();

            empList.Add(new Emp() { FirstName = "Ian", LastName = "Doucett", ExperLevel = "Front end" });
            empList.Add(new Emp() { FirstName = "Mike", LastName = "Bastarache", ExperLevel = "Front end" });
            empList.Add(new Emp() { FirstName = "Andre", LastName = "Arsenault", ExperLevel = "Back end" });
            empList.Add(new Emp() { FirstName = "Paul", LastName = "Curwin ", ExperLevel = "Project Leader" });
            empList.Add(new Emp() { FirstName = "Hugh", LastName = "????", ExperLevel = "Back end" });

            return empList;
        }
    }
}