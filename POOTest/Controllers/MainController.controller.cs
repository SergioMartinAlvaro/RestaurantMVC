using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOTest.Views;
using POOTest.Controllers;
using POOTest.Utilities;


namespace POOTest.Controllers
{
    public class MainController
    {

        public PlateController plateController = new PlateController();
        public string MenuController(string number)
        {

            string id;
            string name;

            switch(number)
            {
                case "1":
                    name = VisualInterface.AskForString(ApplicationMessages.askForNewPlate);
                    Console.WriteLine(plateController.AddPlate(name)); 
                    break;
                case "2":
                    Console.WriteLine(plateController.ShowPlates());
                    break;
                case "3":
                    id = VisualInterface.AskForString(ApplicationMessages.askForId);
                    try
                    {
                        Console.WriteLine(plateController.FindPlate(int.Parse(id)));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(ApplicationMessages.badIdIntroduced);
                    }
                    break;
                case "4":
                    id = VisualInterface.AskForString(ApplicationMessages.askForId);
                    try
                    {
                        Console.WriteLine(plateController.RemovePlate(int.Parse(id)));
                    } catch(Exception e)
                    {
                        Console.WriteLine(ApplicationMessages.badIdIntroduced);
                    }
                    break;
                case "5":
                    plateController.generateExcel();
                    Console.WriteLine(ApplicationMessages.downloadingExcel);
                    break;
                case "6":
                    Console.WriteLine("Bye! Have a nice day!");
                    break;
                default:
                    Console.WriteLine(ApplicationMessages.badIdIntroduced);
                    break;
            }

            return number;
        }

        public void StartApplication()
        {
            string response = "";
            while(response != "6")
            { 
                VisualInterface.WriteMenu();
                response = VisualInterface.AskForString("Introduce a number to choose an option");
                this.MenuController(response);
            }
        }
    }
}
