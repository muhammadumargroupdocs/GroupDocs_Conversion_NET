﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;

namespace GroupDocs.Conversion.Examples.CSharp
{
    public static class Rendering
    {
        #region Converts and Render in HTML

        /// <summary>
        /// Converts and Render file to a HTML format and get output as file path
        /// </summary> 

        public static void RenderHTMLAsPath()
        {
            //ExStart:RenderHTMLAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();;

            // Convert and save converted HTML documents.
            // Returns paths to the converted HTML documents.
            var saveOptions = new HtmlSaveOptions
            {
                CustomName = "cache",
                PageNumber = 2,
                NumPagesToConvert = 2,
                UsePdf = true,
                OutputType = OutputType.String
            };
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new HtmlSaveOptions { OutputType = OutputType.String });
            //ExEnd:RenderHTMLAsPath
        }

        /// <summary>
        /// Converts and Render Document as HTML format and outputs the resulting file to a stream
        /// </summary>

        public static void RenderHTMLAsStream()
        {
            //ExStart:RenderHTMLAsStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();;

            // Convert and save converted HTML documents. 
            // Returns the converted HTML documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new HtmlSaveOptions());
            //ExEnd:RenderHTMLAsStream
        }

        /// <summary>
        /// In advance options example Converts and Render Password Protected file to HTML format
        /// </summary

        public static void RenderHTMLAdvanceOptions()
        {
            //ExStart:RenderHTMLAdvanceOptions
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();;

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new HtmlSaveOptions
            {
                PageNumber = 2,
                NumPagesToConvert = 2
            };

            // Unprotect input document, Convert and save HTML documents using advance options.
            // Returns the converted HTML documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
            //ExEnd:RenderHTMLAdvanceOptions
        }

        #endregion

        #region Converts and Render in Image


        /// <summary>
        /// Converts and Render file to an Image format and get output as file path
        /// </summary> 
        /// <param name="outputFileType"></param>
        public static void RenderImageAsPath(ImageSaveOptions.ImageFileType outputFileType)
        {
            //ExStart:RenderImageAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();;

            // Convert and save converted image file.
            // Returns paths to the converted image file.
            var saveOptions = new ImageSaveOptions
            {
                ConvertFileType = ImageSaveOptions.ImageFileType.Jpg,
                OutputType = OutputType.String
            };

            var convertedDocumentPath = conversionHandler.Convert<IList<string>>(Common.inputGUIDFile, saveOptions);
            //ExEnd:RenderImageAsPathi
        }

        /// <summary>
        /// Converts and Render Document as Image format and outputs the resulting file to a stream
        /// </summary>
        /// <param name="outputFileType"></param>
        public static void RenderImageAsStream(ImageSaveOptions.ImageFileType outputFileType)
        {
            //ExStart:RenderImageAsStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();;

            // Convert and save converted image file. 
            // Returns the converted image file as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>(Common.inputGUIDFile, new ImageSaveOptions { ConvertFileType = outputFileType });
            //ExEnd:RenderImageAsStream
        }

        /// <summary>
        /// In advance options example Converts and Render Password Protected file to Image format
        /// </summary>
        /// <param name="outputFileType"></param>
        public static void RenderImageAdvanceOptions(ImageSaveOptions.ImageFileType outputFileType)
        {
            //ExStart:RenderImageAdvanceOptions
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();;

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Tiff, starting from page 2 and convert 2 pages,
            // use DPI 300, image width 1024, image height 768
            SaveOptions saveOptions = new ImageSaveOptions
            {
                ConvertFileType = outputFileType,
                PageNumber = 2,
                NumPagesToConvert = 2,
                Dpi = 300,
                Width = 1024,
                Height = 768
            };

            // Unprotect input document, Convert and save image file using advance options.
            // Returns the converted image file as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>(Common.inputGUIDFile, loadOptions, saveOptions);
            //ExEnd:RenderImageAdvanceOptions
        }

        #endregion
    }
}
