namespace oop8_orders
{
    partial class StatusForm
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
            this.btnHome = new System.Windows.Forms.Button();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelNewStatus = new System.Windows.Forms.Label();
            this.txtNewStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.Location = new System.Drawing.Point(389, 26);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(160, 49);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "На головну сторінку";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOrderNumber.Location = new System.Drawing.Point(187, 61);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(122, 26);
            this.txtOrderNumber.TabIndex = 16;
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusInfo.Location = new System.Drawing.Point(22, 22);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(309, 20);
            this.labelStatusInfo.TabIndex = 14;
            this.labelStatusInfo.Text = "Для змінення статусу введіть дані:";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeStatus.Location = new System.Drawing.Point(389, 87);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(160, 44);
            this.btnChangeStatus.TabIndex = 17;
            this.btnChangeStatus.Text = "Змінити";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click_1);
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderNumber.Location = new System.Drawing.Point(22, 64);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(159, 20);
            this.labelOrderNumber.TabIndex = 18;
            this.labelOrderNumber.Text = "Номер замовлення:";
            // 
            // labelNewStatus
            // 
            this.labelNewStatus.AutoSize = true;
            this.labelNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewStatus.Location = new System.Drawing.Point(22, 108);
            this.labelNewStatus.Name = "labelNewStatus";
            this.labelNewStatus.Size = new System.Drawing.Size(115, 20);
            this.labelNewStatus.TabIndex = 20;
            this.labelNewStatus.Text = "Новий статус:";
            // 
            // txtNewStatus
            // 
            this.txtNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewStatus.Location = new System.Drawing.Point(187, 105);
            this.txtNewStatus.Name = "txtNewStatus";
            this.txtNewStatus.Size = new System.Drawing.Size(122, 26);
            this.txtNewStatus.TabIndex = 19;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 149);
            this.Controls.Add(this.labelNewStatus);
            this.Controls.Add(this.txtNewStatus);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.labelStatusInfo);
            this.Controls.Add(this.btnHome);
            this.MaximumSize = new System.Drawing.Size(577, 188);
            this.MinimumSize = new System.Drawing.Size(577, 188);
            this.Name = "StatusForm";
            this.Text = "Змінення статусу замовлення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label labelStatusInfo;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label labelNewStatus;
        private System.Windows.Forms.TextBox txtNewStatus;
    }
}