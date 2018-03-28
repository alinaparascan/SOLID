using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DogDoor.Tests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void DogDoorOpens()
        {
            DogDoor door = new DogDoor();
            door.Open();
            Assert.IsTrue(door.Status);
        }

        [TestMethod]
        public void DogDoorCloses()
        {
            DogDoor door = new DogDoor();
            door.Close();
            Assert.IsFalse(door.Status);
        }

        [TestMethod]
        public void TheRemoteOpensTheDoor()
        {
            Remote rem = new Remote(new DogDoor());
            Assert.IsTrue(rem.PressButton());
        }

        [TestMethod]
        public void TheRemoteClosesTheDoor()
        {
            DogDoor door = new DogDoor();
            door.Open();
            Remote rem = new Remote(door);
            Assert.IsFalse(rem.PressButton());
        }

        [TestMethod]
        public void TheDogDoorIsClosedOnCodeEntered()
        {
            DogDoor door = new DogDoor();
            //var doorClosed = door.Close();

            // Assert.IsTrue(doorClosed);
        }

        [TestMethod]
        public void TheWindowsAreClosedOnCodeEntered()
        {
            Window window = new Window();
            Code code = new Code();
            var codeEntered = code.Enter();
            var windowClosed = window.Close();

            Assert.IsTrue(codeEntered);
            Assert.AreEqual(codeEntered, windowClosed);
        }

        [TestMethod]
        public void TheCodeEnteredIsCorrectAndTheWindowIsClosed()
        {
            Window window = new Window();
            Code code = new Code();
            var codeEntered = code.Enter();

            Assert.IsTrue(window.IsClosed);
        }
    }
}