using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traseu
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.Text = "About";
            this.Size = new Size(300, 200);

            Label aboutLabel = new Label
            {
                Text = "This is a sample application to draw lines between coordinates.\n\nAuthor: Your Name\nVersion: 1.0",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(aboutLabel);
        }
    }
}
