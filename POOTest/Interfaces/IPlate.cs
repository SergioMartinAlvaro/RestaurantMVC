using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Interfaces
{
    interface IPlate
    {
        string AddPlate(string name);
        string RemovePlate(int id);
        string FindPlate(int id);
        string ShowPlates();
    }
}
