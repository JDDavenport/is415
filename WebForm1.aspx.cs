using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using RestSharp;

namespace _415.NewFolder1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem li = new ListItem();
            ListItem ls = new ListItem();

            SqlConnection cn = new SqlConnection("Server=tcp:is415.database.windows.net, 1433;Initial Catalog=is415;Persist Security Info=False;User Id=is415; Password = Temporary415;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select reviewerID, productName, reviewerName, asin, overall from am_Products ORDER BY reviewID" );
            SqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                li = new ListItem(dr["reviewerName"].ToString(), dr["reviewerID"].ToString());
                ls = new ListItem(dr["productName"].ToString(), dr["asin"].ToString());

                rblReviewer.Items.Add(li);
                rblProduct.Items.Add(li);

            }
            rblReviewer.DataBind();
            dr.Close();
            cn.Close();
        }
        protected void rblReviewers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/d828e0f64965476990e345b24d11f639/services/f7521d48c071428aaf1c96a1ea8b7d66/execute?api-version=2.0&details=true");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "b63f818f-f280-4aa9-ba85-c82385d0ef1d");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Authorization", "bearer u/CiAsqJF5snHA5K6o1AWQdhPBwdaiDbXAgiSCkyk54T7jjxf909/IAJLeDKrV7LIi4CIHn2sDVGFnVptr18ww==");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n\r\n        \"Inputs\": {\r\n\r\n                \"input1\":\r\n                {\r\n                    \"ColumnNames\": [\"reviewerID\", \"asin\", \"overall\"],\r\n                    \"Values\": [ [ \"" + rblReviewer .SelectedValue.ToString() +    " \", \"value\", \"0\" ], ]\r\n                },        },\r\n            \"GlobalParameters\": {}\r\n    }", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Label1.Text = response.Content.ToString(); 
        }
    }
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem li = new ListItem();
            ListItem ls = new ListItem();

            SqlConnection cn = new SqlConnection("Server=tcp:is415.database.windows.net, 1433;Initial Catalog=is415;Persist Security Info=False;User Id=is415; Password = Temporary415;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select reviewerID, productName, reviewerName, asin, overall from am_Products ORDER BY reviewID");
            SqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                li = new ListItem(dr["reviewerName"].ToString(), dr["reviewerID"].ToString());
                ls = new ListItem(dr["productName"].ToString(), dr["asin"].ToString());

                rblReviewer2.Items.Add(li);
                rblProduct2.Items.Add(li);

            }
            rblReviewer2.DataBind();
            dr.Close();
            cn.Close();
        }
        protected void rblReviewers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/d828e0f64965476990e345b24d11f639/services/f7521d48c071428aaf1c96a1ea8b7d66/execute?api-version=2.0&details=true");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "b63f818f-f280-4aa9-ba85-c82385d0ef1d");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Authorization", "bearer u/CiAsqJF5snHA5K6o1AWQdhPBwdaiDbXAgiSCkyk54T7jjxf909/IAJLeDKrV7LIi4CIHn2sDVGFnVptr18ww==");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n\r\n        \"Inputs\": {\r\n\r\n                \"input1\":\r\n                {\r\n                    \"ColumnNames\": [\"reviewerID\", \"asin\", \"overall\"],\r\n                    \"Values\": [ [ \"" + rblReviewer.SelectedValue.ToString() + " \", \"value\", \"0\" ], ]\r\n                },        },\r\n            \"GlobalParameters\": {}\r\n    }", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Label2.Text = response.Content.ToString();
        }
    }
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem li = new ListItem();
            ListItem ls = new ListItem();

            SqlConnection cn = new SqlConnection("Server=tcp:is415.database.windows.net, 1433;Initial Catalog=is415;Persist Security Info=False;User Id=is415; Password = Temporary415;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select reviewerID, productName, reviewerName, asin, overall from am_Products ORDER BY reviewID");
            SqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                li = new ListItem(dr["reviewerName"].ToString(), dr["reviewerID"].ToString());
                ls = new ListItem(dr["productName"].ToString(), dr["asin"].ToString());

                rblReviewer3.Items.Add(li);
                rblProduct3.Items.Add(li);
                
            }
            rblReviewer3.DataBind();
            dr.Close();
            cn.Close();
        }
        protected void rblReviewers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/d828e0f64965476990e345b24d11f639/services/f7521d48c071428aaf1c96a1ea8b7d66/execute?api-version=2.0&details=true");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "b63f818f-f280-4aa9-ba85-c82385d0ef1d");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Authorization", "bearer u/CiAsqJF5snHA5K6o1AWQdhPBwdaiDbXAgiSCkyk54T7jjxf909/IAJLeDKrV7LIi4CIHn2sDVGFnVptr18ww==");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n\r\n        \"Inputs\": {\r\n\r\n                \"input1\":\r\n                {\r\n                    \"ColumnNames\": [\"reviewerID\", \"asin\", \"overall\"],\r\n                    \"Values\": [ [ \"" + rblReviewer.SelectedValue.ToString() + " \", \"value\", \"0\" ], ]\r\n                },        },\r\n            \"GlobalParameters\": {}\r\n    }", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Label3.Text = response.Content.ToString();
        }
    }
}