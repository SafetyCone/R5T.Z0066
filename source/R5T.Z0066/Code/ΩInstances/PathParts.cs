using System;


namespace R5T.Z0066
{
    public class PathParts : IPathParts
    {
        #region Infrastructure

        public static IPathParts Instance { get; } = new PathParts();


        private PathParts()
        {
        }

        #endregion
    }
}
