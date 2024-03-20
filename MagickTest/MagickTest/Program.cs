using ImageMagick;

namespace ImageDimensionsReader
{
    class Program
    {
        static void Main()
        {

            string filePath = "urltojpg.jpg";

            try
            {
                // Read the dimensions of the image
                using (MagickImage image = new MagickImage(filePath))
                {
                    int width = image.Width;
                    int height = image.Height;

                    Console.WriteLine($"Dimensions of the image '{filePath}':");
                    Console.WriteLine($"Width: {width}px");
                    Console.WriteLine($"Height: {height}px");
                }
            }
            catch (MagickException ex)
            {
                Console.WriteLine($"An error occurred while reading the image: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}