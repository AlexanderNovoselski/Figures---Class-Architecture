using Figures.Models.Contracts.Figures;
using Figures.Models.Contracts.Helper.Shapes;

namespace Figures.Models.Models.Figures
{
    public class GUIItems : IGUIItems
    {
        private readonly IDrawingModel model;

        public GUIItems(IDrawingModel model)
        {
            this.model = model;
        }
        public void DrawAll()
        {
            var objectsWithZIndex = model.GetAllObjectsWithZIndex();
            var objectsWithoutZIndex = model.GetAllObjectsWithoutZIndex();

            var firstThird = objectsWithoutZIndex.ToList().Count / 3;
            var firstThirdList = objectsWithoutZIndex.Take(firstThird).ToList();

            DrawObjects(firstThirdList);

            // Draw ZIndex objects from lower to higher index
            DrawObjects(OrderByAscending(objectsWithZIndex));

            // Draw the rest of the non zIndex objects
            var restObjects = objectsWithoutZIndex.Skip(firstThird).ToList();

            DrawObjects(restObjects);
        }

        private void DrawObjects(List<IGraphicalModel> objects)
        {
            foreach (var obj in objects)
            {
                obj.Draw();
            }
        }

        private List<IGraphicalModel> OrderByAscending(List<IGraphicalModel> objects)
        {
            var sortedList = new List<IGraphicalModel>();
            var copyList = new List<IGraphicalModel>(objects);

            while (copyList.Count > 0)
            {
                var lowestZIndexModel = copyList[0];

                foreach (var graphicalModel in copyList)
                {
                    var currentIndex = (graphicalModel as IHasZIndex)?.ZIndex.ZIndex;
                    var lowestIndex = (lowestZIndexModel as IHasZIndex)?.ZIndex.ZIndex;

                    if (currentIndex < lowestIndex)
                    {
                        lowestZIndexModel = graphicalModel;
                    }
                }

                copyList.Remove(lowestZIndexModel);
                sortedList.Add(lowestZIndexModel);
            }

            return sortedList;
        }

    }
}
