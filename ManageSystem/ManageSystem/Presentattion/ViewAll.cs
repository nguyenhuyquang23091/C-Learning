using ManageSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Presentattion
{
    public partial class ViewAll : UserControl
    {
        private readonly RoleService roleservice;
        public ViewAll()
        {
            InitializeComponent();
            roleservice = new RoleService();
            LoadUserData();

        }
        private void AddAllUserData(object sender, EventArgs e)
        {
            LoadUserData();
        }
       
        private void LoadUserData()
        {
            var usertable = roleservice.GetAllUserData();
            viewallgrid.DataSource = usertable;

        }
        private void viewallgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void administrationview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
