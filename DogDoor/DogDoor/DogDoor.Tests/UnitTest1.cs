using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DogDoor.Tests
{
    [TestClass]
    public class UnitTest1
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
    }
}
