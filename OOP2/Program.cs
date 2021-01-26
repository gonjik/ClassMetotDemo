using System;

namespace GameSimilation
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Firstname = "Gonca";
            player1.Lastname = "Derman";
            player1.NatinalityId = "15482025502";

            Player player2 = new Player();
            player2.Firstname = "Etem";
            player2.Lastname = "Derman";
            player2.NatinalityId = "44818359844";

            Games game1 = new Games();
            game1.Name = "Spiderman";
            game1.Price = 1000;
            game1.GameYear = "2020";

            Games game2 = new Games();
            game2.Name = "Undergrand";
            game2.Price = 300;
            game2.GameYear = "2010";


            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Delete(player2);

            ValentinesCampaigne valentinesCampaigne = new ValentinesCampaigne();
            valentinesCampaigne.Calculate();

            BlackFridayCampaigneManager blackFridayCampaigneManager = new BlackFridayCampaigneManager();
            blackFridayCampaigneManager.Delete();




        }
    }
}
