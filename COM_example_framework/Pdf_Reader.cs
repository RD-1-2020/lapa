using System;
using System.Runtime.InteropServices;


[ClassInterface(ClassInterfaceType.None)]
[Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8")]

[ProgId("COM_example_framework")]
public class Pdf_Reader : IMyInterface
{
    public string get_Hello()
    {
        return "Hello, this Text is from the C# COM.dll.";
    }
}