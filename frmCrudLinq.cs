using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_LINQ
{
    public partial class frmCrudLinq : Form
    {
        public DataBaseServices DataBaseServices = new DataBaseServices();
        public frmCrudLinq()
        {
            InitializeComponent();
            dgvDataUsers.DataSource = GetListUsers();
            dgvDataUsers.Columns[0].Visible = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Users users = new Users() { Firtname = txtFirstname.Text, lastname = txtLastname.Text, INE = txtINE.Text };
            DataBaseServices.Insert(users);
            List<Users> ListUsers = GetListUsers();
            dgvDataUsers.DataSource = ListUsers;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Action(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Action(1);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Action(2);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDataUsers.DataSource = GetListUsers();
        }

        public void Action(int option)
        {
            switch (option)
            {
                case 0:
                    UpdateUsers();
                    break;
                case 1:
                    DelteUsers();
                    break;
                case 2:
                    ViewUsers();
                    break;
            }
        }

        private void ViewUsers()
        {
            if (dgvDataUsers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDataUsers.SelectedRows[0].Cells[0].Value);
                Users users = new Users();
                users = DataBaseServices.GetOne(id);

                MessageBox.Show("Firstname: " + users.Firtname +"\n"+
                                "Lastname: " + users.lastname + "\n"+
                                "INE: " + users.INE
                                , "Data User");

            }

        }

        private void DelteUsers()
        {
            if(dgvDataUsers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDataUsers.SelectedRows[0].Cells[0].Value);
                DataBaseServices.Delete(id);
                dgvDataUsers.DataSource = GetListUsers();
            }
        }

        private void UpdateUsers()
        {
            if (dgvDataUsers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDataUsers.SelectedRows[0].Cells[0].Value);
                Users users = new Users() { idUser = id, Firtname = txtFirstname.Text, lastname = txtLastname.Text, INE = txtINE.Text };  
                DataBaseServices.Update(users);
                dgvDataUsers.DataSource = GetListUsers();
            }
        }

        public List<Users> GetListUsers()
        {
            List<Users> ListUsers = DataBaseServices.GetList();
            return ListUsers;
        }

        private void dgvDataUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDataUsers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDataUsers.SelectedRows[0].Cells[0].Value);            
                Users users = new Users();
                users = DataBaseServices.GetOne(id);
                txtFirstname.Text = users.Firtname;
                txtLastname.Text = users.lastname;
                txtINE.Text = users.INE;    
            }
        }
    }
}
