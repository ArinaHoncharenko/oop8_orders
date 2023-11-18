namespace oop8_orders
{
    partial class AddClientForm
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
            this.labelAddInfo = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddInfo
            // 
            this.labelAddInfo.AutoSize = true;
            this.labelAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddInfo.Location = new System.Drawing.Point(22, 22);
            this.labelAddInfo.Name = "labelAddInfo";
            this.labelAddInfo.Size = new System.Drawing.Size(328, 20);
            this.labelAddInfo.TabIndex = 0;
            this.labelAddInfo.Text = "Для додавання клієнта введіть дані:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFullName.Location = new System.Drawing.Point(156, 66);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(239, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(22, 66);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(102, 20);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "ПІБ клієнта:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(22, 108);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(116, 44);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Контактний номер:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(156, 117);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(239, 26);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostalCode.Location = new System.Drawing.Point(22, 219);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(116, 25);
            this.labelPostalCode.TabIndex = 8;
            this.labelPostalCode.Text = "Номер пошти:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPostalCode.Location = new System.Drawing.Point(156, 218);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(239, 26);
            this.txtPostalCode.TabIndex = 7;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(22, 167);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(55, 20);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "Місто:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.Location = new System.Drawing.Point(156, 167);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(239, 26);
            this.txtCity.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(427, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 44);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 268);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelAddInfo);
            this.Name = "AddClientForm";
            this.Text = "Додавання клієнта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddInfo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnAdd;
    }
}