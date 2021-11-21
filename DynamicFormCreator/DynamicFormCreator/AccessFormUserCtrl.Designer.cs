
namespace DynamicFormCreator
{
    partial class AccessFormUserCtrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbForms = new System.Windows.Forms.ComboBox();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Form to Access:";
            // 
            // cbForms
            // 
            this.cbForms.FormattingEnabled = true;
            this.cbForms.Location = new System.Drawing.Point(160, 22);
            this.cbForms.Name = "cbForms";
            this.cbForms.Size = new System.Drawing.Size(154, 23);
            this.cbForms.TabIndex = 1;
            this.cbForms.DropDown += new System.EventHandler(this.cbForms_DropDown);
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(353, 22);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenForm.TabIndex = 2;
            this.btnOpenForm.Text = "Open Form";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // AccessFormUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.cbForms);
            this.Controls.Add(this.label1);
            this.Name = "AccessFormUserCtrl";
            this.Size = new System.Drawing.Size(569, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbForms;
        private System.Windows.Forms.Button btnOpenForm;
    }
}
