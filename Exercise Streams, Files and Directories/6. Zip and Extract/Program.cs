using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\FIles\3D_Models", @"D:\Test\ZipFile.zip");
            ZipFile.ExtractToDirectory(@"D:\Test\ZipFile.zip", @"D:\Test\");
        }
    }
}
