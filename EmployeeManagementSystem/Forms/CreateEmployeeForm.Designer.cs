namespace EmployeeManagementSystem
{
    partial class CreateEmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmployeeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtEPhone = new System.Windows.Forms.TextBox();
            this.txtEDep = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Phone";
            // 
            // txtEName
            // 
            this.txtEName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEName.Location = new System.Drawing.Point(265, 147);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(235, 22);
            this.txtEName.TabIndex = 3;
            // 
            // txtEPhone
            // 
            this.txtEPhone.Location = new System.Drawing.Point(265, 225);
            this.txtEPhone.Name = "txtEPhone";
            this.txtEPhone.Size = new System.Drawing.Size(235, 22);
            this.txtEPhone.TabIndex = 4;
            // 
            // txtEDep
            // 
            this.txtEDep.Location = new System.Drawing.Point(265, 187);
            this.txtEDep.Name = "txtEDep";
            this.txtEDep.Size = new System.Drawing.Size(235, 22);
            this.txtEDep.TabIndex = 5;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(279, 275);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(85, 33);
            this.bttnAdd.TabIndex = 6;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(389, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Back";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 429);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.txtEDep);
            this.Controls.Add(this.txtEPhone);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtEPhone;
        private System.Windows.Forms.TextBox txtEDep;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}