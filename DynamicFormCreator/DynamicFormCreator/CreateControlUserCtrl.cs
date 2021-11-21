using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicFormCreator
{
    public partial class CreateControlUserCtrl : UserControl
    {
        public CreateControlUserCtrl()
        {
            InitializeComponent();

            cbControlList.Items.Add("TextBox-FreeText");
            cbControlList.Items.Add("TextBox-Numeric");
            cbControlList.Items.Add("DatePicker");
            cbControlList.Items.Add("ComboBox");
            cbControlList.Items.Add("RadioButton");

            cbControlList.SelectedIndexChanged += CbControlList_SelectedIndexChanged;
        }

        private void CbControlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtControlName.Text = "";

            var selected = cbControlList.SelectedItem.ToString();
            if (selected == "ComboBox" || selected == "RadioButton")
            {
                rtbItems.Visible = true;
                lblRule.Visible = true;
                lblRule.Text = string.Format("Please Type the Items to be Added on {0} on Comma Delimited Format", selected);
            }
            else
            {
                rtbItems.Visible = false;
                lblRule.Visible = false;
            }
        }

        private void chkLimit_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkLimit.Checked)
            {
                txtMinVal.Enabled = true;
                txtMaxVal.Enabled = true;
            }
            else
            {
                txtMinVal.Enabled = false;
                txtMaxVal.Enabled = false;
            }
        }

        private void btnAddControl_Click(object sender, EventArgs e)
        {
            var selected = cbControlList.SelectedItem == null ? "" : cbControlList.SelectedItem.ToString();

            if (String.IsNullOrEmpty(txtControlName.Text))
            {
                MessageBox.Show("Please Fill Out Control Name");
                return;
            }
            if (selected == "ComboBox" || selected == "RadioButton")
            {
                if (String.IsNullOrEmpty(rtbItems.Text))
                {
                    MessageBox.Show(string.Format("{0} Items Cannot be Empty!", selected));
                    return;
                }
            }

            if (chkLimit.Checked)
            {
                if (String.IsNullOrEmpty(txtMinVal.Text) || String.IsNullOrEmpty(txtMaxVal.Text))
                {
                    MessageBox.Show("Min And Max Limit Cannot Be Empty!");
                    return;
                }
                else
                {
                    if (Convert.ToInt32(txtMinVal.Text) > Convert.ToInt32(txtMaxVal.Text))
                    {
                        MessageBox.Show("Min Limit Cannot Be Greater Than Max Limit");
                        return;
                    }
                    else if (Convert.ToInt32(txtMinVal.Text) == Convert.ToInt32(txtMaxVal.Text))
                    {
                        MessageBox.Show("Min Limit Cannot Be Equal To Max Limit");
                        return;
                    }
                }
            }
            
            string ctrlAdded = string.Format("{0} | {1} | {2} | {3}", txtControlName.Text, selected,
                                (selected == "ComboBox" || selected == "RadioButton") ? rtbItems.Text : "", (chkLimit.Checked) ? string.Format("{0} > {1}", txtMinVal.Text, txtMaxVal.Text) : "");

            foreach (string item in chkList.Items)
            {
                if (item.Contains(txtControlName.Text.Trim() + " |"))
                {
                    MessageBox.Show(string.Format("{0} control already added, Please Add Unique Control Name", txtControlName.Text));
                    return;
                }
            }

            chkList.Items.Add(ctrlAdded, CheckState.Checked);
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            bool isFormExist = Helper.IsFormNameExist(txtFormName.Text);
            if (isFormExist)
            {
                MessageBox.Show(string.Format("Form {0} already Exist!", txtFormName.Text));
            }
            else
            {
                groupBox1.Visible = true;
                txtFormName.Enabled = false;
                btnAddForm.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (string item in chkList.Items)
            {
                string[] data = item.Split('|');
                Helper.AddToFormDirectory(txtFormName.Text, data[0].Trim(), data[1].Trim(), data[2].Trim(), data[3].Trim());
            }

            Helper.CreateNewTable(txtFormName.Text, chkList.Items);

            MessageBox.Show(string.Format("{0} Successfully Created!", txtFormName.Text));
            ResetControls();
            this.Hide();
        }

        private void ResetControls()
        {
            txtFormName.Text = "";
            txtFormName.Enabled = true;

            btnAddForm.Visible = true;

            groupBox1.Visible = false;

            cbControlList.SelectedIndex = 0;
            txtControlName.Text = "";

            txtMinVal.Text = "0";
            txtMaxVal.Text = "0";
            txtMinVal.Enabled = false;
            txtMaxVal.Enabled = false;

            rtbItems.Text = "";
            rtbItems.Visible = false;
            lblRule.Text = "";
            lblRule.Visible = false;

            chkList.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetControls();
            this.Hide();
        }
    }
}
