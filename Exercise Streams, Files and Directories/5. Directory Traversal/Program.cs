using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<FileInfo>> filesByExtentions = new Dictionary<string, List<FileInfo>>();
            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string extention = info.Extension;
                if (!filesByExtentions.ContainsKey(extention))
                {
                    filesByExtentions[extention] = new List<FileInfo>();
                }
                filesByExtentions[extention].Add(info);
            }
            using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var kvp in filesByExtentions.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(kvp.Key);
                    foreach (var fileInfo in kvp.Value.OrderBy(x => Math.Ceiling((double)x.Length/1024)))
                    {
                        writer.WriteLine($"--{fileInfo.Name} - {Math.Ceiling((double)fileInfo.Length/1024)}kb");
                    }
                }
            }
        }
    }
}
