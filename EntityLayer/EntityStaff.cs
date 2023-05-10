using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityStaff
    {
        private int ID;
        private string NAME;
        private string SURNAME;
        private string CITY;
        private string TASK;
        private short SALARY;

        public int ID1 { get => ID; set => ID = value; }
        public string NAME1 { get => NAME; set => NAME = value; }
        public string SURNAME1 { get => SURNAME; set => SURNAME = value; }
        public string CITY1 { get => CITY; set => CITY = value; }
        public string TASK1 { get => TASK; set => TASK = value; }
        public short SALARY1 { get => SALARY; set => SALARY = value; }
    }
}
