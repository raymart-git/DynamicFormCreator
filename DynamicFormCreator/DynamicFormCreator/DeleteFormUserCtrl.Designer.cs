
namespace DynamicFormCreator
{
    partial class DeleteFormUserCtrl
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbForms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(371, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Form";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbForms
            // 
            this.cbForms.FormattingEnabled = true;
            this.cbForms.Location = new System.Drawing.Point(178, 36);
            this.cbForms.Name = "cbForms";
            this.cbForms.Size = new System.Drawing.Size(154, 23);
            this.cbForms.TabIndex = 4;
            this.cbForms.DropDown += new System.EventHandler(this.cbForms_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Form to Delete";
            // 
            // DeleteFormUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbForms);
            this.Controls.Add(this.label1);
            this.Name = "DeleteFormUserCtrl";
            this.Size = new System.Drawing.Size(480, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbForms;
        private System.Windows.Forms.Label label1;
    }
}
