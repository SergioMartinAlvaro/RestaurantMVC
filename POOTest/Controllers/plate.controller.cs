using POOTest.Interfaces;
using POOTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Controllers
{
    public class plate : IPlate
    {

        private Services.plate plateService = new Services.plate();

        public string AddPlate(string name)
        {
            return plateService.AddPlate(name);
        }

        public string FindPlate(int id)
        {
            return plateService.FindPlate(id);
        }

        public string RemovePlate(int id)
        {
            return plateService.RemovePlate(id);
        }

        public string ShowPlates()
        {
            return plateService.ShowPlates();
        }
    }
}
