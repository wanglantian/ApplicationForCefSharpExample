using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebFormBase;
namespace MyApplication
{
    public partial class WebForm : WebBaseForm
    {
        Label titleLabel = new Label();
        public WebForm()
        {
            titleLabel.Text = "网页";
            titleLabel.Location = new Point(5,5);
            panelTop.Controls.Add(titleLabel);

            this.Icon = Properties.Resources.favicon;
            this.Width = 800;
            this.Height = 600;
            InitializeComponent();
        }
    }
}
