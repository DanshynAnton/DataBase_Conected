namespace DatBase_Conected
{
    partial class VehicleData
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
            this.tbVehIUD_sdof = new System.Windows.Forms.TextBox();
            this.tbVehIUD_fc = new System.Windows.Forms.TextBox();
            this.L_sdof = new System.Windows.Forms.Label();
            this.L_fc = new System.Windows.Forms.Label();
            this.L_lmc = new System.Windows.Forms.Label();
            this.tbVehIUD_lmc = new System.Windows.Forms.TextBox();
            this.L_mileage = new System.Windows.Forms.Label();
            this.L_plate = new System.Windows.Forms.Label();
            this.L_box_id = new System.Windows.Forms.Label();
            this.tbVehIUD_mileage = new System.Windows.Forms.TextBox();
            this.tbVehIUD_plate = new System.Windows.Forms.TextBox();
            this.tbVehIUD_box_id = new System.Windows.Forms.TextBox();
            this.L_veh_id = new System.Windows.Forms.Label();
            this.tbVehIUD_veh_id = new System.Windows.Forms.TextBox();
            this.bComplete = new System.Windows.Forms.Button();
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.gbNonReq = new System.Windows.Forms.GroupBox();
            this.gbRequired.SuspendLayout();
            this.gbNonReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVehIUD_sdof
            // 
            this.tbVehIUD_sdof.Location = new System.Drawing.Point(41, 198);
            this.tbVehIUD_sdof.Name = "tbVehIUD_sdof";
            this.tbVehIUD_sdof.Size = new System.Drawing.Size(237, 21);
            this.tbVehIUD_sdof.TabIndex = 48;
            // 
            // tbVehIUD_fc
            // 
            this.tbVehIUD_fc.Location = new System.Drawing.Point(41, 137);
            this.tbVehIUD_fc.Name = "tbVehIUD_fc";
            this.tbVehIUD_fc.Size = new System.Drawing.Size(237, 21);
            this.tbVehIUD_fc.TabIndex = 47;
            // 
            // L_sdof
            // 
            this.L_sdof.AutoSize = true;
            this.L_sdof.Location = new System.Drawing.Point(12, 180);
            this.L_sdof.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_sdof.Name = "L_sdof";
            this.L_sdof.Size = new System.Drawing.Size(280, 15);
            this.L_sdof.TabIndex = 46;
            this.L_sdof.Text = "Дата начала использования (start_day_of_use):";
            this.L_sdof.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // L_fc
            // 
            this.L_fc.AutoSize = true;
            this.L_fc.Location = new System.Drawing.Point(12, 119);
            this.L_fc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_fc.Name = "L_fc";
            this.L_fc.Size = new System.Drawing.Size(175, 15);
            this.L_fc.TabIndex = 45;
            this.L_fc.Text = "Цена за всё время (full_cost):";
            this.L_fc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // L_lmc
            // 
            this.L_lmc.AutoSize = true;
            this.L_lmc.Location = new System.Drawing.Point(12, 61);
            this.L_lmc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_lmc.Name = "L_lmc";
            this.L_lmc.Size = new System.Drawing.Size(266, 15);
            this.L_lmc.TabIndex = 44;
            this.L_lmc.Text = "Цена за прошедший месяц (last_month_cost):";
            this.L_lmc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbVehIUD_lmc
            // 
            this.tbVehIUD_lmc.Location = new System.Drawing.Point(41, 79);
            this.tbVehIUD_lmc.Name = "tbVehIUD_lmc";
            this.tbVehIUD_lmc.Size = new System.Drawing.Size(237, 21);
            this.tbVehIUD_lmc.TabIndex = 38;
            // 
            // L_mileage
            // 
            this.L_mileage.AutoSize = true;
            this.L_mileage.Location = new System.Drawing.Point(51, 34);
            this.L_mileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_mileage.Name = "L_mileage";
            this.L_mileage.Size = new System.Drawing.Size(108, 15);
            this.L_mileage.TabIndex = 35;
            this.L_mileage.Text = "Пробег (mileage):";
            // 
            // L_plate
            // 
            this.L_plate.AutoSize = true;
            this.L_plate.Location = new System.Drawing.Point(22, 68);
            this.L_plate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_plate.Name = "L_plate";
            this.L_plate.Size = new System.Drawing.Size(137, 15);
            this.L_plate.TabIndex = 35;
            this.L_plate.Text = "Номерной знак (plate):";
            // 
            // L_box_id
            // 
            this.L_box_id.AutoSize = true;
            this.L_box_id.Location = new System.Drawing.Point(47, 99);
            this.L_box_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_box_id.Name = "L_box_id";
            this.L_box_id.Size = new System.Drawing.Size(106, 15);
            this.L_box_id.TabIndex = 34;
            this.L_box_id.Text = "ID бокса (box_id):";
            // 
            // tbVehIUD_mileage
            // 
            this.tbVehIUD_mileage.Location = new System.Drawing.Point(164, 31);
            this.tbVehIUD_mileage.Name = "tbVehIUD_mileage";
            this.tbVehIUD_mileage.Size = new System.Drawing.Size(114, 21);
            this.tbVehIUD_mileage.TabIndex = 33;
            // 
            // tbVehIUD_plate
            // 
            this.tbVehIUD_plate.Location = new System.Drawing.Point(164, 65);
            this.tbVehIUD_plate.Name = "tbVehIUD_plate";
            this.tbVehIUD_plate.Size = new System.Drawing.Size(114, 21);
            this.tbVehIUD_plate.TabIndex = 32;
            // 
            // tbVehIUD_box_id
            // 
            this.tbVehIUD_box_id.Location = new System.Drawing.Point(164, 96);
            this.tbVehIUD_box_id.Name = "tbVehIUD_box_id";
            this.tbVehIUD_box_id.Size = new System.Drawing.Size(114, 21);
            this.tbVehIUD_box_id.TabIndex = 31;
            // 
            // L_veh_id
            // 
            this.L_veh_id.AutoSize = true;
            this.L_veh_id.Location = new System.Drawing.Point(47, 36);
            this.L_veh_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_veh_id.Name = "L_veh_id";
            this.L_veh_id.Size = new System.Drawing.Size(112, 15);
            this.L_veh_id.TabIndex = 25;
            this.L_veh_id.Text = "ID записи (veh_id):";
            // 
            // tbVehIUD_veh_id
            // 
            this.tbVehIUD_veh_id.Location = new System.Drawing.Point(164, 33);
            this.tbVehIUD_veh_id.Name = "tbVehIUD_veh_id";
            this.tbVehIUD_veh_id.Size = new System.Drawing.Size(114, 21);
            this.tbVehIUD_veh_id.TabIndex = 23;
            // 
            // bComplete
            // 
            this.bComplete.Location = new System.Drawing.Point(100, 383);
            this.bComplete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(115, 32);
            this.bComplete.TabIndex = 19;
            this.bComplete.Text = "Выполнить";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.L_plate);
            this.gbRequired.Controls.Add(this.L_veh_id);
            this.gbRequired.Controls.Add(this.tbVehIUD_plate);
            this.gbRequired.Controls.Add(this.tbVehIUD_box_id);
            this.gbRequired.Controls.Add(this.tbVehIUD_veh_id);
            this.gbRequired.Controls.Add(this.L_box_id);
            this.gbRequired.Location = new System.Drawing.Point(12, 12);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(292, 128);
            this.gbRequired.TabIndex = 51;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Обязательные данные";
            // 
            // gbNonReq
            // 
            this.gbNonReq.Controls.Add(this.tbVehIUD_lmc);
            this.gbNonReq.Controls.Add(this.L_lmc);
            this.gbNonReq.Controls.Add(this.L_fc);
            this.gbNonReq.Controls.Add(this.tbVehIUD_sdof);
            this.gbNonReq.Controls.Add(this.tbVehIUD_mileage);
            this.gbNonReq.Controls.Add(this.L_mileage);
            this.gbNonReq.Controls.Add(this.L_sdof);
            this.gbNonReq.Controls.Add(this.tbVehIUD_fc);
            this.gbNonReq.Location = new System.Drawing.Point(12, 146);
            this.gbNonReq.Name = "gbNonReq";
            this.gbNonReq.Size = new System.Drawing.Size(293, 231);
            this.gbNonReq.TabIndex = 52;
            this.gbNonReq.TabStop = false;
            this.gbNonReq.Text = "Необязательные данные (оставить пустыми)";
            // 
            // VehicleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.gbNonReq);
            this.Controls.Add(this.gbRequired);
            this.Controls.Add(this.bComplete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "VehicleData";
            this.Text = "VehicleData";
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.gbNonReq.ResumeLayout(false);
            this.gbNonReq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label L_sdof;
        private System.Windows.Forms.Label L_fc;
        private System.Windows.Forms.Label L_lmc;
        private System.Windows.Forms.Label L_box_id;
        private System.Windows.Forms.Button bComplete;
        public System.Windows.Forms.GroupBox gbRequired;
        public System.Windows.Forms.TextBox tbVehIUD_sdof;
        public System.Windows.Forms.TextBox tbVehIUD_fc;
        public System.Windows.Forms.TextBox tbVehIUD_lmc;
        public System.Windows.Forms.Label L_mileage;
        public System.Windows.Forms.Label L_plate;
        public System.Windows.Forms.TextBox tbVehIUD_mileage;
        public System.Windows.Forms.TextBox tbVehIUD_plate;
        public System.Windows.Forms.TextBox tbVehIUD_box_id;
        public System.Windows.Forms.Label L_veh_id;
        public System.Windows.Forms.TextBox tbVehIUD_veh_id;
        public System.Windows.Forms.GroupBox gbNonReq;
    }
}