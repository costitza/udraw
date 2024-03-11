using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

namespace Udraw.Shapes
{
    class TriangleShape : Shape
    {
        public override Point startPoint { get; set; }
        public override Point endPoint { get; set; }
        public override Color color { get; set; }
        public override int width { get; set; }

        public TriangleShape(Point startPoint, Point endPoint, Color color, int width)
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
                Point[] points =
                {
                    new Point(startPoint.X + (endPoint.X - startPoint.X) / 2, startPoint.Y),
                    new Point(endPoint.X, endPoint.Y),
                    new Point(startPoint.X, endPoint.Y)
                };
                g.DrawPolygon(pen, points);
            }
        }

    }
}

