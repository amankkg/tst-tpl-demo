using System.Collections.Generic;

namespace RecursionDemo
{
    class MyDirectory
    {
        public MyDirectory(IEnumerable<MyFile> files, IEnumerable<MyDirectory> directories)
        {
            Files = files;
            Directories = directories;
        }

        public IEnumerable<MyFile> Files { get; }
        public IEnumerable<MyDirectory> Directories { get; }
    }
}
