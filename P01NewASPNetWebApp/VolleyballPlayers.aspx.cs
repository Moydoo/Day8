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

		public string SampleString { get; set; }
		public List<Player> PlayerList { get; set; }
		protected void Page_Load(object sender, EventArgs e)
		{
			string sampleString = "Hello";
			SampleString = sampleString;
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
								PlayerList.Add(new Player()
								{
									Id = reader.GetInt32(0),
									FirstName = reader.GetString(1),
									LastName = reader.GetString(2),
								});
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