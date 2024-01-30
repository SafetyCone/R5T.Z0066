using System;


namespace R5T.Z0066
{
    public class WindowsPathSets : IWindowsPathSets
    {
        #region Infrastructure

        public static IWindowsPathSets Instance { get; } = new WindowsPathSets();


        private WindowsPathSets()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class WindowsPathSets : IWindowsPathSets
    {
        #region Infrastructure

        public static IWindowsPathSets Instance { get; } = new WindowsPathSets();


        private WindowsPathSets()
        {
        }

        #endregion
    }
}
