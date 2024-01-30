using System;


namespace R5T.Z0066
{
    public class DirectoryPaths : IDirectoryPaths
    {
        #region Infrastructure

        public static IDirectoryPaths Instance { get; } = new DirectoryPaths();


        private DirectoryPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class DirectoryPaths : IDirectoryPaths
    {
        #region Infrastructure

        public static IDirectoryPaths Instance { get; } = new DirectoryPaths();


        private DirectoryPaths()
        {
        }

        #endregion
    }
}