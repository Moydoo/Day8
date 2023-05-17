using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01NewASPNetWebApp
{
	public partial class VolleyballPlayers : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connectionString = "Server=(localdb)\\mssqllocaldb;Database=VolleyballDatabase;Integrated Security=True;";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{

				connection.Open();

				try
				{
					//SELECT
					using (SqlCommand command = new SqlCommand("SELECT Id, First_Name, Last_Name FROM Players", connection))
					{
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								Response.Write($"Id: {reader.GetInt32(0)}, First name: {reader.GetString(1)}, Last name: {reader.GetString(2)}");
								Response.Write("<br>");
							}
						}
					}

				}
				catch (SqlException ex)
				{
					Response.Write("An error occurred while connecting to the database or executing the command: " + ex.Message);
				}
				catch (Exception ex)
				{
					Response.Write("An unexpected error occurred: " + ex.Message);
				}

			}
		}
	}
}