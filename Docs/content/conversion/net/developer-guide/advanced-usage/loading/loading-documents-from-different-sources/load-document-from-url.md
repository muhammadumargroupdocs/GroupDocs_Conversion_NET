---
id: load-document-from-url
url: conversion/net/load-document-from-url
title: Load document from URL
weight: 6
description: "This article explains how to load PDF, Word, Excel, PowerPoint documents from URL when using GroupDocs.Conversion for .NET."
keywords: Load document from URL, Load document by URL GroupDocs.Conversion
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
Following code snippet shows how to convert a document from URL:

```csharp
public static void Run()
{
    string url = "https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/blob/master/Examples/Resources/SampleFiles/sample.docx?raw=true";
    string outputFile = Path.Combine("c:\output", "converted.pdf");
    using (Converter converter = new Converter(() => GetRemoteFile(url)))
    {
        PdfConvertOptions options = new PdfConvertOptions();
        converter.Convert(outputFile, options);
    }
}
        
private static Stream GetRemoteFile(string url)
{
    WebRequest request = WebRequest.Create(url);
    using (WebResponse response = request.GetResponse())
        return GetFileStream(response);
}
private static Stream GetFileStream(WebResponse response)
{
    MemoryStream fileStream = new MemoryStream();
    using (Stream responseStream = response.GetResponseStream())
        responseStream.CopyTo(fileStream);
    fileStream.Position = 0;
    return fileStream;
}
```

## More resources

### GitHub Examples
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Conversion for .NET examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET)
*   [GroupDocs.Conversion for Java examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java)
*   [Document Conversion for .NET MVC UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC)
*   [Document Conversion for .NET App WebForms UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-WebForms)
*   [Document Conversion for Java App Dropwizard UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Dropwizard)
*   [Document Conversion for Java Spring UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Spring)

### Free Online Document Converter Apps
Along with full-featured .NET library we provide free Apps and free services for document conversion.
In order to see a full potential of GroupDocs.Conversion, you are welcome to convert DOC to PDF, DOC to XLSX, PDF to DOC, PDF to XLSX, PPT to DOC and more with **[Free Online Document Converter App](https://products.groupdocs.app/conversion)** or get a full advantage of **[Free Online Document Converter Suite](https://conholdate.app/features/document-converter-online)** with advanced conversion settings and many more enterprise built-in features.

**Please note** that more [premium features](https://conholdate.app/features), advanced options and enhanced document management experience is available for signed-in users at [conholdate.app](https://conholdate.app) for **FREE**.  
If you don't own an account yet, register it now for free! No credit card is required!