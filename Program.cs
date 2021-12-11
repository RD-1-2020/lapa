using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4")]
interface IMyInterface
{
    string get_Hello();
}

[ClassInterface(ClassInterfaceType.None)]
[Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8")]
[ProgId("Pdf_Text_Reader")]
public class pdf_Reader : IMyInterface
{
    public string get_Hello()
    {
        return "Hello, this Text is from the C# COM.dll.";
    }
}
