//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using System;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace CSharp.Shapes
{
    public class FindShapeInSlide
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes();

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate a Presentation class that represents the presentation file
            using (Presentation p = new Presentation(dataDir + "FindingShapeInSlide.pptx"))
            {

                ISlide slide = p.Slides[0];
                //alternative text of the shape to be found
                IShape shape = FindShape(slide, "Shape1");
                if (shape != null)
                {
                    Console.WriteLine("Shape Name: " + shape.Name);
                }
            }
        }
        
        //Method implementation to find a shape in a slide using its alternative text
        public static IShape FindShape(ISlide slide, string alttext)
        {
            //Iterating through all shapes inside the slide
            for (int i = 0; i < slide.Shapes.Count; i++)
            {
                //If the alternative text of the slide matches with the required one then
                //return the shape
                if (slide.Shapes[i].AlternativeText.CompareTo(alttext) == 0)
                    return slide.Shapes[i];
            }
            return null;
        }

    }
}

