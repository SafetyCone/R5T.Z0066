using System;


namespace R5T.Z0066
{
    public class RelativeWindowsDirectoryPaths : IRelativeWindowsDirectoryPaths
    {
        #region Infrastructure

        public static IRelativeWindowsDirectoryPaths Instance { get; } = new RelativeWindowsDirectoryPaths();


        private RelativeWindowsDirectoryPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class RelativeWindowsDirectoryPaths : IRelativeWindowsDirectoryPaths
    {
        #region Infrastructure

        public static IRelativeWindowsDirectoryPaths Instance { get; } = new RelativeWindowsDirectoryPaths();


        private RelativeWindowsDirectoryPaths()
        {
        }

        #endregion
    }
}