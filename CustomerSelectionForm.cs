using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISIK_Group
{
    public partial class CustomerSelectionForm : Form
    {
        public dynamic SelectedCustomer { get; private set; }

        public CustomerSelectionForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            treeViewCustomers.Nodes.Clear();

            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            using (var reader = DatabaseHelper.GetCustomers())
            {
                while (reader.Read())
                {
                    var customer = new
                    {
                        CustomerID = reader.GetInt32("CustomerID"),
                        CustomerNumber = reader.GetString("CustomerNumber"),
                        FullName = reader.GetString("FullName"),
                        IsBlocked = reader.GetBoolean("IsBlocked")
                    };

                    TreeNode node = new TreeNode($"{customer.CustomerNumber} | {customer.FullName}")
                    {
                        Tag = customer
                    };
                    treeViewCustomers.Nodes.Add(node);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            foreach (TreeNode node in treeViewCustomers.Nodes)
            {
                node.BackColor = SystemColors.Window;
                node.ForeColor = SystemColors.WindowText;

                var customer = (dynamic)node.Tag;
                if (customer.CustomerNumber.ToLower().Contains(searchText) ||
                    customer.FullName.ToLower().Contains(searchText))
                {
                    node.BackColor = SystemColors.Highlight;
                    node.ForeColor = SystemColors.HighlightText;
                }
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (treeViewCustomers.SelectedNode != null)
            {
                SelectedCustomer = treeViewCustomers.SelectedNode.Tag;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Kunden aus.");
            }
        }
    }
}
