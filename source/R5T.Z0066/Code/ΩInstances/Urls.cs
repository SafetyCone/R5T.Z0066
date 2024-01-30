using System;


namespace R5T.Z0066
{
    public class Urls : IUrls
    {
        #region Infrastructure

        public static IUrls Instance { get; } = new Urls();


        private Urls()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class Urls : IUrls
    {
        #region Infrastructure

        public static IUrls Instance { get; } = new Urls();


        private Urls()
        {
        }

        #endregion
    }
}
