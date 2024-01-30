using System;


namespace R5T.Z0066
{
    public class WindowsFilePaths : IWindowsFilePaths
    {
        #region Infrastructure

        public static IWindowsFilePaths Instance { get; } = new WindowsFilePaths();


        private WindowsFilePaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class WindowsFilePaths : IWindowsFilePaths
    {
        #region Infrastructure

        public static IWindowsFilePaths Instance { get; } = new WindowsFilePaths();


        private WindowsFilePaths()
        {
        }

        #endregion
    }
}
