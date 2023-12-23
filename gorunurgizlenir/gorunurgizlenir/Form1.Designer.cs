namespace gorunurgizlenir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngoster = new System.Windows.Forms.Button();
            this.btngizle = new System.Windows.Forms.Button();
            this.pctrmeb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrmeb)).BeginInit();
            this.SuspendLayout();
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(95, 70);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(75, 23);
            this.btngoster.TabIndex = 0;
            this.btngoster.Text = "GÖSTER";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            this.btngoster.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btngoster_MouseMove);
            // 
            // btngizle
            // 
            this.btngizle.Location = new System.Drawing.Point(256, 69);
            this.btngizle.Name = "btngizle";
            this.btngizle.Size = new System.Drawing.Size(75, 23);
            this.btngizle.TabIndex = 1;
            this.btngizle.Text = "GİZLE";
            this.btngizle.UseVisualStyleBackColor = true;
            this.btngizle.Click += new System.EventHandler(this.btngizle_Click);
            // 
            // pctrmeb
            // 
            this.pctrmeb.Image = ((System.Drawing.Image)(resources.GetObject("pctrmeb.Image")));
            this.pctrmeb.Location = new System.Drawing.Point(524, 42);
            this.pctrmeb.Name = "pctrmeb";
            this.pctrmeb.Size = new System.Drawing.Size(201, 159);
            this.pctrmeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrmeb.TabIndex = 2;
            this.pctrmeb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctrmeb);
            this.Controls.Add(this.btngizle);
            this.Controls.Add(this.btngoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrmeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Button btngizle;
        private System.Windows.Forms.PictureBox pctrmeb;
    }
}

