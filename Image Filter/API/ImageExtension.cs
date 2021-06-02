using System.Drawing;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.Artistic;
using ImageProcessor.Imaging.Filters.Photo;

namespace ImageFilter
{
    public static class ImageExtension
    {
        public static Image ApplyFilter(this Image image, ImageFilter filter)
        {
            ImageFactory imageFactory = new ImageFactory().Load(image);
            switch (filter)
            {
                case ImageFilter.BlackWhite:
                    return imageFactory.Filter(MatrixFilters.BlackWhite).Image;
                case ImageFilter.Comic:
                    return imageFactory.Filter(MatrixFilters.Comic).Image;
                case ImageFilter.Gotham:
                    return imageFactory.Filter(MatrixFilters.Gotham).Image;
                case ImageFilter.GreyScale:
                    return imageFactory.Filter(MatrixFilters.GreyScale).Image;
                case ImageFilter.HiSatch:
                    return imageFactory.Filter(MatrixFilters.HiSatch).Image;
                case ImageFilter.Invert:
                    return imageFactory.Filter(MatrixFilters.Invert).Image;
                case ImageFilter.Lomograph:
                    return imageFactory.Filter(MatrixFilters.Lomograph).Image;
                case ImageFilter.LoSatch:
                    return imageFactory.Filter(MatrixFilters.LoSatch).Image;
                case ImageFilter.Polaroid:
                    return imageFactory.Filter(MatrixFilters.Polaroid).Image;
                case ImageFilter.Sepia:
                    return imageFactory.Filter(MatrixFilters.Sepia).Image;
                case ImageFilter.OilPainting:
                    OilPaintingFilter oilPaintingFilter = new OilPaintingFilter(255, 8);
                    return oilPaintingFilter.ApplyFilter(new Bitmap(image));
                default:
                    return image;
            }
        }
    }
}
