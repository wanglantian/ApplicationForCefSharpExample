using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBaseLib
{
    /// <summary>
    /// 写一个基类窗体  具备窗体都需要的属性
    /// 1、可移动
    /// 2、可缩放 （可禁止缩放）
    /// </summary>
    public partial class FormBase : Form
    {
        #region Variables
        /// <summary>
        /// 记录鼠标点击位置
        /// </summary>
        private Point mPoint;

        //是否可缩放
        private bool bScaleable;
        /// <summary>
        /// 设置是否能缩放
        /// </summary>
        protected bool BScaleable
        {
            get { return bScaleable; }
            set { bScaleable = value; }
        }

        //是否可移动
        private bool bMoveable;
        /// <summary>
        /// 设置是否能移动
        /// </summary>
        protected bool BMoveable
        {
            get { return bMoveable; }
            set { bMoveable = value; }
        }

        //borderColor
        Color borderColor = Color.FromArgb(41,57,89);
        /// <summary>
        /// 左、右、底部边框颜色
        /// </summary>
        public Color BorderColor
        {
            set {
                if (value != null)
                    SetBorderColor(value);
            }
        }
        #endregion

        #region 构造函数
        public FormBase()
        {
            InitializeComponent();

            bScaleable = true;
            bMoveable = true;
            SetBorderColor(borderColor);
        }
        #endregion

        #region 窗体移动
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMoveable)
            {
                if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                {
                    if (sender is Panel)
                    {
                        Point myPosittion = MousePosition;
                        myPosittion.Offset(-mPoint.X, -mPoint.Y);
                        Location = myPosittion;
                    }
                    else
                    {
                        Point myPosittion = MousePosition;
                        myPosittion.Offset(-mPoint.X - 90, -mPoint.Y);
                        Location = myPosittion;

                    }
                }
            }
        }
        #endregion

        #region 调整大小

        #region Right

        private void panelRT_MouseEnter(object sender, EventArgs e)
        {
            if (bScaleable)
                if (this.Dock != DockStyle.Fill)
                {
                    this.Cursor = Cursors.SizeWE;
                }
        }

        private void panelRT_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Cursor = Cursors.Arrow;
            if (bScaleable)
                if (this.Cursor == Cursors.SizeWE)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Point pt;
                        pt = panelRT.PointToScreen(e.Location);
                        //pt = this.PointToClient(pt);
                        //Point point = this.PointToScreen(new Point(this.Location.X + this.Width,this.Location.Y + this.Height));
                        this.Width = pt.X - this.Location.X;
                        //this.Location = new Point(pt.X, this.Location.Y);

                        //AdjustpbClosePosition();
                        //AdjustpbClose();
                    }
                }
        }

        private void panelRT_MouseLeave(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.Arrow;
        }

        #endregion

        #region Left
        private void panelLT_MouseEnter(object sender, EventArgs e)
        {
            if (bScaleable)
                if (this.Dock != DockStyle.Fill)
                {
                    this.Cursor = Cursors.SizeWE;
                }
        }

        private void panelLT_MouseMove(object sender, MouseEventArgs e)
        {
            if (bScaleable)
                if (this.Cursor == Cursors.SizeWE)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Point pt;
                        //Log.WriteErrorLog("e.x : " + e.X + ",e.y: " + e.Y);
                        pt = panelLT.PointToScreen(e.Location);
                        //pt = this.PointToClient(pt);
                        //Point point = this.PointToScreen(new Point(this.Location.X + this.Width,this.Location.Y + this.Height));
                        this.Width = this.Location.X - pt.X + this.Width;
                        this.Location = new Point(pt.X, this.Location.Y);

                        //AdjustpbClosePosition();
                        //AdjustpbClose();
                    }
                }
        }

        private void panelLT_MouseLeave(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.Arrow;
        }

        #endregion

        #region Bottom
        private void panelBottom_MouseEnter(object sender, EventArgs e)
        {
            if (bScaleable)
                if (this.Dock != DockStyle.Fill)
                {
                    this.Cursor = Cursors.SizeNS;
                }
        }

        private void panelBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (bScaleable)
                if (this.Cursor == Cursors.SizeNS)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Point pt;
                        pt = panelBottom.PointToScreen(e.Location);
                        pt = this.PointToClient(pt);
                        //Point point = this.PointToScreen(new Point(this.Location.X + this.Width,this.Location.Y + this.Height));
                        this.Height = pt.Y;
                        //this.Location = new Point(pt.X, this.Location.Y);

                        //AdjustpbClosePosition();
                    }
                }
        }

        private void panelBottom_MouseLeave(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.Arrow;
        }

        #endregion

        #region 左下
        private void panelLB_MouseEnter(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.SizeNESW;
        }

        private void panelLB_MouseMove(object sender, MouseEventArgs e)
        {
            if (bScaleable)
                if (this.Cursor == Cursors.SizeNESW)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Point pt;
                        pt = panelLB.PointToScreen(e.Location);
                        Point point = this.PointToClient(pt);
                        //Point point = this.PointToScreen(new Point(this.Location.X + this.Width,this.Location.Y + this.Height));
                        //this.Height = point.Y;
                        if (pt.X != this.Location.X)
                        {
                            this.Width = this.Location.X - pt.X + this.Width;

                            this.Location = new Point(pt.X, this.Location.Y);
                        }
                        if (pt.Y != this.Location.Y + this.Height)
                        {
                            this.Height = pt.Y - this.Location.Y;
                        }
                        //this.Location = new Point(pt.X, this.Location.Y);

                        //AdjustpbClosePosition();
                    }
                }
        }

        private void panelLB_MouseLeave(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.Arrow;
        }

        #endregion 

        #region 右下
        private void panelRB_MouseEnter(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.SizeNWSE;
        }

        private void panelRB_MouseMove(object sender, MouseEventArgs e)
        {
            if (bScaleable)
                if (this.Cursor == Cursors.SizeNWSE)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Point pt;
                        pt = panelRB.PointToScreen(e.Location);
                        pt = this.PointToClient(pt);
                        //Point point = this.PointToScreen(new Point(this.Location.X + this.Width,this.Location.Y + this.Height));
                        //this.Height = point.Y;

                        //this.Location = new Point(pt.X, this.Location.Y);

                        if (pt.X != this.Width)
                            this.Width = pt.X;
                        if (pt.Y != this.Height)
                            this.Height = pt.Y;

                        //AdjustpbClosePosition();
                    }
                }
        }

        private void panelRB_MouseLeave(object sender, EventArgs e)
        {
            if (bScaleable)
                this.Cursor = Cursors.Arrow;
        }
        #endregion

        #endregion

        #region 关闭按钮
        private void pbClose_Click(object sender, EventArgs e)
        {
            pbClose.Image = Resource1.wdsCloseClick;
            Close();
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = Resource1.wdsCloseClick;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Resource1.wdsCloseNormal;
        }

        #endregion

        #region 一些方法
        /// <summary>
        /// 设置边框颜色
        /// </summary>
        /// <param name="color">边框颜色，不会为null</param>
        private void SetBorderColor(Color color)
        {
            panelL.BackColor = color;
            panelR.BackColor = color;
            panelBottom.BackColor = color;
        }
        #endregion
    }
}
