<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title></title>   
    <link href="https://fonts.googleapis.com/css?family=Abril+Fatface|Patrick+Hand+SC" rel="stylesheet"> 
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
     <link href="Content/StyleSheet.css" rel="stylesheet" />     
</head>
<body>
    <form id="form1" runat="server">      
    <div class="BackgroundDice">
    <section>
        <div class="BorderuL">           
         <div class="InnerBorder">             
         <div class="Links"> 
         <asp:Label CssClass="GameTitle" ID="GameTitle" runat="server" Text="Dice Roll Game"></asp:Label>
         <asp:Button CssClass="StartGame" ID="Button1" runat="server" Text="Start Game" OnClick="Button1_Click" />                    
         </div>
                        <div class="GameClass">
                  <asp:Panel CssClass="GamePanel" ID="PanelGame" runat="server" Visible="false">                      
                      <asp:Button CssClass="DiceRoll" ID="DiceRoll" runat="server" Text="Click me to roll" OnClick="DiceRoll_Click" /> <br />  
                      <asp:Label CssClass="GameText" ID="DieRollText" runat="server"></asp:Label><asp:Image CssClass="RolledDice" ID="ImageRoll" runat="server"/><br />
                      <asp:Label CssClass="GameText" ID="DieRollTotal" runat="server"></asp:Label><br />  
                      <asp:Label CssClass="GameText" ID="DisplayResult" runat="server"></asp:Label><br /> 
                      <asp:Button CssClass="NewGameButton" ID="NewGameButton" runat="server" Text="New Game" OnClick="NewGameButton_Click" /><br />  
                      <asp:Button CssClass="GameButton" ID="ButtonGameClose" runat="server" Text="Main Menu" OnClick="ButtonGameClose_Click" /><br />  
                    </asp:Panel>
             </div>
          <div class="Links2">
                <asp:Button CssClass="Instructions" ID="Button2" runat="server" Text="Instructions" OnClick="Button2_Click" />  
          </div>   
            <div class="InstructionsClass">
                 <asp:Panel CssClass="InstructionsPanel" ID="PanelInstructions" runat="server" Visible="false">
                     <asp:Label CssClass="InstructionsLabe1" ID="InstructionLabel1" runat="server" Text="Instructions:"></asp:Label> <br />
                     <asp:Label CssClass="InstructionsLabel" ID="LabelInstructions" runat="server" Text="The objective of this game is to obtain 
                         a total score of 21. This is <br /> achieved by clicking the 'Click me to roll' button. After clicking <br /> it consecutively your score will then
                         be accumilated and displayed, <br/> if you happen to recieve a score of 21 you win, if its above 21 then you lose."> </asp:Label><br/> <br/>
                     <asp:Button CssClass="InstructionsButton" ID="ButtonPanelInstructions" runat="server" Text="Main Menu" OnClick="ButtonPanelInstructions_Click" />                     
                 </asp:Panel>
                </div>
                
                  </div>                                                         
          </div>          
          

    </section>
        </div>
        </form>
</body>
</html>
