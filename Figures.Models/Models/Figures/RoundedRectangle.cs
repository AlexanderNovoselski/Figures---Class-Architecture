using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public class RoundedRectangle : Rectangle, IHasRadius
    {
        public RoundedRectangle(PointModel position, ColorModel color, SizeModel size, BorderModel border, ZIndexModel zIndex, RadiusModel radiusModel)
            : base(position, color, size, border, zIndex)
        {
            RadiusModel = radiusModel;
        }

        public RadiusModel RadiusModel { get; }

        public override void Draw()
        {
            Console.WriteLine("Draw Rounded Rectangle");
        }
    }
}
