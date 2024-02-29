﻿using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public class Image : GraphicModel, ISizable, IBorder
    {
        public Image(PointModel position, ColorModel color, BorderModel border, SizeModel size) 
            : base(position, color)
        {
            Border = border;
            Size = size;
        }

        public BorderModel Border { get; }

        public SizeModel Size { get; }

        public override void Draw()
        {
            Console.WriteLine("Draw an image");
        }
    }
}