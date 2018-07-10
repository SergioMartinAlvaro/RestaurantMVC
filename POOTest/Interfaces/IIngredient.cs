using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Interfaces
{
    interface IIngredient
    {
        string AddIngredient(string name, int plateId);
        string ShowIngredients();
        int countIngredients(int plateId);
    }
}
