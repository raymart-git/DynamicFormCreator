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

namespace DynamicFormCreator
{
    public partial class Form1 : Form
    {
        private CreateControlUserCtrl _createControlUserCtrl;
        private AccessFormUserCtrl _accessFormUserCtrl;
        private DeleteFormUserCtrl _deleteFormUserCtrl;

        public Form1()
        {
            InitializeComponent();

            _createControlUserCtrl = new CreateControlUserCtrl();
            _createControlUserCtrl.Dock = DockStyle.Fill;
            _createControlUserCtrl.Visible = false;

            _accessFormUserCtrl = new AccessFormUserCtrl();
            _accessFormUserCtrl.Dock = DockStyle.Fill;
            _accessFormUserCtrl.Visible = false;

            _deleteFormUserCtrl = new DeleteFormUserCtrl();
            _deleteFormUserCtrl.Dock = DockStyle.Fill;
            _deleteFormUserCtrl.Visible = false;

            panel1.Controls.Add(_createControlUserCtrl);
            panel1.Controls.Add(_accessFormUserCtrl);
            panel1.Controls.Add(_deleteFormUserCtrl);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbSelectMain.Items.Add("Create New Form");
            cbSelectMain.Items.Add("Show Form");
            cbSelectMain.Items.Add("Delete Form");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var selected = cbSelectMain.SelectedItem;
            if (selected == null) return;

            if (selected.ToString() == "Create New Form")
            {
                _createControlUserCtrl.Show();
                _accessFormUserCtrl.Hide();
                _deleteFormUserCtrl.Hide();
            }
            else if (selected.ToString() == "Show Form")
            {
                _accessFormUserCtrl.Show();
                _createControlUserCtrl.Hide();
                _deleteFormUserCtrl.Hide();
            }
            else if (selected.ToString() == "Delete Form")
            {
                _deleteFormUserCtrl.Show();
                _createControlUserCtrl.Hide();
                _accessFormUserCtrl.Hide();
            }
        }
    }
}
