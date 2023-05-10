using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
namespace DataAccessLayer

{
    public class DALStaff
    {
        public static List<EntityStaff> ListStaff()
        {
            List<EntityStaff> degerler = new List<EntityStaff>();
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_INFORMATION", Connection.bgl);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityStaff st = new EntityStaff();
                st.ID1 = int.Parse(dr["ID"].ToString());
                st.NAME1 = dr["NAME"].ToString();
                st.SURNAME1 = dr["SURNAME"].ToString();
                st.CITY1 = dr["CITY"].ToString();
                st.TASK1 = dr["TASK"].ToString();
                st.SALARY1 = short.Parse(dr["SALARY"].ToString());
                degerler.Add(st);
            }
            dr.Close();
            return degerler;

        }
        public static int StaffAdd(EntityStaff p)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Tbl_INFORMATION (NAME,SURNAME,CITY,TASK,SALARY) VALUES (@p1,@p2,@p3,@p4,@p5)", Connection.bgl);
            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            komut2.Parameters.AddWithValue("@p1", p.NAME1);
            komut2.Parameters.AddWithValue("@p2", p.SURNAME1);
            komut2.Parameters.AddWithValue("@p3", p.CITY1);
            komut2.Parameters.AddWithValue("@p4", p.TASK1);
            komut2.Parameters.AddWithValue("@p5", p.SALARY1);
            return komut2.ExecuteNonQuery();
        }

        public static bool StaffDelete(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_INFORMATION where ID=@p1", Connection.bgl);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool StaffUpdate(EntityStaff ent)
        {
            SqlCommand komut4 = new SqlCommand("Update Tbl_INFORMATION set NAME=@P1,SURNAME=@P2,CITY=@P3,TASK=@P4,SALARY=@P5 where ID=@P6", Connection.bgl);
            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.NAME1);
            komut4.Parameters.AddWithValue("@P2", ent.SURNAME1);
            komut4.Parameters.AddWithValue("@P3", ent.CITY1);
            komut4.Parameters.AddWithValue("@P4", ent.TASK1);
            komut4.Parameters.AddWithValue("@P5", ent.SALARY1);
            komut4.Parameters.AddWithValue("@P6", ent.ID1);
            return komut4.ExecuteNonQuery()> 0;
        }
    }
}

