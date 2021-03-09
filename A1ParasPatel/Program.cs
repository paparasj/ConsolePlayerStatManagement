using System;
using System.Collections.Generic;
using System.Linq;

namespace A1ParasPatel
{
    class Program
    {
        //ind for unique id using increment.    
        private static int ind = 1;
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            //adding few data into list
           
            Player ph1 = new HockeyPlayer(ind++, PlayerType.HockeyPlayer, "Paras Patel", "Swami Eleven", 1, 12, 13);
            players.Add(ph1);
            Player ph2 = new HockeyPlayer(ind++, PlayerType.HockeyPlayer, "Mitchell Marner", "Maple Leafs", 9, 5, 8);
            players.Add(ph2);
            Player ph3 = new HockeyPlayer(ind++, PlayerType.HockeyPlayer, "Connor McDavid", "Edmonton Oilers", 9, 5, 9);
            players.Add(ph3);

            Player pb1 = new BasketBallPlayer(ind++, PlayerType.BasketBallPlayer, "Kyle Lowry", "Raptors", 15, 18, 4);
            players.Add(pb1);
            Player pb2 = new BasketBallPlayer(ind++, PlayerType.BasketBallPlayer, "Avery Bradley", "Heat", 8, 16, 2);
            players.Add(pb2);

            Player pbb1 = new BaseBallPlayer(ind++, PlayerType.BaseBallPlayer, "Alejandro Kirk", "Blue Jays", 9, 4, 1);
            players.Add(pbb1);
            Player pbb2 = new BaseBallPlayer(ind++, PlayerType.BaseBallPlayer, "Kyle Higashioka", "Yankees", 16, 7, 4);
            players.Add(pbb2);
            Player pbb3 = new BaseBallPlayer(ind++, PlayerType.BaseBallPlayer, "Gs Tatla", "Brampton Sher",1, 15, 11);
            players.Add(pbb3);



            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }
        //generic collection - list for storing data
        static List<Player> players = new List<Player>();
        
        /*Main Menu for 6 choice*/
        private static bool MainMenu() {
            Console.Clear();
            Console.WriteLine("\n\n\tASSIGNMENT-1 by PARAS PATEL\n\n");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\t1 - Add Player\n\t2 - Edit Player\n\t3 - Delete Player");
            Console.WriteLine("\t4 - View Players\n\t5 - Search Player\n\t6 - Exit");
            Console.Write("\nEnter your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    AddPlayer();
                    return false;
                case "2":
                    Console.Clear();
                    EditPlayer();
                    return false;
                case "3":
                    Console.Clear();
                    DeletePlayer();
                    return false;
                case "4":
                    Console.Clear();
                    ViewPlayers();
                    return false;
                case "5":
                    Console.Clear();
                    SearchPlayer();
                    return false;
                case "6":
                    Console.Clear();
                    Console.WriteLine("\n\tHope you enjoyed this console application. \n\tThank you for using.\n\tBye.");
                    return false;
                default:
                    Console.WriteLine("Invalid input. Please try again.\nPress any key to return to main menu.");
                    Console.ReadKey();
                    return true;
            }
        }
        /*Add Player- Menu for adding player based on game*/
        private static Player AddPlayer() {

            Console.WriteLine("Add New Player: \n");
            Console.WriteLine("\t1 - Add Hockey Player\n\t2 - Add BasketBall Player\n\t3 - Add BaseBall Player\n\t4 - Back to Main Menu");
            PlayerType ptype = PlayerType.HockeyPlayer;

            bool showMenu = true;
            while (showMenu)
            { showMenu = AddMenu(); }

            bool AddMenu()
            {
                Console.Write("\nEnter your choice: ");
                switch (Console.ReadLine())
                {
                   
                    case "1":
                        ptype = PlayerType.HockeyPlayer;
                        Console.WriteLine("\nAdding Hockey Player");
                        AddingPlayer(ptype);
                        return false;
                    case "2":
                        ptype = PlayerType.BasketBallPlayer;
                        Console.WriteLine("\nAdding BasketBall Player");

                        AddingPlayer(ptype);

                        return false;
                    case "3":
                        ptype = PlayerType.BaseBallPlayer;
                        Console.WriteLine("\nAdding BaseBall Player");
                        AddingPlayer(ptype);

                        return false;
                    case "4":
                        Console.Clear();

                        MainMenu();
                        return false;
                    
                    default:
                        Console.WriteLine("\nInvalid input. Please try again.");
                        return true;
                }

            }
            /*adding player based on user input*/
            static void AddingPlayer(PlayerType playerType){
                
                int assists = 0, goals = 0, runs = 0, homeRuns = 0, fieldGoals = 0, threePointers = 0;
                bool validator = true;

                Console.Write("\nEnter player Name : ");
                string pName = Console.ReadLine();
                Console.Write("Enter Team Name : ");
                string tName = Console.ReadLine();
                
                int gamesPlayed=0;// 
                //gamesplayed must be a positive number or zero
                    while (validator)
                    {
                      Console.Write("Enter games Played: ");

                        bool success = Int32.TryParse(Console.ReadLine(), out gamesPlayed);
                        if (success && gamesPlayed>=0)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                            validator = true;
                        }
                    }
                if (playerType == PlayerType.HockeyPlayer) {
                    validator = true;
                    while (validator)
                    {
                        Console.Write("Enter assists: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out assists);
                        if (success && assists >=0 )
                        {   validator = false;  }
                        else
                        {
                            Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                            validator = true;
                        }
                    }
                    validator = true;
                    while (validator)
                    {
                        Console.Write("Enter goals: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out goals);
                        if (success && goals >= 0)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                            validator = true;
                        }
                    }
                    Player p = new HockeyPlayer(ind++, playerType, pName,tName,gamesPlayed,assists,goals);
                    players.Add(p);
                }
                if (playerType == PlayerType.BaseBallPlayer)
                {
                    validator = true;
                    while (validator)
                    {
                        Console.Write("Enter runs: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out runs);
                        if (success && runs >= 0)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                            validator = true;
                        }
                    }
                    validator = true;
                    while (validator)
                    {
                        Console.Write("Enter home runs: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out homeRuns);
                        if (success && homeRuns >= 0)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                            validator = true;
                        }
                    }
                    Player p = new HockeyPlayer(ind++, playerType, pName, tName, gamesPlayed, runs, homeRuns);
                    players.Add(p);
                }

                if (playerType == PlayerType.BasketBallPlayer)
                {
                    validator = true;
                    while (validator)
                    {
                        Console.Write("Enter field goals: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out fieldGoals);
                        if (success && fieldGoals >= 0)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type, nter zero or positive numbers only");
                            validator = true;
                        }
                    }
                    validator = true;
                    while (validator)
                    {
                        Console.Write("Enter three pointers: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out threePointers);
                        if (success && threePointers >= 0)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                            validator = true;
                        }
                    }
                    Player p = new HockeyPlayer(ind++, playerType, pName, tName, gamesPlayed, fieldGoals, threePointers);
                    players.Add(p);
                }
                Console.WriteLine("\nNew Player Added!!!");
                Console.Write("\nView All ");
                ViewPlayer(playerType);
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                AddPlayer();//back to add menu

            }
            return null;
        }

