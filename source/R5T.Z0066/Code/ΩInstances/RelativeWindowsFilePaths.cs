using System;


namespace R5T.Z0066
{
    public class RelativeWindowsFilePaths : IRelativeWindowsFilePaths
    {
        #region Infrastructure

        public static IRelativeWindowsFilePaths Instance { get; } = new RelativeWindowsFilePaths();


        private RelativeWindowsFilePaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class RelativeWindowsFilePaths : IRelativeWindowsFilePaths
    {
        #region Infrastructure

        public static IRelativeWindowsFilePaths Instance { get; } = new RelativeWindowsFilePaths();


        private RelativeWindowsFilePaths()
        {
        }

        #endregion
    }
}