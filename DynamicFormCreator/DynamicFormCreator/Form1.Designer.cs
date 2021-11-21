
namespace DynamicFormCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSelectMain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbSelectMain
            // 
            this.cbSelectMain.FormattingEnabled = true;
            this.cbSelectMain.Location = new System.Drawing.Point(153, 31);
            this.cbSelectMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectMain.Name = "cbSelectMain";
            this.cbSelectMain.Size = new System.Drawing.Size(180, 23);
            this.cbSelectMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Form Action";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(367, 31);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 22);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 617);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Create Or Update";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel1;
    }
}

