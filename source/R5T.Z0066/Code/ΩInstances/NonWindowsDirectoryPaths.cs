using System;


namespace R5T.Z0066
{
    public class NonWindowsDirectoryPaths : INonWindowsDirectoryPaths
    {
        #region Infrastructure

        public static INonWindowsDirectoryPaths Instance { get; } = new NonWindowsDirectoryPaths();


        private NonWindowsDirectoryPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class NonWindowsDirectoryPaths : INonWindowsDirectoryPaths
    {
        #region Infrastructure

        public static INonWindowsDirectoryPaths Instance { get; } = new NonWindowsDirectoryPaths();


        private NonWindowsDirectoryPaths()
        {
        }

        #endregion
    }
}