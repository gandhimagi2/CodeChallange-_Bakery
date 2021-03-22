using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeChallange__Bakery
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            string selecteditem = DropDownListID.SelectedValue;
            int quantity = Convert.ToInt32( TextBox3.Text);
            string result=string.Empty;
            if (selecteditem == "VS5")
            {
                result = quantity + " VS5";
                string test = string.Empty;
                int remaiingunits = 0 ;
                int units = 0;
                double price = 0;
                if (quantity >= 5)
                {
                    units = quantity / 5;
                    remaiingunits = quantity % 5;
                    test = test + "<br>" + units + " * 5 $8.99";
                    price = units * 8.99;
                }
                if(remaiingunits>0)
                {
                   
                        units = remaiingunits / 3;
                    if (units == 0)
                    {
                        units = 1;
                    }
                       // units = quantity / 3;
                       // remaiingunits = remaiingunits % 3;
                        test = test + "<br>" + units + " * 3 $6.99";
                        price = price + units * 6.99;
                   // remaiingunits;
                }
                result = result + "$" + price + "<br>" + test;

            }
            else if(selecteditem == "MB11")
            {
                result = quantity + " MB11";
                string test = string.Empty;
                int remaiingunits = 0;
                int units = 0;
                double price = 0;
                if (quantity >= 8)
                {
                    units = quantity / 8;
                    remaiingunits = quantity % 8;
                    test = test + "<br>" + units + " * 8 $24.95";
                    price = units * 24.95;
                }
                if (remaiingunits >= 5)
                {
                    //units = quantity / 3;
                    if (remaiingunits % 5 == 0)
                    {
                        units = remaiingunits / 5;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        remaiingunits = 0;
                        test = test + "<br>" + units + " * 5 $16.95";
                        price = units * 16.95;
                    }
                    else if(remaiingunits%2==0)
                    {
                        units = remaiingunits / 2;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        // units = quantity / 3;
                         remaiingunits = 0;
                        test = test + "<br>" + units + " * 2 $9.95";
                        price = price + units * 9.95;
                    }
                    else
                    {
                        units = remaiingunits / 3;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        remaiingunits = quantity % 3;
                        test = test + "<br>" + units + " * 3 $16.95";
                        price = units * 16.95;
                    }

                }
                if (remaiingunits > 0)
                {

                    units = remaiingunits / 2;
                    if (units == 0)
                    {
                        units = 1;
                    }
                    // units = quantity / 3;
                    // remaiingunits = remaiingunits % 3;
                    test = test + "<br>" + units + " * 2 $9.95";
                    price = price + units * 9.95;
                    // remaiingunits;
                }
                result = result + "$" + price + "<br>" + test;
            }
            else if (selecteditem == "CF")
            {
                result = quantity + " CF";
                string test = string.Empty;
                int remaiingunits = 0;
                int units = 0;
                double price = 0;
                int totalunit = 0;

                if (quantity >= 9)
                {
                    units = quantity / 9;
                    remaiingunits = quantity % 9;
                    test = test + "<br>" + units + " * 9 $16.99";
                    totalunit = totalunit + units * 9;
                    price = units * 16.99;
                }
                if (remaiingunits >= 5)
                {
                    //units = quantity / 3;
                    if (remaiingunits % 5 == 0)
                    {
                        units = remaiingunits / 5;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        remaiingunits = 0;
                        test = test + "<br>" + units + " * 5 $9.95";
                        totalunit = totalunit + units * 5;
                        price = units * 9.95;
                    }
                    else if (remaiingunits % 3 == 0)
                    {
                        units = remaiingunits / 3;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        // units = quantity / 3;
                        remaiingunits = 0;
                        test = test + "<br>" + units + " * 3 $5.95";
                        totalunit = totalunit + units * 3;
                        price = price + units * 5.95;
                    }
                    else
                    {
                        units = remaiingunits / 5;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        remaiingunits = quantity % 3;
                        test = test + "<br>" + units + " * 5 $9.95";
                        price = units * 16.95;
                        totalunit = totalunit + units * 5;
                        }

                }
                if (remaiingunits > 0)
                {

                    units = remaiingunits / 3;
                    if (units == 0)
                    {
                        units = 1;
                    }
                    // units = quantity / 3;
                    // remaiingunits = remaiingunits % 3;
                    test = test + "<br>" + units + " * 3 $5.95";
                    price = price + units * 9.95;
                    totalunit = totalunit + units * 3;
                    // remaiingunits;
                }
                result = result + " $" + price + "<br>" + test;
                if (totalunit != quantity)
                {
                    result = string.Empty;
                    result = quantity + " MB11";
                    test = string.Empty;
                    remaiingunits = 0;
                    totalunit = 0;
                    units = 0;
                    price = 0;
                    totalunit = 0;
                    if (quantity >= 5)
                    {
                        units = quantity / 5;
                        remaiingunits = quantity % 5;
                        test = test + "<br>" + units + " * 5 $9.95";
                        price = units * 8.99;
                        totalunit = totalunit + units * 5;

                    }
                    if (remaiingunits > 0)
                    {

                        units = remaiingunits / 3;
                        if (units == 0)
                        {
                            units = 1;
                        }
                        // units = quantity / 3;
                        // remaiingunits = remaiingunits % 3;
                        test = test + "<br>" + units + " * 3 $5.95";
                        price = price + units * 6.99;
                        totalunit = totalunit + units * 3;
                        // remaiingunits;
                    }
                    result = result + " $" + price + "<br>" + test;

                }

            }
            lblError.Text = result;
        }
    }
}