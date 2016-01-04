using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Uppgift1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public double tal1;
        public double result;

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void DeciliterButton_Click(object sender, EventArgs e)
        {
            //Översätter string till double, om det går (try.Parse)
            double.TryParse(LiterBox.Text, out tal1);
            result = (tal1*10);
            ResultatLabel.Text = result.ToString();

        }

        protected void CentiliterButton_Click(object sender, EventArgs e)
        {
            double.TryParse(LiterBox.Text, out tal1);
            result = (tal1*100);
            ResultatLabel.Text = result.ToString();

        }

        protected void MilliliterButton_Click(object sender, EventArgs e)
        {
            double.TryParse(LiterBox.Text, out tal1);
            result = (tal1*1000);
            ResultatLabel.Text = result.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double result1;
            double result2;
            double result3;
            double.TryParse(LiterBox.Text, out tal1);
            result1 = (tal1*10);
            Label1.Text = result1.ToString();

            double.TryParse(LiterBox.Text, out tal1);
            result2 = (tal1*100);
            Label2.Text = result2.ToString();

            double.TryParse(LiterBox.Text, out tal1);
            result3 = (tal1*1000);
            Label3.Text = result3.ToString();

        }
    }
}