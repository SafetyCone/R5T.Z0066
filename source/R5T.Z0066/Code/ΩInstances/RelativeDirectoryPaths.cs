using System;


namespace R5T.Z0066
{
    public class RelativeDirectoryPaths : IRelativeDirectoryPaths
    {
        #region Infrastructure

        public static IRelativeDirectoryPaths Instance { get; } = new RelativeDirectoryPaths();


        private RelativeDirectoryPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class RelativeDirectoryPaths : IRelativeDirectoryPaths
    {
        #region Infrastructure

        public static IRelativeDirectoryPaths Instance { get; } = new RelativeDirectoryPaths();


        private RelativeDirectoryPaths()
        {
        }

        #endregion
    }
}
