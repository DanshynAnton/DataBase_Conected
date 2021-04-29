namespace DatBase_Conected
{
    partial class RepairData
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
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.tbRepUID_repair_id = new System.Windows.Forms.TextBox();
            this.L_repair_id = new System.Windows.Forms.Label();
            this.gbNonReq = new System.Windows.Forms.GroupBox();
            this.tbRepUID_crew_id = new System.Windows.Forms.TextBox();
            this.tbRepUID_vehicle_id = new System.Windows.Forms.TextBox();
            this.L_repair_cost = new System.Windows.Forms.Label();
            this.L_crew_id = new System.Windows.Forms.Label();
            this.L_vehicle_id = new System.Windows.Forms.Label();
            this.tbRepUID_repair_cost = new System.Windows.Forms.TextBox();
            this.bComplete = new System.Windows.Forms.Button();
            this.gbRequired.SuspendLayout();
            this.gbNonReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.tbRepUID_repair_id);
            this.gbRequired.Controls.Add(this.L_repair_id);
            this.gbRequired.Location = new System.Drawing.Point(12, 12);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(264, 59);
            this.gbRequired.TabIndex = 52;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Обязательные данные";
            // 
            // tbRepUID_repair_id
            // 
            this.tbRepUID_repair_id.Location = new System.Drawing.Point(153, 29);
            this.tbRepUID_repair_id.Name = "tbRepUID_repair_id";
            this.tbRepUID_repair_id.Size = new System.Drawing.Size(98, 20);
            this.tbRepUID_repair_id.TabIndex = 23;
            // 
            // L_repair_id
            // 
            this.L_repair_id.AutoSize = true;
            this.L_repair_id.Location = new System.Drawing.Point(39, 32);
            this.L_repair_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_repair_id.Name = "L_repair_id";
            this.L_repair_id.Size = new System.Drawing.Size(109, 13);
            this.L_repair_id.TabIndex = 25;
            this.L_repair_id.Text = "ID записи (repair_id):";
            // 
            // gbNonReq
            // 
            this.gbNonReq.Controls.Add(this.tbRepUID_crew_id);
            this.gbNonReq.Controls.Add(this.tbRepUID_vehicle_id);
            this.gbNonReq.Controls.Add(this.L_repair_cost);
            this.gbNonReq.Controls.Add(this.L_crew_id);
            this.gbNonReq.Controls.Add(this.L_vehicle_id);
            this.gbNonReq.Controls.Add(this.tbRepUID_repair_cost);
            this.gbNonReq.Location = new System.Drawing.Point(12, 77);
            this.gbNonReq.Name = "gbNonReq";
            this.gbNonReq.Size = new System.Drawing.Size(264, 122);
            this.gbNonReq.TabIndex = 53;
            this.gbNonReq.TabStop = false;
            this.gbNonReq.Text = "Необязательные данные (оставить пустыми)";
            // 
            // tbRepUID_crew_id
            // 
            this.tbRepUID_crew_id.Location = new System.Drawing.Point(153, 25);
            this.tbRepUID_crew_id.Name = "tbRepUID_crew_id";
            this.tbRepUID_crew_id.Size = new System.Drawing.Size(98, 20);
            this.tbRepUID_crew_id.TabIndex = 31;
            // 
            // tbRepUID_vehicle_id
            // 
            this.tbRepUID_vehicle_id.Location = new System.Drawing.Point(153, 61);
            this.tbRepUID_vehicle_id.Name = "tbRepUID_vehicle_id";
            this.tbRepUID_vehicle_id.Size = new System.Drawing.Size(98, 20);
            this.tbRepUID_vehicle_id.TabIndex = 32;
            // 
            // L_repair_cost
            // 
            this.L_repair_cost.AutoSize = true;
            this.L_repair_cost.Location = new System.Drawing.Point(5, 98);
            this.L_repair_cost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_repair_cost.Name = "L_repair_cost";
            this.L_repair_cost.Size = new System.Drawing.Size(143, 13);
            this.L_repair_cost.TabIndex = 35;
            this.L_repair_cost.Text = "Цена ремонта (repair_cost):";
            // 
            // L_crew_id
            // 
            this.L_crew_id.AutoSize = true;
            this.L_crew_id.Location = new System.Drawing.Point(35, 28);
            this.L_crew_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_crew_id.Name = "L_crew_id";
            this.L_crew_id.Size = new System.Drawing.Size(113, 13);
            this.L_crew_id.TabIndex = 34;
            this.L_crew_id.Text = "ID бригады (crew_id):";
            // 
            // L_vehicle_id
            // 
            this.L_vehicle_id.AutoSize = true;
            this.L_vehicle_id.Location = new System.Drawing.Point(24, 64);
            this.L_vehicle_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_vehicle_id.Name = "L_vehicle_id";
            this.L_vehicle_id.Size = new System.Drawing.Size(124, 13);
            this.L_vehicle_id.TabIndex = 35;
            this.L_vehicle_id.Text = "ID бригады (vehicle_id):";
            // 
            // tbRepUID_repair_cost
            // 
            this.tbRepUID_repair_cost.Location = new System.Drawing.Point(153, 95);
            this.tbRepUID_repair_cost.Name = "tbRepUID_repair_cost";
            this.tbRepUID_repair_cost.Size = new System.Drawing.Size(98, 20);
            this.tbRepUID_repair_cost.TabIndex = 33;
            // 
            // bComplete
            // 
            this.bComplete.Location = new System.Drawing.Point(86, 205);
            this.bComplete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(115, 32);
            this.bComplete.TabIndex = 54;
            this.bComplete.Text = "Выполнить";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // RepairData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.bComplete);
            this.Controls.Add(this.gbNonReq);
            this.Controls.Add(this.gbRequired);
            this.Name = "RepairData";
            this.Text = "RepairData";
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.gbNonReq.ResumeLayout(false);
            this.gbNonReq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbRequired;
        public System.Windows.Forms.GroupBox gbNonReq;
        private System.Windows.Forms.Button bComplete;
        private System.Windows.Forms.Label L_repair_id;
        private System.Windows.Forms.TextBox tbRepUID_crew_id;
        private System.Windows.Forms.TextBox tbRepUID_vehicle_id;
        private System.Windows.Forms.Label L_repair_cost;
        private System.Windows.Forms.Label L_crew_id;
        private System.Windows.Forms.Label L_vehicle_id;
        private System.Windows.Forms.TextBox tbRepUID_repair_cost;
        public System.Windows.Forms.TextBox tbRepUID_repair_id;
    }
}