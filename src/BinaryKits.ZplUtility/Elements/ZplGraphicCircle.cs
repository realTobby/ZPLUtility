﻿using System.Collections.Generic;

namespace BinaryKits.ZplUtility.Elements
{
    /// <summary>
    /// Graphic Circle<br/>
    /// The ^GC command produces a circle on the printed label.
    /// The command parameters specify the diameter(width) of the circle, outline thickness, and color.
    /// Thickness extends inward from the outline.
    /// </summary>
    /// <remarks>
    /// Format:^GCd,t,c
    /// d = circle diameter
    /// t = border thickness
    /// c = line color
    /// </remarks>
    public class ZplGraphicCircle : ZplGraphicElement
    {
        public int Diameter { get; private set; }

        public ZplGraphicCircle(int positionX, int positionY, int diameter, int borderThickness = 1, string lineColor = "B") : base(positionX, positionY, borderThickness, lineColor)
        {
            Diameter = diameter;
        }

        public override IEnumerable<string> Render(ZplRenderOptions context)
        {
            //^GCd,t,c
            var result = new List<string>();
            result.AddRange(Origin.Render(context));
            result.Add($"^GC{context.Scale(Diameter)},{context.Scale(BorderThickness)},{LineColor}^FS");

            return result;
        }
    }
}
