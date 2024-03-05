using Figures.Models.Contracts.Figures;
using Figures.Models.Contracts.Helper.Shapes;

namespace Figures.Models.Models.Figures
{
    public class DrawingModels : IDrawingModel
    {
        private List<IGraphicalModel> AllObjects { get; set; }

        public DrawingModels()
        {
            InitializeLists();
        }

        public DrawingModels(List<IGraphicalModel> initialModels)
        {
            InitializeLists();
            AddObjects(initialModels);
        }

        public List<IGraphicalModel> GetAllObjectsWithZIndex()
        {
            return AllObjects
                .OfType<IHasZIndex>()
                .Where(x => x is IHasZIndex)
                .Cast<IGraphicalModel>()
                .ToList();
        }

        public List<IGraphicalModel> GetAllObjectsWithoutZIndex()
        {
            return AllObjects.Where(x => !(x is IHasZIndex)).ToList();
        }

        public void AddObjectToList(IGraphicalModel graphicalModel)
        {
            try
            {
                AllObjects.Add(graphicalModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void AddObjects(List<IGraphicalModel> graphicalModels)
        {
            AllObjects.AddRange(graphicalModels);
        }

        private void InitializeLists()
        {
            AllObjects = new List<IGraphicalModel>();
        }
    }
}
