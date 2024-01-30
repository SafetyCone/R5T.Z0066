using System;


namespace R5T.Z0066
{
    public class RelativePaths : IRelativePaths
    {
        #region Infrastructure

        public static IRelativePaths Instance { get; } = new RelativePaths();


        private RelativePaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class RelativePaths : IRelativePaths
    {
        #region Infrastructure

        public static IRelativePaths Instance { get; } = new RelativePaths();


        private RelativePaths()
        {
        }

        #endregion
    }
}
