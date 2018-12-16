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
            string result = "0";
            
            string move = "0";
            string take = "0";
            if (numberBot < 0.2) 
            {
                CreateRobot createRobot = new CreateCleverBot();
                Robot robot = createRobot.Create();
                CleverBot cleverBot = new CleverBot();
                Console.WriteLine(cleverBot.RobotLegend());
                KeyboardMove keyboard_move = new KeyboardMove();
                keyboard_move.SetCommand(new Move(robot));
                KeyboardAction keyboard_take = new KeyboardAction();
                keyboard_take.SetCommand(new Action(robot));
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
                            result = cleverBot.LostEnergyMove();
                            if (result == "0")
                            {
                                result = cleverBot.Progress();
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
                            result = cleverBot.LostEnergyMove();
                            if (result == "0")
                            {
                                result = cleverBot.Progress();
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
                            result = cleverBot.WeightEnergy();
                            if (result == "0")
                            {
                                result = cleverBot.Progress();
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
                Cyborg cyborg = new Cyborg();
                Console.WriteLine(cyborg.RobotLegend());
                KeyboardMove keyboard_move = new KeyboardMove();
                keyboard_move.SetCommand(new Move(robot));
                KeyboardAction keyboard_take = new KeyboardAction();
                keyboard_take.SetCommand(new Action(robot));
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
                            result = cyborg.LostEnergyMove();
                            if (result == "0")
                            {
                                result = cyborg.Progress();
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
                            result = cyborg.LostEnergyMove();
                            if (result == "0")
                            {
                                result = cyborg.Progress();
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
                            result = cyborg.WeightEnergy();
                            if (result == "0")
                            {
                                result = cyborg.Progress();
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
                WorkBot workBot = new WorkBot();
                Console.WriteLine(workBot.RobotLegend());
                KeyboardMove keyboard_move = new KeyboardMove();
                keyboard_move.SetCommand(new Move(robot));
                KeyboardAction keyboard_take = new KeyboardAction();
                keyboard_take.SetCommand(new Action(robot));
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
                            result = workBot.LostEnergyMove();
                            if (result == "0")
                            {
                                result = workBot.Progress();
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
                            result = workBot.LostEnergyMove();
                            if (result == "0")
                            {
                                result = workBot.Progress();
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
                            result = workBot.WeightEnergy();
                            if (result == "0")
                            {
                                result = workBot.Progress();
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
