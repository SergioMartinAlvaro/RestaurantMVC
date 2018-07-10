using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Models
{
    public class Ingredient
    {
        private int _id;
        private string _name;
        private int _plateId;

        public Ingredient(int id, string name, int plateId)
        {
            _id = id;
            _name = name;
            _plateId = plateId;
        }

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != null)
                {
                    _id = value;
                }
            }
        }

        public int plateId
        {
            get
            {
                return _plateId;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
    }
}
