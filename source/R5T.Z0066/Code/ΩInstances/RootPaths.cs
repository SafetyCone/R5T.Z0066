using System;


namespace R5T.Z0066
{
    public class RootPaths : IRootPaths
    {
        #region Infrastructure

        public static IRootPaths Instance { get; } = new RootPaths();


        private RootPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class RootPaths : IRootPaths
    {
        #region Infrastructure

        public static IRootPaths Instance { get; } = new RootPaths();


        private RootPaths()
        {
        }

        #endregion
    }
}
