using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

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

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "CircleShape" },
                { "StartPoint", new { X = startPoint.X, Y = startPoint.Y } },
                { "EndPoint", new { X = endPoint.X, Y = endPoint.Y } },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }

        public static CircleShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a CircleShape instance
                CircleShape circleShape = JsonSerializer.Deserialize<CircleShape>(json);

                // Return the deserialized CircleShape
                return circleShape;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing CircleShape from JSON: {ex.Message}");
                return null;
            }
        }
    }
}
