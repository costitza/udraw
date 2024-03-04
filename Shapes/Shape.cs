using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw
{
    abstract class Shape
    {
        public abstract void Draw(Graphics g);

        public virtual List<Point> FreehandPoints { get; set; } = new List<Point>();
    }
}
