namespace DatBase_Conected
{
    partial class PointData
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
            this.L_point_id = new System.Windows.Forms.Label();
            this.tbPointIUD_point_id = new System.Windows.Forms.TextBox();
            this.tbPointIUD_pname = new System.Windows.Forms.TextBox();
            this.L_pname = new System.Windows.Forms.Label();
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.bComplete = new System.Windows.Forms.Button();
            this.gbRequired.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_point_id
            // 
            this.L_point_id.AutoSize = true;
            this.L_point_id.Location = new System.Drawing.Point(5, 30);
            this.L_point_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_point_id.Name = "L_point_id";
            this.L_point_id.Size = new System.Drawing.Size(104, 13);
            this.L_point_id.TabIndex = 25;
            this.L_point_id.Text = "ID записи (path_id):";
            // 
            // tbPointIUD_point_id
            // 
            this.tbPointIUD_point_id.Location = new System.Drawing.Point(114, 27);
            this.tbPointIUD_point_id.Name = "tbPointIUD_point_id";
            this.tbPointIUD_point_id.Size = new System.Drawing.Size(147, 20);
            this.tbPointIUD_point_id.TabIndex = 23;
            // 
            // tbPointIUD_pname
            // 
            this.tbPointIUD_pname.Location = new System.Drawing.Point(114, 66);
            this.tbPointIUD_pname.Name = "tbPointIUD_pname";
            this.tbPointIUD_pname.Size = new System.Drawing.Size(147, 20);
            this.tbPointIUD_pname.TabIndex = 33;
            // 
            // L_pname
            // 
            this.L_pname.AutoSize = true;
            this.L_pname.Location = new System.Drawing.Point(36, 69);
            this.L_pname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_pname.Name = "L_pname";
            this.L_pname.Size = new System.Drawing.Size(73, 13);
            this.L_pname.TabIndex = 35;
            this.L_pname.Text = "Имя (pname):";
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.tbPointIUD_pname);
            this.gbRequired.Controls.Add(this.L_point_id);
            this.gbRequired.Controls.Add(this.L_pname);
            this.gbRequired.Controls.Add(this.tbPointIUD_point_id);
            this.gbRequired.Location = new System.Drawing.Point(12, 12);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(273, 99);
            this.gbRequired.TabIndex = 57;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Обязательные данные";
            // 
            // bComplete
            // 
            this.bComplete.Location = new System.Drawing.Point(83, 117);
            this.bComplete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(115, 32);
            this.bComplete.TabIndex = 56;
            this.bComplete.Text = "Выполнить";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // PointData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 156);
            this.Controls.Add(this.gbRequired);
            this.Controls.Add(this.bComplete);
            this.Name = "PointData";
            this.Text = "PointData";
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label L_point_id;
        public System.Windows.Forms.TextBox tbPointIUD_point_id;
        public System.Windows.Forms.TextBox tbPointIUD_pname;
        public System.Windows.Forms.Label L_pname;
        public System.Windows.Forms.GroupBox gbRequired;
        private System.Windows.Forms.Button bComplete;
    }
}