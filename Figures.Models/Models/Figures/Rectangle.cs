using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public class Rectangle : GraphicModel, ISizable, IBorder, IZIndex
    {

        public Rectangle(PointModel position, ColorModel color, SizeModel size, BorderModel border, ZIndexModel zIndex)
            : base(position, color)
        {
            Size = size;
            Border = border;
            ZIndex = zIndex;
        }

        public SizeModel Size { get; }

        public BorderModel Border { get; }

        public ZIndexModel ZIndex { get; }

        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
