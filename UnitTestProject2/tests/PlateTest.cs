using POOTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCases
{
    [TestClass]
    public class PlateTest
    {
        private plate plateController = new plate();

        [TestMethod]
        public void PlateAddedSuccesfully()
        {
            string response = plateController.AddPlate("jamon");
            Assert.AreEqual(response, "Plate jamon added succesfully!.");
        }

        [TestMethod]
        public void ErrorAddingRepeatedPlate()
        {
            string response = plateController.AddPlate("jamon");
            response = plateController.AddPlate("jamon");
            Assert.AreEqual(response, "Error adding plate, a plate with the same name exists in database.");

        }

        [TestMethod]
        public void plateShow()
        {
            string response = plateController.AddPlate("jamon");
            string testString = "==============================\r\n" +
                              "Plate id: " + 1 + "\r\n" +
                              "Plate name: " + "jamon" + "\r\n";
            Assert.AreEqual(plateController.ShowPlates(), testString);

        }

        [TestMethod]
        public void plateShowIEmpty()
        {
            Assert.AreEqual(plateController.ShowPlates(), "No plates found in database.");

        }
    }


}

