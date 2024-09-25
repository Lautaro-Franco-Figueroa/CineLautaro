namespace AMeterleGanas
{
    partial class Form2
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.btMovie3 = new System.Windows.Forms.Button();
            this.btMovie2 = new System.Windows.Forms.Button();
            this.btMovie1 = new System.Windows.Forms.Button();
            this.BoxD1 = new System.Windows.Forms.ComboBox();
            this.BoxD2 = new System.Windows.Forms.ComboBox();
            this.BoxD3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(75, 39);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(403, 31);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Elija la pelicula que quiere ver";
            // 
            // btMovie3
            // 
            this.btMovie3.Image = global::AMeterleGanas.Properties.Resources.gru;
            this.btMovie3.Location = new System.Drawing.Point(384, 132);
            this.btMovie3.Name = "btMovie3";
            this.btMovie3.Size = new System.Drawing.Size(165, 226);
            this.btMovie3.TabIndex = 3;
            this.btMovie3.UseVisualStyleBackColor = true;
            // 
            // btMovie2
            // 
            this.btMovie2.Image = global::AMeterleGanas.Properties.Resources.dedpolwolverine3;
            this.btMovie2.Location = new System.Drawing.Point(198, 132);
            this.btMovie2.Name = "btMovie2";
            this.btMovie2.Size = new System.Drawing.Size(165, 226);
            this.btMovie2.TabIndex = 2;
            this.btMovie2.UseVisualStyleBackColor = true;
            // 
            // btMovie1
            // 
            this.btMovie1.Image = global::AMeterleGanas.Properties.Resources.alien;
            this.btMovie1.Location = new System.Drawing.Point(12, 132);
            this.btMovie1.Name = "btMovie1";
            this.btMovie1.Size = new System.Drawing.Size(165, 226);
            this.btMovie1.TabIndex = 1;
            this.btMovie1.UseVisualStyleBackColor = true;
            this.btMovie1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // BoxD1
            // 
            this.BoxD1.FormattingEnabled = true;
            this.BoxD1.Items.AddRange(new object[] {
            "2D $2000",
            "3D $3000"});
            this.BoxD1.Location = new System.Drawing.Point(36, 364);
            this.BoxD1.Name = "BoxD1";
            this.BoxD1.Size = new System.Drawing.Size(121, 21);
            this.BoxD1.TabIndex = 5;
            // 
            // BoxD2
            // 
            this.BoxD2.FormattingEnabled = true;
            this.BoxD2.Items.AddRange(new object[] {
            "2D $4000",
            "3D $5000"});
            this.BoxD2.Location = new System.Drawing.Point(220, 364);
            this.BoxD2.Name = "BoxD2";
            this.BoxD2.Size = new System.Drawing.Size(121, 21);
            this.BoxD2.TabIndex = 6;
            // 
            // BoxD3
            // 
            this.BoxD3.FormattingEnabled = true;
            this.BoxD3.Items.AddRange(new object[] {
            "2D $6000",
            "3D $7000"});
            this.BoxD3.Location = new System.Drawing.Point(406, 364);
            this.BoxD3.Name = "BoxD3";
            this.BoxD3.Size = new System.Drawing.Size(121, 21);
            this.BoxD3.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(561, 408);
            this.Controls.Add(this.BoxD3);
            this.Controls.Add(this.BoxD2);
            this.Controls.Add(this.BoxD1);
            this.Controls.Add(this.btMovie3);
            this.Controls.Add(this.btMovie2);
            this.Controls.Add(this.btMovie1);
            this.Controls.Add(this.lblChoose);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btMovie1;
        private System.Windows.Forms.Button btMovie2;
        private System.Windows.Forms.Button btMovie3;
        private System.Windows.Forms.ComboBox BoxD1;
        private System.Windows.Forms.ComboBox BoxD2;
        private System.Windows.Forms.ComboBox BoxD3;
    }
}