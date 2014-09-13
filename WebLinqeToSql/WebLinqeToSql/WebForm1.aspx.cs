using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLinqeToSql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();// this instance from linq to SQL
            CemProDBContext dbcon = new CemProDBContext();
            //IEnumerable<CUSTOMER> listOfCustomers = db.CUSTOMERs.Where(x => x.CUST_ISACTIVE == "Y");
            //IEnumerable<string> listOfCustomers1 = db.CUSTOMERs.Select(x => x.CUST_CODE);
            //var listOfCustomers1 = db.CUSTOMERs.Select(x => x);
            //foreach(CUSTOMER i in listOfCustomers1)
            //{
            //    Response.Write(i.CUST_ADDRESS+",,");
            //}

            //////////////////////////////////////////////////////////////////////////
            //using entity framework below line is written
            //var result = dbcon.SUPPLIERs.Select(x => new {Name = x.SUPP_NAME, Address = x.SUPP_ADDRESS });
            //GridView1.DataSource = result.ToList().Where(x => x.Address == "KOLKATA");
            //GridView1.DataBind();
            ///////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////
            //using linq to sql below line is written i havent use entity framework because it suppert for concating
            // here ((new)) creates a new type that is not exist
            // --Select-- cluse is used
            var result = db.CUSTOMERs.Select(x => new { Name = x.CUST_NAME+", and id ="+x.CUST_ID, Address = x.CUST_ADDRESS });
            foreach( var v in result)
            {
                Response.Write(v.Name+" "+v.Address+"\n\n");
            }
            ///////////////////////////////////////////////////////////////////////////

            //GridView1.DataSource = listOfCustomers;
            ////GridView1.DataSource = from CUSTOMER in db.CUSTOMERs
            ////                       where CUSTOMER.CUST_CODE == "CUSC00001"
            ////                       select CUSTOMER;
            //GridView1.DataBind();

            //Use of extention method
            //string s = "Sarfaraj";
            //string cs = s.ChangefristletterCase();
            
            //Response.Write(cs);

            int[] numbers = { 1, 2, 3,4,5,6,7,8,9 };

            //this FUCN fuctin used inside where cluse of a linqe
            //Func<int,bool> funcResult = x => (x%2) == 0;
            //Response.Write( numbers.Where(funcResult));
            //Response.Write(numbers.Where(x => x%2 == 0).Sum());
            //GridView1.DataSource = (numbers.Where(x =>  evenNumber(x) ));
            ////int result = numbers.Aggregate((a,b) => a = a*b);

            ////Response.Write(result);
            ////GridView1.DataSource = from n in numbers
            ////                       where (n % 2) == 0
            ////                       select n;
            //GridView1.DataBind();
        }
        /// <summary>
        /// this function is used fro where clause in linq in where cluse accept oonly those expression which returns bool
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private bool evenNumber(int x)
        {
            return x % 2 == 0;
        }
    }
}