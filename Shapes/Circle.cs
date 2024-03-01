﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw.Shapes
{
    class CircleShape : Shape
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private int width;

        public CircleShape(Point startPoint, Point endPoint, Color color, int width)
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
                int radius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y)) / 2;
                int centerX = startPoint.X + (endPoint.X - startPoint.X) / 2;
                int centerY = startPoint.Y + (endPoint.Y - startPoint.Y) / 2;
                g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }
    }
}
