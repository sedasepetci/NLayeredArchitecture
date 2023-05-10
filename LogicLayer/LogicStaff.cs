using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LogicLayer
{
    public class LogicStaff
    {
        public static List<EntityStaff> LogicLayerList()
        {
            return DALStaff.ListStaff();
        }
        public static int ListStaffAdd(EntityStaff p)
        {
            if(p.NAME1 !=""&& p.SURNAME1 !=""&& p.SALARY1>=3500 && p.NAME1.Length>=3)
            {
                return DALStaff.StaffAdd(p);
            }
            else
            {
                return -1;
            }
        }
        
        public static bool ListStaffDelete(int per)
        {
            
            if (per >= 1)
            {
               return DALStaff.StaffDelete(per);
            }
            else
            {
                return false;
            }
        } 
        
        public static bool ListStaffUpdate(EntityStaff ent) 
        {
            if(ent.NAME1.Length>=3 && ent.NAME1!="" && ent.SALARY1>=10000)
            {
                return DALStaff.StaffUpdate(ent);
            }
            else
            {
                return false;
            }



        }
    }
}
