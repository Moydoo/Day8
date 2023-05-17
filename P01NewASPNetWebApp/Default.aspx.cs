using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01NewASPNetWebApp
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCalculate_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(txtNumber1.Text);
			int b = Convert.ToInt32(txtNumber2.Text);

			int result = a + b;

			lblResult.Text = result.ToString();
		}
	}
}