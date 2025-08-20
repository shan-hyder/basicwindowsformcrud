
namespace newform
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.AgeTextbox = new System.Windows.Forms.TextBox();
            this.AddressRichTextbox = new System.Windows.Forms.RichTextBox();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.CreateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ManageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(277, 62);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(307, 26);
            this.Nametextbox.TabIndex = 4;
            // 
            // AgeTextbox
            // 
            this.AgeTextbox.Location = new System.Drawing.Point(277, 126);
            this.AgeTextbox.Name = "AgeTextbox";
            this.AgeTextbox.Size = new System.Drawing.Size(307, 26);
            this.AgeTextbox.TabIndex = 5;
            // 
            // AddressRichTextbox
            // 
            this.AddressRichTextbox.Location = new System.Drawing.Point(286, 192);
            this.AddressRichTextbox.Name = "AddressRichTextbox";
            this.AddressRichTextbox.Size = new System.Drawing.Size(298, 59);
            this.AddressRichTextbox.TabIndex = 7;
            this.AddressRichTextbox.Text = "";
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Checked = true;
            this.RadMale.Location = new System.Drawing.Point(15, 39);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(68, 24);
            this.RadMale.TabIndex = 8;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Location = new System.Drawing.Point(190, 39);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(87, 24);
            this.RadFemale.TabIndex = 9;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(322, 399);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(85, 29);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadMale);
            this.groupBox1.Controls.Add(this.RadFemale);
            this.groupBox1.Location = new System.Drawing.Point(286, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inserted";
            this.label5.Visible = false;
            // 
            // ManageButton
            // 
            this.ManageButton.Location = new System.Drawing.Point(527, 399);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(85, 29);
            this.ManageButton.TabIndex = 13;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 507);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AddressRichTextbox);
            this.Controls.Add(this.AgeTextbox);
            this.Controls.Add(this.Nametextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.TextBox AgeTextbox;
        private System.Windows.Forms.RichTextBox AddressRichTextbox;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ManageButton;
    }
}

