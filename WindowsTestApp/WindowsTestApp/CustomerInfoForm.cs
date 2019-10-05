using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsTestApp.BLL;
using WindowsTestApp.Model;

namespace WindowsTestApp
{
    public partial class CustomerInfoForm : Form
    {
        CustomerInfoManager _customerInfoManager = new CustomerInfoManager();
        CustomerInfoModel _customerInfoModel = new CustomerInfoModel();

        public CustomerInfoForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            

            _customerInfoModel.Name = customerNameTextBox.Text;
            _customerInfoModel.Address = customerAddrsTextBox.Text;
            _customerInfoModel.Contact = customerConTextBox.Text;

            customerDisplaydataGridView.DataSource  = _customerInfoManager.Save(_customerInfoModel);

            
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            customerDisplaydataGridView.DataSource = _customerInfoManager.Display();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _customerInfoModel.Id = Convert.ToInt32(idTextBox.Text);
            //_customerInfoModel.Name = customerNameTextBox.Text;
            customerDisplaydataGridView.DataSource = _customerInfoManager.delete(_customerInfoModel);
        }

        private void CustomerDisplaydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                idTextBox.Text = customerDisplaydataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerNameTextBox.Text = customerDisplaydataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerAddrsTextBox.Text = customerDisplaydataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerConTextBox.Text = customerDisplaydataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
           

            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _customerInfoModel.Id      = Convert.ToInt32(idTextBox.Text);
            _customerInfoModel.Name    = customerNameTextBox.Text;
            _customerInfoModel.Address = customerAddrsTextBox.Text;
            _customerInfoModel.Contact = customerConTextBox.Text;

            customerDisplaydataGridView.DataSource = _customerInfoManager.Upddate(_customerInfoModel);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
             _customerInfoModel.Name    = customerNameTextBox.Text;
            customerDisplaydataGridView.DataSource = _customerInfoManager.Search(_customerInfoModel);
        }
    }
}
