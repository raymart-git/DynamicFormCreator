
namespace DynamicFormCreator
{
    partial class CreateControlUserCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaxVal = new System.Windows.Forms.NumericUpDown();
            this.txtMinVal = new System.Windows.Forms.NumericUpDown();
            this.lblMaxVal = new System.Windows.Forms.Label();
            this.lblMinVal = new System.Windows.Forms.Label();
            this.chkLimit = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.lblRule = new System.Windows.Forms.Label();
            this.rtbItems = new System.Windows.Forms.RichTextBox();
            this.txtControlName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddControl = new System.Windows.Forms.Button();
            this.cbControlList = new System.Windows.Forms.ComboBox();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinVal)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(125, 19);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(176, 23);
            this.txtFormName.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtMaxVal);
            this.groupBox1.Controls.Add(this.txtMinVal);
            this.groupBox1.Controls.Add(this.lblMaxVal);
            this.groupBox1.Controls.Add(this.lblMinVal);
            this.groupBox1.Controls.Add(this.chkLimit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkList);
            this.groupBox1.Controls.Add(this.lblRule);
            this.groupBox1.Controls.Add(this.rtbItems);
            this.groupBox1.Controls.Add(this.txtControlName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddControl);
            this.groupBox1.Controls.Add(this.cbControlList);
            this.groupBox1.Location = new System.Drawing.Point(35, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 358);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // txtMaxVal
            // 
            this.txtMaxVal.Enabled = false;
            this.txtMaxVal.Location = new System.Drawing.Point(337, 123);
            this.txtMaxVal.Name = "txtMaxVal";
            this.txtMaxVal.Size = new System.Drawing.Size(42, 23);
            this.txtMaxVal.TabIndex = 25;
            // 
            // txtMinVal
            // 
            this.txtMinVal.Enabled = false;
            this.txtMinVal.Location = new System.Drawing.Point(187, 121);
            this.txtMinVal.Name = "txtMinVal";
            this.txtMinVal.Size = new System.Drawing.Size(42, 23);
            this.txtMinVal.TabIndex = 24;
            // 
            // lblMaxVal
            // 
            this.lblMaxVal.AutoSize = true;
            this.lblMaxVal.Location = new System.Drawing.Point(273, 126);
            this.lblMaxVal.Name = "lblMaxVal";
            this.lblMaxVal.Size = new System.Drawing.Size(61, 15);
            this.lblMaxVal.TabIndex = 22;
            this.lblMaxVal.Text = "MaxValue:";
            // 
            // lblMinVal
            // 
            this.lblMinVal.AutoSize = true;
            this.lblMinVal.Location = new System.Drawing.Point(126, 126);
            this.lblMinVal.Name = "lblMinVal";
            this.lblMinVal.Size = new System.Drawing.Size(59, 15);
            this.lblMinVal.TabIndex = 21;
            this.lblMinVal.Text = "MinValue:";
            // 
            // chkLimit
            // 
            this.chkLimit.AutoSize = true;
            this.chkLimit.Location = new System.Drawing.Point(17, 125);
            this.chkLimit.Name = "chkLimit";
            this.chkLimit.Size = new System.Drawing.Size(103, 19);
            this.chkLimit.TabIndex = 20;
            this.chkLimit.Text = "Set Value Limit";
            this.chkLimit.UseVisualStyleBackColor = true;
            this.chkLimit.CheckedChanged += new System.EventHandler(this.chkLimit_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(804, 319);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(513, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Note: Checked Controls to Be Added on New Form before Pressing Save";
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(513, 65);
            this.chkList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(461, 238);
            this.chkList.TabIndex = 17;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.ForeColor = System.Drawing.Color.Blue;
            this.lblRule.Location = new System.Drawing.Point(29, 263);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(30, 15);
            this.lblRule.TabIndex = 16;
            this.lblRule.Text = "Rule";
            this.lblRule.Visible = false;
            // 
            // rtbItems
            // 
            this.rtbItems.Location = new System.Drawing.Point(187, 171);
            this.rtbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbItems.Name = "rtbItems";
            this.rtbItems.Size = new System.Drawing.Size(294, 92);
            this.rtbItems.TabIndex = 15;
            this.rtbItems.Text = "";
            this.rtbItems.Visible = false;
            // 
            // txtControlName
            // 
            this.txtControlName.Location = new System.Drawing.Point(187, 86);
            this.txtControlName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtControlName.Name = "txtControlName";
            this.txtControlName.Size = new System.Drawing.Size(176, 23);
            this.txtControlName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Control Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Control To Add";
            // 
            // btnAddControl
            // 
            this.btnAddControl.Location = new System.Drawing.Point(389, 54);
            this.btnAddControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddControl.Name = "btnAddControl";
            this.btnAddControl.Size = new System.Drawing.Size(52, 21);
            this.btnAddControl.TabIndex = 11;
            this.btnAddControl.Text = "Add";
            this.btnAddControl.UseVisualStyleBackColor = true;
            this.btnAddControl.Click += new System.EventHandler(this.btnAddControl_Click);
            // 
            // cbControlList
            // 
            this.cbControlList.FormattingEnabled = true;
            this.cbControlList.Location = new System.Drawing.Point(187, 54);
            this.cbControlList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbControlList.Name = "cbControlList";
            this.cbControlList.Size = new System.Drawing.Size(176, 23);
            this.cbControlList.TabIndex = 10;
            // 
            // btnAddForm
            // 
            this.btnAddForm.Location = new System.Drawing.Point(322, 18);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddForm.TabIndex = 13;
            this.btnAddForm.Text = "Add Form";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(899, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateControlUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateControlUserCtrl";
            this.Size = new System.Drawing.Size(1144, 438);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.RichTextBox rtbItems;
        private System.Windows.Forms.TextBox txtControlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddControl;
        private System.Windows.Forms.ComboBox cbControlList;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Label lblMaxVal;
        private System.Windows.Forms.Label lblMinVal;
        private System.Windows.Forms.CheckBox chkLimit;
        private System.Windows.Forms.NumericUpDown txtMaxVal;
        private System.Windows.Forms.NumericUpDown txtMinVal;
        private System.Windows.Forms.Button btnCancel;
    }
}
