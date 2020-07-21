using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Example
    {
        public static string ExampleLoadTextFile(string file, string testFile)
        {
            if(file.Length < 10)
            {
                //throw new System.IO.FileNotFoundException();
                throw new ArgumentException("This file name was too short", "file");
            }

            return "The file was correctly loaded";
        }
    }
}
