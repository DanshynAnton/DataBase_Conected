namespace DatBase_Conected
{
    partial class PathData
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
            this.L_path_id = new System.Windows.Forms.Label();
            this.tbPathIUD_path_id = new System.Windows.Forms.TextBox();
            this.tbPathIUD_passangers = new System.Windows.Forms.TextBox();
            this.L_passangers = new System.Windows.Forms.Label();
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.bComplete = new System.Windows.Forms.Button();
            this.gbNonReq = new System.Windows.Forms.GroupBox();
            this.L_points = new System.Windows.Forms.Label();
            this.lbPathIUD_points = new System.Windows.Forms.ListBox();
            this.gbRequired.SuspendLayout();
            this.gbNonReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_path_id
            // 
            this.L_path_id.AutoSize = true;
            this.L_path_id.Location = new System.Drawing.Point(38, 30);
            this.L_path_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_path_id.Name = "L_path_id";
            this.L_path_id.Size = new System.Drawing.Size(104, 13);
            this.L_path_id.TabIndex = 25;
            this.L_path_id.Text = "ID записи (path_id):";
            // 
            // tbPathIUD_path_id
            // 
            this.tbPathIUD_path_id.Location = new System.Drawing.Point(147, 30);
            this.tbPathIUD_path_id.Name = "tbPathIUD_path_id";
            this.tbPathIUD_path_id.Size = new System.Drawing.Size(114, 20);
            this.tbPathIUD_path_id.TabIndex = 23;
            // 
            // tbPathIUD_passangers
            // 
            this.tbPathIUD_passangers.Location = new System.Drawing.Point(147, 28);
            this.tbPathIUD_passangers.Name = "tbPathIUD_passangers";
            this.tbPathIUD_passangers.Size = new System.Drawing.Size(114, 20);
            this.tbPathIUD_passangers.TabIndex = 33;
            // 
            // L_passangers
            // 
            this.L_passangers.AutoSize = true;
            this.L_passangers.Location = new System.Drawing.Point(5, 31);
            this.L_passangers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_passangers.Name = "L_passangers";
            this.L_passangers.Size = new System.Drawing.Size(137, 13);
            this.L_passangers.TabIndex = 35;
            this.L_passangers.Text = "Пассажиров (passangers):";
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.L_path_id);
            this.gbRequired.Controls.Add(this.tbPathIUD_path_id);
            this.gbRequired.Location = new System.Drawing.Point(12, 12);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(273, 67);
            this.gbRequired.TabIndex = 54;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Обязательные данные";
            // 
            // bComplete
            // 
            this.bComplete.Location = new System.Drawing.Point(86, 327);
            this.bComplete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(115, 32);
            this.bComplete.TabIndex = 53;
            this.bComplete.Text = "Выполнить";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // gbNonReq
            // 
            this.gbNonReq.Controls.Add(this.L_points);
            this.gbNonReq.Controls.Add(this.lbPathIUD_points);
            this.gbNonReq.Controls.Add(this.tbPathIUD_passangers);
            this.gbNonReq.Controls.Add(this.L_passangers);
            this.gbNonReq.Location = new System.Drawing.Point(12, 85);
            this.gbNonReq.Name = "gbNonReq";
            this.gbNonReq.Size = new System.Drawing.Size(273, 236);
            this.gbNonReq.TabIndex = 55;
            this.gbNonReq.TabStop = false;
            this.gbNonReq.Text = "Необязательные данные (оставить пустыми)";
            // 
            // L_points
            // 
            this.L_points.AutoSize = true;
            this.L_points.Location = new System.Drawing.Point(86, 66);
            this.L_points.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_points.Name = "L_points";
            this.L_points.Size = new System.Drawing.Size(98, 13);
            this.L_points.TabIndex = 57;
            this.L_points.Text = "Пункты маршрута";
            // 
            // lbPathIUD_points
            // 
            this.lbPathIUD_points.FormattingEnabled = true;
            this.lbPathIUD_points.Location = new System.Drawing.Point(14, 89);
            this.lbPathIUD_points.Name = "lbPathIUD_points";
            this.lbPathIUD_points.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPathIUD_points.Size = new System.Drawing.Size(245, 134);
            this.lbPathIUD_points.TabIndex = 56;
            // 
            // PathData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 368);
            this.Controls.Add(this.gbRequired);
            this.Controls.Add(this.bComplete);
            this.Controls.Add(this.gbNonReq);
            this.Name = "PathData";
            this.Text = "PathData";
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.gbNonReq.ResumeLayout(false);
            this.gbNonReq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label L_path_id;
        public System.Windows.Forms.TextBox tbPathIUD_path_id;
        public System.Windows.Forms.Label L_passangers;
        public System.Windows.Forms.GroupBox gbRequired;
        private System.Windows.Forms.Button bComplete;
        public System.Windows.Forms.GroupBox gbNonReq;
        public System.Windows.Forms.Label L_points;
        public System.Windows.Forms.ListBox lbPathIUD_points;
        public System.Windows.Forms.TextBox tbPathIUD_passangers;
    }
}