namespace butonolaylari
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
            this.btnkolay = new System.Windows.Forms.Button();
            this.btnorta = new System.Windows.Forms.Button();
            this.btnzor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkolay
            // 
            this.btnkolay.Location = new System.Drawing.Point(131, 173);
            this.btnkolay.Name = "btnkolay";
            this.btnkolay.Size = new System.Drawing.Size(129, 59);
            this.btnkolay.TabIndex = 0;
            this.btnkolay.Text = "KOLAY";
            this.btnkolay.UseVisualStyleBackColor = true;
            this.btnkolay.Click += new System.EventHandler(this.btnkolay_Click);
            // 
            // btnorta
            // 
            this.btnorta.Location = new System.Drawing.Point(298, 173);
            this.btnorta.Name = "btnorta";
            this.btnorta.Size = new System.Drawing.Size(129, 59);
            this.btnorta.TabIndex = 0;
            this.btnorta.Text = "ORTA";
            this.btnorta.UseVisualStyleBackColor = true;
            this.btnorta.Click += new System.EventHandler(this.btnorta_Click);
            // 
            // btnzor
            // 
            this.btnzor.Location = new System.Drawing.Point(474, 173);
            this.btnzor.Name = "btnzor";
            this.btnzor.Size = new System.Drawing.Size(129, 59);
            this.btnzor.TabIndex = 0;
            this.btnzor.Text = "ZOR";
            this.btnzor.UseVisualStyleBackColor = true;
            this.btnzor.Click += new System.EventHandler(this.btnzor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnzor);
            this.Controls.Add(this.btnorta);
            this.Controls.Add(this.btnkolay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkolay;
        private System.Windows.Forms.Button btnorta;
        private System.Windows.Forms.Button btnzor;
        private System.Windows.Forms.Button button1;
    }
}

