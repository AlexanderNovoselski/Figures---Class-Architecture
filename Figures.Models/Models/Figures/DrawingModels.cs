using Figures.Models.Contracts.Figures;
using Figures.Models.Contracts.Helper.Shapes;

namespace Figures.Models.Models.Figures
{
    public class DrawingModels : IDrawingModel
    {
        public DrawingModels()
        {
            InitializeLists();
        }

        public DrawingModels(List<IGraphicalModel> initialModels)
        {
            InitializeLists();

            foreach (var model in initialModels)
            {
                AddObjectTo(model);
            }
        }

        private List<Rectangle> Rectangles { get; set; }
        private List<RoundedRectangle> RoundedRectangles { get; set; }
        private List<Line> Lines { get; set; }
        private List<Image> Images { get; set; }
        private List<TextLine> TextLines { get; set; }
        private List<object> OtherGraphicObjects { get; set; }

        public List<IGraphicalModel> GetAllObjectsWithZIndex()
        {
            return GetAllObjects()
                .OfType<IZIndex>()
                .Cast<IGraphicalModel>()
                .Where(x => x is IZIndex)
                .ToList();
        }

        public List<IGraphicalModel> GetAllObjectsWithoutZIndex()
        {
            return GetAllObjects().Where(x => x is not IZIndex).ToList();
        }

        private List<IGraphicalModel> GetAllObjects()
        {
            var allObjects = new List<IGraphicalModel>();
            allObjects.AddRange(Rectangles);
            allObjects.AddRange(RoundedRectangles);
            allObjects.AddRange(Lines);
            allObjects.AddRange(Images);
            allObjects.AddRange(TextLines);
            allObjects.AddRange(OtherGraphicObjects.OfType<IGraphicalModel>());
            return allObjects;
        }


        public void AddObjectTo(IGraphicalModel graphicalModel)
        {
            try
            {
                if (graphicalModel is Rectangle rectangle)
                {
                    Rectangles.Add(rectangle);
                }
                else if (graphicalModel is RoundedRectangle roundedRectangle)
                {
                    RoundedRectangles.Add(roundedRectangle);
                }
                else if (graphicalModel is Line line)
                {
                    Lines.Add(line);
                }
                else if (graphicalModel is Image image)
                {
                    Images.Add(image);
                }
                else if (graphicalModel is TextLine textLine)
                {
                    TextLines.Add(textLine);
                }
                else
                {
                    OtherGraphicObjects.Add(graphicalModel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void InitializeLists()
        {
            Rectangles = new List<Rectangle>();
            RoundedRectangles = new List<RoundedRectangle>();
            Lines = new List<Line>();
            Images = new List<Image>();
            TextLines = new List<TextLine>();
            OtherGraphicObjects = new List<object>();
        }
    }

}
