using Figures.Models.Contracts.Helper.Shapes;
using Figures.Models.Models.HelperModels.Shapes;

namespace Figures.Models.Models.Figures
{
    public class TextLine : GraphicModel, ISizable, ITextStylesModel
    {
        public TextLine(PointModel position, ColorModel color, SizeModel size, TextStylesModel textStyles) 
            : base(position, color)
        {
            Size = size;
            TextStyles = textStyles;
        }

        public SizeModel Size { get; }

        public TextStylesModel TextStyles { get; }

        public override void Draw()
        {
            Console.WriteLine("Draw a text line");
        }
    }
}
