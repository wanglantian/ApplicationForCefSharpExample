namespace WebFormBase
{
    partial class WebBaseForm
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
            this.panelMainT = new System.Windows.Forms.Panel();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.panelMainM = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelMainT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(410, 25);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMainM);
            this.panelMain.Controls.Add(this.panelMainT);
            this.panelMain.Size = new System.Drawing.Size(400, 232);
            // 
            // panelMainT
            // 
            this.panelMainT.Controls.Add(this.pictureBox2);
            this.panelMainT.Controls.Add(this.pictureBox1);
            this.panelMainT.Controls.Add(this.btnNavigate);
            this.panelMainT.Controls.Add(this.tbUrl);
            this.panelMainT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainT.Location = new System.Drawing.Point(0, 0);
            this.panelMainT.Name = "panelMainT";
            this.panelMainT.Size = new System.Drawing.Size(400, 37);
            this.panelMainT.TabIndex = 0;
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(300, 5);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(59, 23);
            this.btnNavigate.TabIndex = 1;
            this.btnNavigate.Text = "前往";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(7, 7);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(287, 21);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            this.tbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrl_KeyPress);
            // 
            // panelMainM
            // 
            this.panelMainM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainM.Location = new System.Drawing.Point(0, 37);
            this.panelMainM.Name = "panelMainM";
            this.panelMainM.Size = new System.Drawing.Size(400, 195);
            this.panelMainM.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(89)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 2);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(89)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 2);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // WebBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Name = "WebBaseForm";
            this.Text = "WebBaseForm";
            this.panelMain.ResumeLayout(false);
            this.panelMainT.ResumeLayout(false);
            this.panelMainT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelMainT;
        protected System.Windows.Forms.Panel panelMainM;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}