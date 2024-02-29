using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Contracts.Figures
{
    public interface IGraphicalModel : IDrawable
    {
        PointModel Position { get; }
        ColorModel Color { get; }
    }
}
