namespace arkaplan_renklendir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhazirlayan = new System.Windows.Forms.Button();
            this.btnmavi = new System.Windows.Forms.Button();
            this.btngri = new System.Windows.Forms.Button();
            this.btnyesil = new System.Windows.Forms.Button();
            this.btnkirmizi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnhazirlayan);
            this.groupBox1.Controls.Add(this.btnmavi);
            this.groupBox1.Controls.Add(this.btngri);
            this.groupBox1.Controls.Add(this.btnyesil);
            this.groupBox1.Controls.Add(this.btnkirmizi);
            this.groupBox1.Location = new System.Drawing.Point(108, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Arka Plan Rengi";
            // 
            // btnhazirlayan
            // 
            this.btnhazirlayan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnhazirlayan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhazirlayan.Location = new System.Drawing.Point(383, 216);
            this.btnhazirlayan.Name = "btnhazirlayan";
            this.btnhazirlayan.Size = new System.Drawing.Size(129, 40);
            this.btnhazirlayan.TabIndex = 0;
            this.btnhazirlayan.Text = "Hazırlayan";
            this.btnhazirlayan.UseVisualStyleBackColor = false;
            this.btnhazirlayan.Click += new System.EventHandler(this.btnhazirlayan_Click);
            // 
            // btnmavi
            // 
            this.btnmavi.BackColor = System.Drawing.Color.Blue;
            this.btnmavi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmavi.Location = new System.Drawing.Point(55, 123);
            this.btnmavi.Name = "btnmavi";
            this.btnmavi.Size = new System.Drawing.Size(129, 40);
            this.btnmavi.TabIndex = 0;
            this.btnmavi.Text = "Mavi";
            this.btnmavi.UseVisualStyleBackColor = false;
            this.btnmavi.Click += new System.EventHandler(this.btnmavi_Click);
            // 
            // btngri
            // 
            this.btngri.BackColor = System.Drawing.Color.Silver;
            this.btngri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngri.Location = new System.Drawing.Point(240, 123);
            this.btngri.Name = "btngri";
            this.btngri.Size = new System.Drawing.Size(129, 40);
            this.btngri.TabIndex = 0;
            this.btngri.Text = "Gri";
            this.btngri.UseVisualStyleBackColor = false;
            this.btngri.Click += new System.EventHandler(this.btngri_Click);
            // 
            // btnyesil
            // 
            this.btnyesil.BackColor = System.Drawing.Color.SeaGreen;
            this.btnyesil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyesil.Location = new System.Drawing.Point(240, 46);
            this.btnyesil.Name = "btnyesil";
            this.btnyesil.Size = new System.Drawing.Size(129, 40);
            this.btnyesil.TabIndex = 0;
            this.btnyesil.Text = "Yeşil";
            this.btnyesil.UseVisualStyleBackColor = false;
            this.btnyesil.Click += new System.EventHandler(this.btnyesil_Click);
            // 
            // btnkirmizi
            // 
            this.btnkirmizi.BackColor = System.Drawing.Color.Red;
            this.btnkirmizi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkirmizi.Location = new System.Drawing.Point(55, 46);
            this.btnkirmizi.Name = "btnkirmizi";
            this.btnkirmizi.Size = new System.Drawing.Size(129, 40);
            this.btnkirmizi.TabIndex = 0;
            this.btnkirmizi.Text = "Kırmızı";
            this.btnkirmizi.UseVisualStyleBackColor = false;
            this.btnkirmizi.Click += new System.EventHandler(this.btnkirmizi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkirmizi;
        private System.Windows.Forms.Button btnhazirlayan;
        private System.Windows.Forms.Button btnmavi;
        private System.Windows.Forms.Button btngri;
        private System.Windows.Forms.Button btnyesil;
    }
}

