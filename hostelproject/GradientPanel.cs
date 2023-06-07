using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace hostelproject
{
    class GradientPanel : Panel
    {
        public Color Colortop { get; set; }
        public Color Colorbottom { get; set; }  
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.Colortop, this.Colorbottom, 90F);
            Graphics g = e.Graphics; 
            g.FillRectangle(lgb, this.ClientRectangle );    
            base.OnPaint(e); 
        }
    }
}
