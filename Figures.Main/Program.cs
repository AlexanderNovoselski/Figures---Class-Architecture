using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Enums;
using Figures.Models.Models.Figures;
using Figures.Models.Models.HelperModels.Shapes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointModel position = new PointModel(10, 20);
            SizeModel size = new SizeModel(30, 40);
            ColorModel color = new ColorModel("da");
            BorderModel border = new BorderModel();
            ZIndexModel zIndex = new ZIndexModel(1);
            RadiusModel radius = new RadiusModel(RadiusType.Corner);

            var rectangle = new Rectangle(position, color, size, border, zIndex);
            RoundedRectangle roundedRectangle = new RoundedRectangle(position, color, size, border, radius, zIndex);
            
            rectangle.Color.SetColor("blue");
            Console.WriteLine(rectangle.Color.ColorName);
            Console.WriteLine(roundedRectangle.RadiusModel.RadiusType);

            rectangle.Draw();
            roundedRectangle.Draw();

            PointModel startPosition = new PointModel(10, 20);
            PointModel endPosition = new PointModel(30, 40);
            ColorModel colorLine = new ColorModel("black");
            BorderModel borderLine = new BorderModel(3, LineType.Single);
            ZIndexModel zIndexLine = new ZIndexModel(1);
            Line line = new Line(startPosition, endPosition, colorLine, borderLine, zIndexLine);

            line.Draw();

            //PointModel positionImage = new PointModel(10, 20);
            //ColorModel colorLineImage = new ColorModel("black");
            //BorderModel borderLineImage = new BorderModel(3, LineType.Single);
            //SizeModel sizeImage = new SizeModel(30, 40);
            //Image image = new Image(positionImage, colorLineImage, borderLine, size);
        }
    }
}   