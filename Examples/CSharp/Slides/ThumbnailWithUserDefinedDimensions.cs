
using System.IO;

using Aspose.Slides;
using System.Drawing;

namespace Aspose.Slides.Examples.CSharp.Slides
{
    public class ThumbnailWithUserDefinedDimensions
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Slides_Presentations();

            // Instantiate a Presentation class that represents the presentation file
            using (Presentation pres = new Presentation(dataDir + "ThumbnailWithUserDefinedDimensions.pptx"))
            {

                //Access the first slide
                ISlide sld = pres.Slides[0];

                // User defined dimension
                int desiredX = 1200;
                int desiredY = 800;

                // Getting scaled value  of X and Y
                float ScaleX = (float)(1.0 / pres.SlideSize.Size.Width) * desiredX;
                float ScaleY = (float)(1.0 / pres.SlideSize.Size.Height) * desiredY;


                // Create a full scale image
                Bitmap bmp = sld.GetThumbnail(ScaleX, ScaleY);

                // Save the image to disk in JPEG format
                bmp.Save(dataDir + "Thumbnail2_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
        }


    }
}

