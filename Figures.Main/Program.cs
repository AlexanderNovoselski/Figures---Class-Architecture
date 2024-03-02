using Figures.Models.Contracts.Figures;
using Figures.Models.Enums;
using Figures.Models.Models.Figures;
using Figures.Models.Models.HelperModels.Shapes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointModel positionRectangle = new PointModel(10, 20);
            ColorModel colorRectangle = new ColorModel("red");
            SizeModel sizeRectangle = new SizeModel(30, 40);
            BorderModel borderRectangle = new BorderModel();
            ZIndexModel zIndexRectangle = new ZIndexModel(17);

            Rectangle rectangle = new Rectangle(positionRectangle, colorRectangle, sizeRectangle, borderRectangle, zIndexRectangle);

            Console.WriteLine(rectangle.Color.ColorName);
            rectangle.Draw();

            //

            PointModel positionrRoundedRectangle = new PointModel(10, 20);
            ColorModel colorRoundedRectangle = new ColorModel("blue");
            SizeModel sizeRoundedRectangle = new SizeModel(30, 40);
            BorderModel borderRoundedRectangle = new BorderModel();
            ZIndexModel zIndexRoundedRectangle = new ZIndexModel(3);
            RadiusModel radiusRoundedRectangle = new RadiusModel(RadiusType.Corner);

            RoundedRectangle roundedRectangle = new RoundedRectangle(positionrRoundedRectangle, colorRoundedRectangle, sizeRoundedRectangle, borderRoundedRectangle, zIndexRoundedRectangle, radiusRoundedRectangle);

            Console.WriteLine(roundedRectangle.RadiusModel.RadiusType);
            Console.WriteLine(roundedRectangle.Color.ColorName);

            roundedRectangle.Color.SetColor("black");

            Console.WriteLine(roundedRectangle.Color.ColorName);

            roundedRectangle.Draw();

            //


            PointModel startPosition = new PointModel(10, 20);
            PointModel endPosition = new PointModel(30, 40);
            ColorModel colorLine = new ColorModel("black");
            BorderModel borderLine = new BorderModel(3, LineType.Single);
            ZIndexModel zIndexLine = new ZIndexModel(1);
            Line line = new Line(startPosition, endPosition, colorLine, borderLine, zIndexLine);

            line.Draw();

            //

            PointModel positionImage = new PointModel(10, 20);
            BorderModel borderLineImage = new BorderModel(3, LineType.Single);
            SizeModel sizeImage = new SizeModel(30, 40);
            Image image = new Image(positionImage, borderLineImage, sizeImage);

            image.Draw();

            //

            PointModel positionText = new PointModel(10, 20);
            SizeModel sizeText = new SizeModel(30, 40);
            TextStylesModel textStyle = new TextStylesModel("Arial", 25);
            TextLine text = new TextLine(positionText, sizeText, textStyle);

            text.Draw();

            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine();

            List<IGraphicalModel> initialModels = new List<IGraphicalModel>{
                text,
                image,
                roundedRectangle,
                line,
                rectangle,
            };
            IDrawingModel models = new DrawingModels(initialModels);
            models.AddObjectTo(text);
            GUIItems items = new GUIItems(models);

            items.DrawAll();

        }
    }
}