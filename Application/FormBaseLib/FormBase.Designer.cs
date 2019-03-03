namespace FormBaseLib
{
    partial class FormBase
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panelL = new System.Windows.Forms.Panel();
            this.panelLT = new System.Windows.Forms.Panel();
            this.panelLB = new System.Windows.Forms.Panel();
            this.panelR = new System.Windows.Forms.Panel();
            this.panelRT = new System.Windows.Forms.Panel();
            this.panelRB = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panelL.SuspendLayout();
            this.panelR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.panelTop.Controls.Add(this.pbClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(284, 25);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pbClose
            // 
            this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbClose.Image = global::FormBaseLib.Resource1.wdsCloseNormal;
            this.pbClose.Location = new System.Drawing.Point(259, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // panelL
            // 
            this.panelL.Controls.Add(this.panelLT);
            this.panelL.Controls.Add(this.panelLB);
            this.panelL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelL.Location = new System.Drawing.Point(0, 25);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(5, 237);
            this.panelL.TabIndex = 1;
            // 
            // panelLT
            // 
            this.panelLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLT.Location = new System.Drawing.Point(0, 0);
            this.panelLT.Name = "panelLT";
            this.panelLT.Size = new System.Drawing.Size(5, 232);
            this.panelLT.TabIndex = 1;
            this.panelLT.MouseEnter += new System.EventHandler(this.panelLT_MouseEnter);
            this.panelLT.MouseLeave += new System.EventHandler(this.panelLT_MouseLeave);
            this.panelLT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLT_MouseMove);
            // 
            // panelLB
            // 
            this.panelLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLB.Location = new System.Drawing.Point(0, 232);
            this.panelLB.Name = "panelLB";
            this.panelLB.Size = new System.Drawing.Size(5, 5);
            this.panelLB.TabIndex = 0;
            this.panelLB.MouseEnter += new System.EventHandler(this.panelLB_MouseEnter);
            this.panelLB.MouseLeave += new System.EventHandler(this.panelLB_MouseLeave);
            this.panelLB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLB_MouseMove);
            // 
            // panelR
            // 
            this.panelR.Controls.Add(this.panelRT);
            this.panelR.Controls.Add(this.panelRB);
            this.panelR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelR.Location = new System.Drawing.Point(279, 25);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(5, 237);
            this.panelR.TabIndex = 2;
            // 
            // panelRT
            // 
            this.panelRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRT.Location = new System.Drawing.Point(0, 0);
            this.panelRT.Name = "panelRT";
            this.panelRT.Size = new System.Drawing.Size(5, 232);
            this.panelRT.TabIndex = 1;
            this.panelRT.MouseEnter += new System.EventHandler(this.panelRT_MouseEnter);
            this.panelRT.MouseLeave += new System.EventHandler(this.panelRT_MouseLeave);
            this.panelRT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRT_MouseMove);
            // 
            // panelRB
            // 
            this.panelRB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRB.Location = new System.Drawing.Point(0, 232);
            this.panelRB.Name = "panelRB";
            this.panelRB.Size = new System.Drawing.Size(5, 5);
            this.panelRB.TabIndex = 0;
            this.panelRB.MouseEnter += new System.EventHandler(this.panelRB_MouseEnter);
            this.panelRB.MouseLeave += new System.EventHandler(this.panelRB_MouseEnter);
            this.panelRB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRB_MouseMove);
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 257);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(274, 5);
            this.panelBottom.TabIndex = 3;
            this.panelBottom.MouseEnter += new System.EventHandler(this.panelBottom_MouseEnter);
            this.panelBottom.MouseLeave += new System.EventHandler(this.panelBottom_MouseLeave);
            this.panelBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBottom_MouseMove);
            // 
            // panel1
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(5, 25);
            this.panelMain.Name = "panel1";
            this.panelMain.Size = new System.Drawing.Size(274, 232);
            this.panelMain.TabIndex = 4;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.panelL);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panelL.ResumeLayout(false);
            this.panelR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelL;
        private System.Windows.Forms.Panel panelLB;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.Panel panelRB;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLT;
        private System.Windows.Forms.Panel panelRT;
        protected System.Windows.Forms.Panel panelTop;
        protected System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbClose;
    }
}