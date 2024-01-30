using System;


namespace R5T.Z0066
{
    public class RelativeFilePaths : IRelativeFilePaths
    {
        #region Infrastructure

        public static IRelativeFilePaths Instance { get; } = new RelativeFilePaths();


        private RelativeFilePaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class RelativeFilePaths : IRelativeFilePaths
    {
        #region Infrastructure

        public static IRelativeFilePaths Instance { get; } = new RelativeFilePaths();


        private RelativeFilePaths()
        {
        }

        #endregion
    }
}
