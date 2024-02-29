using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public class RoundedRectangle : Rectangle, IRadius
    {
        public RoundedRectangle(PointModel position, ColorModel color, SizeModel size, BorderModel border, RadiusModel radiusModel, ZIndexModel zIndex)
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
