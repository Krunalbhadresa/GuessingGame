using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static int no_try = 100;
    //int rnd;
    Random random_number = new Random();
    static int rnd;
   

    public void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
           
            rnd = random_number.Next(1, 101);
            //Label4.Text = Convert.ToString(rnd);
            no_try = 100;
        }
    }



    public void Button1_Click(object sender, EventArgs e)
    {
        if(Int32.Parse(TextBox1.Text) < rnd)
        {
            hint.Text = "Guessed lower, try again";
            no_try--;
            tries.Text = Convert.ToString(no_try);
        }
        if(Int32.Parse(TextBox1.Text) > rnd)
        {
            hint.Text = "Guessed higher, try again";
            no_try--;
            tries.Text = Convert.ToString(no_try);
        }
        if(Int32.Parse(TextBox1.Text) == rnd)
        {
            hint.Text = "Congratulations !! You've guessed the correct number.";
            no_try--;
            tries.Text = Convert.ToString(no_try);
            score.Text = tries.Text;
            //tries.Text = Convert.ToString(no_try);
            
           
        }
        
    }

 
}