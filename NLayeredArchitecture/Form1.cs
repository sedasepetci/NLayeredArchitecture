using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
namespace NLayeredArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EntityStaff> PerList = LogicStaff.LogicLayerList();
            dataGridView1.DataSource = PerList;
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            EntityStaff ent = new EntityStaff();
            ent.NAME1 = TxtNAME.Text;
            ent.SURNAME1 = TxtSURNAME.Text;
            ent.CITY1= TxtCITY.Text;
            ent.TASK1 = TxtTASK.Text;
            ent.SALARY1=short.Parse(TxtSALARY.Text);
            LogicStaff.ListStaffAdd(ent);
        }

        private void BtnLIST_Click(object sender, EventArgs e)
        {
            List<EntityStaff> PerList = LogicStaff.LogicLayerList();
            dataGridView1.DataSource = PerList;
        }

        private void BtnDELETE_Click(object sender, EventArgs e)
        {
            EntityStaff ent=new EntityStaff();
            ent.ID1=Convert.ToInt32(TxtID.Text);
            LogicStaff.ListStaffDelete(ent.ID1);
        }

        private void BtnUPDATE_Click(object sender, EventArgs e)
        {
            EntityStaff ent = new EntityStaff();
            ent.ID1 = Convert.ToInt32(TxtID.Text);
            ent.NAME1 = TxtNAME.Text;
            ent.SURNAME1 = TxtSURNAME.Text;
            ent.CITY1 = TxtCITY.Text; 
            ent.TASK1 = TxtTASK.Text;
            ent.SALARY1 =short.Parse(TxtSALARY.Text);
           
            LogicStaff.ListStaffUpdate(ent);
        }
    }
}
