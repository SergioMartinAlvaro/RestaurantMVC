using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOTest.Views;
using POOTest.Controllers;


namespace POOTest.Controllers
{
    public class main
    {

        public Controllers.plate plateController = new Controllers.plate();
        public string MenuController(string number)
        {
            switch(number)
            {
                case "1":
                    string name = VisualInterface.AskForString("Introduce the name of the new plate: ");
                    Console.WriteLine(plateController.AddPlate(name)); 
                    break;
                case "2":
                    Console.WriteLine(plateController.ShowPlates());
                    break;
                case "5":
                    Console.WriteLine("Bye! Have a nice day!");
                    break;
                default:
                    Console.WriteLine("Introduce a valid value.");
                    break;
            }

            return number;
        }

        public void startApplication()
        {
            string response = "";
            while(response != "5")
            { 
                VisualInterface.WriteMenu();
                response = VisualInterface.AskForString("Introduce a number to choose an option");
                this.MenuController(response);
            }
        }
    }
}
