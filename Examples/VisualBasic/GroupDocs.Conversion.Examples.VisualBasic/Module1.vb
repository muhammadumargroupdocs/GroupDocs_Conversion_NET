﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Converter.Option

Namespace GroupDocsConversionExamples.VisualBasic
    Module Module1
        Sub Main(args As String())
            'ExStart:ConvertFilesToDifferentFormats
            ' you can set Input and output paths and input file name along with license path common for all example methods.
            Common.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\SampleFiles")
            Common.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\Cache")
            Common.outputPath = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\ConvertedFiles")
            Common.inputGUIDFile = "DOCXsample.docx"
            'Common.inputGUIDFile = "PPTSample.pptx"
            'Common.inputGUIDFile = "PDFsample.pdf"

            ' Uncomment following lines and specify the licence file path to embed product licence.
            ' Common.licensePath = Path.Combine(Environment.CurrentDirectory, "GroupDocs.Conversion.lic")
            ' Common.ApplyLicense(Common.licensePath)

            ' Uncomment following lines and specify the licence file stream to embed product licence.
            'Dim licenseStream As New FileStream(Path.Combine(Environment.CurrentDirectory, "GroupDocs.total.lic"), FileMode.Open, FileAccess.Read)
            'Common.ApplyLicense(licenseStream)

            ''' <summary>
            ''' **** Convert Spreadsheet, PDF, Presentation, Document Processing  formats.
            ''' </summary>


            ' Convert file  Spreadsheet Document formats and get output as file path
            Conversion.ConvertToSpreadsheetAsPath()

            ' Convert file  Spreadsheet Document formats and get output as Stream
            ' Conversion.ConvertToSpreadsheetStream()

            ' In Advanced example Convert Password Protected file to Spreadsheet Document formats 
            ' Conversion.ConvertToSpreadsheetAdvanceOptions()

            ' Convert file to PDF format and get output as file path
            Conversion.ConvertToPdfAsPath()

            ' Convert file to PDF format and get output as Stream
            ' Conversion.ConvertToPdfAsStream()

            ' In Advanced example Convert Password Protected file to PDF format
            ' Conversion.ConvertToPdfAdvanceOptions()

            ' Convert file to Presentation Document format and get output as file path
            Conversion.ConvertToPresentationAsPath()

            ' Convert file to Presentation Document format and get output as Stream
            ' Conversion.ConvertToPresentationAsStream()

            ' In Advanced example Convert Password Protected file to Presentation Document format
            ' Conversion.ConversionToSlidesAdvanceOptions()

            ' Convert file to Word Processing Document format and get output as file path
            Conversion.ConvertToWordDocumentAsPath()

            ' Convert file to Word Processing Document format and get output as Stream
            ' Conversion.ConvertToWordDocumentAsStream()

            ' In Advanced example Convert Password Protected file to Word Processing Document format
            ' Conversion.ConvertToWordDocumentAdvanceOptions()

            ''' <summary>
            ''' **** Rendering and Converting to HTML and Image formats.
            ''' </summary>

            ' Converts and Render file to a HTML format and get output as file path
            Rendering.RenderHTMLAsPath()

            ' Converts and Render file as HTML format and get output as Stream
            ' Rendering.RenderHTMLAsStream()

            ' In Advanced example Converts and Render Password Protected file to Excel format
            ' Rendering.RenderHTMLAdvanceOptions()

            ' Converts and Render file to an Image format and get output as file path
            Rendering.RenderImageAsPath(ImageSaveOptions.ImageFileType.Png)

            ' Converts and Render file to an Image format and get output as Stream
            ' Rendering.RenderImageAsStream(ImageSaveOptions.ImageFileType.Png)

            ' In Advanced example Converts and Render Password Protected file to Image format
            ' Rendering.RenderImageAdvanceOptions(ImageSaveOptions.ImageFileType.Gif)

            'ExEnd:ConvertFilesToDifferentFormats
        End Sub
    End Module
End Namespace
