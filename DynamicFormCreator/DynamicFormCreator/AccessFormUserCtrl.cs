using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicFormCreator
{
    public partial class AccessFormUserCtrl : UserControl
    {
        public AccessFormUserCtrl()
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

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            if (cbForms.SelectedItem == null) return;

            List<FormDirectory> formControls = Helper.GetFormControls(cbForms.SelectedItem.ToString());
            Form frm = GenerateForm(formControls);
            frm.Show();
        }

        private Form GenerateForm(List<FormDirectory> formControls)
        {
            Form form = new Form();
            form.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(1000, 450);
            form.Name = formControls[0].FormName;
            form.Text = formControls[0].FormName;

            int labelX = 12;
            int labelY = 23;

            int ctrlX = 123;
            int ctrlY = 23;


            DataGridView dataGridView = LoadGrid(formControls[0].FormName, ctrlX + 250, ctrlY);
            form.Controls.Add(dataGridView);

            foreach (FormDirectory frmCtrl in formControls)
            {
                Label lblCtrl = GenerateLabel(frmCtrl, labelX, labelY);
                form.Controls.Add(lblCtrl);

                if (frmCtrl.ControlType == "TextBox-FreeText")
                {
                    TextBox txtBox = GenerateTextBox(frmCtrl, ctrlX, ctrlY);
                    form.Controls.Add(txtBox);
                }
                else if (frmCtrl.ControlType == "TextBox-Numeric")
                {
                    NumericUpDown numTextBox = GenerateNumericUpDown(frmCtrl, ctrlX, ctrlY);
                    form.Controls.Add(numTextBox);
                }
                else if (frmCtrl.ControlType == "DatePicker")
                {
                    DateTimePicker dateTimePicker = GenerateDateTimePicker(frmCtrl, ctrlX, ctrlY);
                    form.Controls.Add(dateTimePicker);
                }
                else if (frmCtrl.ControlType == "ComboBox")
                {
                    ComboBox comboBox = GenerateComboBox(frmCtrl, ctrlX, ctrlY);
                    form.Controls.Add(comboBox);
                }
                else if (frmCtrl.ControlType == "RadioButton")
                {
                    GroupBox radioButtonList = GenerateRadioButton(frmCtrl, ctrlX, ctrlY);
                    form.Controls.Add(radioButtonList);
                }

                labelY = labelY + 50;
                ctrlY = ctrlY + 50;
            }

            Button btnSave = SaveButton(ctrlX, ctrlY);
            form.Controls.Add(btnSave);

            Button btnCancel = CancelButton(ctrlX + btnSave.Width + 50, ctrlY);
            form.Controls.Add(btnCancel);

            return form;
        }

        private Button SaveButton(int x, int y)
        {
            Button button = new Button();

            button.Location = new System.Drawing.Point(x, y);
            button.Name = "btnSave";
            button.Size = new System.Drawing.Size(75, 23);
            button.TabIndex = 0;
            button.Text = "Save";
            button.UseVisualStyleBackColor = true;
            button.Click += ButtonSave_Click;


            return button;
        }

        private Button CancelButton(int x, int y)
        {
            Button button = new Button();

            button.Location = new System.Drawing.Point(x, y);
            button.Name = "btnCancel";
            button.Size = new System.Drawing.Size(75, 23);
            button.TabIndex = 0;
            button.Text = "Cancel";
            button.UseVisualStyleBackColor = true;
            button.Click += ButtonCancel_Click;


            return button;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            string queryColumns = "";
            string queryValues = "";
            DataGridView dataGridView = new DataGridView();

            foreach (Control control in x.Parent.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    var controlName = control.Name.Replace("txt__", "").Trim();
                    var controlValue = control.Text;

                    queryColumns += string.Format(" {0}, ", controlName);
                    queryValues += string.Format(" '{0}', ", control.Text);
                }
                else if (control.GetType() == typeof(NumericUpDown))
                {
                    var controlName = control.Name.Replace("txt__", "").Trim();
                    var controlValue = control.Text;

                    queryColumns += string.Format(" {0}, ", controlName);
                    queryValues += string.Format(" '{0}', ", control.Text);
                }
                else if (control.GetType() == typeof(DateTimePicker))
                {
                    var controlName = control.Name.Replace("dt__", "").Trim();
                    var controlValue = control.Text;

                    queryColumns += string.Format(" {0}, ", controlName);
                    queryValues += string.Format(" '{0}', ", control.Text);
                }
                else if (control.GetType() == typeof(ComboBox))
                {
                    var controlName = control.Name.Replace("cb__", "").Trim();
                    var controlValue = control.Text;

                    queryColumns += string.Format(" {0}, ", controlName);
                    queryValues += string.Format(" '{0}', ", control.Text);
                }
                else if (control.GetType() == typeof(GroupBox))
                {
                    GroupBox gb = ((GroupBox)control);
                    foreach (Control grpBoxCtrl in gb.Controls)
                    {
                        if (grpBoxCtrl.GetType() == typeof(RadioButton))
                        {
                            RadioButton rb = ((RadioButton)grpBoxCtrl);
                            if (rb.Checked)
                            {
                                var controlName = grpBoxCtrl.Name.Replace("rb__", "").Trim();
                                string[] splitName = controlName.Split('_');
                                var controlName_final = splitName[0];

                                queryColumns += string.Format(" {0}, ", controlName_final);
                                queryValues += string.Format(" '{0}', ", grpBoxCtrl.Text);
                            }
                        }
                    }
                }
                else if (control.GetType() == typeof(DataGridView))
                {
                    dataGridView = (DataGridView)control;
                }
            }

            queryColumns = queryColumns.Trim();
            queryValues = queryValues.Trim();

            if (!String.IsNullOrEmpty(queryColumns) && !String.IsNullOrEmpty(queryValues))
            {
                if (queryColumns[queryColumns.Length - 1] == ',')
                {
                    queryColumns = queryColumns.Remove(queryColumns.Length - 1);
                }
                if (queryValues[queryValues.Length - 1] == ',')
                {
                    queryValues = queryValues.Remove(queryValues.Length - 1);
                }
            }

            Helper.InsertFormData(x.Parent.Name, queryColumns, queryValues);
            dataGridView.DataSource = Helper.GetFormData(x.Parent.Name);
            MessageBox.Show(string.Format("{0} Data Has Been Saved!", x.Parent.Name));
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            Form frm = (Form)x.Parent;
            frm.Close();
        }

        private TextBox GenerateTextBox(FormDirectory formControl, int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Name = string.Format("txt__{0}", formControl.ControlName);
            textBox.Size = new System.Drawing.Size(200, 23);
            textBox.Visible = true;

            if (!String.IsNullOrEmpty(formControl.ControlValueLimit.Trim()))
            {
                string[] minMax = formControl.ControlValueLimit.Split('>');
                int min = Convert.ToInt32(minMax[0]);
                int max = Convert.ToInt32(minMax[1]);

                textBox.MaxLength = max;
            }

            return textBox;
        }

        private NumericUpDown GenerateNumericUpDown(FormDirectory formControl, int x, int y)
        {
            NumericUpDown numericTextBox = new NumericUpDown();
            numericTextBox.Location = new System.Drawing.Point(x, y);
            numericTextBox.Name = string.Format("txt__{0}", formControl.ControlName);
            numericTextBox.Size = new System.Drawing.Size(200, 23);
            numericTextBox.Visible = true;

            if (!String.IsNullOrEmpty(formControl.ControlValueLimit.Trim()))
            {
                string[] minMax = formControl.ControlValueLimit.Split('>');
                int min = Convert.ToInt32(minMax[0]);
                int max = Convert.ToInt32(minMax[1]);

                numericTextBox.Minimum = min;
                numericTextBox.Maximum = max;
            }

            return numericTextBox;
        }

        private ComboBox GenerateComboBox(FormDirectory formControl, int x, int y)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.FormattingEnabled = true;
            comboBox.Location = new System.Drawing.Point(x, y);
            comboBox.Name = string.Format("cb__{0}", formControl.ControlName);
            comboBox.Size = new System.Drawing.Size(200, 23);
            comboBox.Visible = true;

            if (!String.IsNullOrEmpty(formControl.ControlOptions.Trim()))
            {
                string[] options = formControl.ControlOptions.Split(',');
                foreach (string option in options)
                {
                    if (!String.IsNullOrEmpty(option.Trim()))
                    {
                        comboBox.Items.Add(option.Trim());
                    }
                }
            }

            return comboBox;
        }

        private DateTimePicker GenerateDateTimePicker(FormDirectory formControl, int x, int y)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Location = new System.Drawing.Point(x, y);
            dateTimePicker.Name = string.Format("dt__{0}", formControl.ControlName);
            dateTimePicker.Size = new System.Drawing.Size(200, 23);
            dateTimePicker.Visible = true;

            return dateTimePicker;
        }

        private GroupBox GenerateRadioButton(FormDirectory formControl, int x, int y)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new System.Drawing.Point(x, y);
            groupBox.Name = "groupBox1";

            int sumAllRadioButtonWidth = 0;

            if (!String.IsNullOrEmpty(formControl.ControlOptions.Trim()))
            {
                string[] options = formControl.ControlOptions.Split(',');
                int radioX = 5;
                int previousRadioButtonWidth = 0;
                foreach (string option in options)
                {
                    if (!String.IsNullOrEmpty(option.Trim()))
                    {
                        RadioButton radioButton = new RadioButton();
                        radioButton.AutoSize = true;
                        radioButton.Location = new System.Drawing.Point(radioX, 5);
                        radioButton.Name = string.Format("rb__{0}_{1}", formControl.ControlName, option.Trim());
                        radioButton.Text = option.Trim();
                        radioButton.UseVisualStyleBackColor = false;

                        groupBox.Controls.Add(radioButton);

                        previousRadioButtonWidth = radioButton.Width;
                        radioX = radioX + previousRadioButtonWidth;
                        sumAllRadioButtonWidth = sumAllRadioButtonWidth + radioButton.Width;
                    }
                }
            }

            groupBox.Size = new System.Drawing.Size(sumAllRadioButtonWidth + 10, 20);
            return groupBox;
        }

        private Label GenerateLabel(FormDirectory formControl, int x, int y)
        {
            Label label = new Label();
            label.Location = new System.Drawing.Point(x, y);
            label.Name = string.Format("lbl{0}", formControl.ControlName);
            label.Text = formControl.ControlName;
            label.Size = new System.Drawing.Size(100, 23);
            label.Visible = true;
            return label;
        }

        private DataGridView LoadGrid(string formName, int x, int y)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new System.Drawing.Point(x, y);
            dataGridView.Name = "dataGridView1";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(600, 150);
            dataGridView.DataSource = Helper.GetFormData(formName);
            dataGridView.Visible = true;

            return dataGridView;
        }
    }
}
