---
id: listening
url: conversion/net/listening
title: Listening
weight: 4
description: "Follow this guide and learn how to track conversion process by subscribing to specific events of GroupDocs.Conversion for .NET API."
keywords: Track conversion process, Subscribe to conversion process events
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
In some cases there is the need to monitor conversion process and to receive update for start, progress and completion of a conversion. For such situations [**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) expose extension point where the client application may hook up and receive updates.. 

To enable listening you have to:

*   Implement you own implementation of [IConverterListener](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.reporting/iconverterlistener) interface
*   Instantiate [ConverterSettings](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/convertersettings) class and pass an instance of the class created in first step
*   Pass [ConverterSettings](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/convertersettings) object factory to constructor of a [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class

Here is a code that demonstrates how to enable listening for GroupDocs.Conversion.

```csharp
public class ConverterListener : IConverterListener
{
    public void Started()
    {
        Console.WriteLine("Conversion started...");
    }
    public void Progress(byte current)
    {
        Console.WriteLine($"... {current} % ...");
    }
    public void Completed()
    {
        Console.WriteLine("... conversion completed");
    }
}
```

```csharp
IConverterListener listener = new ConverterListener();
Contracts.Func<ConverterSettings> settingsFactory = () => new ConverterSettings
{
    Listener = listener
};
using (Converter converter = new Converter("sample.docx", settingsFactory))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
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