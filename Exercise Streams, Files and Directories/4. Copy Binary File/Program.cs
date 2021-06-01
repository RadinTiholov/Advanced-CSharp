using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            const int byteBuffer = 4096;
            using (FileStream reader = new FileStream("./copyMe.png", FileMode.Open))

            using (FileStream writer = new FileStream("../../../copiedPicture.png", FileMode.Create))
                while (reader.CanRead)
                {
                    byte[] buffer = new byte[byteBuffer];
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    writer.Write(buffer, 0 , readBytes);
                }
        }
    }
}
