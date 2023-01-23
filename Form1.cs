using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicService.CustomerClasses;

namespace TechnicService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerClass std = new CustomerClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);

        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            std.FirstName = txtFirstName.Text;
            std.LastName = txtLastName.Text;
            std.Address = txtAddress.Text;
         

            bool success = std.Insert(std);

            if (success == true)
            {
                MessageBox.Show("A new customer inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed");
            }
            DataTable dt = std.Select();
            dgvCustomerList.DataSource = dt;
        
        }
        private void dgvCustomerList_RowHeaderMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;


                txtFirstName.Text = dgvCustomerList.Rows[rowindex].Cells[0].Value.ToString();
            txtLastName.Text = dgvCustomerList.Rows[rowindex].Cells[1].Value.ToString();
            txtAddress.Text = dgvCustomerList.Rows[rowindex].Cells[2].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            std.FirstName = txtFirstName.Text;
            std.LastName = txtLastName.Text;
            std.Address = txtAddress.Text;

            bool success = std.Update(std);
        if(success == true)
            {
                MessageBox.Show("Record has been updated");
                DataTable dt = std.Select();
                dgvCustomerList.DataSource = dt;
            }
            else {
                MessageBox.Show("Update failed");
            }
        }


        private void btnDelete_Click(object sender,EventArgs e)
        {
            std.ID = Convert.ToInt32(txtID.Text);
            bool success = std.Delete(std);
            if (success)
            {
                MessageBox.Show("Record has been deleted.");
                DataTable dt = std.Select();
                dgvCustomerList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Record has not been deleted");
            }
            }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
        }
        private void btnClear_Click(object sender,EventArgs e)
        {
            Clear();
        }



        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
