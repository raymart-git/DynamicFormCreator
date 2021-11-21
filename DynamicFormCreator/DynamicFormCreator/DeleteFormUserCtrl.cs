using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicFormCreator
{
    public partial class DeleteFormUserCtrl : UserControl
    {
        public DeleteFormUserCtrl()
        {
            InitializeComponent();
        }

        private void cbForms_DropDown(object sender, System.EventArgs e)
        {
            List<string> formList = Helper.GetListOfForms();
            cbForms.Items.Clear();
            foreach (var item in formList)
            {
                cbForms.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbForms.SelectedItem == null) return;

            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to delete {0}?", cbForms.SelectedItem), "Delete Form", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Helper.DeleteFormData(cbForms.SelectedItem.ToString());
                Helper.DropTable(cbForms.SelectedItem.ToString());

                MessageBox.Show(string.Format("{0} has been Deleted", cbForms.SelectedItem));
                cbForms.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
