using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myCalculator
{
    public partial class myCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn1_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "1";

                }

                catch
                {

                    Session["SecondValue"] = "1";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "1";

                }

                catch
                {

                    Session["FirstValue"] = "1";

                }

            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "2";

                }

                catch
                {

                    Session["SecondValue"] = "2";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "2";

                }

                catch
                {

                    Session["FirstValue"] = "2";

                }

            }

        }

        protected void btn3_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "3";

                }

                catch
                {

                    Session["SecondValue"] = "3";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "3";

                }

                catch
                {

                    Session["FirstValue"] = "3";

                }

            }

        }

        protected void btn4_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "4";

                }

                catch
                {

                    Session["SecondValue"] = "4";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "4";
                }

                catch
                {

                    Session["FirstValue"] = "4";

                }

            }

        }

        protected void btn5_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "5";

                }

                catch
                {

                    Session["SecondValue"] = "5";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "5";

                }

                catch
                {

                    Session["FirstValue"] = "5";

                }

            }

        }

        protected void btn6_Click(object sender, EventArgs e)
        {

            if (Session["op"].ToString() != "")
            {

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "6";

                }

                catch
                {

                    Session["SecondValue"] = "6";

                }

            }

            else
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "6";

                }
                catch
                {

                    Session["FirstValue"] = "6";

                }

            }

        }

        protected void btn7_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "7";

                }

                catch
                {

                    Session["SecondValue"] = "7";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "7";

                }

                catch
                {

                    Session["FirstValue"] = "7";

                }

            }

        }

        protected void btn8_Click(object sender, EventArgs e)
        {

            try
            {

                string op = Session["op"].ToString();

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "8";

                }

                catch
                {

                    Session["SecondValue"] = "8";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "8";

                }

                catch
                {

                    Session["FirstValue"] = "8";

                }

            }

        }

        protected void btn9_Click(object sender, EventArgs e)
        {

            string op = Session["op"].ToString();

            try
            {

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "9";

                }

                catch
                {

                    Session["SecondValue"] = "9";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = fv + "9";

                }

                catch
                {

                    Session["FirstValue"] = "9";

                }

            }


        }

        protected void btn0_Click(object sender, EventArgs e)
        {

            string op = Session["op"].ToString();

            try
            {

                try
                {

                    int sv = int.Parse(Session["SecondValue"].ToString());
                    Session["SecondValue"] = sv + "0";

                }

                catch
                {

                    Session["SecondValue"] = "0";

                }

            }

            catch
            {

                try
                {

                    int fv = int.Parse(Session["FirstValue"].ToString());
                    Session["FirstValue"] = "0";

                }

                catch
                {

                    Session["FirstValue"] = "0";

                }

            }

        }

        protected void btnDot_Click(object sender, EventArgs e)
        {

        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {

            Session["op"] = "mult";

        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {

            Session["op"] = "add";

        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {

            Session["op"] = "sub";

        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {

            Session["op"] = "div";

        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {

            int fv = int.Parse(Session["FirstValue"].ToString());
            int sv = int.Parse(Session["SecondValue"].ToString());
            string op = Session["op"].ToString();
            switch (op)
            {


                case "add":
                    txtDisplay.Text = (sv + fv).ToString();
                    break;

                case "mult":
                    txtDisplay.Text = (sv * fv).ToString();
                    break;

                case "sub":
                    txtDisplay.Text = (fv - sv).ToString();
                    break;

                case "div":
                    txtDisplay.Text = (fv / sv).ToString();
                    break;

            }

            Session.Clear();

        }

    }

}