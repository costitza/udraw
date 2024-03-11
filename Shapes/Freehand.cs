using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;

namespace Udraw
{
    public class FreehandShape
    {
        public List<Point> freehandPoints { get; set; }
        public Color color { get; set; }
        public int width { get; set; }

        public FreehandShape(List<Point> freehandPoints, Color color, int width)
        {
            this.freehandPoints = freehandPoints;
            this.color = color;
            this.width = width;
        }

        public void Draw(Graphics g)
        {
            try
            {
                using (Pen pen = new Pen(color, width))
                {
                    g.DrawLines(pen, freehandPoints.ToArray());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error drawing shape: {ex.Message}");
            }
        }

    }
}
