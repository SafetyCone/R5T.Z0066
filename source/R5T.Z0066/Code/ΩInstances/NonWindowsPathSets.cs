using System;


namespace R5T.Z0066
{
    public class NonWindowsPathSets : INonWindowsPathSets
    {
        #region Infrastructure

        public static INonWindowsPathSets Instance { get; } = new NonWindowsPathSets();


        private NonWindowsPathSets()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class NonWindowsPathSets : INonWindowsPathSets
    {
        #region Infrastructure

        public static INonWindowsPathSets Instance { get; } = new NonWindowsPathSets();


        private NonWindowsPathSets()
        {
        }

        #endregion
    }
}