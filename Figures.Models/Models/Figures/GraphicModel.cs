using Figures.Models.Contracts.Figures;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public abstract class GraphicModel : IGraphicalModel
    {
        public GraphicModel(PointModel position)
        {
            Position = position;
        }
        public PointModel Position { get; }

        public abstract void Draw();
    }
}
