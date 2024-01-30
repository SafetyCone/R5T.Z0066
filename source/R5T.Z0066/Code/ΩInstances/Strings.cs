using System;


namespace R5T.Z0066
{
    public class Strings : IStrings
    {
        #region Infrastructure

        public static IStrings Instance { get; } = new Strings();


        private Strings()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class Strings : IStrings
    {
        #region Infrastructure

        public static IStrings Instance { get; } = new Strings();


        private Strings()
        {
        }

        #endregion
    }
}
