using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Models
{
    public class Plate
    {
        private int _id;
        private string _name;

        public Plate(int id, string name)
        {
            _id = id;
            _name = name;

        }

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if(value != null)
                {
                    _id = value;
                }
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
