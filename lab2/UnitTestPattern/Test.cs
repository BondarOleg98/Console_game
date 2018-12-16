using System;
using lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPattern
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestPatternFactoryMethod()
        {
            CreateRobot createRobot = new CreateCleverBot();
            Robot robot = createRobot.Create();
            Assert.IsNotNull(robot);

            createRobot = new CreateWorkBot();
            robot = createRobot.Create();
            Assert.IsNotNull(robot);

            createRobot = new CreateCyborg();
            robot = createRobot.Create();
            Assert.IsNotNull(robot);
        }
        [TestMethod]
        public void TestPatternCommand()
        {
            CreateRobot createRobot = new CreateCleverBot();
            Robot robot = createRobot.Create();
            Move move = new Move(robot);
            KeyboardMove keyboard_move = new KeyboardMove();
            keyboard_move.SetCommand(new Move(robot));
            Assert.AreEqual(move.Execute(), keyboard_move.PressButton());

            keyboard_move.SetCommand(new Move(robot));
            Assert.AreEqual(move.Undo(), keyboard_move.PressUndo());

            KeyboardAction keyboardTake = new KeyboardAction();
            keyboardTake.SetCommand(new lab2.Action(robot));
            Assert.AreEqual(move.Execute(), keyboard_move.PressButton());
        }
        [TestMethod]
        public void TestPatternSaver()
        {
            CreateRobot createRobot = new CreateCleverBot();
            Robot robot = createRobot.Create();
            CleverBot cleverBot = new CleverBot();
            string result1 = "0";
            string result2 = "0";
            RobotMemento robotMemento = new RobotMemento(10, 20, 65);
            result1 = cleverBot.RestoreState(robotMemento);
            result2 = "Restore game: money - " + 65 + ", weight - " + 20 + " ,charge - " + 10;
            Assert.AreEqual(result1, result2);

            GameHistory gameHistory = new GameHistory();
            gameHistory.History.Push(cleverBot.SaveState());
            result1 = cleverBot.RestoreState(gameHistory.History.Pop());
            Assert.AreEqual(result1, result2);
        }
        [TestMethod]
        public void TestFunctionLostEnergyMove()
        {
            CleverBot cleverBot = new CleverBot();
            string result1 = "0";
            string result2 = "Money: " + 0 + " Weight: "+ 0 + " Charge: " + 89;
            result1 = cleverBot.LostEnergyMove();
            Assert.AreEqual(result1, result2);
        }
    }
}
