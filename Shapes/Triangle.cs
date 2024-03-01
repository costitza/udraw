using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw.Shapes
{
    class TriangleShape : Shape
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private int width;

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
