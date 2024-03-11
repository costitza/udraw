using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

namespace Udraw.Shapes
{
    class LineShape : Shape
    {
        public override Point startPoint { get; set; }
        public override Point endPoint { get; set; }
        public override Color color { get; set; }
        public override int width { get; set; }

        public LineShape(Point startPoint, Point endPoint, Color color, int width)
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
                g.DrawLine(pen, startPoint, endPoint);
            }
        }

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "LineShape" },
                { "StartPoint", new { X = startPoint.X, Y = startPoint.Y } },
                { "EndPoint", new { X = endPoint.X, Y = endPoint.Y } },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }

        public static LineShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a LineShape instance
                LineShape lineShape = JsonSerializer.Deserialize<LineShape>(json);

                // Return the deserialized LineShape
                return lineShape;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing LineShape from JSON: {ex.Message}");
                return null;
            }
        }
    }
}
