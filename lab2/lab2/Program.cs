using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game Robots");
            Random random = new Random();
            double numberBot = random.NextDouble();          
            string flag_history = "h";
            string result = "0";
            
            string move = "0";
            string take = "0";
            if (numberBot < 0.2) 
            {
                CreateRobot createRobot = new CreateCleverBot();
                Robot robot = createRobot.Create();
                CleverBot cleverBot = new CleverBot(flag_history);
                Console.WriteLine(cleverBot.RobotLegend());
                KeyboardMove keyboard_move = new KeyboardMove();
                keyboard_move.SetCommand(new Move(robot));
                KeyboardTake keyboard_take = new KeyboardTake();
                keyboard_take.SetCommand(new TakePut(robot));
                GameHistory gameHistory = new GameHistory();
                ConsoleKeyInfo key;
                do
                {
                    Console.WriteLine("Would you like to take the package? If yes, press ENTER");
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            move = keyboard_move.PressButton();
                            Console.WriteLine(move);
                            gameHistory.History.Push(cleverBot.SaveState());
                            result = cleverBot.LostEnergy();
                            if (result == "0")
                            {
                                result = cleverBot.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                           
                            Console.WriteLine(result);
                            break;
                        case ConsoleKey.LeftArrow:
                           
                            move = keyboard_move.PressUndo();
                            Console.WriteLine(move);
                            gameHistory.History.Push(cleverBot.SaveState());
                            result = cleverBot.LostEnergy();
                            if (result == "0")
                            {
                                result = cleverBot.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                            Console.WriteLine(result);
                            break;
                        case ConsoleKey.DownArrow:
                            try
                            {
                                if (gameHistory.History.Count == 0)
                                {
                                    throw new Exception("Does not have a back move");
                                }
                                result = cleverBot.RestoreState(gameHistory.History.Pop());
                                Console.WriteLine(result);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            break;
                        case ConsoleKey.Enter:
                            take  =  keyboard_take.TakeButton();
                            Console.WriteLine(take);
                            gameHistory.History.Push(cleverBot.SaveState());
                            result = cleverBot.LoadCapacity();
                            if (result == "0")
                            {
                                result = cleverBot.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                            
                            Console.WriteLine(result);
                            break;
                    }
                    Console.WriteLine();


                } while (key.Key != ConsoleKey.Q);
            }
            else if(numberBot < 0.5)
            {
                CreateRobot createRobot = new CreateCyborg();
                Robot robot = createRobot.Create();
                Cyborg cyborg = new Cyborg(flag_history);
                Console.WriteLine(cyborg.RobotLegend());
                KeyboardMove keyboard_move = new KeyboardMove();
                keyboard_move.SetCommand(new Move(robot));
                KeyboardTake keyboard_take = new KeyboardTake();
                keyboard_take.SetCommand(new TakePut(robot));
                GameHistory gameHistory = new GameHistory();
                ConsoleKeyInfo key;
                do
                {
                    Console.WriteLine("Would you like to take the package? If yes, press ENTER");
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            move = keyboard_move.PressButton();
                            Console.WriteLine(move);
                            gameHistory.History.Push(cyborg.SaveState());                          
                            result = cyborg.LostEnergy();
                            if (result == "0")
                            {
                                result = cyborg.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                            Console.WriteLine(result);
                            break;
                        case ConsoleKey.LeftArrow:
                            move = keyboard_move.PressUndo();
                            Console.WriteLine(move);
                            gameHistory.History.Push(cyborg.SaveState());
                            result = cyborg.LostEnergy();
                            if (result == "0")
                            {
                                result = cyborg.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                            Console.WriteLine(result);
                            break;
                        case ConsoleKey.DownArrow:
                            try
                            {
                                if(gameHistory.History.Count == 0)
                                {
                                    throw new Exception("Does not have a back move");
                                }
                                result = cyborg.RestoreState(gameHistory.History.Pop());
                                Console.WriteLine(result);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }                           
                            break;
                        case ConsoleKey.Enter:
                            take = keyboard_take.TakeButton();
                            Console.WriteLine(take);
                            gameHistory.History.Push(cyborg.SaveState());
                            result = cyborg.LoadCapacity();
                            if (result == "0")
                            {
                                result = cyborg.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                           
                            Console.WriteLine(result);
                            break;
                    }                
                    Console.WriteLine();


                } while (key.Key != ConsoleKey.Q);             

            }
            else
            {
                CreateRobot createRobot = new CreateWorkBot();
                Robot robot = createRobot.Create();
                WorkBot workBot = new WorkBot(flag_history);
                Console.WriteLine(workBot.RobotLegend());
                KeyboardMove keyboard_move = new KeyboardMove();
                keyboard_move.SetCommand(new Move(robot));
                KeyboardTake keyboard_take = new KeyboardTake();
                keyboard_take.SetCommand(new TakePut(robot));
                GameHistory gameHistory = new GameHistory();
                ConsoleKeyInfo key;
                do
                {
                    Console.WriteLine("Would you like to take the package? If yes, press ENTER");
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            move = keyboard_move.PressButton();
                            Console.WriteLine(move);
                            gameHistory.History.Push(workBot.SaveState());
                            result = workBot.LostEnergy();
                            if (result == "0")
                            {
                                result = workBot.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                            Console.WriteLine(result);
                            break;
                        case ConsoleKey.LeftArrow:
                            move = keyboard_move.PressUndo();
                            Console.WriteLine(move);
                            gameHistory.History.Push(workBot.SaveState());
                            result = workBot.LostEnergy();
                            if (result == "0")
                            {
                                result = workBot.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                            Console.WriteLine(result);
                            break;
                        case ConsoleKey.DownArrow:
                            try
                            {
                                if (gameHistory.History.Count == 0)
                                {
                                    throw new Exception("Does not have a back move");
                                }
                                result = workBot.RestoreState(gameHistory.History.Pop());
                                Console.WriteLine(result);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            break;
                        case ConsoleKey.Enter:
                            take = keyboard_take.TakeButton();
                            Console.WriteLine(take);
                            gameHistory.History.Push(workBot.SaveState());
                            result = workBot.LoadCapacity();
                            if (result == "0")
                            {
                                result = workBot.TotalCost();
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("Game over:" + result);
                                Console.ReadKey();
                                return;
                            }
                           
                            Console.WriteLine(result);
                            break;
                    }
                    Console.WriteLine();


                } while (key.Key != ConsoleKey.Q);

            }

            Console.ReadKey();
        }
    }
}
