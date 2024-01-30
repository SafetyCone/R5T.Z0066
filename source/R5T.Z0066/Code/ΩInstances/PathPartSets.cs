using System;


namespace R5T.Z0066
{
    public class PathPartSets : IPathPartSets
    {
        #region Infrastructure

        public static IPathPartSets Instance { get; } = new PathPartSets();


        private PathPartSets()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class PathPartSets : IPathPartSets
    {
        #region Infrastructure

        public static IPathPartSets Instance { get; } = new PathPartSets();


        private PathPartSets()
        {
        }

        #endregion
    }
}