using POOTest.Interfaces;
using POOTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOTest.Models;
using System.Collections;

namespace POOTest.Services
{
    class PlateService : IPlate
    {
        private List<Plate> availablePlates = new List<Plate>();

        public string AddPlate(string name)
        {
            if(!IsUniquePlateName(name))
            {
                availablePlates.Add(new Plate(CalculateId(availablePlates), name));
                return ApplicationMessages.addedPlate;
            }
            return ApplicationMessages.errorPlateUniqueViolation;
        }

        public string FindPlate(int id)
        {
            IEnumerable<Plate> result = availablePlates.ToArray().Where((x) => x.id == id);
            if(result.Count() > 0)
            {
                return "==============================\r\n" +
                  "Plate id: " + result.First().id + "\r\n" +
                  "Plate name: " + result.First().name + "\r\n";
            }
            return ApplicationMessages.plateNotFound;


        }

        public string RemovePlate(int id)
        {
            if(id > availablePlates.Count() || id < 1)
            {
                return ApplicationMessages.errorDeletingIdNotFound;
            }
            availablePlates.RemoveAt(id - 1);
            return ApplicationMessages.deletedPlate;
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

            if(platesList != "")
            {
                return platesList;
            }
            return ApplicationMessages.noPlatesInDataBase;


        }

        private bool IsUniquePlateName(string name)
        {
            return (availablePlates.ToArray().Where((x) => x.name.ToLower() == name.ToLower())).Count() > 0;
        }

        private int CalculateId(List<Plate> listOfPlates )
        {
            if (listOfPlates.ToArray().Length == 0)
            {
                return 1;
            }
            else
            {
                return listOfPlates.ToArray()[listOfPlates.ToArray().Length - 1].id + 1;
            }
        }
    }
}
