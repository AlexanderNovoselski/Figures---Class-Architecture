namespace Figures.Models.Contracts.Figures
{
    public interface IDrawingModel
    {
        List<IGraphicalModel> GetAllObjectsWithZIndex();

        List<IGraphicalModel> GetAllObjectsWithoutZIndex();

        void AddObjectTo(IGraphicalModel graphicalModel);
    }
}
