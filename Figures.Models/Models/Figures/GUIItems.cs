using Figures.Models.Contracts.Figures;
using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;
using System.Collections.Generic;

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


            // DrawObjects(firstThird);
            var firstThird = objectsWithoutZIndex.ToList().Count / 3; // TODO kakvo pravq ako sa 2 elementa samo, .. risuvam gi i 2ta v kraq?
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
                    var currentIndex = (graphicalModel as IZIndex)?.ZIndex;
                    var lowestIndex = (lowestZIndexModel as IZIndex)?.ZIndex;

                    if (currentIndex.ZIndex < lowestIndex.ZIndex)
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
