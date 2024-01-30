using System;


namespace R5T.Z0066
{
    public class NonWindowsPaths : INonWindowsPaths
    {
        #region Infrastructure

        public static INonWindowsPaths Instance { get; } = new NonWindowsPaths();


        private NonWindowsPaths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class NonWindowsPaths : INonWindowsPaths
    {
        #region Infrastructure

        public static INonWindowsPaths Instance { get; } = new NonWindowsPaths();


        private NonWindowsPaths()
        {
        }

        #endregion
    }
}
