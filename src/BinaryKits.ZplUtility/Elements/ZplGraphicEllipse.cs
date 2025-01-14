﻿using System.Collections.Generic;

namespace BinaryKits.ZplUtility.Elements
{
    public class ZplGraphicEllipse : ZplGraphicBox
    {
        public ZplGraphicEllipse(int positionX, int positionY, int width, int height, int borderThickness = 1, string lineColor = "B") : base(positionX, positionY, width, height, borderThickness, lineColor, 0)
        {
        }

        public override IEnumerable<string> Render(ZplRenderOptions context)
        {
            //^ GE300,100,10,B ^ FS
            var result = new List<string>();
            result.AddRange(Origin.Render(context));
            result.Add($"^GE{context.Scale(Width)},{context.Scale(Height)},{context.Scale(BorderThickness)},{LineColor}^FS");

            return result;
        }
    }
}
