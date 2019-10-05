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
    public partial class ItemUi : Form
    {
        

        ItemManager _itemManager = new ItemManager();
        TestItem _testItem = new TestItem();

        public ItemUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Item Name Can Not Be Empty");
                return;
            }
            if (string.IsNullOrEmpty(itemPriceTextBox.Text))
            {
                MessageBox.Show("Item Price Can Not Be Empty");
                return;
            }

            //unique
            _testItem.ItemName = itemNameTextBox.Text;

            if (_itemManager.IsNameExits(_testItem))
            {
                MessageBox.Show(itemNameTextBox.Text+" Item Name Already Exits!!");
                itemNameTextBox.Text = "";
                itemPriceTextBox.Text = "";
                return;
            }
            _testItem.ItemPrice = Convert.ToDouble(itemPriceTextBox.Text);

            bool added = _itemManager.Add(_testItem);
            if (added)
            {
                displayDataGridView.DataSource = _itemManager.InstantDisplayData();
                itemNameTextBox.Text = "";
                itemPriceTextBox.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Data Not insert Successfully !!! Error: " + added);
            }
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _itemManager.ShowData();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("Delete Id Can Not Be Empty");
            //    return;
            //}

            _testItem.Id = Convert.ToInt32(itemComboBox.SelectedValue);
            
           
            if (_itemManager.Delete(_testItem))
            {
                displayDataGridView.DataSource = _itemManager.InstantDisplayData();
                return;
            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _testItem.ItemName = itemNameTextBox.Text;

            if (_itemManager.IsNameExits(_testItem))
            {
                MessageBox.Show("Sorry Your Update Item Already Exits in Data table!! try to new Item Name");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(itemPriceTextBox.Text))
                {
                    MessageBox.Show("Empty Press");
                    return;
                }
                _testItem.ItemPrice = Convert.ToDouble(itemPriceTextBox.Text);
                _testItem.Id = Convert.ToInt32(idTextBox.Text);
                _itemManager.Update(_testItem);

                displayDataGridView.DataSource = _itemManager.InstantDisplayData();

            }




        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _testItem.ItemName = itemNameTextBox.Text;
            displayDataGridView.DataSource = _itemManager.Search(_testItem);
        }

        private void DisplayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             idTextBox.Text       = displayDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            itemNameTextBox.Text  = displayDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            itemPriceTextBox.Text = displayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void ItemUi_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource = _itemManager.ItemComboBox();
        }
    }
}
