using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

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

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "SquareShape" },
                { "StartPoint", new { X = startPoint.X, Y = startPoint.Y } },
                { "EndPoint", new { X = endPoint.X, Y = endPoint.Y } },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }
        public static SquareShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a SquareShape instance
                SquareShape squareShape = JsonSerializer.Deserialize<SquareShape>(json);

                // Return the deserialized SquareShape
                return squareShape;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing SquareShape from JSON: {ex.Message}");
                return null;
            }
        }
    }
}
