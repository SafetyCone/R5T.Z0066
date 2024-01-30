using System;


namespace R5T.Z0066
{
    public class WindowsDirectoryPaths : IWindowsDirectoryPaths
    {
        #region Infrastructure

        public static IWindowsDirectoryPaths Instance { get; } = new WindowsDirectoryPaths();


        private WindowsDirectoryPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class WindowsDirectoryPaths : IWindowsDirectoryPaths
    {
        #region Infrastructure

        public static IWindowsDirectoryPaths Instance { get; } = new WindowsDirectoryPaths();


        private WindowsDirectoryPaths()
        {
        }

        #endregion
    }
}