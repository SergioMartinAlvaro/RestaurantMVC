using POOTest.Controllers;
using POOTest.Utilities;
using POOTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCases
{
    [TestClass]
    public class PlateTest
    {
        private PlateController plateController = new PlateController();

        [TestMethod]
        public void PlateAddedSuccesfully()
        {
            string response = plateController.AddPlate("jamon");
            Assert.AreEqual(response, ApplicationMessages.addedPlate);
        }

        [TestMethod]
        public void ErrorAddingRepeatedPlate()
        {
            string response = plateController.AddPlate("jamon");
            response = plateController.AddPlate("jamon");
            Assert.AreEqual(response, ApplicationMessages.errorPlateUniqueViolation);

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
        public void twoPlateShow()
        {
            string response = plateController.AddPlate("jamon");
            response = plateController.AddPlate("pollo");
            string testString = "==============================\r\n" +
                              "Plate id: " + 1 + "\r\n" +
                              "Plate name: " + "jamon" + "\r\n";
            testString += "==============================\r\n" +
                  "Plate id: " + 2 + "\r\n" +
                  "Plate name: " + "pollo" + "\r\n";
            Assert.AreEqual(plateController.ShowPlates(), testString);

        }

        [TestMethod]
        public void plateShowIsEmpty()
        {
            Assert.AreEqual(plateController.ShowPlates(), ApplicationMessages.noPlatesInDataBase);

        }

        [TestMethod]
        public void plateRemoveSuccesful()
        {
            string response = plateController.AddPlate("jamon");
            Assert.AreEqual(plateController.RemovePlate(1), ApplicationMessages.deletedPlate);
        }

        [TestMethod]
        public void plateRemoveWrongId()
        {
            Assert.AreEqual(plateController.RemovePlate(1), ApplicationMessages.errorDeletingIdNotFound);
        }

        [TestMethod]
        public void FindPlate()
        {
            string response = plateController.AddPlate("jamon");
            string testString = "==============================\r\n" +
                              "Plate id: " + 1 + "\r\n" +
                              "Plate name: " + "jamon" + "\r\n";
            Assert.AreEqual(plateController.FindPlate(1), testString);
        }

        [TestMethod]
        public void PlateNotFound()
        {
            string response = plateController.AddPlate("jamon");
            string testString = "==============================\r\n" +
                              "Plate id: " + 1 + "\r\n" +
                              "Plate name: " + "jamon" + "\r\n";
            Assert.AreEqual(plateController.FindPlate(2), ApplicationMessages.plateNotFound);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }


}

