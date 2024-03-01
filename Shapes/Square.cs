using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Udraw.Shapes
{
    class SquareShape : Shape
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private int width;

        public SquareShape(Point startPoint, Point endPoint, Color color, int width)
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
                
                int width = Math.Abs(endPoint.X - startPoint.X);
                int height = Math.Abs(endPoint.Y - startPoint.Y);

                
                int size = Math.Min(width, height);

                
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);

                Rectangle rect = new Rectangle(x, y, size, size);
                g.DrawRectangle(pen, rect);
            }
        }
    }
}
