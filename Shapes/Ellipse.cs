using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw.Shapes
{
    class EllipseShape : Shape
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private int width;

        public EllipseShape(Point startPoint, Point endPoint, Color color, int width)
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
                int halfWidth = Math.Abs(endPoint.X - startPoint.X) / 2;
                int halfHeight = Math.Abs(endPoint.Y - startPoint.Y) / 2;

                int centerX = Math.Min(startPoint.X, endPoint.X) + halfWidth;
                int centerY = Math.Min(startPoint.Y, endPoint.Y) + halfHeight;

                g.DrawEllipse(pen, centerX - halfWidth, centerY - halfHeight, 2 * halfWidth, 2 * halfHeight);
            }
        }
    }

}