        /**********************************Edit Player*************************************************/
        private static Player EditPlayer()
        {

            Console.WriteLine("Edit Player: \n\n");
            Console.WriteLine("\t1 - Edit Hockey Player\n\t2 - Edit BasketBall Player\n\t3 - Edit BaseBall Player\n\t4 - Back to Main Menu");
            PlayerType ptype = PlayerType.HockeyPlayer;

            bool showMenu = true;
            while (showMenu)
            { showMenu = EditMenu(); }
            bool EditMenu()
            {
                Console.Write("\nEnter your choice: ");
                switch (Console.ReadLine())
                {

                    case "1":
                        ptype = PlayerType.HockeyPlayer;
                        Console.WriteLine("\nEditing Hockey Player");
                        EditingPlayer(ptype);
                        return true;
                    case "2":
                        ptype = PlayerType.BasketBallPlayer;
                        Console.WriteLine("\nEditing BasketBall Player");

                        EditingPlayer(ptype);

                        return false;
                    case "3":
                        ptype = PlayerType.BaseBallPlayer;
                        Console.WriteLine("\nEditing BaseBall Player");
                        EditingPlayer(ptype);

                        return false;
                    case "4":
                        Console.Clear();

                        MainMenu();
                        return false;

                    default:
                        Console.WriteLine("\nInvalid input. Please try again.");
                        return true;
                }

            }
            /*Editing player's details based on user input*/
            static void EditingPlayer(PlayerType playerType)
            {

                ViewPlayer(playerType);
                bool des = true;
                while (des)
                {
                    Console.Write("\nEnter ID of Player to want to edit: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index > 0 && index < players.Count)
                    {
                        if (players[index - 1].PlayerType == playerType)
                        {

                            int assists = 0, goals = 0, runs = 0, homeRuns = 0, fieldGoals = 0, threePointers = 0;
                            bool validator = true;
                            Console.Write("\nEnter player's new Name : ");
                            string pName = Console.ReadLine();
                            Console.Write("Enter new Team Name : ");
                            string tName = Console.ReadLine();
                            int gamesPlayed = 0;// 
                            while (validator)
                            {
                                Console.Write("Enter games Played: ");

                                bool success = Int32.TryParse(Console.ReadLine(), out gamesPlayed);
                                if (success && gamesPlayed >= 0)
                                {
                                    validator = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                    validator = true;
                                }
                            }
                            if (playerType == PlayerType.HockeyPlayer)
                            {
                                validator = true;
                                while (validator)
                                {
                                    Console.Write("Enter assists: ");
                                    bool success = Int32.TryParse(Console.ReadLine(), out assists);
                                    if (success && assists >= 0)
                                    {
                                        validator = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                        validator = true;
                                    }
                                }
                                validator = true;
                                while (validator)
                                {
                                    Console.Write("Enter goals: ");
                                    bool success = Int32.TryParse(Console.ReadLine(), out goals);
                                    if (success && goals >= 0)
                                    {
                                        validator = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                        validator = true;
                                    }
                                }
                                players[index-1] =  new HockeyPlayer(index , playerType, pName, tName, gamesPlayed, assists, goals);
                            }
                            if (playerType == PlayerType.BaseBallPlayer)
                            {
                                validator = true;
                                while (validator)
                                {
                                    Console.Write("Enter runs: ");
                                    bool success = Int32.TryParse(Console.ReadLine(), out runs);
                                    if (success && runs >= 0)
                                    {
                                        validator = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                        validator = true;
                                    }
                                }

                                validator = true;
                                while (validator)
                                {
                                    Console.Write("Enter home runs: ");
                                    bool success = Int32.TryParse(Console.ReadLine(), out homeRuns);
                                    if (success && homeRuns >= 0)
                                    {
                                        validator = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                        validator = true;
                                    }
                                }
                                players[index - 1] = new HockeyPlayer(index, playerType, pName, tName, gamesPlayed, runs, homeRuns);
                            }
                            if (playerType == PlayerType.BasketBallPlayer)
                            {
                                validator = true;
                                while (validator)
                                {
                                    Console.Write("Enter field goals: ");


                                    bool success = Int32.TryParse(Console.ReadLine(), out fieldGoals);
                                    if (success && fieldGoals >= 0)
                                    {
                                        validator = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                        validator = true;
                                    }
                                }

                                validator = true;
                                while (validator)
                                {
                                    Console.Write("Enter three pointers: ");
                                    bool success = Int32.TryParse(Console.ReadLine(), out threePointers);
                                    if (success && threePointers >= 0)
                                    {
                                        validator = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Type, enter zero or positive numbers only");
                                        validator = true;
                                    }
                                }
                                players[index - 1] = new HockeyPlayer(index, playerType, pName, tName, gamesPlayed, fieldGoals, threePointers);
                            }
                            Console.WriteLine($"\n\nPlayer with ID = {index} Updated!!!");
                            Console.Write("\n\nView all ");
                            ViewPlayer(playerType);
                            des = false;
                        }
                        else {
                            Console.WriteLine("Invalid Id");
                            des = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Id");
                        des = true;
                    }
                    
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                EditPlayer();//back to menu
           }
            return null;
        }

        /**********************************Delete Player*************************************************/
        private static Player DeletePlayer()
        {
            Console.Clear();
            Console.WriteLine("Delete Player: \n");
            Console.WriteLine("\t1 - Delete Hockey Player\n\t2 - Delete BasketBall Player\n\t3 - Delete BaseBall Player\n\t4 - Back to Main Menu");
            PlayerType ptype = PlayerType.HockeyPlayer;

            bool showMenu = true;
            while (showMenu)
            { showMenu = DeleteMenu(); }
            bool DeleteMenu()
            {
                Console.Write("\nEnter your choice: ");
                switch (Console.ReadLine())
                {

                    case "1":
                        ptype = PlayerType.HockeyPlayer;
                        Console.WriteLine("\n\nView all ");
                        DeletingPlayer(ptype);
                        return false;
                    case "2":
                        ptype = PlayerType.BasketBallPlayer;
                        Console.WriteLine("\n\nView all ");
                        DeletingPlayer(ptype);
                        return false;
                    case "3":
                        ptype = PlayerType.BaseBallPlayer;
                        Console.WriteLine("\n\nView all ");
                        DeletingPlayer(ptype);

                        return false;
                    case "4":
                        Console.Clear();
                        MainMenu();
                        return false;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        return true;
                }

            }
            /*deleting player*/
            static void DeletingPlayer(PlayerType playerType)
            {

                ViewPlayer(playerType);
                bool des = true;
                while (des)
                {
                    int index = -1;
                    int getInd = -1;
                    bool validator = true;
                    while (validator)
                    {
                        Console.Write("\n\nEnter ID of Player to want to delete: ");
                        bool success = Int32.TryParse(Console.ReadLine(), out index);
                        if (success)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Type!!!");
                            validator = true;
                        }
                    }
                    getInd = players.FindIndex(p => p.PlayerId == index);

                    if (getInd != -1)
                    {
                        if (players[getInd].PlayerType == playerType)
                        {
                            players.RemoveAt(getInd);
                            Console.WriteLine($"\nPlayer with ID = {index} Deleted!!!\n\nView all ");
                            ViewPlayer(playerType);
                            Console.Write("\nPress any key to continue");
                            Console.ReadKey();
                            des = false;

                        }
                        else
                        {
                            Console.WriteLine($"\nNo {playerType} with  Id = {index}.\nPress any key to return to Delete menu.");
                            Console.ReadKey();
                            des = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nList is Empty or No Data found with same Id.\nPress any key to return to Delete menu");
                        Console.ReadKey();
                        des = false;
                    }
                }
                DeletePlayer();
            }
            return null;
        }

        /**********************************************Searching Player*********************************************/
        private static void SearchPlayer()
        {
            Console.WriteLine("\nSearch Players by Name. Partial matches can fetch result");
            Console.Write("\n\tEnter player name to search: ");
            string searchValue = Console.ReadLine();
           

            var searchResults = from player in players
                                where player.PlayerName.Contains(searchValue,StringComparison.OrdinalIgnoreCase)
                                select player;
            if (searchResults.Count() > 0)
            {
                Console.WriteLine($"\nAll players whose name match with the given string : {searchValue}.\n");
                foreach (var i in searchResults){
                    if (i.PlayerType == PlayerType.HockeyPlayer)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hockey Players\n");
                        Console.WriteLine($"{ "Player Type",-20}{" Player ID",+12} {"Player Name",-20} {"Team Name",-20} {"Games Played",+12    }\t{"Assists",+11}\t{"Goals",+14}\t{"Points",+6}\n");
                        Console.WriteLine(i);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n");

                    }
                    if (i.PlayerType == PlayerType.BasketBallPlayer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("BasketBall Players\n");
                        Console.WriteLine($"{ "Player Type",-20}{" Player ID",+12} {"Player Name",-20} {"Team Name",-20} {"Games Played",+12}\t{"Field Goals",+11}\t{"Three Pointers",+14}\t{"Points",+6}\n");
                        Console.WriteLine(i);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n");

                    }
                    if (i.PlayerType == PlayerType.BaseBallPlayer)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("BaseBall Players\n");
                        Console.WriteLine($"{ "Player Type",-20}{" Player ID",+12} {"Player Name",-20} {"Team Name",-20} {"Games Played",+12}\t{"Runs",+11}\t{"Home Runs",+14}\t{"Points",+6}\n");
                        Console.WriteLine(i);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n");

                    }


                }
            }
            else{
                Console.WriteLine("\n\n\tNo Match!!");
            }
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            MainMenu();
        }
        /*View all players*/
        private static void ViewPlayers() {

           

            Console.WriteLine("\n\t\tView All Players:\n\n");
            ViewPlayer(PlayerType.HockeyPlayer);
            Console.WriteLine("\n\n");
            ViewPlayer(PlayerType.BasketBallPlayer);
            Console.WriteLine("\n\n");

            ViewPlayer(PlayerType.BaseBallPlayer);
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            MainMenu();
        }
        /*view players of one game */
        static void ViewPlayer(PlayerType playerType)
        {
            var hockeyPlayers = from player in players
                                where player.PlayerType == PlayerType.HockeyPlayer
                                select player;
            var basketBallPlayers = from player in players
                                    where player.PlayerType == PlayerType.BasketBallPlayer
                                    select player;

            var baseBallPlayers = from player in players
                                  where player.PlayerType == PlayerType.BaseBallPlayer
                                  select player;

            if (playerType == PlayerType.HockeyPlayer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hockey Players\n");

                Console.WriteLine($"{ "Player Type",-20}{" Player ID",+12} {"Player Name",-20} {"Team Name",-20} {"Games Played",+12    }\t{"Assists",+11}\t{"Goals",+14}\t{"Points",+6}\n");
                foreach (var i in hockeyPlayers)
                    Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.Blue;

            }
           
            if (playerType == PlayerType.BasketBallPlayer)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("BasketBall Players\n");

                Console.WriteLine($"{ "Player Type",-20}{" Player ID",+12} {"Player Name",-20} {"Team Name",-20} {"Games Played",+12}\t{"Field Goals",+11}\t{"Three Pointers",+14}\t{"Points",+6}\n");
                foreach (var i in basketBallPlayers)
                    Console.WriteLine(i);

                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (playerType == PlayerType.BaseBallPlayer)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("BaseBall Players\n");

                Console.WriteLine($"{ "Player Type",-20}{" Player ID",+12} {"Player Name",-20} {"Team Name",-20} {"Games Played",+12}\t{"Runs",+11}\t{"Home Runs",+14}\t{"Points",+6}\n");
                foreach (var i in baseBallPlayers)
                    Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.Blue;

            }
        }

    }
    }
