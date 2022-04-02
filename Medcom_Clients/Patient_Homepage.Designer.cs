
namespace Medcom_Clients
{
    partial class Patient_Homepage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.home_button = new System.Windows.Forms.Button();
            this.bill_button = new System.Windows.Forms.Button();
            this.doctor_button = new System.Windows.Forms.Button();
            this.Profile_button = new System.Windows.Forms.Button();
            this.nine_one_one_button = new System.Windows.Forms.Button();
            this.Pharmacy_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pharmacy_button);
            this.groupBox1.Controls.Add(this.nine_one_one_button);
            this.groupBox1.Controls.Add(this.Profile_button);
            this.groupBox1.Controls.Add(this.doctor_button);
            this.groupBox1.Controls.Add(this.bill_button);
            this.groupBox1.Controls.Add(this.home_button);
            this.groupBox1.Location = new System.Drawing.Point(-5, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(6, 11);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(61, 45);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            // 
            // bill_button
            // 
            this.bill_button.Location = new System.Drawing.Point(73, 11);
            this.bill_button.Name = "bill_button";
            this.bill_button.Size = new System.Drawing.Size(61, 45);
            this.bill_button.TabIndex = 1;
            this.bill_button.Text = "Bills";
            this.bill_button.UseVisualStyleBackColor = true;
            this.bill_button.Click += new System.EventHandler(this.bill_button_Click);
            // 
            // doctor_button
            // 
            this.doctor_button.Location = new System.Drawing.Point(140, 11);
            this.doctor_button.Name = "doctor_button";
            this.doctor_button.Size = new System.Drawing.Size(61, 45);
            this.doctor_button.TabIndex = 2;
            this.doctor_button.Text = "doctor";
            this.doctor_button.UseVisualStyleBackColor = true;
            // 
            // Profile_button
            // 
            this.Profile_button.Location = new System.Drawing.Point(339, 11);
            this.Profile_button.Name = "Profile_button";
            this.Profile_button.Size = new System.Drawing.Size(61, 45);
            this.Profile_button.TabIndex = 3;
            this.Profile_button.Text = "Profile";
            this.Profile_button.UseVisualStyleBackColor = true;
            // 
            // nine_one_one_button
            // 
            this.nine_one_one_button.Location = new System.Drawing.Point(207, 11);
            this.nine_one_one_button.Name = "nine_one_one_button";
            this.nine_one_one_button.Size = new System.Drawing.Size(61, 45);
            this.nine_one_one_button.TabIndex = 4;
            this.nine_one_one_button.Text = "911";
            this.nine_one_one_button.UseVisualStyleBackColor = true;
            // 
            // Pharmacy_button
            // 
            this.Pharmacy_button.Location = new System.Drawing.Point(272, 11);
            this.Pharmacy_button.Name = "Pharmacy_button";
            this.Pharmacy_button.Size = new System.Drawing.Size(61, 45);
            this.Pharmacy_button.TabIndex = 5;
            this.Pharmacy_button.Text = "Pharmacy";
            this.Pharmacy_button.UseVisualStyleBackColor = true;
            // 
            // Patient_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 683);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(420, 730);
            this.MinimumSize = new System.Drawing.Size(420, 730);
            this.Name = "Patient_Homepage";
            this.Text = "Patient_Homepage";
            this.Load += new System.EventHandler(this.Patient_Homepage_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nine_one_one_button;
        private System.Windows.Forms.Button Profile_button;
        private System.Windows.Forms.Button doctor_button;
        private System.Windows.Forms.Button bill_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button Pharmacy_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}