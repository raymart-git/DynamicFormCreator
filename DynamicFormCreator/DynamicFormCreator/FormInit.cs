using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicFormCreator
{
    public partial class FormInit : Form
    {
        public FormInit()
        {
            InitializeComponent();

            txtConnectionString.Text = Global.ConnectionString;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                MessageBox.Show("Please Fill out Connection String");
            }
            else
            {
                // Connect to DB using ConnectionString Provided
                Global.ConnectionString = txtConnectionString.Text;
                Helper.Connect(Global.ConnectionString);

                // Create FormDirectory table
                Helper.CreateFormDirectoryTable();

                // Show Main Form
                Form1 form1 = new Form1();
                form1.Show();

                // Hide this Form
                this.Hide();
            }
        }

        private void FormInit_Load(object sender, EventArgs e)
        {
            // Create Form Builder DB
            Helper.CreateFormBuilderDB();
        }
    }
}
