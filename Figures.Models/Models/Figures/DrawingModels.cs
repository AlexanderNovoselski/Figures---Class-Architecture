using Figures.Models.Contracts.Figures;
using Figures.Models.Contracts.Helper.Shapes;
using static System.Net.Mime.MediaTypeNames;

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
            var noZIndexList = new List<IGraphicalModel>();
            foreach (var item in AllObjects)
            {
                var type = item.GetType();
                var interfaceType = typeof(IHasZIndex);

                if (!interfaceType.IsAssignableFrom(type))
                {
                    noZIndexList.Add(item);
                }
            }

            return noZIndexList;
        }

        public void AddObjectToList(IGraphicalModel graphicalModel)
        {
            try
            {
                var type = graphicalModel.GetType();
                var interfaceType = typeof(IGraphicalModel);

                if (interfaceType.IsAssignableFrom(type))
                {
                    AllObjects.Add(graphicalModel);

                }
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
