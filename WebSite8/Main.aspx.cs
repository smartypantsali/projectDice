using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    //Dice list
    static List<int> diceList = new List<int>();

    protected void Page_Load(object sender, EventArgs e)
    {

       if(!Page.IsPostBack)
       {
            PanelGame.Visible = false;
            PanelInstructions.Visible = false;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GameTitle.Visible = false;
        PanelGame.Visible = true;
        Button1.Visible = false;
        Button2.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GameTitle.Visible = false;
        PanelInstructions.Visible = true;
        Button1.Visible = false;
        Button2.Visible = false;
    }

    protected void ButtonPanelInstructions_Click(object sender, EventArgs e)
    {
        GameTitle.Visible = true; 
        PanelInstructions.Visible = false;
        Button1.Visible = true;
        Button2.Visible = true;
    }

    protected void ButtonGameClose_Click(object sender, EventArgs e)
    {
        GameTitle.Visible = true;
        PanelGame.Visible = false;
        Button1.Visible = true;
        Button2.Visible = true;
        diceList.Clear();
        DiceRoll.Enabled = true;
        DieRollText.Text = "";
        DisplayResult.Text = "";
        DieRollTotal.Text = "";
        ImageRoll.ImageUrl = "";
    }

    protected void DiceRoll_Click(object sender, EventArgs e)
    {
        int sum = 0; 

        //Generate random number
        Random randomNumber = new Random();
        int randomRoll = randomNumber.Next(1, 7);

        switch (randomRoll)
        {
            case (1):
                DieRollText.Text = "You rolled a: " + Convert.ToString(randomRoll) + " ";
                ImageRoll.ImageUrl = "~/Terning1.svg.png";
                break;
            case (2):
                DieRollText.Text = "You rolled a: " + Convert.ToString(randomRoll) + " ";
                ImageRoll.ImageUrl = "~/Terning2.svg.png";
                break;
            case (3):
                DieRollText.Text = "You rolled a: " + Convert.ToString(randomRoll) + " ";
                ImageRoll.ImageUrl = "~/Terning3.svg.png";
                break;
            case (4):
                DieRollText.Text = "You rolled a: " + Convert.ToString(randomRoll) + " ";
                ImageRoll.ImageUrl = "~/Terning4.svg.png";
                break;
            case (5):
                DieRollText.Text = "You rolled a: " + Convert.ToString(randomRoll) + " ";
                ImageRoll.ImageUrl = "~/Terning5.svg.png";
                break;
            case (6):
                DieRollText.Text = "You rolled a: " + Convert.ToString(randomRoll) + " ";
                ImageRoll.ImageUrl = "~/Terning6.svg.png";
                break;
        }
        //Add randomRoll to List.
        diceList.Add(randomRoll);
        //Loop through List.
        foreach (int i in diceList)
        {
            sum += i;
        }        
        if(sum >= 21)
            {
                DiceRoll.Enabled = false;                
            }  
        if(sum == 21)
        {
            DisplayResult.Text = "Congratulations you win!! Click New Game to play again.";
        }
        else if(sum > 21)
        {
            DisplayResult.Text = "Too bad, you lost :(. Click New Game to try again.";
        }

        //Convert to string to display as text.
        DieRollTotal.Text = "Total: " + Convert.ToString(sum);
    }


    protected void NewGameButton_Click(object sender, EventArgs e)
    {
        diceList.Clear();
        DiceRoll.Enabled = true;
        DieRollText.Text = "";
        DisplayResult.Text = "";
        DieRollTotal.Text = "";
        ImageRoll.ImageUrl = "";

    }
}
