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

            KeyboardTake keyboardTake = new KeyboardTake();
            keyboardTake.SetCommand(new TakePut(robot));
            Assert.AreEqual(move.Execute(), keyboard_move.PressButton());
        }
        [TestMethod]
        public void TestPatternSaver()
        {
            CreateRobot createRobot = new CreateCleverBot();
            Robot robot = createRobot.Create();
            CleverBot cleverBot = new CleverBot();
            string result1 = "0";
            string result2 = "Your weight: " + 0 + " , charge: " + 89;
            RobotMemento robotMemento = new RobotMemento(10, 20, 65);
            result1 = cleverBot.RestoreState(robotMemento);
            result2 = "Restore game: charge - " + 10 + ", weight - " + 20 + " ,cost - " + 65;
            Assert.AreEqual(result1, result2);

            GameHistory gameHistory = new GameHistory();
            gameHistory.History.Push(cleverBot.SaveState());
            result1 = cleverBot.RestoreState(gameHistory.History.Pop());
            Assert.AreEqual(result1, result2);
        }
        [TestMethod]
        public void TestSomeFunction()
        {
            CleverBot cleverBot = new CleverBot();
            string result1 = "0";
            string result2 = "Your weight: " + 0 + " , charge: " + 89;
            result1 = cleverBot.LostEnergy();
            Assert.AreEqual(result1, result2);

            int decode_result = 0;
            DecoderPackage decoderPackage = new DecoderPackage();
            decode_result = decoderPackage.Decoding(2);
            Assert.AreEqual(1, decode_result);
        }
    }
}
