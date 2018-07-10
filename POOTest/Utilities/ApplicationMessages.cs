using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Utilities
{
    public static class ApplicationMessages
    {
        public const string addedPlate = "Plate added succesfully!";
        public const string errorPlateUniqueViolation = "Error adding plate, plate exists.";
        public const string deletedPlate = "Plate deleted succesfully!";
        public const string errorDeletingIdNotFound = "Error deleting plate, id not found.";
        public const string plateNotFound = "Plate not found in database, this Id isnt available.";
        public const string noPlatesInDataBase = "No plates found in database.";

        public const string askForNewPlate = "Introduce the name of the new plate: ";
        public const string askForId = "Introduce the id value: ";

        public const string badIdIntroduced = "Error! Introduce a valid id!";
    }
}
