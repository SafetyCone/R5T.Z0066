using System;


namespace R5T.Z0066
{
    public class WindowsPaths : IWindowsPaths
    {
        #region Infrastructure

        public static IWindowsPaths Instance { get; } = new WindowsPaths();


        private WindowsPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class WindowsPaths : IWindowsPaths
    {
        #region Infrastructure

        public static IWindowsPaths Instance { get; } = new WindowsPaths();


        private WindowsPaths()
        {
        }

        #endregion
    }
}