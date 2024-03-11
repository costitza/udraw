using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Udraw
{
    [Serializable]
    public abstract class Shape
    {
        public abstract Point startPoint { get; set; }
        public abstract Point endPoint { get; set; }
        public abstract Color color { get; set; }
        public abstract int width { get; set; }
        public Shape() { }

        public abstract void Draw(Graphics g);
        public abstract string ToJson();

        ///public virtual List<Point> FreehandPoints { get; set; } = new List<Point>();
    }
}
