using POOTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOTest.Models;

namespace POOTest.Services
{
    class plate : IPlate
    {
        private List<Plate> availablePlates = new List<Plate>();

        public string AddPlate(string name)
        {
            if(!isUniquePlateName(name))
            {
                int id = availablePlates.ToArray().Length + 1;
                availablePlates.Add(new Plate(id, name));
                return "Plate added succesfully!.";
            }
            return "Error adding plate, a plate with the same name exists in database.";
        }

        public string FindPlate(int id)
        {
            return "";
        }

        public string RemovePlate(int id)
        {
            return "";
        }

        public string ShowPlates()
        {
            string platesList = "";

            foreach(Plate availablePlate in availablePlates)
            {
                platesList += "==============================\r\n" +
                              "Plate id: " + availablePlate.id + "\r\n" +
                              "Plate name: " + availablePlate.name + "\r\n";
            }

            return platesList;
        }

        private bool isUniquePlateName(string name)
        {
            return (availablePlates.ToArray().Where((x) => x.name.ToLower() == name.ToLower())).Count() > 0;
        }
    }
}
