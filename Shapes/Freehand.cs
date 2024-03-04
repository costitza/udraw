using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw
{
    class FreehandShape : Shape
    {
        private List<Point> freehandPoints;
        private Color color;
        private int width;

        public FreehandShape(List<Point> freehandPoints, Color color, int width)
        {
            this.freehandPoints = freehandPoints;
            this.color = color;
            this.width = width;
        }

        public override void Draw(Graphics g)
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
