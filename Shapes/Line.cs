using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Udraw.Shapes
{
    class LineShape : Shape
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private int width;

        public LineShape(Point startPoint, Point endPoint, Color color, int width)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.color = color;
            this.width = width;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, width))
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
        }
    }
}
