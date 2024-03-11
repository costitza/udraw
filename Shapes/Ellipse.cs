using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

namespace Udraw.Shapes
{
    class EllipseShape : Shape
    {
        public override Point startPoint { get; set; }
        public override Point endPoint { get; set; }
        public override Color color { get; set; }
        public override int width { get; set; }

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
