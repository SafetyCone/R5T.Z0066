using System;


namespace R5T.Z0066
{
    public class NonWindowsFilePaths : INonWindowsFilePaths
    {
        #region Infrastructure

        public static INonWindowsFilePaths Instance { get; } = new NonWindowsFilePaths();


        private NonWindowsFilePaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class NonWindowsFilePaths : INonWindowsFilePaths
    {
        #region Infrastructure

        public static INonWindowsFilePaths Instance { get; } = new NonWindowsFilePaths();


        private NonWindowsFilePaths()
        {
        }

        #endregion
    }
}
