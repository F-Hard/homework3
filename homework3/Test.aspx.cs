using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String show = "";
        Boolean flag = true; // "..."开关
        int result = 0;
        int i = 0;
        int goal_temp = 1;
        int goal_number = Convert.ToInt32(TextBox1.Text);

        for(i=1; i<= goal_number; i++)
        {
            for(int j=2;j<=i;j++)
            {
                goal_temp = goal_temp * j;
            }
            result = result + goal_temp;
            goal_temp = 1;
        }

        if (goal_number == 0)
            Label1.Text = "0！= 1";
        else
        {
            for (i = 1; i < goal_number; i++)
            {
                if (i == 3 && goal_number < 4)
                {
                    show += i.ToString() + "!";
                }
                else if (i <= goal_number - 1 && i <= 3)
                    show += i.ToString() + "! + "; 
                else if (i > 3 && flag)
                {
                    show += " ...... +";
                    flag = false;
                }       
            }
            if(i != 4)
                show += i.ToString() + "! = " + result.ToString();
            else
            {
                show += " ...... +"+i.ToString()+" = " +result.ToString();
            }
         Label1.Text = show;  
        }
        result = 0;
    }
}