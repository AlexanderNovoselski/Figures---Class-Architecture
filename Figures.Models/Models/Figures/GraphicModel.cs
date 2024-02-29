using Figures.Models.Contracts.Figures;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public abstract class GraphicModel : IGraphicalModel
    {
        public GraphicModel(PointModel position, ColorModel color)
        {
            Position = position;
            Color = color;
        }
        public PointModel Position { get; }
        public ColorModel Color { get; }

        public abstract void Draw();
    }
}
