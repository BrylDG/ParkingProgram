using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkNClick
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void DatabasePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ParkinPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10; // Adjust the radius to your preference
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = DisplayPanel.ClientRectangle;
            bounds.Width--; // Adjust to prevent clipping
            bounds.Height--; // Adjust to prevent clipping
            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();
        }
    }
}
