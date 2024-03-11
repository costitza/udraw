using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;

namespace Udraw.Shapes
{
    class RectangleShape : Shape
    {
        public override Point startPoint { get; set; }
        public override Point endPoint { get; set; }
        public override Color color { get; set; }
        public override int width { get; set; }

        public RectangleShape(Point startPoint, Point endPoint, Color color, int width)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.color = color;
            this.width = width;
        }

        public override void Draw(Graphics g)
        {
            try
            {
                using (Pen pen = new Pen(color, width))
                {
                    Rectangle rect = new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                    g.DrawRectangle(pen, rect);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error drawing shape: {ex.Message}");
            }
        }

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "RectangleShape" },
                { "StartPoint", new { X = startPoint.X, Y = startPoint.Y } },
                { "EndPoint", new { X = endPoint.X, Y = endPoint.Y } },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }

        public static RectangleShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a RectangleShape instance
                RectangleShape rectangleShape = JsonSerializer.Deserialize<RectangleShape>(json);

                // Return the deserialized RectangleShape
                return rectangleShape;
            }
            catch (Exception ex)
            {
                // Handle any exception that might occur during deserialization
                Console.WriteLine($"Error deserializing RectangleShape from JSON: {ex.Message}");
                return null; // or throw an exception, depending on your error-handling strategy
            }
        }

    }
}
