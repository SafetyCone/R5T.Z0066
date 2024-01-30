using System;


namespace R5T.Z0066
{
    public static class Instances
    {
        public static IDirectoryNames DirectoryNames => Z0066.DirectoryNames.Instance;
        public static Pathological.IDirectoryNames DirectoryNames_Pathological => Pathological.DirectoryNames.Instance;
        public static IFileNames FileNames => Z0066.FileNames.Instance;
        public static IRootPaths RootPaths => Z0066.RootPaths.Instance;
    }
}