﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;

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

        public override string ToJson()
        {
            // Create a dictionary to represent the shape properties
            var shapeProperties = new Dictionary<string, object>
            {
                { "Type", "FreehandShape" },
                { "FreehandPoints", freehandPoints.Select(p => new { X = p.X, Y = p.Y }).ToList() },
                { "Color", color.ToArgb() },
                { "Width", width }
            };

            // Serialize the dictionary to JSON
            return JsonSerializer.Serialize(shapeProperties);
        }

        public static FreehandShape FromJson(string json)
        {
            try
            {
                // Deserialize the JSON string into a FreehandShape instance
                FreehandShape freehandShape = JsonSerializer.Deserialize<FreehandShape>(json);

                // Return the deserialized FreehandShape
                return freehandShape;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing FreehandShape from JSON: {ex.Message}");
                return null;
            }
        }
    }
}
