using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public class Line : GraphicModel, IBorder, IZIndex
    {
        public Line(PointModel startPosition, PointModel endPosition, ColorModel color, BorderModel border, ZIndexModel zIndex)
        : base(startPosition, color)
        {
            EndPosition = endPosition;
            Border = border;
            ZIndex = zIndex;
        }

        public PointModel EndPosition { get; }

        public BorderModel Border { get; }

        public ZIndexModel ZIndex { get; }

        public override void Draw()
        {
            Console.WriteLine($"Draw Line");
        }

    }
}
