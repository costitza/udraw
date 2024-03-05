using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

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

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "TriangleShape" },
                { "StartPoint", new { X = startPoint.X, Y = startPoint.Y } },
                { "EndPoint", new { X = endPoint.X, Y = endPoint.Y } },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }

        // Inside TriangleShape class
        public static TriangleShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a TriangleShape instance
                TriangleShape triangleShape = JsonSerializer.Deserialize<TriangleShape>(json);

                // Return the deserialized TriangleShape
                return triangleShape;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing TriangleShape from JSON: {ex.Message}");
                return null;
            }
        }

    }
}
