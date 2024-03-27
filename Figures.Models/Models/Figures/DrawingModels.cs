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
            var zIndexList = new List<IGraphicalModel>();
            foreach (var item in AllObjects)
            {
                var type = item.GetType();
                var interfaceType = typeof(IHasZIndex);

                if (interfaceType.IsAssignableFrom(type))
                {
                    zIndexList.Add(item);
                }
            }

            return zIndexList;

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
