using System;


namespace R5T.Z0066
{
    public class Paths : IPaths
    {
        #region Infrastructure

        public static IPaths Instance { get; } = new Paths();


        private Paths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Raw
{
    public class Paths : IPaths
    {
        #region Infrastructure

        public static IPaths Instance { get; } = new Paths();


        private Paths()
        {
        }

        #endregion
    }
}

namespace R5T.Z0066.Pathological
{
    public class Paths : IPaths
    {
        #region Infrastructure

        public static IPaths Instance { get; } = new Paths();


        private Paths()
        {
        }

        #endregion
    }
}


namespace R5T.Z0066.Pathological.Raw
{
    public class Paths : IPaths
    {
        #region Infrastructure

        public static IPaths Instance { get; } = new Paths();


        private Paths()
        {
        }

        #endregion
    }
}